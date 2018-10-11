using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SuperFundLookup.SFLSampleCSharp.ServiceReferenceSFL;

namespace SuperFundLookup.SFLSampleCSharp
{
    public partial class FormSFLookup : Form
    {
        private Collection<string> initialControlValue = new Collection<string>(); 
        public FormSFLookup()
        {
            InitializeComponent();
        }
        // -----------------------------------------------------------------------------------------------
        //  Initialise form with default values
        // -----------------------------------------------------------------------------------------------
        private void FormSFLookup_Load(object sender, EventArgs e)
        {
           InitialiseControls();
           InitialiseTextBoxValues();
           foreach (Control control in this.tabPageXmlSearch.Controls)
           {
              if (control is TextBox)
              {
                 initialControlValue.Add(control.Text);
              }
           }
        }
        // -----------------------------------------------------------------------------------------------
        //  Set controls to initial state
        // -----------------------------------------------------------------------------------------------
        private void InitialiseControls()
        {
           this.richTextBoxResults.Visible = false;
           this.textBoxGuid.Focus();
        }
        // -----------------------------------------------------------------------------------------------
        //  Initialises the text boxes with default values
        // -----------------------------------------------------------------------------------------------
        private void InitialiseTextBoxValues()
        {
            if (this.radioButtonAbn.Checked)
            {
               this.textBoxCriteria.Text = "79 781 199 140";
            }
            this.textBoxGuid.Text = AppSettings.Guid;
        }
        // -----------------------------------------------------------------------------------------------
        //  Exit the program
        // -----------------------------------------------------------------------------------------------
        private void buttonExit_Click(object sender, EventArgs e)
        {
           this.Close();
        }
        // -----------------------------------------------------------------------------------------------
        //  Reset the form as a start up
        // -----------------------------------------------------------------------------------------------
        private void buttonReset_Click(object sender, EventArgs e)
        {
           int index = 0;
           try
           {
              foreach (Control control in tabPageXmlSearch.Controls)
              {
                 if (control is TextBox)
                 {
                    control.Text = (initialControlValue[index].ToString());
                    index++;
                 }
              }
              InitialiseControls();
           }
           catch (Exception exp)
           {
              ShowException(exp.ToString());
           }
        }
        // -----------------------------------------------------------------------------------------------
        //  Initiate the search
        // -----------------------------------------------------------------------------------------------
        private void buttonSearch_Click(object sender, EventArgs e)
        {
           InitialiseResultControls();
           try
           {
              if (this.radioButtonProxy.Checked)
              {
                 UseStronglyTypedSearch();
              }
              else if (this.radioButtonSoap.Checked)
              {
                 UseSoapSearch();
              }
              else
              {
                 UseHttpGetSearch();
              }
           }
           catch (Exception exp)
           {
              ShowException(exp.ToString());
           }
           this.Cursor = System.Windows.Forms.Cursors.Default;
        }
        // -----------------------------------------------------------------------------------------------
        //  Set search result controls to initial state
        // -----------------------------------------------------------------------------------------------
        private void InitialiseResultControls()
        {
           this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
           this.richTextBoxResults.Clear();
           this.richTextBoxResults.Visible = true;
        }
        // -----------------------------------------------------------------------------------------------
        //  Search using the web service proxies. See Web References for the project
        // -----------------------------------------------------------------------------------------------
        private void UseStronglyTypedSearch()
        {
           ServiceReferenceSFL.FundPayload SearchFundPayload = null;
           try
           {
              if (this.radioButtonAbn.Checked)
              {
                 //SearchFundPayload response will contain a Superannuation Fund when searching By ABN
                 SearchFundPayload = ProxyXmlSearch.AbnSearch(TrimString(this.textBoxCriteria.Text), TrimString(this.textBoxGuid.Text));
                 this.richTextBoxResults.Text = ResultsInterpreter.SerialiseFundPayload(SearchFundPayload);
              }
           }
           catch
           {
              throw;
           }
        }
         // -----------------------------------------------------------------------------------------------
         //  Search without using the web service proxies. 
         // -----------------------------------------------------------------------------------------------
         private void UseSoapSearch()
         {
            string SearchFundPayload = "";
            try
            {
               if (this.radioButtonAbn.Checked)
               {
                  //  SearchFundPayload response will contain a Superannuation Fund when searching By ABN
                  SearchFundPayload = SoapSearch.AbnSearch(TrimString(this.textBoxCriteria.Text), TrimString(this.textBoxGuid.Text));
                  this.richTextBoxResults.Text = SearchFundPayload;
               }
            }
            catch 
            {
               throw;
            }
         }
         // -----------------------------------------------------------------------------------------------
         //  Search using http get
         // -----------------------------------------------------------------------------------------------
         private void UseHttpGetSearch() {
            string SearchFundPayload = "";
            try
            {
               if (this.radioButtonAbn.Checked)
               {
                  //SearchFundPayload response will contain a Superannuation Fund when searching By ABN
                  SearchFundPayload = HttpGetSearch.AbnSearch(TrimString(this.textBoxCriteria.Text), TrimString(this.textBoxGuid.Text));
                  this.richTextBoxResults.Text = SearchFundPayload;
               }
            }
            catch
            {
               throw;
            }
         }
        //------------------------------------------------------------------------------
        // Display an error message
        //------------------------------------------------------------------------------
        private void ShowException(string message)
        {
            const string CAPTION = "Extract Error";
            MessageBox.Show(this, message, CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
        // -----------------------------------------------------------------------------------------------
        //  Convert null to string and trim non-null strings
        // -----------------------------------------------------------------------------------------------
        private static string TrimString(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return "";
            }
            else
            {
                return value.Trim();
            }
        }
    }
}

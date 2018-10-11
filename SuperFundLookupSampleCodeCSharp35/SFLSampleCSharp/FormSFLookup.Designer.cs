namespace SuperFundLookup.SFLSampleCSharp
{
    partial class FormSFLookup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
         this.richTextBoxResults = new System.Windows.Forms.RichTextBox();
         this.buttonSearch = new System.Windows.Forms.Button();
         this.buttonReset = new System.Windows.Forms.Button();
         this.radioButtonHttpGet = new System.Windows.Forms.RadioButton();
         this.tabControlWebServices = new System.Windows.Forms.TabControl();
         this.tabPageXmlSearch = new System.Windows.Forms.TabPage();
         this.buttonExit = new System.Windows.Forms.Button();
         this.radioButtonSoap = new System.Windows.Forms.RadioButton();
         this.radioButtonProxy = new System.Windows.Forms.RadioButton();
         this.textBoxCriteria = new System.Windows.Forms.TextBox();
         this.textBoxGuid = new System.Windows.Forms.TextBox();
         this.groupBoxMethod = new System.Windows.Forms.GroupBox();
         this.radioButtonAbn = new System.Windows.Forms.RadioButton();
         this.groupBoxProtocolOptions = new System.Windows.Forms.GroupBox();
         this.labelGuid = new System.Windows.Forms.Label();
         this.labelCriteria = new System.Windows.Forms.Label();
         this.tabControlWebServices.SuspendLayout();
         this.tabPageXmlSearch.SuspendLayout();
         this.groupBoxMethod.SuspendLayout();
         this.SuspendLayout();
         // 
         // richTextBoxResults
         // 
         this.richTextBoxResults.Location = new System.Drawing.Point(29, 384);
         this.richTextBoxResults.Name = "richTextBoxResults";
         this.richTextBoxResults.Size = new System.Drawing.Size(527, 158);
         this.richTextBoxResults.TabIndex = 11;
         this.richTextBoxResults.Text = "";
         // 
         // buttonSearch
         // 
         this.buttonSearch.Location = new System.Drawing.Point(127, 355);
         this.buttonSearch.Name = "buttonSearch";
         this.buttonSearch.Size = new System.Drawing.Size(75, 23);
         this.buttonSearch.TabIndex = 10;
         this.buttonSearch.Text = "Search";
         this.buttonSearch.UseVisualStyleBackColor = true;
         this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
         // 
         // buttonReset
         // 
         this.buttonReset.Location = new System.Drawing.Point(23, 355);
         this.buttonReset.Name = "buttonReset";
         this.buttonReset.Size = new System.Drawing.Size(75, 23);
         this.buttonReset.TabIndex = 9;
         this.buttonReset.Text = "Reset";
         this.buttonReset.UseVisualStyleBackColor = true;
         this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
         // 
         // radioButtonHttpGet
         // 
         this.radioButtonHttpGet.AutoSize = true;
         this.radioButtonHttpGet.Location = new System.Drawing.Point(301, 277);
         this.radioButtonHttpGet.Name = "radioButtonHttpGet";
         this.radioButtonHttpGet.Size = new System.Drawing.Size(62, 17);
         this.radioButtonHttpGet.TabIndex = 7;
         this.radioButtonHttpGet.TabStop = true;
         this.radioButtonHttpGet.Text = "HttpGet";
         this.radioButtonHttpGet.UseVisualStyleBackColor = true;
         // 
         // tabControlWebServices
         // 
         this.tabControlWebServices.Controls.Add(this.tabPageXmlSearch);
         this.tabControlWebServices.Location = new System.Drawing.Point(42, 4);
         this.tabControlWebServices.Name = "tabControlWebServices";
         this.tabControlWebServices.SelectedIndex = 0;
         this.tabControlWebServices.Size = new System.Drawing.Size(597, 636);
         this.tabControlWebServices.TabIndex = 13;
         // 
         // tabPageXmlSearch
         // 
         this.tabPageXmlSearch.Controls.Add(this.labelCriteria);
         this.tabPageXmlSearch.Controls.Add(this.labelGuid);
         this.tabPageXmlSearch.Controls.Add(this.buttonExit);
         this.tabPageXmlSearch.Controls.Add(this.richTextBoxResults);
         this.tabPageXmlSearch.Controls.Add(this.buttonSearch);
         this.tabPageXmlSearch.Controls.Add(this.buttonReset);
         this.tabPageXmlSearch.Controls.Add(this.radioButtonHttpGet);
         this.tabPageXmlSearch.Controls.Add(this.radioButtonSoap);
         this.tabPageXmlSearch.Controls.Add(this.radioButtonProxy);
         this.tabPageXmlSearch.Controls.Add(this.textBoxCriteria);
         this.tabPageXmlSearch.Controls.Add(this.textBoxGuid);
         this.tabPageXmlSearch.Controls.Add(this.groupBoxMethod);
         this.tabPageXmlSearch.Controls.Add(this.groupBoxProtocolOptions);
         this.tabPageXmlSearch.Location = new System.Drawing.Point(4, 22);
         this.tabPageXmlSearch.Name = "tabPageXmlSearch";
         this.tabPageXmlSearch.Padding = new System.Windows.Forms.Padding(3);
         this.tabPageXmlSearch.Size = new System.Drawing.Size(589, 610);
         this.tabPageXmlSearch.TabIndex = 0;
         this.tabPageXmlSearch.Text = "Xml Search";
         this.tabPageXmlSearch.UseVisualStyleBackColor = true;
         // 
         // buttonExit
         // 
         this.buttonExit.Location = new System.Drawing.Point(480, 572);
         this.buttonExit.Name = "buttonExit";
         this.buttonExit.Size = new System.Drawing.Size(75, 23);
         this.buttonExit.TabIndex = 12;
         this.buttonExit.Text = "Exit";
         this.buttonExit.UseVisualStyleBackColor = true;
         this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
         // 
         // radioButtonSoap
         // 
         this.radioButtonSoap.AutoSize = true;
         this.radioButtonSoap.Checked = true;
         this.radioButtonSoap.Location = new System.Drawing.Point(184, 277);
         this.radioButtonSoap.Name = "radioButtonSoap";
         this.radioButtonSoap.Size = new System.Drawing.Size(50, 17);
         this.radioButtonSoap.TabIndex = 6;
         this.radioButtonSoap.TabStop = true;
         this.radioButtonSoap.Text = "Soap";
         this.radioButtonSoap.UseVisualStyleBackColor = true;
         // 
         // radioButtonProxy
         // 
         this.radioButtonProxy.AutoSize = true;
         this.radioButtonProxy.Location = new System.Drawing.Point(49, 277);
         this.radioButtonProxy.Name = "radioButtonProxy";
         this.radioButtonProxy.Size = new System.Drawing.Size(88, 17);
         this.radioButtonProxy.TabIndex = 5;
         this.radioButtonProxy.Text = "Proxy objects";
         this.radioButtonProxy.UseVisualStyleBackColor = true;
         // 
         // textBoxCriteria
         // 
         this.textBoxCriteria.Location = new System.Drawing.Point(127, 203);
         this.textBoxCriteria.Name = "textBoxCriteria";
         this.textBoxCriteria.Size = new System.Drawing.Size(259, 20);
         this.textBoxCriteria.TabIndex = 4;
         // 
         // textBoxGuid
         // 
         this.textBoxGuid.Location = new System.Drawing.Point(127, 156);
         this.textBoxGuid.Name = "textBoxGuid";
         this.textBoxGuid.Size = new System.Drawing.Size(259, 20);
         this.textBoxGuid.TabIndex = 2;
         // 
         // groupBoxMethod
         // 
         this.groupBoxMethod.Controls.Add(this.radioButtonAbn);
         this.groupBoxMethod.Location = new System.Drawing.Point(23, 29);
         this.groupBoxMethod.Name = "groupBoxMethod";
         this.groupBoxMethod.Size = new System.Drawing.Size(363, 100);
         this.groupBoxMethod.TabIndex = 0;
         this.groupBoxMethod.TabStop = false;
         this.groupBoxMethod.Text = "Search Method";
         // 
         // radioButtonAbn
         // 
         this.radioButtonAbn.AutoSize = true;
         this.radioButtonAbn.Checked = true;
         this.radioButtonAbn.Location = new System.Drawing.Point(26, 43);
         this.radioButtonAbn.Name = "radioButtonAbn";
         this.radioButtonAbn.Size = new System.Drawing.Size(84, 17);
         this.radioButtonAbn.TabIndex = 0;
         this.radioButtonAbn.TabStop = true;
         this.radioButtonAbn.Text = "ABN Search";
         this.radioButtonAbn.UseVisualStyleBackColor = true;
         // 
         // groupBoxProtocolOptions
         // 
         this.groupBoxProtocolOptions.Location = new System.Drawing.Point(23, 252);
         this.groupBoxProtocolOptions.Name = "groupBoxProtocolOptions";
         this.groupBoxProtocolOptions.Size = new System.Drawing.Size(533, 64);
         this.groupBoxProtocolOptions.TabIndex = 8;
         this.groupBoxProtocolOptions.TabStop = false;
         this.groupBoxProtocolOptions.Text = "Protocol options";
         // 
         // labelGuid
         // 
         this.labelGuid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.labelGuid.ForeColor = System.Drawing.SystemColors.Desktop;
         this.labelGuid.Location = new System.Drawing.Point(25, 156);
         this.labelGuid.Name = "labelGuid";
         this.labelGuid.Size = new System.Drawing.Size(40, 23);
         this.labelGuid.TabIndex = 13;
         this.labelGuid.Text = "GUID:";
         this.labelGuid.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         // 
         // labelCriteria
         // 
         this.labelCriteria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.labelCriteria.ForeColor = System.Drawing.SystemColors.Desktop;
         this.labelCriteria.Location = new System.Drawing.Point(25, 203);
         this.labelCriteria.Name = "labelCriteria";
         this.labelCriteria.Size = new System.Drawing.Size(48, 23);
         this.labelCriteria.TabIndex = 14;
         this.labelCriteria.Text = "Criteria:";
         this.labelCriteria.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         // 
         // FormSFLookup
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(680, 644);
         this.Controls.Add(this.tabControlWebServices);
         this.Name = "FormSFLookup";
         this.Text = "Super Fund Lookup";
         this.Load += new System.EventHandler(this.FormSFLookup_Load);
         this.tabControlWebServices.ResumeLayout(false);
         this.tabPageXmlSearch.ResumeLayout(false);
         this.tabPageXmlSearch.PerformLayout();
         this.groupBoxMethod.ResumeLayout(false);
         this.groupBoxMethod.PerformLayout();
         this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxResults;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.RadioButton radioButtonHttpGet;
        private System.Windows.Forms.TabControl tabControlWebServices;
        private System.Windows.Forms.TabPage tabPageXmlSearch;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.RadioButton radioButtonSoap;
        private System.Windows.Forms.RadioButton radioButtonProxy;
        private System.Windows.Forms.TextBox textBoxCriteria;
        private System.Windows.Forms.TextBox textBoxGuid;
        private System.Windows.Forms.GroupBox groupBoxMethod;
        private System.Windows.Forms.RadioButton radioButtonAbn;
        private System.Windows.Forms.GroupBox groupBoxProtocolOptions;
        internal System.Windows.Forms.Label labelCriteria;
        internal System.Windows.Forms.Label labelGuid;
    }
}


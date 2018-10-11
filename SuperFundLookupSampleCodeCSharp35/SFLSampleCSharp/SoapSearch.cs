using System;
using System.IO;
using System.Net;
using System.Globalization;

namespace SuperFundLookup.SFLSampleCSharp
{
   /// <summary>
   /// Non-Strongly Typed Search - Builds the Soap message as a string. 
   /// </summary>
   class SoapSearch {
      //  Private constructor
      private SoapSearch() { }
      // ---------------------------------------------------------------------------------------------
      //  Search by an Abn
      // ---------------------------------------------------------------------------------------------
      public static string AbnSearch(string searchText, string guid)
      {
         string SoapMessage = BuildAbnSoapMessage(searchText, guid);
         string SoapAction = AppSettings.SoapActionAbnSearch;
         HttpWebRequest WebRequest = null;
         try
         {
            WebRequest = BuildRequest(SoapMessage, SoapAction);
            Send(WebRequest, SoapMessage);
            return ReadResponse(WebRequest);
         }
         catch
         {
            throw;
         }
         finally
         {
            WebRequest.Abort();
         }
      }
      // -----------------------------------------------------------------------------------------------
      //  Return the SOAP message for a search by ABN 
      // -----------------------------------------------------------------------------------------------
      private static string BuildAbnSoapMessage(string searchText, string guid)
      {
         return
             "<?xml version=\"1.0\" encoding=\"utf-8\"?>" +
             "<soap:Envelope " +
              "xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" " +
             "xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" " +
             "xmlns:soap=\"http://schemas.xmlsoap.org/soap/envelope/\">" +
             "<soap:Body> " +
             "<SearchByABN xmlns=\"http://superfundlookup.gov.au\"> " +
             "<abn>" + searchText + "</abn>" +
             "<guid>" + guid + "</guid>" +
             "</SearchByABN>" +
             "</soap:Body>" +
             "</soap:Envelope>";
      }
      // ---------------------------------------------------------------------------------------------
      //  Set the request header details
      // ---------------------------------------------------------------------------------------------
      private static HttpWebRequest BuildRequest(string soapMessage, string soapAction) {
         HttpWebRequest Request;
         Request = (HttpWebRequest)WebRequest.Create(AppSettings.SearchUrl);
         try {
            Request.Timeout = int.Parse(AppSettings.RequestTimeoutInMilliseconds, CultureInfo.CurrentCulture);
         }
         catch {
            Request.Timeout = 100000;
         }
         Request.Headers.Add("SoapAction", soapAction);
         Request.ContentType = "text/xml; charset=utf-8";
         Request.ContentLength = soapMessage.Length;
         Request.Proxy = GetWebProxy();
         Request.Method = "POST";
         return (Request);
      }
      // ---------------------------------------------------------------------------------------------
      //  Set proxy depending on settings in the config file
      // ---------------------------------------------------------------------------------------------
      private static IWebProxy GetWebProxy() {
         string ProxySetting = AppSettings.Proxy;
         if (ProxySetting.Length > 0) {
            return new WebProxy(ProxySetting);
         }
         else {
            return WebRequest.GetSystemWebProxy();
         }
      }
      // ---------------------------------------------------------------------------------------------
      //  issue the request to the web service
      // ---------------------------------------------------------------------------------------------
      private static void Send(HttpWebRequest webRequest, string soapMessage) {
         StreamWriter StreamWriter;
         StreamWriter = new StreamWriter(webRequest.GetRequestStream());
         StreamWriter.Write(soapMessage);
         StreamWriter.Flush();
         StreamWriter.Close();
      }
      // ---------------------------------------------------------------------------------------------
      //  Return the response from the request as a string 
      // ---------------------------------------------------------------------------------------------
      private static string ReadResponse(HttpWebRequest webRequest) {
         StreamReader Reader;
         HttpWebResponse Response;
         String ResponseContents = "";
         try {
            Response = ((HttpWebResponse)(webRequest.GetResponse()));
            Reader = new StreamReader(Response.GetResponseStream());
            ResponseContents = Reader.ReadToEnd();
            Reader.Close();
         }
         catch (ObjectDisposedException) {
            throw;
         }
         catch (IOException) {
            throw;
         }
         catch (SystemException) {
            throw;
         }
         return ResponseContents;
      }
   }
}

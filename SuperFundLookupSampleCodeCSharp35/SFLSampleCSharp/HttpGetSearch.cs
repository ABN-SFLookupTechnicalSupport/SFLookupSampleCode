using System;
using System.IO;
using System.Net;
using System.Globalization;
using System.Text;

namespace SuperFundLookup.SFLSampleCSharp
{
   /// <summary>
   /// Call web services using HttpGet 
   /// </summary>
   class HttpGetSearch {
      //  Private constructor
      private HttpGetSearch() { }
      // ---------------------------------------------------------------------------------------------
      //  Search by an Abn
      // ---------------------------------------------------------------------------------------------
      public static string AbnSearch(string searchText, string guid) {
         string QueryString = BuildAbnQueryString(searchText, guid);
         HttpWebRequest WebRequest = null;
         try {
            WebRequest = BuildRequest(QueryString);
            return ReadResponse(WebRequest);
         }
         catch {
            throw;
         }
         finally {
            WebRequest.Abort();
         }
      }
      // -----------------------------------------------------------------------------------------------
      //  Return query string for a search by ABN 
      // -----------------------------------------------------------------------------------------------
      private static string BuildAbnQueryString(string searchText, string guid)
      {
         StringBuilder QueryString = new StringBuilder("http://superfundlookup.gov.au/xmlsearch/SflXmlSearch.asmx/SearchByABN?");
         QueryString.Append("abn=" + searchText);
         QueryString.Append("&guid=" + guid);
         return QueryString.ToString();
      }
      // ---------------------------------------------------------------------------------------------
      //  Set the request header details
      // ---------------------------------------------------------------------------------------------
      private static HttpWebRequest BuildRequest(string queryString) {
         HttpWebRequest Request;
         Request = (HttpWebRequest)WebRequest.Create(queryString);
         try {
            Request.Timeout = int.Parse(AppSettings.RequestTimeoutInMilliseconds, CultureInfo.CurrentCulture);
         }
         catch {
            Request.Timeout = 100000;
         }
         Request.ContentType = "text/xml; charset=utf-8";
         Request.Proxy = GetWebProxy();
         Request.Method = "GET";
         return (Request);
      }
      // ---------------------------------------------------------------------------------------------
      //  Set proxy depending on settings in the config file
      // ---------------------------------------------------------------------------------------------
      private static IWebProxy GetWebProxy() {
         string ProxySetting = AppSettings.Proxy;
         if (ProxySetting.Length > 0) {
            return new WebProxy(ProxySetting);}
         else {
            return WebRequest.GetSystemWebProxy();
         }
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

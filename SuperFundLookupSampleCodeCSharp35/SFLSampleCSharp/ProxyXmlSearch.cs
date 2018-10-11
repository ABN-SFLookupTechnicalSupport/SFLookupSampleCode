using System;
using SuperFundLookup.SFLSampleCSharp.ServiceReferenceSFL;

namespace SuperFundLookup.SFLSampleCSharp
{
   class ProxyXmlSearch {
      //  Private constructor
      private ProxyXmlSearch() { }
      // -----------------------------------------------------------------------------------------------
      //  Search by ABN
      // -----------------------------------------------------------------------------------------------
      public static ServiceReferenceSFL.FundPayload AbnSearch(string searchText, string guid)
      {
         using (ServiceReferenceSFL.SflXmlSearchSoapClient Search = new SflXmlSearchSoapClient())
         {
            return Search.SearchByABN(searchText,guid);
         }
      }
   }
}


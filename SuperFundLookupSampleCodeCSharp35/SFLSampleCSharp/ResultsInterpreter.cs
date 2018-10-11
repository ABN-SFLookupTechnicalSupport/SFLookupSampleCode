using System;
using System.IO;
using System.Xml.Serialization;
using System.Data;
using System.Globalization;
using SuperFundLookup.SFLSampleCSharp.ServiceReferenceSFL;

namespace SuperFundLookup.SFLSampleCSharp
{
   class ResultsInterpreter {
      //  Private constructor
      private ResultsInterpreter() { }
      // -----------------------------------------------------------------------------------------------
      //  Return FundPayload as an XML String
      // -----------------------------------------------------------------------------------------------
      public static string SerialiseFundPayload(ServiceReferenceSFL.FundPayload searchFundPayload)
      {
          try
          {
              MemoryStream XmlStream = new MemoryStream();
              StreamReader XmlReader = new StreamReader(XmlStream);
              XmlSerializer Serializer = new XmlSerializer(typeof(ServiceReferenceSFL.FundPayload));
              Serializer.Serialize(XmlStream, searchFundPayload);
              XmlStream.Seek(0, System.IO.SeekOrigin.Begin);
              return XmlReader.ReadToEnd();
          }
          catch
          {
              throw;
          }
      }
   }
}

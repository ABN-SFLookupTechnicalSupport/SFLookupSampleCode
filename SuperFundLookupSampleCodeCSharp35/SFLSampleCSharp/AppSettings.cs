using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SuperFundLookup.SFLSampleCSharp
{
    public sealed class AppSettings
    {
        // Private Constructor:
        private AppSettings() { }
        //--------------------------------------------------------------------------
        // Proxy setting
        //--------------------------------------------------------------------------
        public static string Proxy
        {
            get
            {
                return Settings.GetApplicationSetting("Proxy");
            }
        }
        //--------------------------------------------------------------------------
        // Guid to access the web services
        //--------------------------------------------------------------------------
        public static string Guid
        {
            get
            {
                return Settings.GetApplicationSetting("Guid");
            }
        }
        //--------------------------------------------------------------------------
        // Web request timeout
        //--------------------------------------------------------------------------
        public static string RequestTimeoutInMilliseconds
        {
            get
            {
                return Settings.GetApplicationSetting("RequestTimeoutInMilliseconds");
            }
        }
        //--------------------------------------------------------------------------
        // Url for web services
        //--------------------------------------------------------------------------
        public static Uri SearchUrl
        {
            get
            {
                return new Uri(Settings.GetApplicationSetting("SearchUrl"));
            }
        }
        //--------------------------------------------------------------------------
        // Soap action for abn search
        //--------------------------------------------------------------------------
        public static string SoapActionAbnSearch
        {
            get
            {
                return Settings.GetApplicationSetting("SoapAction.AbnSearch");
            }
        }
    }
}

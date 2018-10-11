using System;
using System.Collections.Specialized;
using System.Configuration;

namespace SuperFundLookup.SFLSampleCSharp
{
    public sealed class Settings
    {
        //--------------------------------------------------------------------------------------------
        // Private Constructor:
        //--------------------------------------------------------------------------------------------
        private Settings() { }
        //--------------------------------------------------------------------------------------------
        // Return the application setting from the config file
        //--------------------------------------------------------------------------------------------
        public static string GetApplicationSetting(string name)
        {
            NameValueCollection AppSettings = ConfigurationManager.AppSettings;
            try
            {
                return AppSettings[name];
            }
            catch
            {
                throw;
            }
        }
    }
}

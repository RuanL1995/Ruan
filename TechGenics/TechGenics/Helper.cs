using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Microsoft.Win32;

namespace TechGenics
{
    class Helper
    {
        public static bool useManualConString = false;
        public static string conString;
        public static string CnnVal(string name)
        {
            SettingsConstructor settings = new SettingsConstructor();

            if (settings.UseManualConString == false)
            {
                //Gets local server instance and replaces PLACEHOLDER in app.config with local server info
                string svrInstance = "";

                RegistryView registryView = Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32;
                using (RegistryKey hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, registryView))
                {
                    RegistryKey instanceKey = hklm.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server\Instance Names\SQL", false);
                    if (instanceKey != null)
                    {
                        foreach (var instanceName in instanceKey.GetValueNames())
                        {
                            svrInstance = /*Environment.MachineName + @"\" + */instanceName;
                        }
                    }
                }
                conString = ConfigurationManager.ConnectionStrings[name].ConnectionString;
                conString = conString.Replace("PLACEHOLDER", svrInstance);
            }
            else if (settings.UseManualConString == true)
            {
                //Sets connection string manually if option is chosen in settings menu
                conString = settings.ManualConString;
            }

            return conString;
        }
    }
}

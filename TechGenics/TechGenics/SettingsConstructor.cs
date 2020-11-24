using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechGenics
{
    class SettingsConstructor
    {
        /// <summary>
        /// Setup Values
        /// </summary>
        #region Setup Values
        //PublicPlaces
        public static string manualConString = String.Empty;
        //QuarantineZones
        public static bool useManualConString = false;
        #endregion

        //PublicPlaces
        public string ManualConString   // property
        {
            get { return manualConString; }   // get method
            set { manualConString = value; }  // set method
        }

        //QuarantineZones
        public bool UseManualConString  // property
        {
            get { return useManualConString; }   // get method
            set { useManualConString = value; }  // set method
        }
    }
}

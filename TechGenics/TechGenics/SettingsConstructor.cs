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
        //ManualConString
        public static string manualConString = String.Empty;
        //UseManualConString
        public static bool useManualConString = false;
        //CurrentUser
        public static string currentUser = String.Empty;
        //IsAdmin
        public static bool isAdmin = false;


        #endregion

        //ManualConString
        public string ManualConString   // property
        {
            get { return manualConString; }   // get method
            set { manualConString = value; }  // set method
        }

        //UseManualConString
        public bool UseManualConString  // property
        {
            get { return useManualConString; }   // get method
            set { useManualConString = value; }  // set method
        }

        //CurrentUser
        public string CurrentUser // property
        {
            get { return currentUser; }   // get method
            set { currentUser = value; }  // set method
        }

        //IsAdmin
        public bool IsAdmin // property
        {
            get { return isAdmin; }   // get method
            set { isAdmin = value; }  // set method
        }
    }
}

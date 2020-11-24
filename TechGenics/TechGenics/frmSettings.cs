using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;


namespace TechGenics
{
    public partial class frmSettings : Form
    {
        public static string manualConstring = String.Empty;
        public frmSettings()
        {
            InitializeComponent();
        }

        private void radBtnManualConString_CheckedChanged(object sender, EventArgs e)
        {
            if (radBtnManualConString.Checked == true)
            {
                manualConstring = Interaction.InputBox("New Project Creation", "Enter the name of the new project", "new project 1..", -1, -1);
            }
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

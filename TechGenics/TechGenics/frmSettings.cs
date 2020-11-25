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

        frmMainAdmin admin = new frmMainAdmin();

        private void radBtnManualConString_CheckedChanged(object sender, EventArgs e)
        {
            if (radBtnManualConString.Checked == true)
            {
                //Example con string Data Source=DESKTOP-7GT4A2S\SQLEXPRESS;Initial Catalog=TGDB;Integrated Security=True
                manualConstring = Interaction.InputBox("", "Manual connection string", "Enter manual connection string here...", -1, -1);
                SettingsConstructor settings = new SettingsConstructor();
                settings.ManualConString = manualConstring;
                settings.UseManualConString = true;
            }
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void radBtnAutoConString_CheckedChanged(object sender, EventArgs e)
        {
            if (radBtnManualConString.Checked == true)
            {
                SettingsConstructor settings = new SettingsConstructor();
                settings.UseManualConString = false;
            }
        }

        private void btnPhases_Click(object sender, EventArgs e)
        {

        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.SendToBack();
            admin.Show();
        }
    }
}

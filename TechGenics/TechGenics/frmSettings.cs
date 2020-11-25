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

        private void btnThemeSave_Click(object sender, EventArgs e)
        {
            if(rgbDark.Checked)
            {
                
                TechGenics.Properties.Settings.Default.Theme = "Dark";
            }
            if(rgbLight.Checked)
            {
                
                TechGenics.Properties.Settings.Default.Theme = "Light";
            }
        }

        
        private void btnSettings_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(TechGenics.Properties.Settings.Default.Theme == "Dark")
            {
                this.BackColor = SystemColors.ActiveCaptionText;

                lblSettings.BackColor = SystemColors.ActiveCaptionText;
                tabPage1.BackColor = SystemColors.ActiveCaptionText;
                tabPage2.BackColor = SystemColors.ActiveCaptionText;

                btnPhases.BackColor = SystemColors.ActiveCaptionText;
                pnlDiagramsSub.BackColor = SystemColors.ActiveCaptionText;
                btnSaveSettings.BackColor = SystemColors.ActiveCaptionText;
                btnMain.BackColor = SystemColors.ActiveCaptionText;
                btnThemeSave.BackColor = SystemColors.ActiveCaptionText; 
                btnTheme.BackColor = SystemColors.ActiveCaptionText;


            }
            if(TechGenics.Properties.Settings.Default.Theme == "Light")
            {
                this.BackColor = SystemColors.AppWorkspace;

                lblSettings.BackColor = SystemColors.AppWorkspace;
                tabPage1.BackColor = SystemColors.AppWorkspace;
                tabPage2.BackColor = SystemColors.AppWorkspace;

                btnPhases.BackColor = SystemColors.AppWorkspace;
                pnlDiagramsSub.BackColor = SystemColors.AppWorkspace;
                btnSaveSettings.BackColor = SystemColors.AppWorkspace;
                btnMain.BackColor = SystemColors.AppWorkspace;
                btnThemeSave.BackColor = SystemColors.AppWorkspace;
                btnTheme.BackColor = SystemColors.AppWorkspace;

            }
        }
    }
}

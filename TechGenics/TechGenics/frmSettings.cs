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

        bool lBlueBack = false;
        bool blueBack = false;
        bool dBlueBack = false;
        bool lGreyBack = false;
        bool dGreyBack = false;
        bool blackBack = false;
        bool whiteBack = false;

        bool lBlueFore = false;
        bool blueFore = false;
        bool dBlueFore = false;
        bool lGreyFore = false;
        bool dGreyFore = false;
        bool blackFore = false;
        bool whiteFore = false;

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

            //Custom background
            if (TechGenics.Properties.Settings.Default.Theme == "LBlueC")
            {
                lBlueBack = true;
                blueBack = false;
                dBlueBack = false;
                lGreyBack = false;
                dGreyBack = false;
                blackBack = false;
                whiteBack = false;
            }
            if (TechGenics.Properties.Settings.Default.Theme == "BlueC")
            {
                lBlueBack = false;
                blueBack = true;
                dBlueBack = false;
                lGreyBack = false;
                dGreyBack = false;
                blackBack = false;
                whiteBack = false;
            }
            if (TechGenics.Properties.Settings.Default.Theme == "DBlueC")
            {
                lBlueBack = false;
                blueBack = false;
                dBlueBack = true;
                lGreyBack = false;
                dGreyBack = false;
                blackBack = false;
                whiteBack = false;
            }
            if (TechGenics.Properties.Settings.Default.Theme == "LGreyC")
            {
                lBlueBack = false;
                blueBack = false;
                dBlueBack = false;
                lGreyBack = true;
                dGreyBack = false;
                blackBack = false;
                whiteBack = false;
            }
            if (TechGenics.Properties.Settings.Default.Theme == "DGreyC")
            {
                lBlueBack = false;
                blueBack = false;
                dBlueBack = false;
                lGreyBack = false;
                dGreyBack = true;
                blackBack = false;
                whiteBack = false;
            }
            if (TechGenics.Properties.Settings.Default.Theme == "BlackC")
            {
                lBlueBack = false;
                blueBack = false;
                dBlueBack = false;
                lGreyBack = false;
                dGreyBack = false;
                blackBack = true;
                whiteBack = false;
            }
            if (TechGenics.Properties.Settings.Default.Theme == "WhiteC")
            {
                lBlueBack = false;
                blueBack = false;
                dBlueBack = false;
                lGreyBack = false;
                dGreyBack = false;
                blackBack = false;
                whiteBack = true;
            }

            //Custom foreground
            if (TechGenics.Properties.Settings.Default.Theme == "LBlueC2")
            {
                lBlueFore = true;
                blueFore = false;
                dBlueFore = false;
                lGreyFore = false;
                dGreyFore = false;
                blackFore = false;
                whiteFore = false;
            }
            if (TechGenics.Properties.Settings.Default.Theme == "BlueC2")
            {
                lBlueFore = false;
                blueFore = true;
                dBlueFore = false;
                lGreyFore = false;
                dGreyFore = false;
                blackFore = false;
                whiteFore = false;
            }
            if (TechGenics.Properties.Settings.Default.Theme == "DBlueC2")
            {
                lBlueFore = false;
                blueFore = false;
                dBlueFore = true;
                lGreyFore = false;
                dGreyFore = false;
                blackFore = false;
                whiteFore = false;
            }
            if (TechGenics.Properties.Settings.Default.Theme == "LGreyC2")
            {
                lBlueFore = false;
                blueFore = false;
                dBlueFore = false;
                lGreyFore = true;
                dGreyFore = false;
                blackFore = false;
                whiteFore = false;
            }
            if (TechGenics.Properties.Settings.Default.Theme == "DGreyC2")
            {
                lBlueFore = false;
                blueFore = false;
                dBlueFore = false;
                lGreyFore = false;
                dGreyFore = true;
                blackFore = false;
                whiteFore = false;
            }
            if (TechGenics.Properties.Settings.Default.Theme == "BlackC2")
            {
                lBlueFore = false;
                blueFore = false;
                dBlueFore = false;
                lGreyFore = false;
                dGreyFore = false;
                blackFore = true;
                whiteFore = false;
            }
            if (TechGenics.Properties.Settings.Default.Theme == "WhiteC2")
            {
                lBlueFore = false;
                blueFore = false;
                dBlueFore = false;
                lGreyFore = false;
                dGreyFore = false;
                blackFore = false;
                whiteFore = true;
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

            #region example background
            //Custom background
            if (TechGenics.Properties.Settings.Default.Theme == "LBlueC")
            {
                btnCustom.BackColor = SystemColors.ActiveCaption;
            }
            if (TechGenics.Properties.Settings.Default.Theme == "BlueC")
            {
                btnCustom.BackColor = SystemColors.Highlight;
            }
            if (TechGenics.Properties.Settings.Default.Theme == "DBlueC")
            {
                btnCustom.BackColor = SystemColors.Info;
            }
            if (TechGenics.Properties.Settings.Default.Theme == "LGreyC")
            {
                btnCustom.BackColor = SystemColors.ControlDark;
            }
            if (TechGenics.Properties.Settings.Default.Theme == "DGreyC")
            {
                btnCustom.BackColor = SystemColors.ControlDarkDark;
            }
            if (TechGenics.Properties.Settings.Default.Theme == "BlackC")
            {
                btnCustom.BackColor = SystemColors.Desktop;
            }
            if (TechGenics.Properties.Settings.Default.Theme == "WhiteC")
            {
                btnCustom.BackColor = SystemColors.Window;
            }
            #endregion

            #region example foreground
            //Custom foreground
            if (TechGenics.Properties.Settings.Default.Theme == "LBlueC2")
            {
                btnCustom.ForeColor = SystemColors.ActiveCaption;
            }
            if (TechGenics.Properties.Settings.Default.Theme == "BlueC2")
            {
                btnCustom.ForeColor = SystemColors.Highlight;
            }
            if (TechGenics.Properties.Settings.Default.Theme == "DBlueC2")
            {
                btnCustom.ForeColor = SystemColors.Info;
            }
            if (TechGenics.Properties.Settings.Default.Theme == "LGreyC2")
            {
                btnCustom.ForeColor = SystemColors.ControlDark;
            }
            if (TechGenics.Properties.Settings.Default.Theme == "DGreyC2")
            {
                btnCustom.ForeColor = SystemColors.ControlDarkDark;
            }
            if (TechGenics.Properties.Settings.Default.Theme == "BlackC2")
            {
                btnCustom.ForeColor = SystemColors.Desktop;
            }
            if (TechGenics.Properties.Settings.Default.Theme == "WhiteC2")
            {
                btnCustom.ForeColor = SystemColors.Window;
            }
#endregion

            if (lBlueBack == true)
            {
                this.BackColor = SystemColors.ActiveCaption;

                lblSettings.BackColor = SystemColors.ActiveCaption;
                tabPage1.BackColor = SystemColors.ActiveCaption;
                tabPage2.BackColor = SystemColors.ActiveCaption;

                btnPhases.BackColor = SystemColors.ActiveCaption;
                pnlDiagramsSub.BackColor = SystemColors.ActiveCaption;
                btnSaveSettings.BackColor = SystemColors.ActiveCaption;
                btnMain.BackColor = SystemColors.ActiveCaption;
                btnThemeSave.BackColor = SystemColors.ActiveCaption;
                btnTheme.BackColor = SystemColors.ActiveCaption;
            }

            if (blueBack == true)
            {
                this.BackColor = SystemColors.Highlight;

                lblSettings.BackColor = SystemColors.Highlight; 
                tabPage1.BackColor = SystemColors.Highlight;
                tabPage2.BackColor = SystemColors.Highlight;

                btnPhases.BackColor = SystemColors.Highlight;
                pnlDiagramsSub.BackColor = SystemColors.Highlight;
                btnSaveSettings.BackColor = SystemColors.Highlight;
                btnMain.BackColor = SystemColors.Highlight;
                btnThemeSave.BackColor = SystemColors.Highlight;
                btnTheme.BackColor = SystemColors.Highlight;
            }

            if (dBlueBack == true)
            {
                this.BackColor = SystemColors.Info;

                lblSettings.BackColor = SystemColors.Info;
                tabPage1.BackColor = SystemColors.Info;
                tabPage2.BackColor = SystemColors.Info;

                btnPhases.BackColor = SystemColors.Info;
                pnlDiagramsSub.BackColor = SystemColors.Info;
                btnSaveSettings.BackColor = SystemColors.Info;
                btnMain.BackColor = SystemColors.Info;
                btnThemeSave.BackColor = SystemColors.Info;
                btnTheme.BackColor = SystemColors.Info;
            }

            if (lGreyBack == true)
            {
                this.BackColor = SystemColors.ControlDark;

                lblSettings.BackColor = SystemColors.ControlDark;
                tabPage1.BackColor = SystemColors.ControlDark;
                tabPage2.BackColor = SystemColors.ControlDark;

                btnPhases.BackColor = SystemColors.ControlDark;
                pnlDiagramsSub.BackColor = SystemColors.ControlDark;
                btnSaveSettings.BackColor = SystemColors.ControlDark;
                btnMain.BackColor = SystemColors.ControlDark;
                btnThemeSave.BackColor = SystemColors.ControlDark;
                btnTheme.BackColor = SystemColors.ControlDark;
            }

            if (dGreyBack == true)
            {
                this.BackColor = SystemColors.ControlDarkDark;

                lblSettings.BackColor = SystemColors.ControlDarkDark;
                tabPage1.BackColor = SystemColors.ControlDarkDark;
                tabPage2.BackColor = SystemColors.ControlDarkDark;

                btnPhases.BackColor = SystemColors.ControlDarkDark;
                pnlDiagramsSub.BackColor = SystemColors.ControlDarkDark;
                btnSaveSettings.BackColor = SystemColors.ControlDarkDark;
                btnMain.BackColor = SystemColors.ControlDarkDark;
                btnThemeSave.BackColor = SystemColors.ControlDarkDark;
                btnTheme.BackColor = SystemColors.ControlDarkDark;
            }

            if (blackBack == true)
            {
                this.BackColor = SystemColors.Desktop;

                lblSettings.BackColor = SystemColors.Desktop;
                tabPage1.BackColor = SystemColors.Desktop;
                tabPage2.BackColor = SystemColors.Desktop;

                btnPhases.BackColor = SystemColors.Desktop;
                pnlDiagramsSub.BackColor = SystemColors.Desktop;
                btnSaveSettings.BackColor = SystemColors.Desktop;
                btnMain.BackColor = SystemColors.Desktop;
                btnThemeSave.BackColor = SystemColors.Desktop;
                btnTheme.BackColor = SystemColors.Desktop;
            }

            if (whiteBack == true)
            {
                this.BackColor = SystemColors.Window;

                lblSettings.BackColor = SystemColors.Window;
                tabPage1.BackColor = SystemColors.Window;
                tabPage2.BackColor = SystemColors.Window;

                btnPhases.BackColor = SystemColors.Window;
                pnlDiagramsSub.BackColor = SystemColors.Window;
                btnSaveSettings.BackColor = SystemColors.Window;
                btnMain.BackColor = SystemColors.Window;
                btnThemeSave.BackColor = SystemColors.Window;
                btnTheme.BackColor = SystemColors.Window;
            }

            //foreground
            if (lBlueFore == true)
            {
                this.ForeColor = SystemColors.ActiveCaption;

                lblSettings.ForeColor = SystemColors.ActiveCaption;
                tabPage1.ForeColor = SystemColors.ActiveCaption;
                tabPage2.ForeColor = SystemColors.ActiveCaption;

                btnPhases.ForeColor = SystemColors.ActiveCaption;
                pnlDiagramsSub.ForeColor = SystemColors.ActiveCaption;
                btnSaveSettings.ForeColor = SystemColors.ActiveCaption;
                btnMain.ForeColor = SystemColors.ActiveCaption;
                btnThemeSave.ForeColor = SystemColors.ActiveCaption;
                btnTheme.ForeColor = SystemColors.ActiveCaption;
            }

            if (blueFore == true)
            {
                this.ForeColor = SystemColors.Highlight;

                lblSettings.ForeColor = SystemColors.Highlight;
                tabPage1.ForeColor = SystemColors.Highlight;
                tabPage2.ForeColor = SystemColors.Highlight;

                btnPhases.ForeColor = SystemColors.Highlight;
                pnlDiagramsSub.ForeColor = SystemColors.Highlight;
                btnSaveSettings.ForeColor = SystemColors.Highlight;
                btnMain.ForeColor = SystemColors.Highlight;
                btnThemeSave.ForeColor = SystemColors.Highlight;
                btnTheme.ForeColor = SystemColors.Highlight;
            }

            if (dBlueFore == true)
            {
                this.ForeColor = SystemColors.Info;

                lblSettings.ForeColor = SystemColors.Info;
                tabPage1.ForeColor = SystemColors.Info;
                tabPage2.ForeColor = SystemColors.Info;

                btnPhases.ForeColor = SystemColors.Info;
                pnlDiagramsSub.ForeColor = SystemColors.Info;
                btnSaveSettings.ForeColor = SystemColors.Info;
                btnMain.ForeColor = SystemColors.Info;
                btnThemeSave.ForeColor = SystemColors.Info;
                btnTheme.ForeColor = SystemColors.Info;
            }

            if (lGreyFore == true)
            {
                this.ForeColor = SystemColors.ControlDark;

                lblSettings.ForeColor = SystemColors.ControlDark;
                tabPage1.ForeColor = SystemColors.ControlDark;
                tabPage2.ForeColor = SystemColors.ControlDark;

                btnPhases.ForeColor = SystemColors.ControlDark;
                pnlDiagramsSub.ForeColor = SystemColors.ControlDark;
                btnSaveSettings.ForeColor = SystemColors.ControlDark;
                btnMain.ForeColor = SystemColors.ControlDark;
                btnThemeSave.ForeColor = SystemColors.ControlDark;
                btnTheme.ForeColor = SystemColors.ControlDark;
            }

            if (dGreyFore == true)
            {
                this.ForeColor = SystemColors.ControlDarkDark;

                lblSettings.ForeColor = SystemColors.ControlDarkDark;
                tabPage1.ForeColor = SystemColors.ControlDarkDark;
                tabPage2.ForeColor = SystemColors.ControlDarkDark;

                btnPhases.ForeColor = SystemColors.ControlDarkDark;
                pnlDiagramsSub.ForeColor = SystemColors.ControlDarkDark;
                btnSaveSettings.ForeColor = SystemColors.ControlDarkDark;
                btnMain.ForeColor = SystemColors.ControlDarkDark;
                btnThemeSave.ForeColor = SystemColors.ControlDarkDark;
                btnTheme.ForeColor = SystemColors.ControlDarkDark;
            }

            if (blackFore == true)
            {
                this.ForeColor = SystemColors.Desktop;

                lblSettings.ForeColor = SystemColors.Desktop;
                tabPage1.ForeColor = SystemColors.Desktop;
                tabPage2.ForeColor = SystemColors.Desktop;

                btnPhases.ForeColor = SystemColors.Desktop;
                pnlDiagramsSub.ForeColor = SystemColors.Desktop;
                btnSaveSettings.ForeColor = SystemColors.Desktop;
                btnMain.ForeColor = SystemColors.Desktop;
                btnThemeSave.ForeColor = SystemColors.Desktop;
                btnTheme.ForeColor = SystemColors.Desktop;
            }

            if (whiteFore == true)
            {
                this.ForeColor = SystemColors.Window;

                lblSettings.ForeColor = SystemColors.Window;
                tabPage1.ForeColor = SystemColors.Window;
                tabPage2.ForeColor = SystemColors.Window;

                btnPhases.ForeColor = SystemColors.Window;
                pnlDiagramsSub.ForeColor = SystemColors.Window;
                btnSaveSettings.ForeColor = SystemColors.Window;
                btnMain.ForeColor = SystemColors.Window;
                btnThemeSave.ForeColor = SystemColors.Window;
                btnTheme.ForeColor = SystemColors.Window;
            }
        }

        private void cmboBack_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmboBack.SelectedItem.ToString() == "Light Blue")
            {
                TechGenics.Properties.Settings.Default.Theme = "LBlueC";

            }

            if (cmboBack.SelectedItem.ToString() == "Blue")
            {
                TechGenics.Properties.Settings.Default.Theme = "BlueC";
                
            }

            if (cmboBack.SelectedItem.ToString() == "Dark Blue")
            {
                TechGenics.Properties.Settings.Default.Theme = "DBlueC";

            }

            if (cmboBack.SelectedItem.ToString() == "Light Grey")
            {
                TechGenics.Properties.Settings.Default.Theme = "LGreyC";

            }

            if (cmboBack.SelectedItem.ToString() == "Dark Grey")
            {
                TechGenics.Properties.Settings.Default.Theme = "DGreyC";

            }

            if (cmboBack.SelectedItem.ToString() == "Black")
            {
                TechGenics.Properties.Settings.Default.Theme = "BlackC";

            }

            if (cmboBack.SelectedItem.ToString() == "White")
            {
                TechGenics.Properties.Settings.Default.Theme = "WhiteC";

            }
        }

        private void cmboFore_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmboBack.SelectedItem.ToString() == "Light Blue")
            {
                TechGenics.Properties.Settings.Default.Theme = "LBlueC2";

            }

            if (cmboBack.SelectedItem.ToString() == "Blue")
            {
                TechGenics.Properties.Settings.Default.Theme = "BlueC2";

            }

            if (cmboBack.SelectedItem.ToString() == "Dark Blue")
            {
                TechGenics.Properties.Settings.Default.Theme = "DBlueC2";

            }

            if (cmboBack.SelectedItem.ToString() == "Light Grey")
            {
                TechGenics.Properties.Settings.Default.Theme = "LGreyC2";

            }

            if (cmboBack.SelectedItem.ToString() == "Dark Grey")
            {
                TechGenics.Properties.Settings.Default.Theme = "DGreyC2";

            }

            if (cmboBack.SelectedItem.ToString() == "Black")
            {
                TechGenics.Properties.Settings.Default.Theme = "BlackC2";

            }

            if (cmboBack.SelectedItem.ToString() == "White")
            {
                TechGenics.Properties.Settings.Default.Theme = "WhiteC2";

            }
        }

        private void rgbCustom_CheckedChanged(object sender, EventArgs e)
        {
            pnlCustom.Visible = true;
        }
    }
}

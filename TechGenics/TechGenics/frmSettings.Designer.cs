namespace TechGenics
{
    partial class frmSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnPhases = new System.Windows.Forms.Button();
            this.radBtnAutoConString = new System.Windows.Forms.RadioButton();
            this.radBtnManualConString = new System.Windows.Forms.RadioButton();
            this.pnlDiagramsSub = new System.Windows.Forms.Panel();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.btnMain = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnTheme = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThemeSave = new System.Windows.Forms.Button();
            this.rgbDark = new System.Windows.Forms.RadioButton();
            this.rgbLight = new System.Windows.Forms.RadioButton();
            this.lblSettings = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlDiagramsSub.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPhases
            // 
            this.btnPhases.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPhases.BackColor = System.Drawing.Color.Black;
            this.btnPhases.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPhases.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPhases.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhases.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnPhases.Location = new System.Drawing.Point(127, 33);
            this.btnPhases.Name = "btnPhases";
            this.btnPhases.Size = new System.Drawing.Size(386, 37);
            this.btnPhases.TabIndex = 2;
            this.btnPhases.Text = "Connection Settings";
            this.btnPhases.UseVisualStyleBackColor = false;
            this.btnPhases.Click += new System.EventHandler(this.btnPhases_Click);
            // 
            // radBtnAutoConString
            // 
            this.radBtnAutoConString.AutoSize = true;
            this.radBtnAutoConString.BackColor = System.Drawing.Color.Transparent;
            this.radBtnAutoConString.Checked = true;
            this.radBtnAutoConString.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBtnAutoConString.ForeColor = System.Drawing.Color.Aquamarine;
            this.radBtnAutoConString.Location = new System.Drawing.Point(12, 6);
            this.radBtnAutoConString.Name = "radBtnAutoConString";
            this.radBtnAutoConString.Size = new System.Drawing.Size(178, 22);
            this.radBtnAutoConString.TabIndex = 3;
            this.radBtnAutoConString.TabStop = true;
            this.radBtnAutoConString.Text = "Auto Connection String";
            this.radBtnAutoConString.UseVisualStyleBackColor = false;
            this.radBtnAutoConString.CheckedChanged += new System.EventHandler(this.radBtnAutoConString_CheckedChanged);
            // 
            // radBtnManualConString
            // 
            this.radBtnManualConString.AutoSize = true;
            this.radBtnManualConString.BackColor = System.Drawing.Color.Transparent;
            this.radBtnManualConString.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBtnManualConString.ForeColor = System.Drawing.Color.Aquamarine;
            this.radBtnManualConString.Location = new System.Drawing.Point(214, 6);
            this.radBtnManualConString.Name = "radBtnManualConString";
            this.radBtnManualConString.Size = new System.Drawing.Size(196, 22);
            this.radBtnManualConString.TabIndex = 4;
            this.radBtnManualConString.Text = "Manual Connection String";
            this.radBtnManualConString.UseVisualStyleBackColor = false;
            this.radBtnManualConString.CheckedChanged += new System.EventHandler(this.radBtnManualConString_CheckedChanged);
            // 
            // pnlDiagramsSub
            // 
            this.pnlDiagramsSub.BackColor = System.Drawing.Color.Black;
            this.pnlDiagramsSub.Controls.Add(this.radBtnAutoConString);
            this.pnlDiagramsSub.Controls.Add(this.radBtnManualConString);
            this.pnlDiagramsSub.Location = new System.Drawing.Point(115, 120);
            this.pnlDiagramsSub.Name = "pnlDiagramsSub";
            this.pnlDiagramsSub.Size = new System.Drawing.Size(448, 36);
            this.pnlDiagramsSub.TabIndex = 5;
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSaveSettings.BackColor = System.Drawing.Color.Black;
            this.btnSaveSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSaveSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveSettings.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnSaveSettings.Location = new System.Drawing.Point(85, 306);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(205, 34);
            this.btnSaveSettings.TabIndex = 12;
            this.btnSaveSettings.Text = "Save";
            this.btnSaveSettings.UseVisualStyleBackColor = false;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // btnMain
            // 
            this.btnMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMain.BackColor = System.Drawing.Color.Black;
            this.btnMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMain.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnMain.Location = new System.Drawing.Point(370, 306);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(205, 34);
            this.btnMain.TabIndex = 13;
            this.btnMain.Text = "Back to Main";
            this.btnMain.UseVisualStyleBackColor = false;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(23, 64);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(627, 453);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Black;
            this.tabPage1.Controls.Add(this.btnPhases);
            this.tabPage1.Controls.Add(this.btnMain);
            this.tabPage1.Controls.Add(this.pnlDiagramsSub);
            this.tabPage1.Controls.Add(this.btnSaveSettings);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(619, 427);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Connection";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Black;
            this.tabPage2.Controls.Add(this.btnTheme);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(619, 427);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Advanced";
            // 
            // btnTheme
            // 
            this.btnTheme.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTheme.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnTheme.Location = new System.Drawing.Point(27, 18);
            this.btnTheme.Name = "btnTheme";
            this.btnTheme.Size = new System.Drawing.Size(75, 23);
            this.btnTheme.TabIndex = 1;
            this.btnTheme.Text = "Theme";
            this.btnTheme.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnThemeSave);
            this.panel1.Controls.Add(this.rgbDark);
            this.panel1.Controls.Add(this.rgbLight);
            this.panel1.Location = new System.Drawing.Point(27, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(566, 349);
            this.panel1.TabIndex = 0;
            // 
            // btnThemeSave
            // 
            this.btnThemeSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnThemeSave.BackColor = System.Drawing.Color.Black;
            this.btnThemeSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThemeSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemeSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemeSave.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnThemeSave.Location = new System.Drawing.Point(178, 284);
            this.btnThemeSave.Name = "btnThemeSave";
            this.btnThemeSave.Size = new System.Drawing.Size(205, 34);
            this.btnThemeSave.TabIndex = 13;
            this.btnThemeSave.Text = "Save";
            this.btnThemeSave.UseVisualStyleBackColor = false;
            this.btnThemeSave.Click += new System.EventHandler(this.btnThemeSave_Click);
            // 
            // rgbDark
            // 
            this.rgbDark.AutoSize = true;
            this.rgbDark.Checked = true;
            this.rgbDark.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rgbDark.ForeColor = System.Drawing.Color.Aquamarine;
            this.rgbDark.Location = new System.Drawing.Point(408, 119);
            this.rgbDark.Name = "rgbDark";
            this.rgbDark.Size = new System.Drawing.Size(100, 22);
            this.rgbDark.TabIndex = 1;
            this.rgbDark.TabStop = true;
            this.rgbDark.Text = "Dark Mode";
            this.rgbDark.UseVisualStyleBackColor = true;
            // 
            // rgbLight
            // 
            this.rgbLight.AutoSize = true;
            this.rgbLight.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rgbLight.ForeColor = System.Drawing.Color.Aquamarine;
            this.rgbLight.Location = new System.Drawing.Point(83, 119);
            this.rgbLight.Name = "rgbLight";
            this.rgbLight.Size = new System.Drawing.Size(99, 22);
            this.rgbLight.TabIndex = 0;
            this.rgbLight.TabStop = true;
            this.rgbLight.Text = "Light Mode";
            this.rgbLight.UseVisualStyleBackColor = true;
            // 
            // lblSettings
            // 
            this.lblSettings.AutoSize = true;
            this.lblSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSettings.ForeColor = System.Drawing.Color.Aquamarine;
            this.lblSettings.Location = new System.Drawing.Point(267, 24);
            this.lblSettings.Name = "lblSettings";
            this.lblSettings.Size = new System.Drawing.Size(132, 37);
            this.lblSettings.TabIndex = 15;
            this.lblSettings.Text = "Settings";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(675, 548);
            this.Controls.Add(this.lblSettings);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmSettings";
            this.pnlDiagramsSub.ResumeLayout(false);
            this.pnlDiagramsSub.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPhases;
        private System.Windows.Forms.RadioButton radBtnAutoConString;
        private System.Windows.Forms.RadioButton radBtnManualConString;
        private System.Windows.Forms.Panel pnlDiagramsSub;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnTheme;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnThemeSave;
        private System.Windows.Forms.RadioButton rgbDark;
        private System.Windows.Forms.RadioButton rgbLight;
        private System.Windows.Forms.Label lblSettings;
        private System.Windows.Forms.Timer timer1;
    }
}
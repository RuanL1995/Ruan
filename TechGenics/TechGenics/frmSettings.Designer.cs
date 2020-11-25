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
            this.btnPhases = new System.Windows.Forms.Button();
            this.radBtnAutoConString = new System.Windows.Forms.RadioButton();
            this.radBtnManualConString = new System.Windows.Forms.RadioButton();
            this.pnlDiagramsSub = new System.Windows.Forms.Panel();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.btnMain = new System.Windows.Forms.Button();
            this.pnlDiagramsSub.SuspendLayout();
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
            this.btnPhases.Location = new System.Drawing.Point(212, 85);
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
            this.radBtnAutoConString.Checked = true;
            this.radBtnAutoConString.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBtnAutoConString.ForeColor = System.Drawing.Color.Aquamarine;
            this.radBtnAutoConString.Location = new System.Drawing.Point(12, 6);
            this.radBtnAutoConString.Name = "radBtnAutoConString";
            this.radBtnAutoConString.Size = new System.Drawing.Size(178, 22);
            this.radBtnAutoConString.TabIndex = 3;
            this.radBtnAutoConString.TabStop = true;
            this.radBtnAutoConString.Text = "Auto Connection String";
            this.radBtnAutoConString.UseVisualStyleBackColor = true;
            this.radBtnAutoConString.CheckedChanged += new System.EventHandler(this.radBtnAutoConString_CheckedChanged);
            // 
            // radBtnManualConString
            // 
            this.radBtnManualConString.AutoSize = true;
            this.radBtnManualConString.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBtnManualConString.ForeColor = System.Drawing.Color.Aquamarine;
            this.radBtnManualConString.Location = new System.Drawing.Point(214, 6);
            this.radBtnManualConString.Name = "radBtnManualConString";
            this.radBtnManualConString.Size = new System.Drawing.Size(196, 22);
            this.radBtnManualConString.TabIndex = 4;
            this.radBtnManualConString.Text = "Manual Connection String";
            this.radBtnManualConString.UseVisualStyleBackColor = true;
            this.radBtnManualConString.CheckedChanged += new System.EventHandler(this.radBtnManualConString_CheckedChanged);
            // 
            // pnlDiagramsSub
            // 
            this.pnlDiagramsSub.BackColor = System.Drawing.Color.Black;
            this.pnlDiagramsSub.Controls.Add(this.radBtnAutoConString);
            this.pnlDiagramsSub.Controls.Add(this.radBtnManualConString);
            this.pnlDiagramsSub.Location = new System.Drawing.Point(175, 180);
            this.pnlDiagramsSub.Name = "pnlDiagramsSub";
            this.pnlDiagramsSub.Size = new System.Drawing.Size(448, 39);
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
            this.btnSaveSettings.Location = new System.Drawing.Point(175, 282);
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
            this.btnMain.Location = new System.Drawing.Point(418, 282);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(205, 34);
            this.btnMain.TabIndex = 13;
            this.btnMain.Text = "Back to Main";
            this.btnMain.UseVisualStyleBackColor = false;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(809, 590);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.btnSaveSettings);
            this.Controls.Add(this.pnlDiagramsSub);
            this.Controls.Add(this.btnPhases);
            this.Name = "frmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmSettings";
            this.pnlDiagramsSub.ResumeLayout(false);
            this.pnlDiagramsSub.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnPhases;
        private System.Windows.Forms.RadioButton radBtnAutoConString;
        private System.Windows.Forms.RadioButton radBtnManualConString;
        private System.Windows.Forms.Panel pnlDiagramsSub;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.Button btnMain;
    }
}
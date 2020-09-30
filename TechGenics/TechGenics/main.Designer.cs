namespace TechGenics
{
    partial class frmMainAdmin
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
            this.pnlSideMenu = new System.Windows.Forms.Panel();
            this.pnlPhasesSub = new System.Windows.Forms.Panel();
            this.btnCloseOut = new System.Windows.Forms.Button();
            this.btnExecution = new System.Windows.Forms.Button();
            this.btnPlanning = new System.Windows.Forms.Button();
            this.btnInitiation = new System.Windows.Forms.Button();
            this.btnPhases = new System.Windows.Forms.Button();
            this.pnlChildForm = new System.Windows.Forms.Panel();
            this.pnlSideMenu.SuspendLayout();
            this.pnlPhasesSub.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSideMenu
            // 
            this.pnlSideMenu.AutoScroll = true;
            this.pnlSideMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlSideMenu.BackColor = System.Drawing.Color.Black;
            this.pnlSideMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSideMenu.Controls.Add(this.pnlPhasesSub);
            this.pnlSideMenu.Controls.Add(this.btnPhases);
            this.pnlSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlSideMenu.Name = "pnlSideMenu";
            this.pnlSideMenu.Size = new System.Drawing.Size(226, 687);
            this.pnlSideMenu.TabIndex = 0;
            // 
            // pnlPhasesSub
            // 
            this.pnlPhasesSub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.pnlPhasesSub.Controls.Add(this.btnCloseOut);
            this.pnlPhasesSub.Controls.Add(this.btnExecution);
            this.pnlPhasesSub.Controls.Add(this.btnPlanning);
            this.pnlPhasesSub.Controls.Add(this.btnInitiation);
            this.pnlPhasesSub.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPhasesSub.Location = new System.Drawing.Point(0, 34);
            this.pnlPhasesSub.Name = "pnlPhasesSub";
            this.pnlPhasesSub.Size = new System.Drawing.Size(222, 133);
            this.pnlPhasesSub.TabIndex = 1;
            // 
            // btnCloseOut
            // 
            this.btnCloseOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnCloseOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCloseOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseOut.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnCloseOut.Location = new System.Drawing.Point(3, 98);
            this.btnCloseOut.Name = "btnCloseOut";
            this.btnCloseOut.Size = new System.Drawing.Size(186, 24);
            this.btnCloseOut.TabIndex = 3;
            this.btnCloseOut.Text = "Close Out";
            this.btnCloseOut.UseVisualStyleBackColor = false;
            this.btnCloseOut.Click += new System.EventHandler(this.btnCloseOut_Click);
            // 
            // btnExecution
            // 
            this.btnExecution.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnExecution.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExecution.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExecution.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnExecution.Location = new System.Drawing.Point(4, 68);
            this.btnExecution.Name = "btnExecution";
            this.btnExecution.Size = new System.Drawing.Size(186, 24);
            this.btnExecution.TabIndex = 2;
            this.btnExecution.Text = "Execution";
            this.btnExecution.UseVisualStyleBackColor = false;
            this.btnExecution.Click += new System.EventHandler(this.btnExecution_Click);
            // 
            // btnPlanning
            // 
            this.btnPlanning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnPlanning.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPlanning.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlanning.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnPlanning.Location = new System.Drawing.Point(4, 38);
            this.btnPlanning.Name = "btnPlanning";
            this.btnPlanning.Size = new System.Drawing.Size(186, 24);
            this.btnPlanning.TabIndex = 1;
            this.btnPlanning.Text = "Planning";
            this.btnPlanning.UseVisualStyleBackColor = false;
            this.btnPlanning.Click += new System.EventHandler(this.btnPlanning_Click);
            // 
            // btnInitiation
            // 
            this.btnInitiation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnInitiation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnInitiation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInitiation.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnInitiation.Location = new System.Drawing.Point(4, 8);
            this.btnInitiation.Name = "btnInitiation";
            this.btnInitiation.Size = new System.Drawing.Size(186, 24);
            this.btnInitiation.TabIndex = 0;
            this.btnInitiation.Text = "Initiation";
            this.btnInitiation.UseVisualStyleBackColor = false;
            this.btnInitiation.Click += new System.EventHandler(this.btnInitiation_Click);
            // 
            // btnPhases
            // 
            this.btnPhases.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPhases.BackColor = System.Drawing.Color.Black;
            this.btnPhases.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPhases.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPhases.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPhases.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhases.ForeColor = System.Drawing.Color.MintCream;
            this.btnPhases.Location = new System.Drawing.Point(0, 0);
            this.btnPhases.Name = "btnPhases";
            this.btnPhases.Size = new System.Drawing.Size(222, 34);
            this.btnPhases.TabIndex = 0;
            this.btnPhases.Text = "Project Phases";
            this.btnPhases.UseVisualStyleBackColor = false;
            this.btnPhases.Click += new System.EventHandler(this.btnPhases_Click);
            // 
            // pnlChildForm
            // 
            this.pnlChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(45)))));
            this.pnlChildForm.Location = new System.Drawing.Point(221, 2);
            this.pnlChildForm.Name = "pnlChildForm";
            this.pnlChildForm.Size = new System.Drawing.Size(895, 687);
            this.pnlChildForm.TabIndex = 1;
            // 
            // frmMainAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1107, 687);
            this.Controls.Add(this.pnlChildForm);
            this.Controls.Add(this.pnlSideMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMainAdmin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "main";
            this.pnlSideMenu.ResumeLayout(false);
            this.pnlPhasesSub.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSideMenu;
        private System.Windows.Forms.Button btnPhases;
        private System.Windows.Forms.Panel pnlPhasesSub;
        private System.Windows.Forms.Button btnCloseOut;
        private System.Windows.Forms.Button btnExecution;
        private System.Windows.Forms.Button btnPlanning;
        private System.Windows.Forms.Button btnInitiation;
        private System.Windows.Forms.Panel pnlChildForm;
    }
}
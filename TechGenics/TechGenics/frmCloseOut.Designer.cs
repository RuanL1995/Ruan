namespace TechGenics
{
    partial class frmCloseOut
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
            this.pnlCloseOut = new System.Windows.Forms.Panel();
            this.lstInfo = new System.Windows.Forms.ListBox();
            this.btnClosure = new System.Windows.Forms.Button();
            this.btnRev = new System.Windows.Forms.Button();
            this.pnlCloseOut.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCloseOut
            // 
            this.pnlCloseOut.Controls.Add(this.btnRev);
            this.pnlCloseOut.Controls.Add(this.btnClosure);
            this.pnlCloseOut.Controls.Add(this.lstInfo);
            this.pnlCloseOut.Location = new System.Drawing.Point(22, 12);
            this.pnlCloseOut.Name = "pnlCloseOut";
            this.pnlCloseOut.Size = new System.Drawing.Size(823, 591);
            this.pnlCloseOut.TabIndex = 0;
            // 
            // lstInfo
            // 
            this.lstInfo.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lstInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstInfo.FormattingEnabled = true;
            this.lstInfo.Location = new System.Drawing.Point(24, 36);
            this.lstInfo.Name = "lstInfo";
            this.lstInfo.Size = new System.Drawing.Size(765, 312);
            this.lstInfo.TabIndex = 0;
            // 
            // btnClosure
            // 
            this.btnClosure.BackColor = System.Drawing.Color.Aquamarine;
            this.btnClosure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClosure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClosure.Location = new System.Drawing.Point(118, 509);
            this.btnClosure.Name = "btnClosure";
            this.btnClosure.Size = new System.Drawing.Size(269, 32);
            this.btnClosure.TabIndex = 1;
            this.btnClosure.Text = "Project Closure";
            this.btnClosure.UseVisualStyleBackColor = false;
            this.btnClosure.MouseLeave += new System.EventHandler(this.btnClosure_MouseLeave);
            this.btnClosure.MouseHover += new System.EventHandler(this.btnClosure_MouseHover);
            // 
            // btnRev
            // 
            this.btnRev.BackColor = System.Drawing.Color.Aquamarine;
            this.btnRev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRev.Location = new System.Drawing.Point(410, 509);
            this.btnRev.Name = "btnRev";
            this.btnRev.Size = new System.Drawing.Size(269, 32);
            this.btnRev.TabIndex = 2;
            this.btnRev.Text = "Review Project Completion";
            this.btnRev.UseVisualStyleBackColor = false;
            this.btnRev.MouseHover += new System.EventHandler(this.btnRev_MouseHover);
            // 
            // frmCloseOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(871, 628);
            this.Controls.Add(this.pnlCloseOut);
            this.Name = "frmCloseOut";
            this.Text = "frmCloseOut";
            this.pnlCloseOut.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCloseOut;
        private System.Windows.Forms.Button btnClosure;
        private System.Windows.Forms.ListBox lstInfo;
        private System.Windows.Forms.Button btnRev;
    }
}
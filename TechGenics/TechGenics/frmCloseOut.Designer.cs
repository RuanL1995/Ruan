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
            this.btnRev = new System.Windows.Forms.Button();
            this.btnClosure = new System.Windows.Forms.Button();
            this.lstInfo = new System.Windows.Forms.ListBox();
            this.pnlInstr = new System.Windows.Forms.Panel();
            this.btnViewCompletion = new System.Windows.Forms.Button();
            this.btnViewClosure = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lstInstr = new System.Windows.Forms.ListBox();
            this.btnThird = new System.Windows.Forms.Button();
            this.btnSec = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.lblCompletion = new System.Windows.Forms.Label();
            this.lblClosure = new System.Windows.Forms.Label();
            this.pnlCloseOut.SuspendLayout();
            this.pnlInstr.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCloseOut
            // 
            this.pnlCloseOut.Controls.Add(this.pnlInstr);
            this.pnlCloseOut.Controls.Add(this.btnRev);
            this.pnlCloseOut.Controls.Add(this.btnClosure);
            this.pnlCloseOut.Controls.Add(this.lstInfo);
            this.pnlCloseOut.Location = new System.Drawing.Point(22, 12);
            this.pnlCloseOut.Name = "pnlCloseOut";
            this.pnlCloseOut.Size = new System.Drawing.Size(823, 591);
            this.pnlCloseOut.TabIndex = 0;
            // 
            // btnRev
            // 
            this.btnRev.BackColor = System.Drawing.Color.Aquamarine;
            this.btnRev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRev.Location = new System.Drawing.Point(410, 509);
            this.btnRev.Name = "btnRev";
            this.btnRev.Size = new System.Drawing.Size(269, 32);
            this.btnRev.TabIndex = 2;
            this.btnRev.Text = "Review Project Completion";
            this.btnRev.UseVisualStyleBackColor = false;
            this.btnRev.Click += new System.EventHandler(this.btnRev_Click);
            this.btnRev.MouseHover += new System.EventHandler(this.btnRev_MouseHover);
            // 
            // btnClosure
            // 
            this.btnClosure.BackColor = System.Drawing.Color.Aquamarine;
            this.btnClosure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClosure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClosure.Location = new System.Drawing.Point(118, 509);
            this.btnClosure.Name = "btnClosure";
            this.btnClosure.Size = new System.Drawing.Size(269, 32);
            this.btnClosure.TabIndex = 1;
            this.btnClosure.Text = "Project Closure";
            this.btnClosure.UseVisualStyleBackColor = false;
            this.btnClosure.Click += new System.EventHandler(this.btnClosure_Click);
            this.btnClosure.MouseLeave += new System.EventHandler(this.btnClosure_MouseLeave);
            this.btnClosure.MouseHover += new System.EventHandler(this.btnClosure_MouseHover);
            // 
            // lstInfo
            // 
            this.lstInfo.BackColor = System.Drawing.Color.Black;
            this.lstInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstInfo.ForeColor = System.Drawing.SystemColors.Info;
            this.lstInfo.FormattingEnabled = true;
            this.lstInfo.Items.AddRange(new object[] {
            "Project Closure involves releasing the final deliverables to the customer, handin" +
                "g over project documentation",
            "terminating supplier contracts, releasing project resources and communicating the" +
                " closure of the project to all",
            "stakeholders. The last remaining step is to undertake a Post Implementation Revie" +
                "w to quantify the overall",
            "success of the project and list any lessons learnt for future projects."});
            this.lstInfo.Location = new System.Drawing.Point(24, 36);
            this.lstInfo.Name = "lstInfo";
            this.lstInfo.Size = new System.Drawing.Size(765, 429);
            this.lstInfo.TabIndex = 0;
            // 
            // pnlInstr
            // 
            this.pnlInstr.Controls.Add(this.btnViewCompletion);
            this.pnlInstr.Controls.Add(this.btnViewClosure);
            this.pnlInstr.Controls.Add(this.btnClose);
            this.pnlInstr.Controls.Add(this.lstInstr);
            this.pnlInstr.Controls.Add(this.btnThird);
            this.pnlInstr.Controls.Add(this.btnSec);
            this.pnlInstr.Controls.Add(this.btnFirst);
            this.pnlInstr.Controls.Add(this.lblCompletion);
            this.pnlInstr.Controls.Add(this.lblClosure);
            this.pnlInstr.Location = new System.Drawing.Point(2, 3);
            this.pnlInstr.Name = "pnlInstr";
            this.pnlInstr.Size = new System.Drawing.Size(835, 614);
            this.pnlInstr.TabIndex = 3;
            this.pnlInstr.Visible = false;
            this.pnlInstr.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlInstr_Paint);
            // 
            // btnViewCompletion
            // 
            this.btnViewCompletion.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnViewCompletion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewCompletion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewCompletion.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnViewCompletion.Location = new System.Drawing.Point(359, 527);
            this.btnViewCompletion.Name = "btnViewCompletion";
            this.btnViewCompletion.Size = new System.Drawing.Size(115, 27);
            this.btnViewCompletion.TabIndex = 16;
            this.btnViewCompletion.Text = "View Template";
            this.btnViewCompletion.UseVisualStyleBackColor = false;
            this.btnViewCompletion.Visible = false;
            this.btnViewCompletion.Click += new System.EventHandler(this.btnViewCompletion_Click);
            // 
            // btnViewClosure
            // 
            this.btnViewClosure.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnViewClosure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewClosure.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewClosure.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnViewClosure.Location = new System.Drawing.Point(359, 527);
            this.btnViewClosure.Name = "btnViewClosure";
            this.btnViewClosure.Size = new System.Drawing.Size(115, 27);
            this.btnViewClosure.TabIndex = 15;
            this.btnViewClosure.Text = "View Template";
            this.btnViewClosure.UseVisualStyleBackColor = false;
            this.btnViewClosure.Visible = false;
            this.btnViewClosure.Click += new System.EventHandler(this.btnViewClosure_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnClose.Location = new System.Drawing.Point(786, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(34, 21);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lstInstr
            // 
            this.lstInstr.BackColor = System.Drawing.SystemColors.Desktop;
            this.lstInstr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstInstr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstInstr.ForeColor = System.Drawing.Color.White;
            this.lstInstr.FormattingEnabled = true;
            this.lstInstr.ItemHeight = 16;
            this.lstInstr.Items.AddRange(new object[] {
            " "});
            this.lstInstr.Location = new System.Drawing.Point(187, 133);
            this.lstInstr.Name = "lstInstr";
            this.lstInstr.Size = new System.Drawing.Size(633, 352);
            this.lstInstr.TabIndex = 9;
            // 
            // btnThird
            // 
            this.btnThird.BackColor = System.Drawing.Color.Aquamarine;
            this.btnThird.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThird.CausesValidation = false;
            this.btnThird.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThird.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThird.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnThird.Location = new System.Drawing.Point(36, 344);
            this.btnThird.Name = "btnThird";
            this.btnThird.Size = new System.Drawing.Size(124, 64);
            this.btnThird.TabIndex = 8;
            this.btnThird.Text = " Undertake Closure Actions";
            this.btnThird.UseVisualStyleBackColor = false;
            this.btnThird.Visible = false;
            this.btnThird.Click += new System.EventHandler(this.btnThird_Click);
            // 
            // btnSec
            // 
            this.btnSec.BackColor = System.Drawing.Color.Aquamarine;
            this.btnSec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSec.CausesValidation = false;
            this.btnSec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSec.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSec.Location = new System.Drawing.Point(36, 261);
            this.btnSec.Name = "btnSec";
            this.btnSec.Size = new System.Drawing.Size(124, 64);
            this.btnSec.TabIndex = 7;
            this.btnSec.Text = " ";
            this.btnSec.UseVisualStyleBackColor = false;
            this.btnSec.Click += new System.EventHandler(this.btnSec_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.BackColor = System.Drawing.Color.Aquamarine;
            this.btnFirst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFirst.CausesValidation = false;
            this.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirst.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFirst.Location = new System.Drawing.Point(36, 179);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(124, 64);
            this.btnFirst.TabIndex = 6;
            this.btnFirst.Text = " ";
            this.btnFirst.UseVisualStyleBackColor = false;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // lblCompletion
            // 
            this.lblCompletion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCompletion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblCompletion.ForeColor = System.Drawing.Color.MintCream;
            this.lblCompletion.Location = new System.Drawing.Point(439, 48);
            this.lblCompletion.Name = "lblCompletion";
            this.lblCompletion.Size = new System.Drawing.Size(124, 65);
            this.lblCompletion.TabIndex = 1;
            this.lblCompletion.Text = "Review Project Completion";
            this.lblCompletion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCompletion.Click += new System.EventHandler(this.lblCompletion_Click);
            // 
            // lblClosure
            // 
            this.lblClosure.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblClosure.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblClosure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblClosure.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblClosure.ForeColor = System.Drawing.Color.MintCream;
            this.lblClosure.Location = new System.Drawing.Point(309, 48);
            this.lblClosure.Name = "lblClosure";
            this.lblClosure.Size = new System.Drawing.Size(124, 65);
            this.lblClosure.TabIndex = 0;
            this.lblClosure.Text = "Project Closure";
            this.lblClosure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblClosure.Click += new System.EventHandler(this.lblClosure_Click);
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
            this.Load += new System.EventHandler(this.frmCloseOut_Load);
            this.pnlCloseOut.ResumeLayout(false);
            this.pnlInstr.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCloseOut;
        private System.Windows.Forms.Button btnClosure;
        private System.Windows.Forms.ListBox lstInfo;
        private System.Windows.Forms.Button btnRev;
        private System.Windows.Forms.Panel pnlInstr;
        private System.Windows.Forms.Button btnViewClosure;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListBox lstInstr;
        private System.Windows.Forms.Button btnThird;
        private System.Windows.Forms.Button btnSec;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Label lblCompletion;
        private System.Windows.Forms.Label lblClosure;
        private System.Windows.Forms.Button btnViewCompletion;
    }
}
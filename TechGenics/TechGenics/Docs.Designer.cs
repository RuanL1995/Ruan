namespace TechGenics
{
    partial class Docs
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
            this.cmbTemplate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radExistingDoc = new System.Windows.Forms.RadioButton();
            this.radNewDoc = new System.Windows.Forms.RadioButton();
            this.lblDocTemplates = new System.Windows.Forms.Label();
            this.btnDocBack = new System.Windows.Forms.Button();
            this.pnlTemp = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.rgbClose = new System.Windows.Forms.RadioButton();
            this.rgbExecution = new System.Windows.Forms.RadioButton();
            this.rgbInitiation = new System.Windows.Forms.RadioButton();
            this.rgbPlanning = new System.Windows.Forms.RadioButton();
            this.btnOpen = new System.Windows.Forms.Button();
            this.pnlNew = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.cmbOpen = new System.Windows.Forms.ComboBox();
            this.rgbExcel = new System.Windows.Forms.RadioButton();
            this.rgbWord = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.pnlTemp.SuspendLayout();
            this.pnlNew.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbTemplate
            // 
            this.cmbTemplate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTemplate.FormattingEnabled = true;
            this.cmbTemplate.Location = new System.Drawing.Point(189, 159);
            this.cmbTemplate.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTemplate.Name = "cmbTemplate";
            this.cmbTemplate.Size = new System.Drawing.Size(239, 24);
            this.cmbTemplate.TabIndex = 5;
            this.cmbTemplate.Text = "--Please Select a Phase--";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(256, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 44);
            this.label1.TabIndex = 4;
            this.label1.Text = "Techgenics Word";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radExistingDoc);
            this.groupBox1.Controls.Add(this.radNewDoc);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(208, 119);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(465, 52);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create new document or open existing?";
            // 
            // radExistingDoc
            // 
            this.radExistingDoc.AutoSize = true;
            this.radExistingDoc.Location = new System.Drawing.Point(207, 18);
            this.radExistingDoc.Margin = new System.Windows.Forms.Padding(2);
            this.radExistingDoc.Name = "radExistingDoc";
            this.radExistingDoc.Size = new System.Drawing.Size(205, 22);
            this.radExistingDoc.TabIndex = 1;
            this.radExistingDoc.TabStop = true;
            this.radExistingDoc.Text = "Open an existing document";
            this.radExistingDoc.UseVisualStyleBackColor = true;
            this.radExistingDoc.CheckedChanged += new System.EventHandler(this.radExistingDoc_CheckedChanged);
            // 
            // radNewDoc
            // 
            this.radNewDoc.AutoSize = true;
            this.radNewDoc.Location = new System.Drawing.Point(8, 18);
            this.radNewDoc.Margin = new System.Windows.Forms.Padding(2);
            this.radNewDoc.Name = "radNewDoc";
            this.radNewDoc.Size = new System.Drawing.Size(171, 22);
            this.radNewDoc.TabIndex = 0;
            this.radNewDoc.TabStop = true;
            this.radNewDoc.Text = "Create new document";
            this.radNewDoc.UseVisualStyleBackColor = true;
            this.radNewDoc.CheckedChanged += new System.EventHandler(this.radNewDoc_CheckedChanged);
            // 
            // lblDocTemplates
            // 
            this.lblDocTemplates.AutoSize = true;
            this.lblDocTemplates.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocTemplates.Location = new System.Drawing.Point(15, 162);
            this.lblDocTemplates.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDocTemplates.Name = "lblDocTemplates";
            this.lblDocTemplates.Size = new System.Drawing.Size(164, 16);
            this.lblDocTemplates.TabIndex = 10;
            this.lblDocTemplates.Text = "Documents/Templates";
            // 
            // btnDocBack
            // 
            this.btnDocBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnDocBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDocBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocBack.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnDocBack.Location = new System.Drawing.Point(758, 580);
            this.btnDocBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnDocBack.Name = "btnDocBack";
            this.btnDocBack.Size = new System.Drawing.Size(54, 27);
            this.btnDocBack.TabIndex = 11;
            this.btnDocBack.Text = "Back";
            this.btnDocBack.UseVisualStyleBackColor = false;
            this.btnDocBack.Click += new System.EventHandler(this.btnDocBack_Click);
            // 
            // pnlTemp
            // 
            this.pnlTemp.Controls.Add(this.label4);
            this.pnlTemp.Controls.Add(this.rgbClose);
            this.pnlTemp.Controls.Add(this.rgbExecution);
            this.pnlTemp.Controls.Add(this.rgbInitiation);
            this.pnlTemp.Controls.Add(this.rgbPlanning);
            this.pnlTemp.Controls.Add(this.btnOpen);
            this.pnlTemp.Controls.Add(this.lblDocTemplates);
            this.pnlTemp.Controls.Add(this.cmbTemplate);
            this.pnlTemp.Location = new System.Drawing.Point(208, 231);
            this.pnlTemp.Name = "pnlTemp";
            this.pnlTemp.Size = new System.Drawing.Size(476, 255);
            this.pnlTemp.TabIndex = 12;
            this.pnlTemp.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(252, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Choose the phase you wish to view:";
            // 
            // rgbClose
            // 
            this.rgbClose.AutoSize = true;
            this.rgbClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rgbClose.Location = new System.Drawing.Point(207, 121);
            this.rgbClose.Margin = new System.Windows.Forms.Padding(2);
            this.rgbClose.Name = "rgbClose";
            this.rgbClose.Size = new System.Drawing.Size(84, 20);
            this.rgbClose.TabIndex = 15;
            this.rgbClose.TabStop = true;
            this.rgbClose.Text = "Close Out";
            this.rgbClose.UseVisualStyleBackColor = true;
            this.rgbClose.CheckedChanged += new System.EventHandler(this.rgbCloseOut_CheckedChanged);
            // 
            // rgbExecution
            // 
            this.rgbExecution.AutoSize = true;
            this.rgbExecution.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rgbExecution.Location = new System.Drawing.Point(73, 121);
            this.rgbExecution.Margin = new System.Windows.Forms.Padding(2);
            this.rgbExecution.Name = "rgbExecution";
            this.rgbExecution.Size = new System.Drawing.Size(84, 20);
            this.rgbExecution.TabIndex = 14;
            this.rgbExecution.TabStop = true;
            this.rgbExecution.Text = "Execution";
            this.rgbExecution.UseVisualStyleBackColor = true;
            this.rgbExecution.CheckedChanged += new System.EventHandler(this.rgbExecution_CheckedChanged);
            // 
            // rgbInitiation
            // 
            this.rgbInitiation.AutoSize = true;
            this.rgbInitiation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rgbInitiation.Location = new System.Drawing.Point(73, 62);
            this.rgbInitiation.Margin = new System.Windows.Forms.Padding(2);
            this.rgbInitiation.Name = "rgbInitiation";
            this.rgbInitiation.Size = new System.Drawing.Size(74, 20);
            this.rgbInitiation.TabIndex = 13;
            this.rgbInitiation.TabStop = true;
            this.rgbInitiation.Text = "Initiation";
            this.rgbInitiation.UseVisualStyleBackColor = true;
            this.rgbInitiation.CheckedChanged += new System.EventHandler(this.rgbInitiation_CheckedChanged);
            // 
            // rgbPlanning
            // 
            this.rgbPlanning.AutoSize = true;
            this.rgbPlanning.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rgbPlanning.Location = new System.Drawing.Point(207, 62);
            this.rgbPlanning.Margin = new System.Windows.Forms.Padding(2);
            this.rgbPlanning.Name = "rgbPlanning";
            this.rgbPlanning.Size = new System.Drawing.Size(78, 20);
            this.rgbPlanning.TabIndex = 12;
            this.rgbPlanning.TabStop = true;
            this.rgbPlanning.Text = "Planning";
            this.rgbPlanning.UseVisualStyleBackColor = true;
            this.rgbPlanning.CheckedChanged += new System.EventHandler(this.rgbPlanning_CheckedChanged);
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnOpen.Location = new System.Drawing.Point(146, 206);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(87, 28);
            this.btnOpen.TabIndex = 11;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // pnlNew
            // 
            this.pnlNew.Controls.Add(this.label3);
            this.pnlNew.Controls.Add(this.label2);
            this.pnlNew.Controls.Add(this.btnCreate);
            this.pnlNew.Controls.Add(this.cmbOpen);
            this.pnlNew.Controls.Add(this.rgbExcel);
            this.pnlNew.Controls.Add(this.rgbWord);
            this.pnlNew.Location = new System.Drawing.Point(211, 228);
            this.pnlNew.Name = "pnlNew";
            this.pnlNew.Size = new System.Drawing.Size(476, 255);
            this.pnlNew.TabIndex = 13;
            this.pnlNew.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(360, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Choose a phase to be associated with this file:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(108, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Choose a file to be created:";
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnCreate.Location = new System.Drawing.Point(166, 210);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(102, 33);
            this.btnCreate.TabIndex = 3;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // cmbOpen
            // 
            this.cmbOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOpen.FormattingEnabled = true;
            this.cmbOpen.Items.AddRange(new object[] {
            "Initiation",
            "Planning",
            "Execution",
            "CloseOut"});
            this.cmbOpen.Location = new System.Drawing.Point(134, 149);
            this.cmbOpen.Name = "cmbOpen";
            this.cmbOpen.Size = new System.Drawing.Size(150, 24);
            this.cmbOpen.TabIndex = 2;
            this.cmbOpen.Text = "Initiation ";
            // 
            // rgbExcel
            // 
            this.rgbExcel.AutoSize = true;
            this.rgbExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rgbExcel.Location = new System.Drawing.Point(225, 72);
            this.rgbExcel.Name = "rgbExcel";
            this.rgbExcel.Size = new System.Drawing.Size(59, 20);
            this.rgbExcel.TabIndex = 1;
            this.rgbExcel.TabStop = true;
            this.rgbExcel.Text = "Excel";
            this.rgbExcel.UseVisualStyleBackColor = true;
            // 
            // rgbWord
            // 
            this.rgbWord.AutoSize = true;
            this.rgbWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rgbWord.Location = new System.Drawing.Point(134, 72);
            this.rgbWord.Name = "rgbWord";
            this.rgbWord.Size = new System.Drawing.Size(59, 20);
            this.rgbWord.TabIndex = 0;
            this.rgbWord.TabStop = true;
            this.rgbWord.Text = "Word";
            this.rgbWord.UseVisualStyleBackColor = true;
            // 
            // Docs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 617);
            this.Controls.Add(this.pnlNew);
            this.Controls.Add(this.pnlTemp);
            this.Controls.Add(this.btnDocBack);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Docs";
            this.Text = "Docs";
            this.Load += new System.EventHandler(this.Docs_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlTemp.ResumeLayout(false);
            this.pnlTemp.PerformLayout();
            this.pnlNew.ResumeLayout(false);
            this.pnlNew.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbTemplate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radExistingDoc;
        private System.Windows.Forms.RadioButton radNewDoc;
        private System.Windows.Forms.Label lblDocTemplates;
        private System.Windows.Forms.Button btnDocBack;
        private System.Windows.Forms.Panel pnlTemp;
        private System.Windows.Forms.RadioButton rgbInitiation;
        private System.Windows.Forms.RadioButton rgbPlanning;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rgbClose;
        private System.Windows.Forms.RadioButton rgbExecution;
        private System.Windows.Forms.Panel pnlNew;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.ComboBox cmbOpen;
        private System.Windows.Forms.RadioButton rgbExcel;
        private System.Windows.Forms.RadioButton rgbWord;
    }
}
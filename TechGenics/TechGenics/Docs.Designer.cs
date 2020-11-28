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
            this.TextEditor = new System.Windows.Forms.RichTextBox();
            this.cmbTemplate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveDocToDB = new System.Windows.Forms.Button();
            this.AutoSave = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radExistingDoc = new System.Windows.Forms.RadioButton();
            this.radNewDoc = new System.Windows.Forms.RadioButton();
            this.lblDocTemplates = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextEditor
            // 
            this.TextEditor.Location = new System.Drawing.Point(12, 204);
            this.TextEditor.Name = "TextEditor";
            this.TextEditor.Size = new System.Drawing.Size(1069, 504);
            this.TextEditor.TabIndex = 3;
            this.TextEditor.Text = "";
            this.TextEditor.TextChanged += new System.EventHandler(this.AutosaveDoc_TextChanged);
            // 
            // cmbTemplate
            // 
            this.cmbTemplate.FormattingEnabled = true;
            this.cmbTemplate.Items.AddRange(new object[] {
            "Proposal",
            "Feasibility study",
            "Business Case"});
            this.cmbTemplate.Location = new System.Drawing.Point(566, 139);
            this.cmbTemplate.Name = "cmbTemplate";
            this.cmbTemplate.Size = new System.Drawing.Size(188, 24);
            this.cmbTemplate.TabIndex = 5;
            this.cmbTemplate.SelectedIndexChanged += new System.EventHandler(this.Template_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(341, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 55);
            this.label1.TabIndex = 4;
            this.label1.Text = "Techgenics Word";
            // 
            // btnSaveDocToDB
            // 
            this.btnSaveDocToDB.Location = new System.Drawing.Point(450, 714);
            this.btnSaveDocToDB.Name = "btnSaveDocToDB";
            this.btnSaveDocToDB.Size = new System.Drawing.Size(145, 33);
            this.btnSaveDocToDB.TabIndex = 6;
            this.btnSaveDocToDB.Text = "Save to Database";
            this.btnSaveDocToDB.UseVisualStyleBackColor = true;
            this.btnSaveDocToDB.Click += new System.EventHandler(this.btnSaveDocToDB_Click);
            // 
            // AutoSave
            // 
            this.AutoSave.AutoSize = true;
            this.AutoSave.Location = new System.Drawing.Point(101, 44);
            this.AutoSave.Name = "AutoSave";
            this.AutoSave.Size = new System.Drawing.Size(159, 21);
            this.AutoSave.TabIndex = 7;
            this.AutoSave.Text = "AutoSave Document";
            this.AutoSave.UseVisualStyleBackColor = true;
            this.AutoSave.CheckedChanged += new System.EventHandler(this.AutoSave_IsChecked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radExistingDoc);
            this.groupBox1.Controls.Add(this.radNewDoc);
            this.groupBox1.Location = new System.Drawing.Point(351, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 56);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create new document or open existing?";
            // 
            // radExistingDoc
            // 
            this.radExistingDoc.AutoSize = true;
            this.radExistingDoc.Location = new System.Drawing.Point(206, 22);
            this.radExistingDoc.Name = "radExistingDoc";
            this.radExistingDoc.Size = new System.Drawing.Size(201, 21);
            this.radExistingDoc.TabIndex = 1;
            this.radExistingDoc.TabStop = true;
            this.radExistingDoc.Text = "Open an existing document";
            this.radExistingDoc.UseVisualStyleBackColor = true;
            // 
            // radNewDoc
            // 
            this.radNewDoc.AutoSize = true;
            this.radNewDoc.Location = new System.Drawing.Point(10, 22);
            this.radNewDoc.Name = "radNewDoc";
            this.radNewDoc.Size = new System.Drawing.Size(166, 21);
            this.radNewDoc.TabIndex = 0;
            this.radNewDoc.TabStop = true;
            this.radNewDoc.Text = "Create new document";
            this.radNewDoc.UseVisualStyleBackColor = true;
            // 
            // lblDocTemplates
            // 
            this.lblDocTemplates.AutoSize = true;
            this.lblDocTemplates.Location = new System.Drawing.Point(411, 139);
            this.lblDocTemplates.Name = "lblDocTemplates";
            this.lblDocTemplates.Size = new System.Drawing.Size(149, 17);
            this.lblDocTemplates.TabIndex = 10;
            this.lblDocTemplates.Text = "Documents/Templates";
            // 
            // Docs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 759);
            this.Controls.Add(this.lblDocTemplates);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.AutoSave);
            this.Controls.Add(this.btnSaveDocToDB);
            this.Controls.Add(this.cmbTemplate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextEditor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Docs";
            this.Text = "Docs";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox TextEditor;
        private System.Windows.Forms.ComboBox cmbTemplate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaveDocToDB;
        private System.Windows.Forms.CheckBox AutoSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radExistingDoc;
        private System.Windows.Forms.RadioButton radNewDoc;
        private System.Windows.Forms.Label lblDocTemplates;
    }
}
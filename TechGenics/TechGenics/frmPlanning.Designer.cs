namespace TechGenics
{
    partial class frmPlanning
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPlanning));
            this.pnlPlanning = new System.Windows.Forms.Panel();
            this.btnPClose = new System.Windows.Forms.Button();
            this.lstInfo = new System.Windows.Forms.ListBox();
            this.btnPRev = new System.Windows.Forms.Button();
            this.btnProcPlan = new System.Windows.Forms.Button();
            this.btnRiskPlan = new System.Windows.Forms.Button();
            this.btnAccPlan = new System.Windows.Forms.Button();
            this.btnComPlan = new System.Windows.Forms.Button();
            this.btnQualPlan = new System.Windows.Forms.Button();
            this.btnFinPlan = new System.Windows.Forms.Button();
            this.btnResPlan = new System.Windows.Forms.Button();
            this.btnProjectPlan = new System.Windows.Forms.Button();
            this.pnlInstr = new System.Windows.Forms.Panel();
            this.btnViewProcPlan = new System.Windows.Forms.Button();
            this.btnViewPhaseRev = new System.Windows.Forms.Button();
            this.btnViewRiskPlan = new System.Windows.Forms.Button();
            this.btnViewAPlan = new System.Windows.Forms.Button();
            this.btnViewComPlan = new System.Windows.Forms.Button();
            this.btnViewQPlan = new System.Windows.Forms.Button();
            this.btnViewFinPlan = new System.Windows.Forms.Button();
            this.btnViewResPlan = new System.Windows.Forms.Button();
            this.btnViewProjectPlan = new System.Windows.Forms.Button();
            this.pnlSideMenu = new System.Windows.Forms.Panel();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnSec = new System.Windows.Forms.Button();
            this.btnThird = new System.Windows.Forms.Button();
            this.btnFourth = new System.Windows.Forms.Button();
            this.btnSixth = new System.Windows.Forms.Button();
            this.btnFifth = new System.Windows.Forms.Button();
            this.pboTender = new System.Windows.Forms.PictureBox();
            this.pnlHeading = new System.Windows.Forms.Panel();
            this.btnQPlan = new System.Windows.Forms.Button();
            this.btnProc = new System.Windows.Forms.Button();
            this.btnFPlan = new System.Windows.Forms.Button();
            this.btnPhase = new System.Windows.Forms.Button();
            this.btnCPlan = new System.Windows.Forms.Button();
            this.btnPPLan = new System.Windows.Forms.Button();
            this.btnAPlan = new System.Windows.Forms.Button();
            this.btnRisk = new System.Windows.Forms.Button();
            this.btnRPlan = new System.Windows.Forms.Button();
            this.btnHide = new System.Windows.Forms.Button();
            this.lstInstr = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlPlanning.SuspendLayout();
            this.pnlInstr.SuspendLayout();
            this.pnlSideMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboTender)).BeginInit();
            this.pnlHeading.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPlanning
            // 
            this.pnlPlanning.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlPlanning.Controls.Add(this.btnPClose);
            this.pnlPlanning.Controls.Add(this.lstInfo);
            this.pnlPlanning.Controls.Add(this.btnPRev);
            this.pnlPlanning.Controls.Add(this.btnProcPlan);
            this.pnlPlanning.Controls.Add(this.btnRiskPlan);
            this.pnlPlanning.Controls.Add(this.btnAccPlan);
            this.pnlPlanning.Controls.Add(this.btnComPlan);
            this.pnlPlanning.Controls.Add(this.btnQualPlan);
            this.pnlPlanning.Controls.Add(this.btnFinPlan);
            this.pnlPlanning.Controls.Add(this.btnResPlan);
            this.pnlPlanning.Controls.Add(this.btnProjectPlan);
            this.pnlPlanning.Location = new System.Drawing.Point(12, 16);
            this.pnlPlanning.Name = "pnlPlanning";
            this.pnlPlanning.Size = new System.Drawing.Size(823, 610);
            this.pnlPlanning.TabIndex = 0;
            // 
            // btnPClose
            // 
            this.btnPClose.BackColor = System.Drawing.Color.Black;
            this.btnPClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPClose.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnPClose.Location = new System.Drawing.Point(351, 573);
            this.btnPClose.Name = "btnPClose";
            this.btnPClose.Size = new System.Drawing.Size(140, 34);
            this.btnPClose.TabIndex = 29;
            this.btnPClose.Text = "Close";
            this.btnPClose.UseVisualStyleBackColor = false;
            this.btnPClose.Click += new System.EventHandler(this.btnPClose_Click);
            // 
            // lstInfo
            // 
            this.lstInfo.BackColor = System.Drawing.SystemColors.InfoText;
            this.lstInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstInfo.ForeColor = System.Drawing.Color.MintCream;
            this.lstInfo.FormattingEnabled = true;
            this.lstInfo.ItemHeight = 18;
            this.lstInfo.Items.AddRange(new object[] {
            "Once the scope of the project has been defined in the Project Charter, the projec" +
                "t enters the detailed ",
            "planning phase. This involves the creation of a:",
            "",
            " * Project Plan (outlining the activities, tasks, dependencies and timeframes)",
            " * Resource Plan (listing the labour, equipment and materials required)",
            " * Financial Plan (identifying the labour, equipment and materials costs)",
            " * Quality Plan (providing quality targets, assurance and control measures)",
            " * Risk Plan (highlighting potential risks and actions taken to mitigate them) ",
            " * Acceptance Plan (listing the criteria to be met to gain customer acceptance)",
            " * Communications Plan (listing the information needed to inform stakeholders)",
            " * Procurement Plan (identifying products to be sourced from external suppliers)"});
            this.lstInfo.Location = new System.Drawing.Point(38, 3);
            this.lstInfo.Name = "lstInfo";
            this.lstInfo.Size = new System.Drawing.Size(737, 198);
            this.lstInfo.TabIndex = 9;
            // 
            // btnPRev
            // 
            this.btnPRev.BackColor = System.Drawing.Color.Aquamarine;
            this.btnPRev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPRev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPRev.Location = new System.Drawing.Point(270, 231);
            this.btnPRev.Name = "btnPRev";
            this.btnPRev.Size = new System.Drawing.Size(330, 31);
            this.btnPRev.TabIndex = 8;
            this.btnPRev.Text = "Phase Review";
            this.btnPRev.UseVisualStyleBackColor = false;
            this.btnPRev.Click += new System.EventHandler(this.btnPRev_Click);
            this.btnPRev.MouseLeave += new System.EventHandler(this.btnPRev_MouseLeave);
            this.btnPRev.MouseHover += new System.EventHandler(this.btnPRev_MouseHover);
            // 
            // btnProcPlan
            // 
            this.btnProcPlan.BackColor = System.Drawing.Color.Aquamarine;
            this.btnProcPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcPlan.Location = new System.Drawing.Point(253, 265);
            this.btnProcPlan.Name = "btnProcPlan";
            this.btnProcPlan.Size = new System.Drawing.Size(360, 31);
            this.btnProcPlan.TabIndex = 7;
            this.btnProcPlan.Text = "Create a Procurement Plan";
            this.btnProcPlan.UseVisualStyleBackColor = false;
            this.btnProcPlan.Click += new System.EventHandler(this.btnProcPlan_Click);
            this.btnProcPlan.MouseLeave += new System.EventHandler(this.btnProcPlan_MouseLeave);
            this.btnProcPlan.MouseHover += new System.EventHandler(this.btnProcPlan_MouseHover);
            // 
            // btnRiskPlan
            // 
            this.btnRiskPlan.BackColor = System.Drawing.Color.Aquamarine;
            this.btnRiskPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRiskPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRiskPlan.Location = new System.Drawing.Point(232, 299);
            this.btnRiskPlan.Name = "btnRiskPlan";
            this.btnRiskPlan.Size = new System.Drawing.Size(408, 31);
            this.btnRiskPlan.TabIndex = 6;
            this.btnRiskPlan.Text = "Create a Risk Plan";
            this.btnRiskPlan.UseVisualStyleBackColor = false;
            this.btnRiskPlan.Click += new System.EventHandler(this.btnRiskPlan_Click);
            this.btnRiskPlan.MouseLeave += new System.EventHandler(this.btnRiskPlan_MouseLeave);
            this.btnRiskPlan.MouseHover += new System.EventHandler(this.btnRiskPlan_MouseHover);
            // 
            // btnAccPlan
            // 
            this.btnAccPlan.BackColor = System.Drawing.Color.Aquamarine;
            this.btnAccPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccPlan.Location = new System.Drawing.Point(207, 334);
            this.btnAccPlan.Name = "btnAccPlan";
            this.btnAccPlan.Size = new System.Drawing.Size(454, 31);
            this.btnAccPlan.TabIndex = 5;
            this.btnAccPlan.Text = "Create an Acceptance Plan";
            this.btnAccPlan.UseVisualStyleBackColor = false;
            this.btnAccPlan.Click += new System.EventHandler(this.btnAccPlan_Click);
            this.btnAccPlan.MouseLeave += new System.EventHandler(this.btnAccPlan_MouseLeave);
            this.btnAccPlan.MouseHover += new System.EventHandler(this.btnAccPlan_MouseHover);
            // 
            // btnComPlan
            // 
            this.btnComPlan.BackColor = System.Drawing.Color.Aquamarine;
            this.btnComPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComPlan.Location = new System.Drawing.Point(176, 369);
            this.btnComPlan.Name = "btnComPlan";
            this.btnComPlan.Size = new System.Drawing.Size(506, 31);
            this.btnComPlan.TabIndex = 4;
            this.btnComPlan.Text = "Create a Communications Plan";
            this.btnComPlan.UseVisualStyleBackColor = false;
            this.btnComPlan.Click += new System.EventHandler(this.btnComPlan_Click);
            this.btnComPlan.MouseLeave += new System.EventHandler(this.btnComPlan_MouseLeave);
            this.btnComPlan.MouseHover += new System.EventHandler(this.btnComPlan_MouseHover);
            // 
            // btnQualPlan
            // 
            this.btnQualPlan.BackColor = System.Drawing.Color.Aquamarine;
            this.btnQualPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQualPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQualPlan.Location = new System.Drawing.Point(144, 404);
            this.btnQualPlan.Name = "btnQualPlan";
            this.btnQualPlan.Size = new System.Drawing.Size(552, 31);
            this.btnQualPlan.TabIndex = 3;
            this.btnQualPlan.Text = "Create a Quality Plan";
            this.btnQualPlan.UseVisualStyleBackColor = false;
            this.btnQualPlan.Click += new System.EventHandler(this.btnQualPlan_Click);
            this.btnQualPlan.MouseLeave += new System.EventHandler(this.btnQualPlan_MouseLeave);
            this.btnQualPlan.MouseHover += new System.EventHandler(this.btnQualPlan_MouseHover);
            // 
            // btnFinPlan
            // 
            this.btnFinPlan.BackColor = System.Drawing.Color.Aquamarine;
            this.btnFinPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinPlan.Location = new System.Drawing.Point(117, 439);
            this.btnFinPlan.Name = "btnFinPlan";
            this.btnFinPlan.Size = new System.Drawing.Size(606, 31);
            this.btnFinPlan.TabIndex = 2;
            this.btnFinPlan.Text = "Create a Financial Plan";
            this.btnFinPlan.UseVisualStyleBackColor = false;
            this.btnFinPlan.Click += new System.EventHandler(this.btnFinPlan_Click);
            this.btnFinPlan.MouseLeave += new System.EventHandler(this.btnFinPlan_MouseLeave);
            this.btnFinPlan.MouseHover += new System.EventHandler(this.btnFinPlan_MouseHover);
            // 
            // btnResPlan
            // 
            this.btnResPlan.BackColor = System.Drawing.Color.Aquamarine;
            this.btnResPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResPlan.Location = new System.Drawing.Point(82, 474);
            this.btnResPlan.Name = "btnResPlan";
            this.btnResPlan.Size = new System.Drawing.Size(664, 31);
            this.btnResPlan.TabIndex = 1;
            this.btnResPlan.Text = "Create a Resource Plan";
            this.btnResPlan.UseVisualStyleBackColor = false;
            this.btnResPlan.Click += new System.EventHandler(this.btnResPlan_Click);
            this.btnResPlan.MouseLeave += new System.EventHandler(this.btnResPlan_MouseLeave);
            this.btnResPlan.MouseHover += new System.EventHandler(this.btnResPlan_MouseHover);
            // 
            // btnProjectPlan
            // 
            this.btnProjectPlan.BackColor = System.Drawing.Color.Aquamarine;
            this.btnProjectPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProjectPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProjectPlan.Location = new System.Drawing.Point(53, 509);
            this.btnProjectPlan.Name = "btnProjectPlan";
            this.btnProjectPlan.Size = new System.Drawing.Size(713, 31);
            this.btnProjectPlan.TabIndex = 0;
            this.btnProjectPlan.Text = "Create a Project Plan";
            this.btnProjectPlan.UseVisualStyleBackColor = false;
            this.btnProjectPlan.Click += new System.EventHandler(this.btnProjectPlan_Click);
            this.btnProjectPlan.MouseLeave += new System.EventHandler(this.btnProjectPlan_MouseLeave);
            this.btnProjectPlan.MouseHover += new System.EventHandler(this.btnProjectPlan_MouseHover);
            // 
            // pnlInstr
            // 
            this.pnlInstr.Controls.Add(this.btnViewProcPlan);
            this.pnlInstr.Controls.Add(this.btnViewPhaseRev);
            this.pnlInstr.Controls.Add(this.btnViewRiskPlan);
            this.pnlInstr.Controls.Add(this.btnViewAPlan);
            this.pnlInstr.Controls.Add(this.btnViewComPlan);
            this.pnlInstr.Controls.Add(this.btnViewQPlan);
            this.pnlInstr.Controls.Add(this.btnViewFinPlan);
            this.pnlInstr.Controls.Add(this.btnViewResPlan);
            this.pnlInstr.Controls.Add(this.btnViewProjectPlan);
            this.pnlInstr.Controls.Add(this.pnlSideMenu);
            this.pnlInstr.Controls.Add(this.pboTender);
            this.pnlInstr.Controls.Add(this.pnlHeading);
            this.pnlInstr.Controls.Add(this.btnHide);
            this.pnlInstr.Controls.Add(this.lstInstr);
            this.pnlInstr.Location = new System.Drawing.Point(12, 16);
            this.pnlInstr.Name = "pnlInstr";
            this.pnlInstr.Size = new System.Drawing.Size(847, 600);
            this.pnlInstr.TabIndex = 1;
            this.pnlInstr.Visible = false;
            // 
            // btnViewProcPlan
            // 
            this.btnViewProcPlan.BackColor = System.Drawing.Color.Black;
            this.btnViewProcPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewProcPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewProcPlan.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnViewProcPlan.Location = new System.Drawing.Point(403, 561);
            this.btnViewProcPlan.Name = "btnViewProcPlan";
            this.btnViewProcPlan.Size = new System.Drawing.Size(140, 34);
            this.btnViewProcPlan.TabIndex = 28;
            this.btnViewProcPlan.Text = "View Template";
            this.btnViewProcPlan.UseVisualStyleBackColor = false;
            this.btnViewProcPlan.Visible = false;
            this.btnViewProcPlan.Click += new System.EventHandler(this.btnViewProcPlan_Click);
            // 
            // btnViewPhaseRev
            // 
            this.btnViewPhaseRev.BackColor = System.Drawing.Color.Black;
            this.btnViewPhaseRev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewPhaseRev.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewPhaseRev.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnViewPhaseRev.Location = new System.Drawing.Point(403, 561);
            this.btnViewPhaseRev.Name = "btnViewPhaseRev";
            this.btnViewPhaseRev.Size = new System.Drawing.Size(140, 34);
            this.btnViewPhaseRev.TabIndex = 27;
            this.btnViewPhaseRev.Text = "View Template";
            this.btnViewPhaseRev.UseVisualStyleBackColor = false;
            this.btnViewPhaseRev.Visible = false;
            this.btnViewPhaseRev.Click += new System.EventHandler(this.btnViewPhaseRev_Click);
            // 
            // btnViewRiskPlan
            // 
            this.btnViewRiskPlan.BackColor = System.Drawing.Color.Black;
            this.btnViewRiskPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewRiskPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewRiskPlan.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnViewRiskPlan.Location = new System.Drawing.Point(403, 561);
            this.btnViewRiskPlan.Name = "btnViewRiskPlan";
            this.btnViewRiskPlan.Size = new System.Drawing.Size(140, 34);
            this.btnViewRiskPlan.TabIndex = 26;
            this.btnViewRiskPlan.Text = "View Template";
            this.btnViewRiskPlan.UseVisualStyleBackColor = false;
            this.btnViewRiskPlan.Visible = false;
            this.btnViewRiskPlan.Click += new System.EventHandler(this.btnViewRiskPlan_Click);
            // 
            // btnViewAPlan
            // 
            this.btnViewAPlan.BackColor = System.Drawing.Color.Black;
            this.btnViewAPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewAPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAPlan.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnViewAPlan.Location = new System.Drawing.Point(403, 561);
            this.btnViewAPlan.Name = "btnViewAPlan";
            this.btnViewAPlan.Size = new System.Drawing.Size(140, 34);
            this.btnViewAPlan.TabIndex = 25;
            this.btnViewAPlan.Text = "View Template";
            this.btnViewAPlan.UseVisualStyleBackColor = false;
            this.btnViewAPlan.Visible = false;
            this.btnViewAPlan.Click += new System.EventHandler(this.btnViewAPlan_Click);
            // 
            // btnViewComPlan
            // 
            this.btnViewComPlan.BackColor = System.Drawing.Color.Black;
            this.btnViewComPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewComPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewComPlan.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnViewComPlan.Location = new System.Drawing.Point(403, 561);
            this.btnViewComPlan.Name = "btnViewComPlan";
            this.btnViewComPlan.Size = new System.Drawing.Size(140, 34);
            this.btnViewComPlan.TabIndex = 24;
            this.btnViewComPlan.Text = "View Template";
            this.btnViewComPlan.UseVisualStyleBackColor = false;
            this.btnViewComPlan.Visible = false;
            this.btnViewComPlan.Click += new System.EventHandler(this.btnViewComPlan_Click);
            // 
            // btnViewQPlan
            // 
            this.btnViewQPlan.BackColor = System.Drawing.Color.Black;
            this.btnViewQPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewQPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewQPlan.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnViewQPlan.Location = new System.Drawing.Point(403, 561);
            this.btnViewQPlan.Name = "btnViewQPlan";
            this.btnViewQPlan.Size = new System.Drawing.Size(140, 34);
            this.btnViewQPlan.TabIndex = 23;
            this.btnViewQPlan.Text = "View Template";
            this.btnViewQPlan.UseVisualStyleBackColor = false;
            this.btnViewQPlan.Visible = false;
            this.btnViewQPlan.Click += new System.EventHandler(this.btnViewQPlan_Click);
            // 
            // btnViewFinPlan
            // 
            this.btnViewFinPlan.BackColor = System.Drawing.Color.Black;
            this.btnViewFinPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewFinPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewFinPlan.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnViewFinPlan.Location = new System.Drawing.Point(403, 561);
            this.btnViewFinPlan.Name = "btnViewFinPlan";
            this.btnViewFinPlan.Size = new System.Drawing.Size(140, 34);
            this.btnViewFinPlan.TabIndex = 22;
            this.btnViewFinPlan.Text = "View Template";
            this.btnViewFinPlan.UseVisualStyleBackColor = false;
            this.btnViewFinPlan.Visible = false;
            this.btnViewFinPlan.Click += new System.EventHandler(this.btnViewFinPlan_Click);
            // 
            // btnViewResPlan
            // 
            this.btnViewResPlan.BackColor = System.Drawing.Color.Black;
            this.btnViewResPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewResPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewResPlan.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnViewResPlan.Location = new System.Drawing.Point(403, 561);
            this.btnViewResPlan.Name = "btnViewResPlan";
            this.btnViewResPlan.Size = new System.Drawing.Size(140, 34);
            this.btnViewResPlan.TabIndex = 21;
            this.btnViewResPlan.Text = "View Template";
            this.btnViewResPlan.UseVisualStyleBackColor = false;
            this.btnViewResPlan.Visible = false;
            this.btnViewResPlan.Click += new System.EventHandler(this.btnViewResPlan_Click);
            // 
            // btnViewProjectPlan
            // 
            this.btnViewProjectPlan.BackColor = System.Drawing.Color.Black;
            this.btnViewProjectPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewProjectPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewProjectPlan.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnViewProjectPlan.Location = new System.Drawing.Point(403, 561);
            this.btnViewProjectPlan.Name = "btnViewProjectPlan";
            this.btnViewProjectPlan.Size = new System.Drawing.Size(140, 34);
            this.btnViewProjectPlan.TabIndex = 20;
            this.btnViewProjectPlan.Text = "View Template";
            this.btnViewProjectPlan.UseVisualStyleBackColor = false;
            this.btnViewProjectPlan.Visible = false;
            this.btnViewProjectPlan.Click += new System.EventHandler(this.btnViewProjectPlan_Click);
            // 
            // pnlSideMenu
            // 
            this.pnlSideMenu.AutoScroll = true;
            this.pnlSideMenu.Controls.Add(this.btnFirst);
            this.pnlSideMenu.Controls.Add(this.btnSec);
            this.pnlSideMenu.Controls.Add(this.btnThird);
            this.pnlSideMenu.Controls.Add(this.btnFourth);
            this.pnlSideMenu.Controls.Add(this.btnSixth);
            this.pnlSideMenu.Controls.Add(this.btnFifth);
            this.pnlSideMenu.Location = new System.Drawing.Point(14, 125);
            this.pnlSideMenu.Name = "pnlSideMenu";
            this.pnlSideMenu.Size = new System.Drawing.Size(165, 472);
            this.pnlSideMenu.TabIndex = 18;
            // 
            // btnFirst
            // 
            this.btnFirst.BackColor = System.Drawing.Color.Aquamarine;
            this.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirst.Location = new System.Drawing.Point(14, 3);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(124, 64);
            this.btnFirst.TabIndex = 9;
            this.btnFirst.UseVisualStyleBackColor = false;
            this.btnFirst.Visible = false;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnSec
            // 
            this.btnSec.BackColor = System.Drawing.Color.Aquamarine;
            this.btnSec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSec.Location = new System.Drawing.Point(14, 73);
            this.btnSec.Name = "btnSec";
            this.btnSec.Size = new System.Drawing.Size(124, 64);
            this.btnSec.TabIndex = 10;
            this.btnSec.UseVisualStyleBackColor = false;
            this.btnSec.Visible = false;
            this.btnSec.Click += new System.EventHandler(this.btnSec_Click);
            // 
            // btnThird
            // 
            this.btnThird.BackColor = System.Drawing.Color.Aquamarine;
            this.btnThird.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThird.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThird.Location = new System.Drawing.Point(14, 143);
            this.btnThird.Name = "btnThird";
            this.btnThird.Size = new System.Drawing.Size(124, 64);
            this.btnThird.TabIndex = 11;
            this.btnThird.UseVisualStyleBackColor = false;
            this.btnThird.Visible = false;
            this.btnThird.Click += new System.EventHandler(this.btnThird_Click);
            // 
            // btnFourth
            // 
            this.btnFourth.BackColor = System.Drawing.Color.Aquamarine;
            this.btnFourth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFourth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFourth.Location = new System.Drawing.Point(14, 213);
            this.btnFourth.Name = "btnFourth";
            this.btnFourth.Size = new System.Drawing.Size(124, 64);
            this.btnFourth.TabIndex = 12;
            this.btnFourth.UseVisualStyleBackColor = false;
            this.btnFourth.Visible = false;
            this.btnFourth.Click += new System.EventHandler(this.btnFourth_Click);
            // 
            // btnSixth
            // 
            this.btnSixth.BackColor = System.Drawing.Color.Aquamarine;
            this.btnSixth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSixth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSixth.Location = new System.Drawing.Point(16, 355);
            this.btnSixth.Name = "btnSixth";
            this.btnSixth.Size = new System.Drawing.Size(124, 64);
            this.btnSixth.TabIndex = 14;
            this.btnSixth.UseVisualStyleBackColor = false;
            this.btnSixth.Visible = false;
            this.btnSixth.Click += new System.EventHandler(this.btnSixth_Click);
            // 
            // btnFifth
            // 
            this.btnFifth.BackColor = System.Drawing.Color.Aquamarine;
            this.btnFifth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFifth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFifth.Location = new System.Drawing.Point(14, 283);
            this.btnFifth.Name = "btnFifth";
            this.btnFifth.Size = new System.Drawing.Size(124, 64);
            this.btnFifth.TabIndex = 13;
            this.btnFifth.UseVisualStyleBackColor = false;
            this.btnFifth.Visible = false;
            this.btnFifth.Click += new System.EventHandler(this.btnFifth_Click);
            // 
            // pboTender
            // 
            this.pboTender.Image = ((System.Drawing.Image)(resources.GetObject("pboTender.Image")));
            this.pboTender.Location = new System.Drawing.Point(212, 128);
            this.pboTender.Name = "pboTender";
            this.pboTender.Size = new System.Drawing.Size(545, 419);
            this.pboTender.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboTender.TabIndex = 19;
            this.pboTender.TabStop = false;
            this.pboTender.Visible = false;
            // 
            // pnlHeading
            // 
            this.pnlHeading.AutoScroll = true;
            this.pnlHeading.Controls.Add(this.btnQPlan);
            this.pnlHeading.Controls.Add(this.btnProc);
            this.pnlHeading.Controls.Add(this.btnFPlan);
            this.pnlHeading.Controls.Add(this.btnPhase);
            this.pnlHeading.Controls.Add(this.btnCPlan);
            this.pnlHeading.Controls.Add(this.btnPPLan);
            this.pnlHeading.Controls.Add(this.btnAPlan);
            this.pnlHeading.Controls.Add(this.btnRisk);
            this.pnlHeading.Controls.Add(this.btnRPlan);
            this.pnlHeading.Location = new System.Drawing.Point(3, 3);
            this.pnlHeading.Name = "pnlHeading";
            this.pnlHeading.Size = new System.Drawing.Size(800, 100);
            this.pnlHeading.TabIndex = 17;
            // 
            // btnQPlan
            // 
            this.btnQPlan.BackColor = System.Drawing.Color.Black;
            this.btnQPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQPlan.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnQPlan.Location = new System.Drawing.Point(471, 3);
            this.btnQPlan.Name = "btnQPlan";
            this.btnQPlan.Size = new System.Drawing.Size(154, 65);
            this.btnQPlan.TabIndex = 3;
            this.btnQPlan.Text = "Create a Quality Plan";
            this.btnQPlan.UseVisualStyleBackColor = false;
            this.btnQPlan.Click += new System.EventHandler(this.btnQPlan_Click);
            // 
            // btnProc
            // 
            this.btnProc.BackColor = System.Drawing.Color.Black;
            this.btnProc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProc.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnProc.Location = new System.Drawing.Point(1251, 3);
            this.btnProc.Name = "btnProc";
            this.btnProc.Size = new System.Drawing.Size(154, 65);
            this.btnProc.TabIndex = 7;
            this.btnProc.Text = "Create a Procurement Plan";
            this.btnProc.UseVisualStyleBackColor = false;
            this.btnProc.Click += new System.EventHandler(this.btnProc_Click);
            // 
            // btnFPlan
            // 
            this.btnFPlan.BackColor = System.Drawing.Color.Black;
            this.btnFPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFPlan.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnFPlan.Location = new System.Drawing.Point(315, 3);
            this.btnFPlan.Name = "btnFPlan";
            this.btnFPlan.Size = new System.Drawing.Size(154, 65);
            this.btnFPlan.TabIndex = 2;
            this.btnFPlan.Text = "Create a Financial Plan";
            this.btnFPlan.UseVisualStyleBackColor = false;
            this.btnFPlan.Click += new System.EventHandler(this.btnFPlan_Click);
            // 
            // btnPhase
            // 
            this.btnPhase.BackColor = System.Drawing.Color.Black;
            this.btnPhase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhase.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhase.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnPhase.Location = new System.Drawing.Point(1095, 3);
            this.btnPhase.Name = "btnPhase";
            this.btnPhase.Size = new System.Drawing.Size(154, 65);
            this.btnPhase.TabIndex = 8;
            this.btnPhase.Text = "Conduct Phase Review";
            this.btnPhase.UseVisualStyleBackColor = false;
            this.btnPhase.Click += new System.EventHandler(this.btnPhase_Click);
            // 
            // btnCPlan
            // 
            this.btnCPlan.BackColor = System.Drawing.Color.Black;
            this.btnCPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCPlan.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCPlan.Location = new System.Drawing.Point(627, 3);
            this.btnCPlan.Name = "btnCPlan";
            this.btnCPlan.Size = new System.Drawing.Size(154, 65);
            this.btnCPlan.TabIndex = 4;
            this.btnCPlan.Text = "Create a Communications Plan";
            this.btnCPlan.UseVisualStyleBackColor = false;
            this.btnCPlan.Click += new System.EventHandler(this.btnCPlan_Click);
            // 
            // btnPPLan
            // 
            this.btnPPLan.BackColor = System.Drawing.Color.Black;
            this.btnPPLan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPPLan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPPLan.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnPPLan.Location = new System.Drawing.Point(3, 3);
            this.btnPPLan.Name = "btnPPLan";
            this.btnPPLan.Size = new System.Drawing.Size(154, 65);
            this.btnPPLan.TabIndex = 0;
            this.btnPPLan.Text = "Create a Project Plan";
            this.btnPPLan.UseVisualStyleBackColor = false;
            this.btnPPLan.Click += new System.EventHandler(this.btnPPLan_Click);
            // 
            // btnAPlan
            // 
            this.btnAPlan.BackColor = System.Drawing.Color.Black;
            this.btnAPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAPlan.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAPlan.Location = new System.Drawing.Point(783, 3);
            this.btnAPlan.Name = "btnAPlan";
            this.btnAPlan.Size = new System.Drawing.Size(154, 65);
            this.btnAPlan.TabIndex = 5;
            this.btnAPlan.Text = "Create an Acceptance Plan";
            this.btnAPlan.UseVisualStyleBackColor = false;
            this.btnAPlan.Click += new System.EventHandler(this.btnAPlan_Click);
            // 
            // btnRisk
            // 
            this.btnRisk.BackColor = System.Drawing.Color.Black;
            this.btnRisk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRisk.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRisk.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnRisk.Location = new System.Drawing.Point(939, 3);
            this.btnRisk.Name = "btnRisk";
            this.btnRisk.Size = new System.Drawing.Size(154, 65);
            this.btnRisk.TabIndex = 6;
            this.btnRisk.Text = "Create a Risk Plan";
            this.btnRisk.UseVisualStyleBackColor = false;
            this.btnRisk.Click += new System.EventHandler(this.btnRisk_Click);
            // 
            // btnRPlan
            // 
            this.btnRPlan.BackColor = System.Drawing.Color.Black;
            this.btnRPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRPlan.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnRPlan.Location = new System.Drawing.Point(159, 3);
            this.btnRPlan.Name = "btnRPlan";
            this.btnRPlan.Size = new System.Drawing.Size(154, 65);
            this.btnRPlan.TabIndex = 1;
            this.btnRPlan.Text = "Create a Resource Plan";
            this.btnRPlan.UseVisualStyleBackColor = false;
            this.btnRPlan.Click += new System.EventHandler(this.btnRPlan_Click);
            // 
            // btnHide
            // 
            this.btnHide.BackColor = System.Drawing.Color.Black;
            this.btnHide.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHide.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHide.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnHide.Location = new System.Drawing.Point(800, 3);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(36, 23);
            this.btnHide.TabIndex = 16;
            this.btnHide.Text = "X";
            this.btnHide.UseVisualStyleBackColor = false;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // lstInstr
            // 
            this.lstInstr.BackColor = System.Drawing.SystemColors.ControlText;
            this.lstInstr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstInstr.ForeColor = System.Drawing.Color.MintCream;
            this.lstInstr.FormattingEnabled = true;
            this.lstInstr.Location = new System.Drawing.Point(212, 153);
            this.lstInstr.Name = "lstInstr";
            this.lstInstr.Size = new System.Drawing.Size(549, 390);
            this.lstInstr.TabIndex = 15;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmPlanning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(871, 628);
            this.Controls.Add(this.pnlInstr);
            this.Controls.Add(this.pnlPlanning);
            this.Name = "frmPlanning";
            this.Text = "frmPlanning";
            this.Load += new System.EventHandler(this.frmPlanning_Load);
            this.pnlPlanning.ResumeLayout(false);
            this.pnlInstr.ResumeLayout(false);
            this.pnlSideMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboTender)).EndInit();
            this.pnlHeading.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPlanning;
        private System.Windows.Forms.Button btnProjectPlan;
        private System.Windows.Forms.Button btnAccPlan;
        private System.Windows.Forms.Button btnComPlan;
        private System.Windows.Forms.Button btnQualPlan;
        private System.Windows.Forms.Button btnFinPlan;
        private System.Windows.Forms.Button btnResPlan;
        private System.Windows.Forms.ListBox lstInfo;
        private System.Windows.Forms.Button btnPRev;
        private System.Windows.Forms.Button btnProcPlan;
        private System.Windows.Forms.Button btnRiskPlan;
        private System.Windows.Forms.Panel pnlInstr;
        private System.Windows.Forms.Button btnPPLan;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPhase;
        private System.Windows.Forms.Button btnProc;
        private System.Windows.Forms.Button btnRisk;
        private System.Windows.Forms.Button btnAPlan;
        private System.Windows.Forms.Button btnCPlan;
        private System.Windows.Forms.Button btnQPlan;
        private System.Windows.Forms.Button btnFPlan;
        private System.Windows.Forms.Button btnRPlan;
        private System.Windows.Forms.Button btnSixth;
        private System.Windows.Forms.Button btnFifth;
        private System.Windows.Forms.Button btnFourth;
        private System.Windows.Forms.Button btnThird;
        private System.Windows.Forms.Button btnSec;
        private System.Windows.Forms.ListBox lstInstr;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Panel pnlSideMenu;
        private System.Windows.Forms.Panel pnlHeading;
        private System.Windows.Forms.PictureBox pboTender;
        private System.Windows.Forms.Button btnViewProjectPlan;
        private System.Windows.Forms.Button btnViewResPlan;
        private System.Windows.Forms.Button btnViewFinPlan;
        private System.Windows.Forms.Button btnViewQPlan;
        private System.Windows.Forms.Button btnViewComPlan;
        private System.Windows.Forms.Button btnViewAPlan;
        private System.Windows.Forms.Button btnViewRiskPlan;
        private System.Windows.Forms.Button btnViewPhaseRev;
        private System.Windows.Forms.Button btnViewProcPlan;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnPClose;
    }
}
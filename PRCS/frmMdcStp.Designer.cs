namespace PRCS
{
    partial class frmMdcStp
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
            System.Windows.Forms.Label lebFormHead;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMdcStp));
            System.Windows.Forms.Label lebFlag;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmdExit = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.CmdAddNew = new System.Windows.Forms.Button();
            this.CmdMDelete = new System.Windows.Forms.Button();
            this.CmdMSave = new System.Windows.Forms.Button();
            this.cboSl = new System.Windows.Forms.ComboBox();
            this.GridMStp = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMStp = new System.Windows.Forms.TextBox();
            this.CboCase = new System.Windows.Forms.ComboBox();
            this.lblMgs = new System.Windows.Forms.Label();
            this.PicSave = new System.Windows.Forms.PictureBox();
            this.txtRmk = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPrs = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.CmdPrs = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTRmk = new System.Windows.Forms.TextBox();
            this.CboProb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTstame = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.GridTest = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.CmdTAdd = new System.Windows.Forms.Button();
            this.CmdTDel = new System.Windows.Forms.Button();
            this.CmdTSave = new System.Windows.Forms.Button();
            this.CboTSl = new System.Windows.Forms.ComboBox();
            lebFormHead = new System.Windows.Forms.Label();
            lebFlag = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridMStp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridTest)).BeginInit();
            this.SuspendLayout();
            // 
            // lebFormHead
            // 
            lebFormHead.BackColor = System.Drawing.Color.Green;
            lebFormHead.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lebFormHead.Dock = System.Windows.Forms.DockStyle.Top;
            lebFormHead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            lebFormHead.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lebFormHead.ForeColor = System.Drawing.Color.White;
            lebFormHead.Image = ((System.Drawing.Image)(resources.GetObject("lebFormHead.Image")));
            lebFormHead.Location = new System.Drawing.Point(0, 0);
            lebFormHead.Name = "lebFormHead";
            lebFormHead.Size = new System.Drawing.Size(817, 30);
            lebFormHead.TabIndex = 98;
            lebFormHead.Text = "*** MEDECINE SETUP ***";
            lebFormHead.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lebFlag
            // 
            lebFlag.BackColor = System.Drawing.Color.Green;
            lebFlag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lebFlag.Dock = System.Windows.Forms.DockStyle.Top;
            lebFlag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            lebFlag.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lebFlag.ForeColor = System.Drawing.Color.Black;
            lebFlag.Image = ((System.Drawing.Image)(resources.GetObject("lebFlag.Image")));
            lebFlag.Location = new System.Drawing.Point(0, 30);
            lebFlag.Name = "lebFlag";
            lebFlag.Size = new System.Drawing.Size(817, 8);
            lebFlag.TabIndex = 103;
            lebFlag.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmdExit
            // 
            this.cmdExit.BackColor = System.Drawing.Color.Transparent;
            this.cmdExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdExit.BackgroundImage")));
            this.cmdExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cmdExit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExit.Location = new System.Drawing.Point(781, 1);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(29, 26);
            this.cmdExit.TabIndex = 191;
            this.cmdExit.UseVisualStyleBackColor = false;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(43, 103);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(34, 13);
            this.label22.TabIndex = 199;
            this.label22.Text = "SL No";
            // 
            // CmdAddNew
            // 
            this.CmdAddNew.BackColor = System.Drawing.Color.Transparent;
            this.CmdAddNew.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdAddNew.Image = ((System.Drawing.Image)(resources.GetObject("CmdAddNew.Image")));
            this.CmdAddNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CmdAddNew.Location = new System.Drawing.Point(186, 93);
            this.CmdAddNew.Name = "CmdAddNew";
            this.CmdAddNew.Size = new System.Drawing.Size(78, 24);
            this.CmdAddNew.TabIndex = 194;
            this.CmdAddNew.Text = "Add New";
            this.CmdAddNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CmdAddNew.UseVisualStyleBackColor = false;
            this.CmdAddNew.Click += new System.EventHandler(this.CmdAddNew_Click);
            // 
            // CmdMDelete
            // 
            this.CmdMDelete.BackColor = System.Drawing.Color.Transparent;
            this.CmdMDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CmdMDelete.BackgroundImage")));
            this.CmdMDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CmdMDelete.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdMDelete.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CmdMDelete.Location = new System.Drawing.Point(139, 214);
            this.CmdMDelete.Name = "CmdMDelete";
            this.CmdMDelete.Size = new System.Drawing.Size(71, 25);
            this.CmdMDelete.TabIndex = 5;
            this.CmdMDelete.Text = "DELETE";
            this.CmdMDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CmdMDelete.UseVisualStyleBackColor = false;
            this.CmdMDelete.Click += new System.EventHandler(this.CmdMDelete_Click);
            // 
            // CmdMSave
            // 
            this.CmdMSave.BackColor = System.Drawing.Color.Transparent;
            this.CmdMSave.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdMSave.Image = ((System.Drawing.Image)(resources.GetObject("CmdMSave.Image")));
            this.CmdMSave.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.CmdMSave.Location = new System.Drawing.Point(72, 214);
            this.CmdMSave.Name = "CmdMSave";
            this.CmdMSave.Size = new System.Drawing.Size(66, 26);
            this.CmdMSave.TabIndex = 4;
            this.CmdMSave.Text = "SAVE";
            this.CmdMSave.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.CmdMSave.UseVisualStyleBackColor = false;
            this.CmdMSave.Click += new System.EventHandler(this.CmdMSave_Click);
            // 
            // cboSl
            // 
            this.cboSl.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSl.FormattingEnabled = true;
            this.cboSl.Location = new System.Drawing.Point(125, 95);
            this.cboSl.Name = "cboSl";
            this.cboSl.Size = new System.Drawing.Size(51, 21);
            this.cboSl.TabIndex = 0;
            this.cboSl.Leave += new System.EventHandler(this.cboSl_Leave);
            // 
            // GridMStp
            // 
            this.GridMStp.AllowUserToAddRows = false;
            this.GridMStp.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridMStp.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GridMStp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GridMStp.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.GreenYellow;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridMStp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridMStp.DefaultCellStyle = dataGridViewCellStyle3;
            this.GridMStp.GridColor = System.Drawing.Color.LightGreen;
            this.GridMStp.Location = new System.Drawing.Point(72, 264);
            this.GridMStp.Name = "GridMStp";
            this.GridMStp.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridMStp.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.GridMStp.RowHeadersVisible = false;
            this.GridMStp.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridMStp.RowTemplate.Height = 18;
            this.GridMStp.Size = new System.Drawing.Size(295, 108);
            this.GridMStp.TabIndex = 7;
            this.GridMStp.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridMStp_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 201;
            this.label1.Text = "Case";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 203;
            this.label2.Text = "Medicine Setup";
            // 
            // txtMStp
            // 
            this.txtMStp.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMStp.Location = new System.Drawing.Point(125, 120);
            this.txtMStp.Multiline = true;
            this.txtMStp.Name = "txtMStp";
            this.txtMStp.Size = new System.Drawing.Size(234, 35);
            this.txtMStp.TabIndex = 2;
            // 
            // CboCase
            // 
            this.CboCase.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboCase.FormattingEnabled = true;
            this.CboCase.Location = new System.Drawing.Point(124, 70);
            this.CboCase.Name = "CboCase";
            this.CboCase.Size = new System.Drawing.Size(132, 21);
            this.CboCase.TabIndex = 1;
            this.CboCase.Leave += new System.EventHandler(this.CboCase_Leave);
            // 
            // lblMgs
            // 
            this.lblMgs.AutoSize = true;
            this.lblMgs.BackColor = System.Drawing.Color.Transparent;
            this.lblMgs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMgs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblMgs.Location = new System.Drawing.Point(302, 406);
            this.lblMgs.Name = "lblMgs";
            this.lblMgs.Size = new System.Drawing.Size(36, 16);
            this.lblMgs.TabIndex = 386;
            this.lblMgs.Text = ".......";
            this.lblMgs.Visible = false;
            this.lblMgs.Click += new System.EventHandler(this.lblMgs_Click);
            // 
            // PicSave
            // 
            this.PicSave.BackColor = System.Drawing.Color.Transparent;
            this.PicSave.Image = ((System.Drawing.Image)(resources.GetObject("PicSave.Image")));
            this.PicSave.Location = new System.Drawing.Point(550, 406);
            this.PicSave.Name = "PicSave";
            this.PicSave.Size = new System.Drawing.Size(58, 27);
            this.PicSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicSave.TabIndex = 385;
            this.PicSave.TabStop = false;
            this.PicSave.Visible = false;
            this.PicSave.Click += new System.EventHandler(this.PicSave_Click);
            // 
            // txtRmk
            // 
            this.txtRmk.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRmk.Location = new System.Drawing.Point(125, 159);
            this.txtRmk.Name = "txtRmk";
            this.txtRmk.Size = new System.Drawing.Size(234, 21);
            this.txtRmk.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 388;
            this.label3.Text = "Remarks";
            // 
            // btnPrs
            // 
            this.btnPrs.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnPrs.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrs.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPrs.Location = new System.Drawing.Point(216, 215);
            this.btnPrs.Name = "btnPrs";
            this.btnPrs.Size = new System.Drawing.Size(112, 25);
            this.btnPrs.TabIndex = 6;
            this.btnPrs.Text = "Prescription>>";
            this.btnPrs.UseVisualStyleBackColor = false;
            this.btnPrs.Click += new System.EventHandler(this.btnPrs_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CmdPrs
            // 
            this.CmdPrs.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.CmdPrs.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdPrs.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CmdPrs.Location = new System.Drawing.Point(563, 215);
            this.CmdPrs.Name = "CmdPrs";
            this.CmdPrs.Size = new System.Drawing.Size(112, 25);
            this.CmdPrs.TabIndex = 395;
            this.CmdPrs.Text = "Prescription>>";
            this.CmdPrs.UseVisualStyleBackColor = false;
            this.CmdPrs.Click += new System.EventHandler(this.CmdPrs_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(390, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 401;
            this.label4.Text = "Remarks";
            // 
            // txtTRmk
            // 
            this.txtTRmk.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTRmk.Location = new System.Drawing.Point(472, 159);
            this.txtTRmk.Name = "txtTRmk";
            this.txtTRmk.Size = new System.Drawing.Size(234, 21);
            this.txtTRmk.TabIndex = 392;
            // 
            // CboProb
            // 
            this.CboProb.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboProb.FormattingEnabled = true;
            this.CboProb.Location = new System.Drawing.Point(471, 70);
            this.CboProb.Name = "CboProb";
            this.CboProb.Size = new System.Drawing.Size(132, 21);
            this.CboProb.TabIndex = 390;
            this.CboProb.Leave += new System.EventHandler(this.CboProb_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(390, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 400;
            this.label5.Text = "Medicine Setup";
            // 
            // txtTstame
            // 
            this.txtTstame.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTstame.Location = new System.Drawing.Point(472, 120);
            this.txtTstame.Multiline = true;
            this.txtTstame.Name = "txtTstame";
            this.txtTstame.Size = new System.Drawing.Size(234, 35);
            this.txtTstame.TabIndex = 391;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(389, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 399;
            this.label6.Text = "Case";
            // 
            // GridTest
            // 
            this.GridTest.AllowUserToAddRows = false;
            this.GridTest.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridTest.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.GridTest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GridTest.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.GreenYellow;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridTest.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridTest.DefaultCellStyle = dataGridViewCellStyle7;
            this.GridTest.GridColor = System.Drawing.Color.LightGreen;
            this.GridTest.Location = new System.Drawing.Point(419, 264);
            this.GridTest.Name = "GridTest";
            this.GridTest.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridTest.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.GridTest.RowHeadersVisible = false;
            this.GridTest.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridTest.RowTemplate.Height = 18;
            this.GridTest.Size = new System.Drawing.Size(295, 108);
            this.GridTest.TabIndex = 396;
            this.GridTest.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridTest_CellDoubleClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(390, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 398;
            this.label7.Text = "SL No";
            // 
            // CmdTAdd
            // 
            this.CmdTAdd.BackColor = System.Drawing.Color.Transparent;
            this.CmdTAdd.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdTAdd.Image = ((System.Drawing.Image)(resources.GetObject("CmdTAdd.Image")));
            this.CmdTAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CmdTAdd.Location = new System.Drawing.Point(530, 92);
            this.CmdTAdd.Name = "CmdTAdd";
            this.CmdTAdd.Size = new System.Drawing.Size(78, 24);
            this.CmdTAdd.TabIndex = 397;
            this.CmdTAdd.Text = "Add New";
            this.CmdTAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CmdTAdd.UseVisualStyleBackColor = false;
            this.CmdTAdd.Click += new System.EventHandler(this.CmdTAdd_Click);
            // 
            // CmdTDel
            // 
            this.CmdTDel.BackColor = System.Drawing.Color.Transparent;
            this.CmdTDel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CmdTDel.BackgroundImage")));
            this.CmdTDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CmdTDel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdTDel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CmdTDel.Location = new System.Drawing.Point(486, 214);
            this.CmdTDel.Name = "CmdTDel";
            this.CmdTDel.Size = new System.Drawing.Size(71, 25);
            this.CmdTDel.TabIndex = 394;
            this.CmdTDel.Text = "DELETE";
            this.CmdTDel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CmdTDel.UseVisualStyleBackColor = false;
            this.CmdTDel.Click += new System.EventHandler(this.CmdTDel_Click);
            // 
            // CmdTSave
            // 
            this.CmdTSave.BackColor = System.Drawing.Color.Transparent;
            this.CmdTSave.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdTSave.Image = ((System.Drawing.Image)(resources.GetObject("CmdTSave.Image")));
            this.CmdTSave.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.CmdTSave.Location = new System.Drawing.Point(419, 214);
            this.CmdTSave.Name = "CmdTSave";
            this.CmdTSave.Size = new System.Drawing.Size(66, 26);
            this.CmdTSave.TabIndex = 393;
            this.CmdTSave.Text = "SAVE";
            this.CmdTSave.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.CmdTSave.UseVisualStyleBackColor = false;
            this.CmdTSave.Click += new System.EventHandler(this.CmdTSave_Click);
            // 
            // CboTSl
            // 
            this.CboTSl.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboTSl.FormattingEnabled = true;
            this.CboTSl.Location = new System.Drawing.Point(472, 95);
            this.CboTSl.Name = "CboTSl";
            this.CboTSl.Size = new System.Drawing.Size(51, 21);
            this.CboTSl.TabIndex = 389;
            // 
            // frmMdcStp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 449);
            this.Controls.Add(this.CmdPrs);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTRmk);
            this.Controls.Add(this.CboProb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTstame);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.GridTest);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CmdTAdd);
            this.Controls.Add(this.CmdTDel);
            this.Controls.Add(this.CmdTSave);
            this.Controls.Add(this.CboTSl);
            this.Controls.Add(this.btnPrs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRmk);
            this.Controls.Add(this.lblMgs);
            this.Controls.Add(this.PicSave);
            this.Controls.Add(this.CboCase);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMStp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GridMStp);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.CmdAddNew);
            this.Controls.Add(this.CmdMDelete);
            this.Controls.Add(this.CmdMSave);
            this.Controls.Add(this.cboSl);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(lebFlag);
            this.Controls.Add(lebFormHead);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMdcStp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medical Setup";
            this.Load += new System.EventHandler(this.frmMdcStp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridMStp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridTest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdExit;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button CmdAddNew;
        private System.Windows.Forms.Button CmdMDelete;
        private System.Windows.Forms.Button CmdMSave;
        private System.Windows.Forms.ComboBox cboSl;
        private System.Windows.Forms.DataGridView GridMStp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMStp;
        private System.Windows.Forms.ComboBox CboCase;
        private System.Windows.Forms.Label lblMgs;
        private System.Windows.Forms.PictureBox PicSave;
        private System.Windows.Forms.TextBox txtRmk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPrs;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button CmdPrs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTRmk;
        private System.Windows.Forms.ComboBox CboProb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTstame;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView GridTest;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button CmdTAdd;
        private System.Windows.Forms.Button CmdTDel;
        private System.Windows.Forms.Button CmdTSave;
        private System.Windows.Forms.ComboBox CboTSl;
    }
}
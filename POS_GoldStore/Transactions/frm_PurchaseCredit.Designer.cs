namespace POS_GoldStore.Transactions
{
    partial class frm_PurchaseCredit
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_PurchaseCredit));
            this.label33 = new System.Windows.Forms.Label();
            this.dgv_PruchaseCredit = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_exitForm = new System.Windows.Forms.Button();
            this.txt_ProductId = new System.Windows.Forms.TextBox();
            this.txt_CustomerName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_New = new System.Windows.Forms.Button();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_NewAmount = new System.Windows.Forms.TextBox();
            this.txt_BalanceAmount = new System.Windows.Forms.TextBox();
            this.txt_SMID = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_Find = new System.Windows.Forms.TextBox();
            this.txt_Rate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_ProductName = new System.Windows.Forms.TextBox();
            this.txt_TotalAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_CustomerID = new System.Windows.Forms.TextBox();
            this.txt_Amount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_InvId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PMID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PMNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PMDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PMCustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PMProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PMRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PMAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BalAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PruchaseCredit)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.ForeColor = System.Drawing.Color.White;
            this.label33.Location = new System.Drawing.Point(19, 13);
            this.label33.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(214, 33);
            this.label33.TabIndex = 1;
            this.label33.Text = "Purchae Credit";
            // 
            // dgv_PruchaseCredit
            // 
            this.dgv_PruchaseCredit.AllowUserToAddRows = false;
            this.dgv_PruchaseCredit.AllowUserToDeleteRows = false;
            this.dgv_PruchaseCredit.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_PruchaseCredit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_PruchaseCredit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PruchaseCredit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PMID,
            this.PMNo,
            this.PMDate,
            this.PMCustomerID,
            this.CustomerName,
            this.PMProductID,
            this.PName,
            this.ProductWeight,
            this.PMRate,
            this.PMAmount,
            this.BalAmt,
            this.Remarks});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_PruchaseCredit.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_PruchaseCredit.Location = new System.Drawing.Point(3, 398);
            this.dgv_PruchaseCredit.Name = "dgv_PruchaseCredit";
            this.dgv_PruchaseCredit.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_PruchaseCredit.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_PruchaseCredit.RowHeadersWidth = 10;
            this.dgv_PruchaseCredit.Size = new System.Drawing.Size(902, 251);
            this.dgv_PruchaseCredit.TabIndex = 1058;
            this.dgv_PruchaseCredit.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_SaleTemp_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(174)))), ((int)(((byte)(174)))));
            this.panel2.Controls.Add(this.btn_exitForm);
            this.panel2.Controls.Add(this.label33);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 34);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(917, 66);
            this.panel2.TabIndex = 1060;
            // 
            // btn_exitForm
            // 
            this.btn_exitForm.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_exitForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_exitForm.FlatAppearance.BorderSize = 0;
            this.btn_exitForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exitForm.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exitForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btn_exitForm.Image = global::POS_GoldStore.Properties.Resources.icons8_close_window_36;
            this.btn_exitForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_exitForm.Location = new System.Drawing.Point(799, 0);
            this.btn_exitForm.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_exitForm.Name = "btn_exitForm";
            this.btn_exitForm.Size = new System.Drawing.Size(118, 66);
            this.btn_exitForm.TabIndex = 1016;
            this.btn_exitForm.Text = "     &Close";
            this.btn_exitForm.UseVisualStyleBackColor = false;
            this.btn_exitForm.Click += new System.EventHandler(this.btn_exitForm_Click);
            // 
            // txt_ProductId
            // 
            this.txt_ProductId.Enabled = false;
            this.txt_ProductId.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ProductId.Location = new System.Drawing.Point(622, 702);
            this.txt_ProductId.Name = "txt_ProductId";
            this.txt_ProductId.Size = new System.Drawing.Size(43, 26);
            this.txt_ProductId.TabIndex = 1082;
            this.txt_ProductId.Visible = false;
            // 
            // txt_CustomerName
            // 
            this.txt_CustomerName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CustomerName.Location = new System.Drawing.Point(152, 215);
            this.txt_CustomerName.Name = "txt_CustomerName";
            this.txt_CustomerName.Size = new System.Drawing.Size(178, 26);
            this.txt_CustomerName.TabIndex = 1072;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(10, 218);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 20);
            this.label9.TabIndex = 1063;
            this.label9.Text = "Customer Name :";
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(174)))), ((int)(((byte)(174)))));
            this.btn_Save.Enabled = false;
            this.btn_Save.FlatAppearance.BorderSize = 0;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Image = ((System.Drawing.Image)(resources.GetObject("btn_Save.Image")));
            this.btn_Save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Save.Location = new System.Drawing.Point(10, 82);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(172, 43);
            this.btn_Save.TabIndex = 131;
            this.btn_Save.Text = "  &Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(174)))), ((int)(((byte)(174)))));
            this.btn_cancel.Enabled = false;
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Image = ((System.Drawing.Image)(resources.GetObject("btn_cancel.Image")));
            this.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancel.Location = new System.Drawing.Point(10, 146);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(172, 43);
            this.btn_cancel.TabIndex = 130;
            this.btn_cancel.Text = "  &Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_New
            // 
            this.btn_New.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(174)))), ((int)(((byte)(174)))));
            this.btn_New.FlatAppearance.BorderSize = 0;
            this.btn_New.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_New.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_New.ForeColor = System.Drawing.Color.White;
            this.btn_New.Image = ((System.Drawing.Image)(resources.GetObject("btn_New.Image")));
            this.btn_New.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_New.Location = new System.Drawing.Point(8, 22);
            this.btn_New.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(172, 43);
            this.btn_New.TabIndex = 127;
            this.btn_New.Text = "&New";
            this.btn_New.UseVisualStyleBackColor = false;
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // dtp_date
            // 
            this.dtp_date.Location = new System.Drawing.Point(3, 12);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(200, 20);
            this.dtp_date.TabIndex = 133;
            this.dtp_date.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Save);
            this.groupBox2.Controls.Add(this.btn_cancel);
            this.groupBox2.Controls.Add(this.btn_New);
            this.groupBox2.Location = new System.Drawing.Point(671, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(190, 219);
            this.groupBox2.TabIndex = 1080;
            this.groupBox2.TabStop = false;
            // 
            // txt_NewAmount
            // 
            this.txt_NewAmount.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NewAmount.Location = new System.Drawing.Point(487, 225);
            this.txt_NewAmount.Name = "txt_NewAmount";
            this.txt_NewAmount.Size = new System.Drawing.Size(178, 26);
            this.txt_NewAmount.TabIndex = 1078;
            // 
            // txt_BalanceAmount
            // 
            this.txt_BalanceAmount.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BalanceAmount.Location = new System.Drawing.Point(487, 186);
            this.txt_BalanceAmount.Name = "txt_BalanceAmount";
            this.txt_BalanceAmount.Size = new System.Drawing.Size(178, 26);
            this.txt_BalanceAmount.TabIndex = 1077;
            // 
            // txt_SMID
            // 
            this.txt_SMID.Enabled = false;
            this.txt_SMID.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SMID.Location = new System.Drawing.Point(622, 665);
            this.txt_SMID.Name = "txt_SMID";
            this.txt_SMID.Size = new System.Drawing.Size(43, 26);
            this.txt_SMID.TabIndex = 1081;
            this.txt_SMID.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.txt_Find);
            this.groupBox1.Location = new System.Drawing.Point(238, 340);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 52);
            this.groupBox1.TabIndex = 1079;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(321, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 170;
            this.pictureBox1.TabStop = false;
            // 
            // txt_Find
            // 
            this.txt_Find.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Find.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Find.Location = new System.Drawing.Point(6, 19);
            this.txt_Find.Name = "txt_Find";
            this.txt_Find.Size = new System.Drawing.Size(315, 22);
            this.txt_Find.TabIndex = 10;
            this.txt_Find.TextChanged += new System.EventHandler(this.txt_Find_TextChanged);
            // 
            // txt_Rate
            // 
            this.txt_Rate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Rate.Location = new System.Drawing.Point(346, 678);
            this.txt_Rate.Name = "txt_Rate";
            this.txt_Rate.Size = new System.Drawing.Size(178, 26);
            this.txt_Rate.TabIndex = 1070;
            this.txt_Rate.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(388, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 20);
            this.label8.TabIndex = 1068;
            this.label8.Text = "Remaining :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(370, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 20);
            this.label7.TabIndex = 1069;
            this.label7.Text = "Total Amount :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(368, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 20);
            this.label6.TabIndex = 1066;
            this.label6.Text = "New Amount :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 684);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 1065;
            this.label5.Text = "Amount :";
            this.label5.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(289, 681);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 1067;
            this.label4.Text = "Rate :";
            this.label4.Visible = false;
            // 
            // txt_ProductName
            // 
            this.txt_ProductName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ProductName.Location = new System.Drawing.Point(152, 247);
            this.txt_ProductName.Name = "txt_ProductName";
            this.txt_ProductName.Size = new System.Drawing.Size(178, 26);
            this.txt_ProductName.TabIndex = 1071;
            // 
            // txt_TotalAmount
            // 
            this.txt_TotalAmount.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TotalAmount.Location = new System.Drawing.Point(487, 147);
            this.txt_TotalAmount.Name = "txt_TotalAmount";
            this.txt_TotalAmount.Size = new System.Drawing.Size(178, 26);
            this.txt_TotalAmount.TabIndex = 1073;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.TabIndex = 1064;
            this.label3.Text = "Product Name :";
            // 
            // txt_CustomerID
            // 
            this.txt_CustomerID.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CustomerID.Location = new System.Drawing.Point(152, 183);
            this.txt_CustomerID.Name = "txt_CustomerID";
            this.txt_CustomerID.Size = new System.Drawing.Size(178, 26);
            this.txt_CustomerID.TabIndex = 1074;
            // 
            // txt_Amount
            // 
            this.txt_Amount.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Amount.Location = new System.Drawing.Point(85, 678);
            this.txt_Amount.Name = "txt_Amount";
            this.txt_Amount.Size = new System.Drawing.Size(178, 26);
            this.txt_Amount.TabIndex = 1075;
            this.txt_Amount.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 1062;
            this.label2.Text = "Customer ID :";
            // 
            // txt_InvId
            // 
            this.txt_InvId.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_InvId.Location = new System.Drawing.Point(152, 144);
            this.txt_InvId.Name = "txt_InvId";
            this.txt_InvId.Size = new System.Drawing.Size(178, 26);
            this.txt_InvId.TabIndex = 1076;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 1061;
            this.label1.Text = "Invoice ID :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.dtp_date);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(917, 34);
            this.panel1.TabIndex = 1059;
            // 
            // PMID
            // 
            this.PMID.DataPropertyName = "PMID";
            this.PMID.HeaderText = "PMID";
            this.PMID.Name = "PMID";
            this.PMID.ReadOnly = true;
            this.PMID.Visible = false;
            // 
            // PMNo
            // 
            this.PMNo.DataPropertyName = "PMNo";
            this.PMNo.HeaderText = "Inv No";
            this.PMNo.Name = "PMNo";
            this.PMNo.ReadOnly = true;
            this.PMNo.Width = 80;
            // 
            // PMDate
            // 
            this.PMDate.DataPropertyName = "PMDate";
            this.PMDate.HeaderText = "Date";
            this.PMDate.Name = "PMDate";
            this.PMDate.ReadOnly = true;
            // 
            // PMCustomerID
            // 
            this.PMCustomerID.DataPropertyName = "PMCustomerID";
            this.PMCustomerID.HeaderText = "PMCustomerID";
            this.PMCustomerID.Name = "PMCustomerID";
            this.PMCustomerID.ReadOnly = true;
            this.PMCustomerID.Visible = false;
            // 
            // CustomerName
            // 
            this.CustomerName.DataPropertyName = "CustomerName";
            this.CustomerName.HeaderText = "Customer Name";
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            // 
            // PMProductID
            // 
            this.PMProductID.DataPropertyName = "PMProductID";
            this.PMProductID.HeaderText = "PMProductID";
            this.PMProductID.Name = "PMProductID";
            this.PMProductID.ReadOnly = true;
            this.PMProductID.Visible = false;
            // 
            // PName
            // 
            this.PName.DataPropertyName = "PName";
            this.PName.HeaderText = "Product Name";
            this.PName.Name = "PName";
            this.PName.ReadOnly = true;
            // 
            // ProductWeight
            // 
            this.ProductWeight.DataPropertyName = "ProductWeight";
            this.ProductWeight.HeaderText = "Product Weight";
            this.ProductWeight.Name = "ProductWeight";
            this.ProductWeight.ReadOnly = true;
            // 
            // PMRate
            // 
            this.PMRate.DataPropertyName = "PMRate";
            this.PMRate.HeaderText = "Rate";
            this.PMRate.Name = "PMRate";
            this.PMRate.ReadOnly = true;
            // 
            // PMAmount
            // 
            this.PMAmount.DataPropertyName = "PMAmount";
            this.PMAmount.HeaderText = "Total Amount";
            this.PMAmount.Name = "PMAmount";
            this.PMAmount.ReadOnly = true;
            // 
            // BalAmt
            // 
            this.BalAmt.DataPropertyName = "BalAmt";
            this.BalAmt.HeaderText = "Balance Amount";
            this.BalAmt.Name = "BalAmt";
            this.BalAmt.ReadOnly = true;
            // 
            // Remarks
            // 
            this.Remarks.DataPropertyName = "PMRemarks";
            this.Remarks.HeaderText = "Remarks";
            this.Remarks.Name = "Remarks";
            this.Remarks.ReadOnly = true;
            // 
            // frm_PurchaseCredit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 767);
            this.Controls.Add(this.dgv_PruchaseCredit);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txt_ProductId);
            this.Controls.Add(this.txt_CustomerName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txt_NewAmount);
            this.Controls.Add(this.txt_BalanceAmount);
            this.Controls.Add(this.txt_SMID);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_Rate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_ProductName);
            this.Controls.Add(this.txt_TotalAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_CustomerID);
            this.Controls.Add(this.txt_Amount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_InvId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_PurchaseCredit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_PurchaseCredit";
            this.Activated += new System.EventHandler(this.frm_PurchaseCredit_Activated);
            this.Load += new System.EventHandler(this.frm_PurchaseCredit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PruchaseCredit)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.DataGridView dgv_PruchaseCredit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_exitForm;
        private System.Windows.Forms.TextBox txt_ProductId;
        private System.Windows.Forms.TextBox txt_CustomerName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_New;
        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_NewAmount;
        private System.Windows.Forms.TextBox txt_BalanceAmount;
        private System.Windows.Forms.TextBox txt_SMID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_Find;
        private System.Windows.Forms.TextBox txt_Rate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_ProductName;
        private System.Windows.Forms.TextBox txt_TotalAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_CustomerID;
        private System.Windows.Forms.TextBox txt_Amount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_InvId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PMID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PMNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PMDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PMCustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PMProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn PMRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PMAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn BalAmt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remarks;
    }
}
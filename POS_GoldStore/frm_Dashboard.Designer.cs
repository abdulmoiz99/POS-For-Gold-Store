namespace POS_GoldStore
{
    partial class frm_Dashboard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Dashboard));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lab_date = new System.Windows.Forms.Label();
            this.panel17 = new System.Windows.Forms.Panel();
            this.lab_PurchaeAmount = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.lab_SaleAmount = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lab_CompanyName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lab_Username = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_Expense = new System.Windows.Forms.DataGridView();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Update = new System.Windows.Forms.Button();
            this.txt_OpeningBalance = new System.Windows.Forms.TextBox();
            this.btn_OpenCounter = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lab_SaleRetAmt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lab_PurchaseRetAmt = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgv_ProductWeight = new System.Windows.Forms.DataGridView();
            this.PName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Receiveable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lab_ClosingBalance = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel17.SuspendLayout();
            this.panel14.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Expense)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProductWeight)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lab_date
            // 
            this.lab_date.AutoSize = true;
            this.lab_date.Font = new System.Drawing.Font("BigNoodleTitling", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_date.ForeColor = System.Drawing.Color.DarkGray;
            this.lab_date.Location = new System.Drawing.Point(554, 14);
            this.lab_date.Name = "lab_date";
            this.lab_date.Size = new System.Drawing.Size(168, 52);
            this.lab_date.TabIndex = 65;
            this.lab_date.Text = "Net Profit";
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(161)))), ((int)(((byte)(95)))));
            this.panel17.Controls.Add(this.lab_PurchaeAmount);
            this.panel17.Controls.Add(this.label23);
            this.panel17.Location = new System.Drawing.Point(5, 253);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(295, 35);
            this.panel17.TabIndex = 64;
            // 
            // lab_PurchaeAmount
            // 
            this.lab_PurchaeAmount.AutoSize = true;
            this.lab_PurchaeAmount.Font = new System.Drawing.Font("BigNoodleTitling", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_PurchaeAmount.ForeColor = System.Drawing.Color.White;
            this.lab_PurchaeAmount.Location = new System.Drawing.Point(156, 5);
            this.lab_PurchaeAmount.Name = "lab_PurchaeAmount";
            this.lab_PurchaeAmount.Size = new System.Drawing.Size(18, 27);
            this.lab_PurchaeAmount.TabIndex = 7;
            this.lab_PurchaeAmount.Text = "1";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("BigNoodleTitling", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(9, 6);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(151, 27);
            this.label23.TabIndex = 7;
            this.label23.Text = "Purchase Amount : ";
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(161)))), ((int)(((byte)(95)))));
            this.panel14.Controls.Add(this.lab_SaleAmount);
            this.panel14.Controls.Add(this.label17);
            this.panel14.Location = new System.Drawing.Point(6, 301);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(295, 35);
            this.panel14.TabIndex = 61;
            this.panel14.Paint += new System.Windows.Forms.PaintEventHandler(this.panel14_Paint);
            // 
            // lab_SaleAmount
            // 
            this.lab_SaleAmount.AutoSize = true;
            this.lab_SaleAmount.Font = new System.Drawing.Font("BigNoodleTitling", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_SaleAmount.ForeColor = System.Drawing.Color.White;
            this.lab_SaleAmount.Location = new System.Drawing.Point(155, 0);
            this.lab_SaleAmount.Name = "lab_SaleAmount";
            this.lab_SaleAmount.Size = new System.Drawing.Size(18, 27);
            this.lab_SaleAmount.TabIndex = 7;
            this.lab_SaleAmount.Text = "1";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("BigNoodleTitling", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(39, 8);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(113, 27);
            this.label17.TabIndex = 7;
            this.label17.Text = "Sale Amount : ";
            // 
            // lab_CompanyName
            // 
            this.lab_CompanyName.AutoSize = true;
            this.lab_CompanyName.Font = new System.Drawing.Font("BigNoodleTitling", 60F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_CompanyName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lab_CompanyName.Location = new System.Drawing.Point(12, 20);
            this.lab_CompanyName.Name = "lab_CompanyName";
            this.lab_CompanyName.Size = new System.Drawing.Size(251, 87);
            this.lab_CompanyName.TabIndex = 56;
            this.lab_CompanyName.Text = "COmpany";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lab_Username);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Location = new System.Drawing.Point(4, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(437, 143);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Info";
            // 
            // lab_Username
            // 
            this.lab_Username.AutoSize = true;
            this.lab_Username.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Username.Location = new System.Drawing.Point(172, 47);
            this.lab_Username.Name = "lab_Username";
            this.lab_Username.Size = new System.Drawing.Size(124, 24);
            this.lab_Username.TabIndex = 35;
            this.lab_Username.Text = "Username :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 24);
            this.label4.TabIndex = 35;
            this.label4.Text = "Username :";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel7.Controls.Add(this.panel9);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Location = new System.Drawing.Point(449, 79);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(392, 45);
            this.panel7.TabIndex = 52;
            // 
            // panel9
            // 
            this.panel9.Location = new System.Drawing.Point(0, 39);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(391, 408);
            this.panel9.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label3.Location = new System.Drawing.Point(3, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Today\'s Expense ";
            // 
            // dgv_Expense
            // 
            this.dgv_Expense.AllowUserToAddRows = false;
            this.dgv_Expense.AllowUserToDeleteRows = false;
            this.dgv_Expense.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_Expense.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Expense.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Expense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Expense.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Type,
            this.Amount});
            this.dgv_Expense.Location = new System.Drawing.Point(449, 121);
            this.dgv_Expense.Name = "dgv_Expense";
            this.dgv_Expense.ReadOnly = true;
            this.dgv_Expense.Size = new System.Drawing.Size(390, 94);
            this.dgv_Expense.TabIndex = 54;
            // 
            // Type
            // 
            this.Type.DataPropertyName = "ESName";
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Width = 200;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "EAmount";
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            this.Amount.Width = 140;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Update);
            this.groupBox2.Controls.Add(this.txt_OpeningBalance);
            this.groupBox2.Controls.Add(this.btn_OpenCounter);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox2.Location = new System.Drawing.Point(325, 452);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(537, 146);
            this.groupBox2.TabIndex = 66;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Update.Enabled = false;
            this.btn_Update.FlatAppearance.BorderSize = 0;
            this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Update.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.btn_Update.Image = ((System.Drawing.Image)(resources.GetObject("btn_Update.Image")));
            this.btn_Update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Update.Location = new System.Drawing.Point(274, 83);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(253, 49);
            this.btn_Update.TabIndex = 328;
            this.btn_Update.Text = "  &Update";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // txt_OpeningBalance
            // 
            this.txt_OpeningBalance.Enabled = false;
            this.txt_OpeningBalance.Location = new System.Drawing.Point(14, 37);
            this.txt_OpeningBalance.Name = "txt_OpeningBalance";
            this.txt_OpeningBalance.Size = new System.Drawing.Size(513, 37);
            this.txt_OpeningBalance.TabIndex = 130;
            this.txt_OpeningBalance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_OpeningBalance_KeyPress);
            // 
            // btn_OpenCounter
            // 
            this.btn_OpenCounter.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_OpenCounter.FlatAppearance.BorderSize = 0;
            this.btn_OpenCounter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OpenCounter.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OpenCounter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.btn_OpenCounter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_OpenCounter.Location = new System.Drawing.Point(12, 83);
            this.btn_OpenCounter.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn_OpenCounter.Name = "btn_OpenCounter";
            this.btn_OpenCounter.Size = new System.Drawing.Size(253, 49);
            this.btn_OpenCounter.TabIndex = 129;
            this.btn_OpenCounter.Text = "&Open Counter";
            this.btn_OpenCounter.UseVisualStyleBackColor = false;
            this.btn_OpenCounter.Click += new System.EventHandler(this.btn_OpenCounter_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.dateTime);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(289, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 67;
            this.dateTimePicker1.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(161)))), ((int)(((byte)(95)))));
            this.panel1.Controls.Add(this.lab_SaleRetAmt);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(6, 382);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 35);
            this.panel1.TabIndex = 69;
            // 
            // lab_SaleRetAmt
            // 
            this.lab_SaleRetAmt.AutoSize = true;
            this.lab_SaleRetAmt.Font = new System.Drawing.Font("BigNoodleTitling", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_SaleRetAmt.ForeColor = System.Drawing.Color.White;
            this.lab_SaleRetAmt.Location = new System.Drawing.Point(156, 5);
            this.lab_SaleRetAmt.Name = "lab_SaleRetAmt";
            this.lab_SaleRetAmt.Size = new System.Drawing.Size(18, 27);
            this.lab_SaleRetAmt.TabIndex = 7;
            this.lab_SaleRetAmt.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("BigNoodleTitling", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(55, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 27);
            this.label2.TabIndex = 7;
            this.label2.Text = "Sale Ret  : ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(161)))), ((int)(((byte)(95)))));
            this.panel2.Controls.Add(this.lab_PurchaseRetAmt);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(7, 341);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(295, 35);
            this.panel2.TabIndex = 68;
            // 
            // lab_PurchaseRetAmt
            // 
            this.lab_PurchaseRetAmt.AutoSize = true;
            this.lab_PurchaseRetAmt.Font = new System.Drawing.Font("BigNoodleTitling", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_PurchaseRetAmt.ForeColor = System.Drawing.Color.White;
            this.lab_PurchaseRetAmt.Location = new System.Drawing.Point(155, 11);
            this.lab_PurchaseRetAmt.Name = "lab_PurchaseRetAmt";
            this.lab_PurchaseRetAmt.Size = new System.Drawing.Size(18, 27);
            this.lab_PurchaseRetAmt.TabIndex = 7;
            this.lab_PurchaseRetAmt.Text = "1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("BigNoodleTitling", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(24, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 27);
            this.label6.TabIndex = 7;
            this.label6.Text = "Purchase Ret :";
            // 
            // dgv_ProductWeight
            // 
            this.dgv_ProductWeight.AllowUserToAddRows = false;
            this.dgv_ProductWeight.AllowUserToDeleteRows = false;
            this.dgv_ProductWeight.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_ProductWeight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ProductWeight.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_ProductWeight.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ProductWeight.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PName,
            this.Column2,
            this.Receiveable});
            this.dgv_ProductWeight.Location = new System.Drawing.Point(307, 258);
            this.dgv_ProductWeight.Name = "dgv_ProductWeight";
            this.dgv_ProductWeight.ReadOnly = true;
            this.dgv_ProductWeight.Size = new System.Drawing.Size(570, 187);
            this.dgv_ProductWeight.TabIndex = 70;
            // 
            // PName
            // 
            this.PName.DataPropertyName = "Pname";
            this.PName.HeaderText = "Name";
            this.PName.Name = "PName";
            this.PName.ReadOnly = true;
            this.PName.Width = 120;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Payable";
            this.Column2.HeaderText = "Payable";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // Receiveable
            // 
            this.Receiveable.DataPropertyName = "Receiveable";
            this.Receiveable.HeaderText = "Receiveable";
            this.Receiveable.Name = "Receiveable";
            this.Receiveable.ReadOnly = true;
            this.Receiveable.Width = 200;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(161)))), ((int)(((byte)(95)))));
            this.panel3.Controls.Add(this.lab_ClosingBalance);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(5, 423);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(295, 35);
            this.panel3.TabIndex = 71;
            // 
            // lab_ClosingBalance
            // 
            this.lab_ClosingBalance.AutoSize = true;
            this.lab_ClosingBalance.Font = new System.Drawing.Font("BigNoodleTitling", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_ClosingBalance.ForeColor = System.Drawing.Color.White;
            this.lab_ClosingBalance.Location = new System.Drawing.Point(156, 5);
            this.lab_ClosingBalance.Name = "lab_ClosingBalance";
            this.lab_ClosingBalance.Size = new System.Drawing.Size(18, 27);
            this.lab_ClosingBalance.TabIndex = 7;
            this.lab_ClosingBalance.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("BigNoodleTitling", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 27);
            this.label5.TabIndex = 7;
            this.label5.Text = "CLosing Balance : ";
            // 
            // frm_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 651);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dgv_ProductWeight);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lab_date);
            this.Controls.Add(this.panel17);
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.lab_CompanyName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.dgv_Expense);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Dashboard";
            this.Load += new System.EventHandler(this.frm_Dashboard_Load);
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Expense)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProductWeight)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_date;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Label lab_PurchaeAmount;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label lab_SaleAmount;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lab_CompanyName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lab_Username;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_Expense;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.TextBox txt_OpeningBalance;
        private System.Windows.Forms.Button btn_OpenCounter;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lab_SaleRetAmt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lab_PurchaseRetAmt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgv_ProductWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn PName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Receiveable;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lab_ClosingBalance;
        private System.Windows.Forms.Label label5;
    }
}
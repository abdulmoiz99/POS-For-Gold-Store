﻿namespace POS_GoldStore.Transactions
{
    partial class frm_SaleOrder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmb_CustomerName = new SergeUtils.EasyCompletionComboBox();
            this.lab_RatePerTola = new System.Windows.Forms.Label();
            this.gbPartyInfo = new System.Windows.Forms.GroupBox();
            this.txt_CICellNo = new System.Windows.Forms.TextBox();
            this.Label12 = new System.Windows.Forms.Label();
            this.txt_CIRemarks = new System.Windows.Forms.RichTextBox();
            this.Label26 = new System.Windows.Forms.Label();
            this.Label36 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnfnd = new System.Windows.Forms.Button();
            this.dtp_InvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.Label3 = new System.Windows.Forms.Label();
            this.txt_InvoiceNo = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_Return = new System.Windows.Forms.TextBox();
            this.txt_Received = new System.Windows.Forms.TextBox();
            this.lab_Ret = new System.Windows.Forms.Label();
            this.lab_Recived = new System.Windows.Forms.Label();
            this.cmb_ProductName = new SergeUtils.EasyCompletionComboBox();
            this.txt_Amount = new System.Windows.Forms.TextBox();
            this.txt_ProductRate = new System.Windows.Forms.TextBox();
            this.txt_ProductWeight = new System.Windows.Forms.TextBox();
            this.lab_Amt = new System.Windows.Forms.Label();
            this.cmb_InvoiceType = new SergeUtils.EasyCompletionComboBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_CustomerId = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Print = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_New = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rdo_Temp = new System.Windows.Forms.RadioButton();
            this.rdo_Credit = new System.Windows.Forms.RadioButton();
            this.rdo_Cash = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_exitForm = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lab_Amount = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lab_Rec = new System.Windows.Forms.Label();
            this.lab_Return = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lab_Weight = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv_ProductDetails = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Balance = new System.Windows.Forms.Button();
            this.gbPartyInfo.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProductDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_CustomerName
            // 
            this.cmb_CustomerName.Font = new System.Drawing.Font("Comfortaa", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_CustomerName.FormattingEnabled = true;
            this.cmb_CustomerName.Location = new System.Drawing.Point(101, 27);
            this.cmb_CustomerName.Name = "cmb_CustomerName";
            this.cmb_CustomerName.Size = new System.Drawing.Size(208, 26);
            this.cmb_CustomerName.TabIndex = 1002;
            this.cmb_CustomerName.SelectedIndexChanged += new System.EventHandler(this.cmb_CustomerName_SelectedIndexChanged);
            // 
            // lab_RatePerTola
            // 
            this.lab_RatePerTola.AutoSize = true;
            this.lab_RatePerTola.Font = new System.Drawing.Font("Comfortaa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_RatePerTola.Location = new System.Drawing.Point(32, 119);
            this.lab_RatePerTola.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_RatePerTola.Name = "lab_RatePerTola";
            this.lab_RatePerTola.Size = new System.Drawing.Size(116, 23);
            this.lab_RatePerTola.TabIndex = 22;
            this.lab_RatePerTola.Text = "Rate Per Tola :";
            // 
            // gbPartyInfo
            // 
            this.gbPartyInfo.Controls.Add(this.cmb_CustomerName);
            this.gbPartyInfo.Controls.Add(this.txt_CICellNo);
            this.gbPartyInfo.Controls.Add(this.Label12);
            this.gbPartyInfo.Controls.Add(this.txt_CIRemarks);
            this.gbPartyInfo.Controls.Add(this.Label26);
            this.gbPartyInfo.Controls.Add(this.Label36);
            this.gbPartyInfo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPartyInfo.Location = new System.Drawing.Point(300, 184);
            this.gbPartyInfo.Margin = new System.Windows.Forms.Padding(4);
            this.gbPartyInfo.Name = "gbPartyInfo";
            this.gbPartyInfo.Padding = new System.Windows.Forms.Padding(4);
            this.gbPartyInfo.Size = new System.Drawing.Size(316, 160);
            this.gbPartyInfo.TabIndex = 1031;
            this.gbPartyInfo.TabStop = false;
            this.gbPartyInfo.Text = "Customer Info";
            // 
            // txt_CICellNo
            // 
            this.txt_CICellNo.Location = new System.Drawing.Point(101, 64);
            this.txt_CICellNo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_CICellNo.Name = "txt_CICellNo";
            this.txt_CICellNo.Size = new System.Drawing.Size(208, 23);
            this.txt_CICellNo.TabIndex = 2;
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Location = new System.Drawing.Point(25, 106);
            this.Label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(70, 17);
            this.Label12.TabIndex = 309;
            this.Label12.Text = "Remarks :";
            // 
            // txt_CIRemarks
            // 
            this.txt_CIRemarks.Location = new System.Drawing.Point(101, 101);
            this.txt_CIRemarks.Margin = new System.Windows.Forms.Padding(4);
            this.txt_CIRemarks.Name = "txt_CIRemarks";
            this.txt_CIRemarks.Size = new System.Drawing.Size(208, 35);
            this.txt_CIRemarks.TabIndex = 3;
            this.txt_CIRemarks.Text = "";
            // 
            // Label26
            // 
            this.Label26.AutoSize = true;
            this.Label26.Location = new System.Drawing.Point(3, 70);
            this.Label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label26.Name = "Label26";
            this.Label26.Size = new System.Drawing.Size(94, 17);
            this.Label26.TabIndex = 29;
            this.Label26.Text = "Contact No :";
            // 
            // Label36
            // 
            this.Label36.AutoSize = true;
            this.Label36.Location = new System.Drawing.Point(42, 34);
            this.Label36.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label36.Name = "Label36";
            this.Label36.Size = new System.Drawing.Size(56, 17);
            this.Label36.TabIndex = 23;
            this.Label36.Text = "Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comfortaa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 23);
            this.label1.TabIndex = 22;
            this.label1.Text = "Product Weight :";
            // 
            // btnfnd
            // 
            this.btnfnd.Location = new System.Drawing.Point(234, 50);
            this.btnfnd.Margin = new System.Windows.Forms.Padding(4);
            this.btnfnd.Name = "btnfnd";
            this.btnfnd.Size = new System.Drawing.Size(41, 29);
            this.btnfnd.TabIndex = 41;
            this.btnfnd.Text = "...";
            this.btnfnd.UseVisualStyleBackColor = true;
            // 
            // dtp_InvoiceDate
            // 
            this.dtp_InvoiceDate.CustomFormat = "dd/MM/yyyy";
            this.dtp_InvoiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_InvoiceDate.Location = new System.Drawing.Point(120, 91);
            this.dtp_InvoiceDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_InvoiceDate.Name = "dtp_InvoiceDate";
            this.dtp_InvoiceDate.Size = new System.Drawing.Size(155, 23);
            this.dtp_InvoiceDate.TabIndex = 2;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(22, 56);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(86, 17);
            this.Label3.TabIndex = 0;
            this.Label3.Text = "Invoice No :";
            // 
            // txt_InvoiceNo
            // 
            this.txt_InvoiceNo.BackColor = System.Drawing.SystemColors.Control;
            this.txt_InvoiceNo.Enabled = false;
            this.txt_InvoiceNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_InvoiceNo.Location = new System.Drawing.Point(120, 58);
            this.txt_InvoiceNo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_InvoiceNo.Name = "txt_InvoiceNo";
            this.txt_InvoiceNo.ReadOnly = true;
            this.txt_InvoiceNo.Size = new System.Drawing.Size(110, 21);
            this.txt_InvoiceNo.TabIndex = 999;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(10, 92);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(99, 17);
            this.Label2.TabIndex = 5;
            this.Label2.Text = "Invoice Date :";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Comfortaa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(21, 44);
            this.Label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(127, 23);
            this.Label8.TabIndex = 22;
            this.Label8.Text = "Product Name :";
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.txt_Return);
            this.GroupBox2.Controls.Add(this.txt_Received);
            this.GroupBox2.Controls.Add(this.lab_Ret);
            this.GroupBox2.Controls.Add(this.lab_Recived);
            this.GroupBox2.Controls.Add(this.cmb_ProductName);
            this.GroupBox2.Controls.Add(this.txt_Amount);
            this.GroupBox2.Controls.Add(this.txt_ProductRate);
            this.GroupBox2.Controls.Add(this.txt_ProductWeight);
            this.GroupBox2.Controls.Add(this.lab_RatePerTola);
            this.GroupBox2.Controls.Add(this.lab_Amt);
            this.GroupBox2.Controls.Add(this.label1);
            this.GroupBox2.Controls.Add(this.Label8);
            this.GroupBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox2.Location = new System.Drawing.Point(12, 352);
            this.GroupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox2.Size = new System.Drawing.Size(433, 279);
            this.GroupBox2.TabIndex = 1033;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Product Info";
            this.GroupBox2.Enter += new System.EventHandler(this.GroupBox2_Enter);
            // 
            // txt_Return
            // 
            this.txt_Return.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_Return.Font = new System.Drawing.Font("Comfortaa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Return.Location = new System.Drawing.Point(155, 220);
            this.txt_Return.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Return.Name = "txt_Return";
            this.txt_Return.Size = new System.Drawing.Size(268, 24);
            this.txt_Return.TabIndex = 1005;
            this.txt_Return.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_Return.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Return_KeyPress);
            // 
            // txt_Received
            // 
            this.txt_Received.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_Received.Font = new System.Drawing.Font("Comfortaa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Received.Location = new System.Drawing.Point(155, 186);
            this.txt_Received.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Received.Name = "txt_Received";
            this.txt_Received.Size = new System.Drawing.Size(268, 24);
            this.txt_Received.TabIndex = 1006;
            this.txt_Received.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_Received.TextChanged += new System.EventHandler(this.txt_Received_TextChanged_1);
            this.txt_Received.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Received_KeyPress);
            // 
            // lab_Ret
            // 
            this.lab_Ret.AutoSize = true;
            this.lab_Ret.Font = new System.Drawing.Font("Comfortaa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Ret.Location = new System.Drawing.Point(60, 220);
            this.lab_Ret.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_Ret.Name = "lab_Ret";
            this.lab_Ret.Size = new System.Drawing.Size(86, 23);
            this.lab_Ret.TabIndex = 1003;
            this.lab_Ret.Text = "Discount :";
            // 
            // lab_Recived
            // 
            this.lab_Recived.AutoSize = true;
            this.lab_Recived.Font = new System.Drawing.Font("Comfortaa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Recived.Location = new System.Drawing.Point(62, 187);
            this.lab_Recived.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_Recived.Name = "lab_Recived";
            this.lab_Recived.Size = new System.Drawing.Size(85, 23);
            this.lab_Recived.TabIndex = 1004;
            this.lab_Recived.Text = "Received :";
            // 
            // cmb_ProductName
            // 
            this.cmb_ProductName.Font = new System.Drawing.Font("Comfortaa", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_ProductName.FormattingEnabled = true;
            this.cmb_ProductName.Location = new System.Drawing.Point(155, 38);
            this.cmb_ProductName.Name = "cmb_ProductName";
            this.cmb_ProductName.Size = new System.Drawing.Size(268, 26);
            this.cmb_ProductName.TabIndex = 1001;
            // 
            // txt_Amount
            // 
            this.txt_Amount.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_Amount.Font = new System.Drawing.Font("Comfortaa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Amount.Location = new System.Drawing.Point(155, 154);
            this.txt_Amount.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Amount.Name = "txt_Amount";
            this.txt_Amount.Size = new System.Drawing.Size(268, 24);
            this.txt_Amount.TabIndex = 358;
            this.txt_Amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_Amount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Amount_KeyDown);
            this.txt_Amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Amount_KeyPress);
            // 
            // txt_ProductRate
            // 
            this.txt_ProductRate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_ProductRate.Font = new System.Drawing.Font("Comfortaa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ProductRate.Location = new System.Drawing.Point(155, 116);
            this.txt_ProductRate.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ProductRate.Name = "txt_ProductRate";
            this.txt_ProductRate.Size = new System.Drawing.Size(268, 24);
            this.txt_ProductRate.TabIndex = 358;
            this.txt_ProductRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_ProductRate.TextChanged += new System.EventHandler(this.txt_ProductRate_TextChanged);
            this.txt_ProductRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ProductRate_KeyPress);
            // 
            // txt_ProductWeight
            // 
            this.txt_ProductWeight.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_ProductWeight.Font = new System.Drawing.Font("Comfortaa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ProductWeight.Location = new System.Drawing.Point(155, 78);
            this.txt_ProductWeight.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ProductWeight.Name = "txt_ProductWeight";
            this.txt_ProductWeight.Size = new System.Drawing.Size(268, 24);
            this.txt_ProductWeight.TabIndex = 358;
            this.txt_ProductWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_ProductWeight.TextChanged += new System.EventHandler(this.txt_ProductWeight_TextChanged);
            this.txt_ProductWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ProductWeight_KeyPress);
            // 
            // lab_Amt
            // 
            this.lab_Amt.AutoSize = true;
            this.lab_Amt.Font = new System.Drawing.Font("Comfortaa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Amt.Location = new System.Drawing.Point(70, 155);
            this.lab_Amt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_Amt.Name = "lab_Amt";
            this.lab_Amt.Size = new System.Drawing.Size(78, 23);
            this.lab_Amt.TabIndex = 22;
            this.lab_Amt.Text = "Amount :";
            // 
            // cmb_InvoiceType
            // 
            this.cmb_InvoiceType.Font = new System.Drawing.Font("Comfortaa", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_InvoiceType.FormattingEnabled = true;
            this.cmb_InvoiceType.Location = new System.Drawing.Point(120, 128);
            this.cmb_InvoiceType.Name = "cmb_InvoiceType";
            this.cmb_InvoiceType.Size = new System.Drawing.Size(43, 26);
            this.cmb_InvoiceType.TabIndex = 1002;
            this.cmb_InvoiceType.Visible = false;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.btnfnd);
            this.GroupBox1.Controls.Add(this.dtp_InvoiceDate);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.txt_InvoiceNo);
            this.GroupBox1.Controls.Add(this.cmb_InvoiceType);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(11, 183);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox1.Size = new System.Drawing.Size(283, 161);
            this.GroupBox1.TabIndex = 1032;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Invoice Info";
            // 
            // txt_CustomerId
            // 
            this.txt_CustomerId.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CustomerId.Location = new System.Drawing.Point(8, 174);
            this.txt_CustomerId.Name = "txt_CustomerId";
            this.txt_CustomerId.Size = new System.Drawing.Size(274, 37);
            this.txt_CustomerId.TabIndex = 333;
            this.txt_CustomerId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(995, 34);
            this.panel1.TabIndex = 1035;
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.txt_CustomerId);
            this.GroupBox3.Controls.Add(this.label4);
            this.GroupBox3.Controls.Add(this.btn_Print);
            this.GroupBox3.Controls.Add(this.btn_cancel);
            this.GroupBox3.Controls.Add(this.btn_Save);
            this.GroupBox3.Controls.Add(this.btn_New);
            this.GroupBox3.Location = new System.Drawing.Point(622, 116);
            this.GroupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox3.Size = new System.Drawing.Size(295, 228);
            this.GroupBox3.TabIndex = 1034;
            this.GroupBox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 124);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 30);
            this.label4.TabIndex = 332;
            this.label4.Text = "Customer Id :";
            // 
            // btn_Print
            // 
            this.btn_Print.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(174)))), ((int)(((byte)(174)))));
            this.btn_Print.FlatAppearance.BorderSize = 0;
            this.btn_Print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Print.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Print.ForeColor = System.Drawing.Color.White;
            this.btn_Print.Image = global::POS_GoldStore.Properties.Resources.icons8_print_36;
            this.btn_Print.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Print.Location = new System.Drawing.Point(149, 19);
            this.btn_Print.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(133, 43);
            this.btn_Print.TabIndex = 326;
            this.btn_Print.Text = "&Print";
            this.btn_Print.UseVisualStyleBackColor = false;
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(174)))), ((int)(((byte)(174)))));
            this.btn_cancel.Enabled = false;
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Image = global::POS_GoldStore.Properties.Resources.icons8_undo_36;
            this.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancel.Location = new System.Drawing.Point(149, 72);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(133, 43);
            this.btn_cancel.TabIndex = 329;
            this.btn_cancel.Text = "    &Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(174)))), ((int)(((byte)(174)))));
            this.btn_Save.Enabled = false;
            this.btn_Save.FlatAppearance.BorderSize = 0;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Image = global::POS_GoldStore.Properties.Resources.icons8_save_36;
            this.btn_Save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Save.Location = new System.Drawing.Point(8, 72);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(133, 43);
            this.btn_Save.TabIndex = 330;
            this.btn_Save.Text = "  &Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_New
            // 
            this.btn_New.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(174)))), ((int)(((byte)(174)))));
            this.btn_New.FlatAppearance.BorderSize = 0;
            this.btn_New.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_New.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_New.ForeColor = System.Drawing.Color.White;
            this.btn_New.Image = global::POS_GoldStore.Properties.Resources.AddNewFolder_36;
            this.btn_New.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_New.Location = new System.Drawing.Point(8, 19);
            this.btn_New.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(133, 43);
            this.btn_New.TabIndex = 326;
            this.btn_New.Text = "&New";
            this.btn_New.UseVisualStyleBackColor = false;
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rdo_Temp);
            this.groupBox5.Controls.Add(this.rdo_Credit);
            this.groupBox5.Controls.Add(this.rdo_Cash);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Location = new System.Drawing.Point(12, 116);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(604, 67);
            this.groupBox5.TabIndex = 1038;
            this.groupBox5.TabStop = false;
            // 
            // rdo_Temp
            // 
            this.rdo_Temp.AutoSize = true;
            this.rdo_Temp.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_Temp.ForeColor = System.Drawing.Color.Black;
            this.rdo_Temp.Location = new System.Drawing.Point(420, 20);
            this.rdo_Temp.Name = "rdo_Temp";
            this.rdo_Temp.Size = new System.Drawing.Size(86, 29);
            this.rdo_Temp.TabIndex = 1001;
            this.rdo_Temp.Text = "Temp";
            this.rdo_Temp.UseVisualStyleBackColor = true;
            this.rdo_Temp.CheckedChanged += new System.EventHandler(this.rdo_Temp_CheckedChanged);
            // 
            // rdo_Credit
            // 
            this.rdo_Credit.AutoSize = true;
            this.rdo_Credit.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_Credit.ForeColor = System.Drawing.Color.Black;
            this.rdo_Credit.Location = new System.Drawing.Point(316, 20);
            this.rdo_Credit.Name = "rdo_Credit";
            this.rdo_Credit.Size = new System.Drawing.Size(91, 29);
            this.rdo_Credit.TabIndex = 45;
            this.rdo_Credit.Text = "Credit";
            this.rdo_Credit.UseVisualStyleBackColor = true;
            this.rdo_Credit.CheckedChanged += new System.EventHandler(this.rdo_Credit_CheckedChanged);
            // 
            // rdo_Cash
            // 
            this.rdo_Cash.AutoSize = true;
            this.rdo_Cash.Checked = true;
            this.rdo_Cash.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_Cash.ForeColor = System.Drawing.Color.Black;
            this.rdo_Cash.Location = new System.Drawing.Point(219, 20);
            this.rdo_Cash.Name = "rdo_Cash";
            this.rdo_Cash.Size = new System.Drawing.Size(82, 29);
            this.rdo_Cash.TabIndex = 45;
            this.rdo_Cash.TabStop = true;
            this.rdo_Cash.Text = "Cash";
            this.rdo_Cash.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(8, 22);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(193, 25);
            this.label13.TabIndex = 44;
            this.label13.Text = "Transaction Mode";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.ForeColor = System.Drawing.Color.White;
            this.label33.Location = new System.Drawing.Point(14, 18);
            this.label33.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(257, 33);
            this.label33.TabIndex = 1;
            this.label33.Text = "Sale / Temp Given";
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
            this.panel2.Size = new System.Drawing.Size(995, 75);
            this.panel2.TabIndex = 1036;
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
            this.btn_exitForm.Location = new System.Drawing.Point(877, 0);
            this.btn_exitForm.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_exitForm.Name = "btn_exitForm";
            this.btn_exitForm.Size = new System.Drawing.Size(118, 75);
            this.btn_exitForm.TabIndex = 1016;
            this.btn_exitForm.Text = "     &Close";
            this.btn_exitForm.UseVisualStyleBackColor = false;
            this.btn_exitForm.Click += new System.EventHandler(this.btn_exitForm_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lab_Amount);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.lab_Rec);
            this.groupBox4.Controls.Add(this.lab_Return);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.lab_Weight);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox4.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.groupBox4.Location = new System.Drawing.Point(453, 352);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(296, 270);
            this.groupBox4.TabIndex = 1039;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sub Total ";
            // 
            // lab_Amount
            // 
            this.lab_Amount.AutoSize = true;
            this.lab_Amount.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Amount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lab_Amount.Location = new System.Drawing.Point(145, 99);
            this.lab_Amount.Name = "lab_Amount";
            this.lab_Amount.Size = new System.Drawing.Size(117, 28);
            this.lab_Amount.TabIndex = 1;
            this.lab_Amount.Text = "Amount :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label17.Location = new System.Drawing.Point(32, 99);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(117, 28);
            this.label17.TabIndex = 2;
            this.label17.Text = "Amount :";
            // 
            // lab_Rec
            // 
            this.lab_Rec.AutoSize = true;
            this.lab_Rec.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Rec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lab_Rec.Location = new System.Drawing.Point(145, 154);
            this.lab_Rec.Name = "lab_Rec";
            this.lab_Rec.Size = new System.Drawing.Size(135, 28);
            this.lab_Rec.TabIndex = 0;
            this.lab_Rec.Text = "Received :";
            // 
            // lab_Return
            // 
            this.lab_Return.AutoSize = true;
            this.lab_Return.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Return.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lab_Return.Location = new System.Drawing.Point(145, 209);
            this.lab_Return.Name = "lab_Return";
            this.lab_Return.Size = new System.Drawing.Size(98, 28);
            this.lab_Return.TabIndex = 0;
            this.lab_Return.Text = "Return :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label15.Location = new System.Drawing.Point(14, 154);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(135, 28);
            this.label15.TabIndex = 0;
            this.label15.Text = "Received :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label14.Location = new System.Drawing.Point(51, 209);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 28);
            this.label14.TabIndex = 0;
            this.label14.Text = "Return :";
            // 
            // lab_Weight
            // 
            this.lab_Weight.AutoSize = true;
            this.lab_Weight.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Weight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lab_Weight.Location = new System.Drawing.Point(145, 44);
            this.lab_Weight.Name = "lab_Weight";
            this.lab_Weight.Size = new System.Drawing.Size(106, 28);
            this.lab_Weight.TabIndex = 0;
            this.lab_Weight.Text = "Weight :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 104);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 36);
            this.label11.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(43, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 28);
            this.label5.TabIndex = 0;
            this.label5.Text = "Weight :";
            // 
            // dgv_ProductDetails
            // 
            this.dgv_ProductDetails.AllowUserToAddRows = false;
            this.dgv_ProductDetails.AllowUserToDeleteRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            this.dgv_ProductDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgv_ProductDetails.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ProductDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgv_ProductDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ProductDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Balance});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(83)))), ((int)(((byte)(121)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_ProductDetails.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgv_ProductDetails.Location = new System.Drawing.Point(769, 405);
            this.dgv_ProductDetails.Name = "dgv_ProductDetails";
            this.dgv_ProductDetails.ReadOnly = true;
            this.dgv_ProductDetails.RowHeadersWidth = 7;
            this.dgv_ProductDetails.RowTemplate.Height = 35;
            this.dgv_ProductDetails.Size = new System.Drawing.Size(214, 225);
            this.dgv_ProductDetails.TabIndex = 1040;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "PName";
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 120;
            // 
            // Balance
            // 
            this.Balance.DataPropertyName = "PBalance";
            this.Balance.HeaderText = "Balance";
            this.Balance.Name = "Balance";
            this.Balance.ReadOnly = true;
            this.Balance.Width = 80;
            // 
            // btn_Balance
            // 
            this.btn_Balance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(174)))), ((int)(((byte)(174)))));
            this.btn_Balance.FlatAppearance.BorderSize = 0;
            this.btn_Balance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Balance.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Balance.ForeColor = System.Drawing.Color.White;
            this.btn_Balance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Balance.Location = new System.Drawing.Point(768, 370);
            this.btn_Balance.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_Balance.Name = "btn_Balance";
            this.btn_Balance.Size = new System.Drawing.Size(214, 35);
            this.btn_Balance.TabIndex = 1043;
            this.btn_Balance.Text = "Balance";
            this.btn_Balance.UseVisualStyleBackColor = false;
            this.btn_Balance.Click += new System.EventHandler(this.btn_Balance_Click);
            // 
            // frm_SaleOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(995, 650);
            this.Controls.Add(this.btn_Balance);
            this.Controls.Add(this.dgv_ProductDetails);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.gbPartyInfo);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_SaleOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_SaleOrder";
            this.Activated += new System.EventHandler(this.frm_SaleOrder_Activated);
            this.Load += new System.EventHandler(this.frm_SaleOrder_Load);
            this.gbPartyInfo.ResumeLayout(false);
            this.gbPartyInfo.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProductDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private SergeUtils.EasyCompletionComboBox cmb_CustomerName;
        internal System.Windows.Forms.Label lab_RatePerTola;
        internal System.Windows.Forms.GroupBox gbPartyInfo;
        private System.Windows.Forms.TextBox txt_CICellNo;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.RichTextBox txt_CIRemarks;
        internal System.Windows.Forms.Label Label26;
        internal System.Windows.Forms.Label Label36;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Button btnfnd;
        internal System.Windows.Forms.DateTimePicker dtp_InvoiceDate;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txt_InvoiceNo;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.GroupBox GroupBox2;
        private SergeUtils.EasyCompletionComboBox cmb_InvoiceType;
        private SergeUtils.EasyCompletionComboBox cmb_ProductName;
        internal System.Windows.Forms.TextBox txt_Amount;
        internal System.Windows.Forms.TextBox txt_ProductRate;
        internal System.Windows.Forms.TextBox txt_ProductWeight;
        internal System.Windows.Forms.Label lab_Amt;
        internal System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.TextBox txt_CustomerId;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_New;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rdo_Temp;
        private System.Windows.Forms.RadioButton rdo_Credit;
        private System.Windows.Forms.RadioButton rdo_Cash;
        internal System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btn_exitForm;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lab_Amount;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lab_Rec;
        private System.Windows.Forms.Label lab_Return;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lab_Weight;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        internal System.Windows.Forms.TextBox txt_Return;
        internal System.Windows.Forms.TextBox txt_Received;
        internal System.Windows.Forms.Label lab_Ret;
        internal System.Windows.Forms.Label lab_Recived;
        private System.Windows.Forms.DataGridView dgv_ProductDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Balance;
        private System.Windows.Forms.Button btn_Balance;
    }
}
namespace POS_GoldStore
{
    partial class frm_Main
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
            this.btn_CashTemp = new System.Windows.Forms.Button();
            this.btn_SaleOrder = new System.Windows.Forms.Button();
            this.btn_PurchaseOrder = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_CashReports = new System.Windows.Forms.Button();
            this.btn_CashTransactinos = new System.Windows.Forms.Button();
            this.btn_CashT = new System.Windows.Forms.Button();
            this.btn_SaleCredit = new System.Windows.Forms.Button();
            this.btn_PurchaseCredit = new System.Windows.Forms.Button();
            this.btn_TempBal = new System.Windows.Forms.Button();
            this.btn_Expense = new System.Windows.Forms.Button();
            this.btn_SaleTemp = new System.Windows.Forms.Button();
            this.btn_PurchaseTemp = new System.Windows.Forms.Button();
            this.btn_CashTemp1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voucherSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expenseSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cashToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.balanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tempToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trasnsactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_CashTemp
            // 
            this.btn_CashTemp.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_CashTemp.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CashTemp.ForeColor = System.Drawing.Color.White;
            this.btn_CashTemp.Location = new System.Drawing.Point(6, 493);
            this.btn_CashTemp.Name = "btn_CashTemp";
            this.btn_CashTemp.Size = new System.Drawing.Size(220, 46);
            this.btn_CashTemp.TabIndex = 0;
            this.btn_CashTemp.Text = "Cash Balance";
            this.btn_CashTemp.UseVisualStyleBackColor = false;
            this.btn_CashTemp.Visible = false;
            this.btn_CashTemp.Click += new System.EventHandler(this.btn_CashFlow_Click);
            // 
            // btn_SaleOrder
            // 
            this.btn_SaleOrder.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_SaleOrder.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SaleOrder.ForeColor = System.Drawing.Color.White;
            this.btn_SaleOrder.Location = new System.Drawing.Point(3, 124);
            this.btn_SaleOrder.Name = "btn_SaleOrder";
            this.btn_SaleOrder.Size = new System.Drawing.Size(220, 46);
            this.btn_SaleOrder.TabIndex = 0;
            this.btn_SaleOrder.Text = "&Sale ";
            this.btn_SaleOrder.UseVisualStyleBackColor = false;
            this.btn_SaleOrder.Click += new System.EventHandler(this.btn_SaleOrder_Click);
            // 
            // btn_PurchaseOrder
            // 
            this.btn_PurchaseOrder.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_PurchaseOrder.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PurchaseOrder.ForeColor = System.Drawing.Color.White;
            this.btn_PurchaseOrder.Location = new System.Drawing.Point(3, 64);
            this.btn_PurchaseOrder.Name = "btn_PurchaseOrder";
            this.btn_PurchaseOrder.Size = new System.Drawing.Size(220, 46);
            this.btn_PurchaseOrder.TabIndex = 0;
            this.btn_PurchaseOrder.Text = "&Purchase";
            this.btn_PurchaseOrder.UseVisualStyleBackColor = false;
            this.btn_PurchaseOrder.Click += new System.EventHandler(this.btn_PurchaseOrder_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.btn_CashReports);
            this.panel2.Controls.Add(this.btn_CashTransactinos);
            this.panel2.Controls.Add(this.btn_CashT);
            this.panel2.Controls.Add(this.btn_SaleCredit);
            this.panel2.Controls.Add(this.btn_PurchaseCredit);
            this.panel2.Controls.Add(this.btn_TempBal);
            this.panel2.Controls.Add(this.btn_Expense);
            this.panel2.Controls.Add(this.btn_SaleTemp);
            this.panel2.Controls.Add(this.btn_CashTemp);
            this.panel2.Controls.Add(this.btn_PurchaseTemp);
            this.panel2.Controls.Add(this.btn_CashTemp1);
            this.panel2.Controls.Add(this.btn_SaleOrder);
            this.panel2.Controls.Add(this.btn_PurchaseOrder);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(474, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(226, 712);
            this.panel2.TabIndex = 4;
            // 
            // btn_CashReports
            // 
            this.btn_CashReports.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_CashReports.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CashReports.ForeColor = System.Drawing.Color.White;
            this.btn_CashReports.Location = new System.Drawing.Point(6, 649);
            this.btn_CashReports.Name = "btn_CashReports";
            this.btn_CashReports.Size = new System.Drawing.Size(220, 46);
            this.btn_CashReports.TabIndex = 9;
            this.btn_CashReports.Text = "Cash Reports";
            this.btn_CashReports.UseVisualStyleBackColor = false;
            this.btn_CashReports.Visible = false;
            this.btn_CashReports.Click += new System.EventHandler(this.btn_CashReports_Click);
            // 
            // btn_CashTransactinos
            // 
            this.btn_CashTransactinos.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_CashTransactinos.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CashTransactinos.ForeColor = System.Drawing.Color.White;
            this.btn_CashTransactinos.Location = new System.Drawing.Point(6, 597);
            this.btn_CashTransactinos.Name = "btn_CashTransactinos";
            this.btn_CashTransactinos.Size = new System.Drawing.Size(220, 46);
            this.btn_CashTransactinos.TabIndex = 8;
            this.btn_CashTransactinos.Text = "Cash Transactions";
            this.btn_CashTransactinos.UseVisualStyleBackColor = false;
            this.btn_CashTransactinos.Visible = false;
            this.btn_CashTransactinos.Click += new System.EventHandler(this.btn_CashTransactinos_Click);
            // 
            // btn_CashT
            // 
            this.btn_CashT.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_CashT.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CashT.ForeColor = System.Drawing.Color.White;
            this.btn_CashT.Location = new System.Drawing.Point(6, 545);
            this.btn_CashT.Name = "btn_CashT";
            this.btn_CashT.Size = new System.Drawing.Size(220, 46);
            this.btn_CashT.TabIndex = 7;
            this.btn_CashT.Text = "Cash Temp";
            this.btn_CashT.UseVisualStyleBackColor = false;
            this.btn_CashT.Visible = false;
            this.btn_CashT.Click += new System.EventHandler(this.btn_CashT_Click);
            // 
            // btn_SaleCredit
            // 
            this.btn_SaleCredit.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_SaleCredit.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SaleCredit.ForeColor = System.Drawing.Color.White;
            this.btn_SaleCredit.Location = new System.Drawing.Point(5, 441);
            this.btn_SaleCredit.Name = "btn_SaleCredit";
            this.btn_SaleCredit.Size = new System.Drawing.Size(220, 46);
            this.btn_SaleCredit.TabIndex = 6;
            this.btn_SaleCredit.Text = "Sale Credit";
            this.btn_SaleCredit.UseVisualStyleBackColor = false;
            this.btn_SaleCredit.Click += new System.EventHandler(this.btn_SaleCredit_Click);
            // 
            // btn_PurchaseCredit
            // 
            this.btn_PurchaseCredit.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_PurchaseCredit.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PurchaseCredit.ForeColor = System.Drawing.Color.White;
            this.btn_PurchaseCredit.Location = new System.Drawing.Point(5, 389);
            this.btn_PurchaseCredit.Name = "btn_PurchaseCredit";
            this.btn_PurchaseCredit.Size = new System.Drawing.Size(220, 46);
            this.btn_PurchaseCredit.TabIndex = 5;
            this.btn_PurchaseCredit.Text = "Purchase Credit";
            this.btn_PurchaseCredit.UseVisualStyleBackColor = false;
            this.btn_PurchaseCredit.Click += new System.EventHandler(this.btn_PurchaseCredit_Click);
            // 
            // btn_TempBal
            // 
            this.btn_TempBal.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_TempBal.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TempBal.ForeColor = System.Drawing.Color.White;
            this.btn_TempBal.Location = new System.Drawing.Point(5, 337);
            this.btn_TempBal.Name = "btn_TempBal";
            this.btn_TempBal.Size = new System.Drawing.Size(220, 46);
            this.btn_TempBal.TabIndex = 4;
            this.btn_TempBal.Text = "Temp Balance";
            this.btn_TempBal.UseVisualStyleBackColor = false;
            this.btn_TempBal.Click += new System.EventHandler(this.btn_TempBal_Click);
            // 
            // btn_Expense
            // 
            this.btn_Expense.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Expense.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Expense.ForeColor = System.Drawing.Color.White;
            this.btn_Expense.Location = new System.Drawing.Point(5, 285);
            this.btn_Expense.Name = "btn_Expense";
            this.btn_Expense.Size = new System.Drawing.Size(220, 46);
            this.btn_Expense.TabIndex = 3;
            this.btn_Expense.Text = "&Expense";
            this.btn_Expense.UseVisualStyleBackColor = false;
            this.btn_Expense.Click += new System.EventHandler(this.btn_Expense_Click);
            // 
            // btn_SaleTemp
            // 
            this.btn_SaleTemp.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_SaleTemp.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SaleTemp.ForeColor = System.Drawing.Color.White;
            this.btn_SaleTemp.Location = new System.Drawing.Point(3, 233);
            this.btn_SaleTemp.Name = "btn_SaleTemp";
            this.btn_SaleTemp.Size = new System.Drawing.Size(220, 46);
            this.btn_SaleTemp.TabIndex = 2;
            this.btn_SaleTemp.Text = "&Given";
            this.btn_SaleTemp.UseVisualStyleBackColor = false;
            this.btn_SaleTemp.Click += new System.EventHandler(this.btn_SaleTemp_Click);
            // 
            // btn_PurchaseTemp
            // 
            this.btn_PurchaseTemp.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_PurchaseTemp.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PurchaseTemp.ForeColor = System.Drawing.Color.White;
            this.btn_PurchaseTemp.Location = new System.Drawing.Point(3, 181);
            this.btn_PurchaseTemp.Name = "btn_PurchaseTemp";
            this.btn_PurchaseTemp.Size = new System.Drawing.Size(220, 46);
            this.btn_PurchaseTemp.TabIndex = 2;
            this.btn_PurchaseTemp.Text = "&Recevie Temp";
            this.btn_PurchaseTemp.UseVisualStyleBackColor = false;
            this.btn_PurchaseTemp.Click += new System.EventHandler(this.btn_PurchaseTemp_Click);
            // 
            // btn_CashTemp1
            // 
            this.btn_CashTemp1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_CashTemp1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CashTemp1.ForeColor = System.Drawing.Color.White;
            this.btn_CashTemp1.Location = new System.Drawing.Point(3, 12);
            this.btn_CashTemp1.Name = "btn_CashTemp1";
            this.btn_CashTemp1.Size = new System.Drawing.Size(220, 46);
            this.btn_CashTemp1.TabIndex = 1;
            this.btn_CashTemp1.Text = "&Dashboard";
            this.btn_CashTemp1.UseVisualStyleBackColor = false;
            this.btn_CashTemp1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainToolStripMenuItem,
            this.setupToolStripMenuItem,
            this.userManagementToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.cashToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(700, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mainToolStripMenuItem
            // 
            this.mainToolStripMenuItem.Name = "mainToolStripMenuItem";
            this.mainToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.mainToolStripMenuItem.Text = "Main";
            // 
            // setupToolStripMenuItem
            // 
            this.setupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addProductToolStripMenuItem,
            this.addCustomerToolStripMenuItem,
            this.voucherSetupToolStripMenuItem,
            this.expenseSetupToolStripMenuItem});
            this.setupToolStripMenuItem.Name = "setupToolStripMenuItem";
            this.setupToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.setupToolStripMenuItem.Text = "Setup";
            // 
            // addProductToolStripMenuItem
            // 
            this.addProductToolStripMenuItem.Name = "addProductToolStripMenuItem";
            this.addProductToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.addProductToolStripMenuItem.Text = "Add Product";
            this.addProductToolStripMenuItem.Click += new System.EventHandler(this.addProductToolStripMenuItem_Click_1);
            // 
            // addCustomerToolStripMenuItem
            // 
            this.addCustomerToolStripMenuItem.Name = "addCustomerToolStripMenuItem";
            this.addCustomerToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.addCustomerToolStripMenuItem.Text = "Add Customer";
            this.addCustomerToolStripMenuItem.Click += new System.EventHandler(this.addCustomerToolStripMenuItem_Click);
            // 
            // voucherSetupToolStripMenuItem
            // 
            this.voucherSetupToolStripMenuItem.Name = "voucherSetupToolStripMenuItem";
            this.voucherSetupToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.voucherSetupToolStripMenuItem.Text = "Voucher Setup";
            this.voucherSetupToolStripMenuItem.Click += new System.EventHandler(this.voucherSetupToolStripMenuItem_Click_1);
            // 
            // expenseSetupToolStripMenuItem
            // 
            this.expenseSetupToolStripMenuItem.Name = "expenseSetupToolStripMenuItem";
            this.expenseSetupToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.expenseSetupToolStripMenuItem.Text = "Expense Setup";
            this.expenseSetupToolStripMenuItem.Click += new System.EventHandler(this.expenseSetupToolStripMenuItem_Click);
            // 
            // userManagementToolStripMenuItem
            // 
            this.userManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePasswordToolStripMenuItem});
            this.userManagementToolStripMenuItem.Name = "userManagementToolStripMenuItem";
            this.userManagementToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.userManagementToolStripMenuItem.Text = "User Management";
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click_1);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transactionReportsToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // transactionReportsToolStripMenuItem
            // 
            this.transactionReportsToolStripMenuItem.Name = "transactionReportsToolStripMenuItem";
            this.transactionReportsToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.transactionReportsToolStripMenuItem.Text = "Transaction Reports";
            this.transactionReportsToolStripMenuItem.Click += new System.EventHandler(this.transactionReportsToolStripMenuItem_Click);
            // 
            // cashToolStripMenuItem
            // 
            this.cashToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.balanceToolStripMenuItem,
            this.tempToolStripMenuItem,
            this.trasnsactionsToolStripMenuItem,
            this.reportsToolStripMenuItem1});
            this.cashToolStripMenuItem.Name = "cashToolStripMenuItem";
            this.cashToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.cashToolStripMenuItem.Text = "Cash";
            // 
            // balanceToolStripMenuItem
            // 
            this.balanceToolStripMenuItem.Name = "balanceToolStripMenuItem";
            this.balanceToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.balanceToolStripMenuItem.Text = "Balance ";
            this.balanceToolStripMenuItem.Click += new System.EventHandler(this.balanceToolStripMenuItem_Click);
            // 
            // tempToolStripMenuItem
            // 
            this.tempToolStripMenuItem.Name = "tempToolStripMenuItem";
            this.tempToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.tempToolStripMenuItem.Text = "Temp";
            this.tempToolStripMenuItem.Click += new System.EventHandler(this.tempToolStripMenuItem_Click);
            // 
            // trasnsactionsToolStripMenuItem
            // 
            this.trasnsactionsToolStripMenuItem.Name = "trasnsactionsToolStripMenuItem";
            this.trasnsactionsToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.trasnsactionsToolStripMenuItem.Text = "Trasnsactions";
            this.trasnsactionsToolStripMenuItem.Click += new System.EventHandler(this.trasnsactionsToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem1
            // 
            this.reportsToolStripMenuItem1.Name = "reportsToolStripMenuItem1";
            this.reportsToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
            this.reportsToolStripMenuItem1.Text = "Reports";
            this.reportsToolStripMenuItem1.Click += new System.EventHandler(this.reportsToolStripMenuItem1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 736);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GOLD STORE POS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Main_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_Main_FormClosed);
            this.Load += new System.EventHandler(this.frm_Main_Load);
            this.panel2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_CashTemp;
        private System.Windows.Forms.Button btn_SaleOrder;
        private System.Windows.Forms.Button btn_PurchaseOrder;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_CashTemp1;
        private System.Windows.Forms.Button btn_PurchaseTemp;
        private System.Windows.Forms.Button btn_SaleTemp;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voucherSetupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem expenseSetupToolStripMenuItem;
        private System.Windows.Forms.Button btn_Expense;
        private System.Windows.Forms.Button btn_TempBal;
        private System.Windows.Forms.Button btn_PurchaseCredit;
        private System.Windows.Forms.Button btn_SaleCredit;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionReportsToolStripMenuItem;
        private System.Windows.Forms.Button btn_CashT;
        private System.Windows.Forms.Button btn_CashTransactinos;
        private System.Windows.Forms.Button btn_CashReports;
        private System.Windows.Forms.ToolStripMenuItem cashToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem balanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tempToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trasnsactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem1;
    }
}
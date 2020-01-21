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
            this.btn_Expense = new System.Windows.Forms.Button();
            this.btn_SaleTemp = new System.Windows.Forms.Button();
            this.btn_PurchaseTemp = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voucherSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expenseSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.btn_CashTemp.Location = new System.Drawing.Point(3, 285);
            this.btn_CashTemp.Name = "btn_CashTemp";
            this.btn_CashTemp.Size = new System.Drawing.Size(220, 46);
            this.btn_CashTemp.TabIndex = 0;
            this.btn_CashTemp.Text = "&Cash Temp";
            this.btn_CashTemp.UseVisualStyleBackColor = false;
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
            this.panel2.Controls.Add(this.btn_Expense);
            this.panel2.Controls.Add(this.btn_SaleTemp);
            this.panel2.Controls.Add(this.btn_CashTemp);
            this.panel2.Controls.Add(this.btn_PurchaseTemp);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btn_SaleOrder);
            this.panel2.Controls.Add(this.btn_PurchaseOrder);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(474, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(226, 712);
            this.panel2.TabIndex = 4;
            // 
            // btn_Expense
            // 
            this.btn_Expense.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Expense.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Expense.ForeColor = System.Drawing.Color.White;
            this.btn_Expense.Location = new System.Drawing.Point(3, 337);
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(3, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 46);
            this.button1.TabIndex = 1;
            this.button1.Text = "&Dashboard";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainToolStripMenuItem,
            this.setupToolStripMenuItem,
            this.userManagementToolStripMenuItem});
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
        private System.Windows.Forms.Button button1;
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
    }
}
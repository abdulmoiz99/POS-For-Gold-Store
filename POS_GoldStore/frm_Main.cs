using POS_GoldStore.Expense;
using POS_GoldStore.ReprtForm;
using POS_GoldStore.Setup;
using POS_GoldStore.Transactions;
using POS_GoldStore.UserManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_GoldStore
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            try
            {
                //FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                Left = Top = 0;
                Width = Screen.PrimaryScreen.WorkingArea.Width;
                Height = Screen.PrimaryScreen.WorkingArea.Height;
                //var frm = new frm_Main();
                //frm.MdiParent = this; // assign MdiParent of FormB to FormC
                //frm.Dock = DockStyle.Fill;
                //frm.Show();

            }
            catch (Exception)
            {
            }
        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var frm = new frm_AddProduct();
                frm.MdiParent = this; // assign MdiParent of FormB to FormC
                frm.Dock = DockStyle.Fill;
                frm.Show();

            }
            catch (Exception)
            {
            }
        }

        private void addPartyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var frm = new frm_AddCustomer();
                frm.MdiParent = this; // assign MdiParent of FormB to FormC
                frm.Dock = DockStyle.Fill;
                frm.Show();

            }
            catch (Exception)
            {
            }
        }

        private void purchaseOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var frm = new frm_PurchaseOrder();
                frm.MdiParent = this; // assign MdiParent of FormB to FormC
                frm.Dock = DockStyle.Fill;
                frm.Show();

            }
            catch (Exception)
            {
            }
        }

        private void saleOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var frm = new frm_SaleOrder();
                frm.MdiParent = this; // assign MdiParent of FormB to FormC
                frm.Dock = DockStyle.Fill;
                frm.Show();

            }
            catch (Exception)
            {
            }
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var frm = new frm_ChangeUserPassword();
                frm.MdiParent = this; // assign MdiParent of FormB to FormC
                frm.Dock = DockStyle.Fill;
                frm.Show();

            }
            catch (Exception)
            {
            }
        }

        private void voucherSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var frm = new frm_DocSetup();
                frm.MdiParent = this; // assign MdiParent of FormB to FormC
                frm.Dock = DockStyle.Fill;
                frm.Show();

            }
            catch (Exception)
            {
            }
        }

        private void btn_Dashboard_Click(object sender, EventArgs e)
        {

        }

        private void btn_AddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                var frm = new frm_AddProduct();
                frm.MdiParent = this; // assign MdiParent of FormB to FormC
                frm.Dock = DockStyle.Fill;
                frm.Show();

            }
            catch (Exception)
            {
            }
        }

        private void btn_AddCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                var frm = new frm_AddCustomer();
                frm.MdiParent = this; // assign MdiParent of FormB to FormC
                frm.Dock = DockStyle.Fill;
                frm.Show();

            }
            catch (Exception)
            {
            }
        }

        private void btn_VoucherSetup_Click(object sender, EventArgs e)
        {
            try
            {
                var frm = new frm_DocSetup();
                frm.MdiParent = this; // assign MdiParent of FormB to FormC
                frm.Dock = DockStyle.Fill;
                frm.Show();

            }
            catch (Exception)
            {
            }
        }

        private void btn_PurchaseOrder_Click(object sender, EventArgs e)
        {
           
                var frm = new frm_PurchaseOrder();
                frm.MdiParent = this; // assign MdiParent of FormB to FormC
                frm.Dock = DockStyle.Fill;
                frm.Show();

        }

        private void btn_SaleOrder_Click(object sender, EventArgs e)
        {
            try
            {
                var frm = new frm_SaleOrder();
                frm.MdiParent = this; // assign MdiParent of FormB to FormC
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }

        private void btn_CashFlow_Click(object sender, EventArgs e)
        {
            try
            {
                var frm = new CashBalance();
                frm.MdiParent = this; // assign MdiParent of FormB to FormC
                frm.Dock = DockStyle.Fill;
                frm.Show();

            }
            catch (Exception)
            {
            }
        }

        private void btn_ChangePassword_Click(object sender, EventArgs e)
        {
            try
            {
                var frm = new frm_ChangeUserPassword();
                frm.MdiParent = this; // assign MdiParent of FormB to FormC
                frm.Dock = DockStyle.Fill;
                frm.Show();

            }
            catch (Exception)
            {
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frm_Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_PurchaseTemp_Click(object sender, EventArgs e)
        {
            try
            {
                var frm = new frm_PurchaseTemp();
                frm.MdiParent = this; // assign MdiParent of FormB to FormC
                frm.Dock = DockStyle.Fill;
                frm.Show();

            }
            catch (Exception)
            {
            }
        }

        private void btn_SaleTemp_Click(object sender, EventArgs e)
        {
            try
            {
                var frm = new frm_SaleTemp();
                frm.MdiParent = this; // assign MdiParent of FormB to FormC
                frm.Dock = DockStyle.Fill;
                frm.Show();

            }
            catch (Exception)
            {
            }
        }

        private void addProductToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                var frm = new frm_AddProduct();
                frm.MdiParent = this; // assign MdiParent of FormB to FormC
                frm.Dock = DockStyle.Fill;
                frm.Show();

            }
            catch (Exception)
            {
            }
        }

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var frm = new frm_AddCustomer();
                frm.MdiParent = this; // assign MdiParent of FormB to FormC
                frm.Dock = DockStyle.Fill;
                frm.Show();

            }
            catch (Exception)
            {
            }
        }

        private void voucherSetupToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                var frm = new frm_DocSetup();
                frm.MdiParent = this; // assign MdiParent of FormB to FormC
                frm.Dock = DockStyle.Fill;
                frm.Show();

            }
            catch (Exception)
            {
            }
        }

        private void changePasswordToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                var frm = new frm_ChangeUserPassword();
                frm.MdiParent = this; // assign MdiParent of FormB to FormC
                frm.Dock = DockStyle.Fill;
                frm.Show();

            }
            catch (Exception)
            {
            }
        }

        private void expenseSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frm_ExpenseSetup();
            frm.MdiParent = this; // assign MdiParent of FormB to FormC
            frm.Dock = DockStyle.Fill;
            frm.Show();

        }

        private void btn_Expense_Click(object sender, EventArgs e)
        {
            var frm = new frm_AddExpense();
            frm.MdiParent = this; // assign MdiParent of FormB to FormC
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frm = new frm_Dashboard();
            frm.MdiParent = this; // assign MdiParent of FormB to FormC
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void btn_TempBal_Click(object sender, EventArgs e)
        {
            var frm = new frm_TempBalance();
            frm.MdiParent = this; // assign MdiParent of FormB to FormC
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void btn_PurchaseCredit_Click(object sender, EventArgs e)
        {
            var frm = new frm_PurchaseCredit();
            frm.MdiParent = this; // assign MdiParent of FormB to FormC
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void btn_SaleCredit_Click(object sender, EventArgs e)
        {
            var frm = new frm_SaleOrderCredit();
            frm.MdiParent = this; // assign MdiParent of FormB to FormC
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void transactionReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new SalePurchaseReports();
            frm.MdiParent = this; // assign MdiParent of FormB to FormC
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void btn_CashT_Click(object sender, EventArgs e)
        {
            var frm = new frm_CashTemp();
            frm.MdiParent = this; // assign MdiParent of FormB to FormC
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void btn_CashTransactinos_Click(object sender, EventArgs e)
        {
            var frm = new frm_CashTempTransactions();
            frm.MdiParent = this; // assign MdiParent of FormB to FormC
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void btn_CashReports_Click(object sender, EventArgs e)
        {
            var frm = new frm_CashReports();
            frm.MdiParent = this; // assign MdiParent of FormB to FormC
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void balanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new CashBalance();
            frm.MdiParent = this; // assign MdiParent of FormB to FormC
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void tempToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frm_CashTemp();
            frm.MdiParent = this; // assign MdiParent of FormB to FormC
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void trasnsactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frm_CashTempTransactions();
            frm.MdiParent = this; // assign MdiParent of FormB to FormC
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void reportsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var frm = new frm_CashReports();
            frm.MdiParent = this; // assign MdiParent of FormB to FormC
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void frm_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            //DialogResult YorN = MessageBox.Show("Are You Sure To Exit", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (YorN == DialogResult.Yes)
            //{
            //    Application.Exit();
            //}
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process p = null;
                if (p == null)
                {
                    p = new Process();
                    p.StartInfo.FileName = "Calc.exe";
                    p.Start();
                }
                else
                {
                    p.Close();
                    p.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Excepton" + ex.Message);
            }
        }

        private void btn_exitForm_Click(object sender, EventArgs e)
        {
            DialogResult YorN = MessageBox.Show("Are You Sure To Exit", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (YorN == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
        //    if (e.KeyChar == 'm')
                this.WindowState = FormWindowState.Minimized;
        }

        private void btn_Calculator_Click(object sender, EventArgs e)
        {
            try
            {
                Process p = null;
                if (p == null)
                {
                    p = new Process();
                    p.StartInfo.FileName = "Calc.exe";
                    p.Start();
                }
                else
                {
                    p.Close();
                    p.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Excepton" + ex.Message);
            }
        }

        private void customerBalanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frm_TotalBalance();
            frm.MdiParent = this; // assign MdiParent of FormB to FormC
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }
    }
    }


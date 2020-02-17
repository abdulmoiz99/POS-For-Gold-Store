using POS_GoldStore.Setup;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_GoldStore.Transactions
{
    public partial class frm_TotalBalance : Form
    {
        public frm_TotalBalance()
        {
            InitializeComponent();
        }
        private void TotalReceiveable(int CustomerID)
        {
            String CreditCashReceiveable = SQL.ScalarQuery("SELECT SUM(CAST(BalAmt AS decimal(10, 3))) AS [Balance Amount] FROM dbo.TvuFrmCreditSaleOrder where SMCustomerID = " + CustomerID + "  GROUP BY SMCustomerID, CustomerName");
            String CashReceiveable = SQL.ScalarQuery("select  SUM(Balance) as Receiveable from TvuFrmCashMainSummary where [Customer ID] = " + CustomerID + " AND MODE = 'PAY'");
            float fCreditCashReceiveable = 0, fCashReceiveable = 0, TotalReceiveable = 0;
            float.TryParse(CreditCashReceiveable, out fCreditCashReceiveable);
            float.TryParse(CashReceiveable, out fCashReceiveable);
            TotalReceiveable = fCreditCashReceiveable + fCashReceiveable;
            txt_CashReceiveable.Text = TotalReceiveable.ToString();
        }
        private void TotalPayable(int CustomerID)
        {
            String CreditCashPayable = SQL.ScalarQuery("SELECT SUM(CAST(BalAmt AS decimal(10, 3))) AS [Balance Amount] FROM dbo.TvuFrmCreditPurchaseOrder where PMCustomerID = " + CustomerID + "  GROUP BY PMCustomerID, CustomerName");
            String CashReceiveable = SQL.ScalarQuery("select  SUM(Balance) as Receiveable from TvuFrmCashMainSummary where [Customer ID] = " + CustomerID + " AND MODE = 'RECEIVE'");
            float fCreditCashPayable = 0, fCashPayable = 0, TotalPayable = 0;
            float.TryParse(CreditCashPayable, out fCreditCashPayable);
            float.TryParse(CashReceiveable, out fCashPayable);
            TotalPayable = fCreditCashPayable + fCashPayable;
            txt_CashPayable.Text = TotalPayable.ToString();
        }
        private void Checkbalance()
        {
            lab_bal.Visible = true;
            float Receive = 0, Pay = 0, Bal = 0;
            float.TryParse(txt_CashReceiveable.Text, out Receive);
            float.TryParse(txt_CashPayable.Text, out Pay);
            Bal = Receive - Pay;
            lab_bal.Text = Bal.ToString();
            if (Bal >= 0)
            {
                lab_bal.ForeColor = Color.SpringGreen;
            }
            else lab_bal.ForeColor = Color.Red;

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_exitForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            if (cmb_CustomerName.SelectedIndex < 0)
            {
                MessageBox.Show("Please Select Customer First");
            }
            else
            {
                int customerID = 0;
                int.TryParse(cmb_CustomerName.SelectedValue.ToString(), out customerID);
                TotalReceiveable(customerID);
                TotalPayable(customerID);
                Checkbalance();
            }
        }

        private void frm_TotalBalance_Activated(object sender, EventArgs e)
        {
            try
            {
                String CustomerCount = SQL.ScalarQuery("SELECT COUNT(CustomerName) FROM  CustomerMaster WHERE CustomerActive =1 and CompanyID=" + Main.CompanyID + "");


                if (CustomerCount == "0")
                {
                    MessageBox.Show("No Custoemr Is Found Please Enter Customer Details ", "Suggestion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    var frm = new frm_AddCustomer();
                    frm.ShowDialog();
                    //this.Close();
                }
                else
                {
                    Main.fillCombo(cmb_CustomerName, "CustomerMaster", "CustomerName", "CustomerID", "CustomerActive=1");

                }
            }
            catch (Exception ex)
            {

            }
        }

        private void cmb_CustomerName_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_CustomerID.Text = cmb_CustomerName.SelectedValue.ToString();
        }
    }
}

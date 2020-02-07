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
    public partial class CashBalance : Form
    {
        public CashBalance()
        {
            InitializeComponent();
        }
        private void SaleOrderBalance()
        {
            Main.fillDgv(dgv_Balance, @"SELECT        SMCustomerID AS [Customer ID], CustomerName AS [Customer Name], SUM(CAST(SMAmount AS decimal(10, 3))) AS [Total Amount], SUM(CAST(TMAmount AS decimal(10, 3))) AS [Paid Amount], SUM(CAST(BalAmt AS decimal(10, 3))) AS [Balance Amount]
                                        FROM            dbo.TvuFrmCreditSaleOrder
                                        GROUP BY SMCustomerID, CustomerName");
        }
        private void PurchaseOrderBalance()
        {
            Main.fillDgv(dgv_Balance, @"SELECT        PMCustomerID AS [Customer Id], CustomerName AS [Customer Name], SUM(CAST(PMAmount AS decimal(10, 3))) AS [Total Amount], SUM(CAST(TMAmount AS decimal(10, 3))) AS [Paid Amount], SUM(CAST(BalAmt AS decimal(10,3))) AS [Balance Amount]
                                        FROM            dbo.TvuFrmCreditPurchaseOrder
                                        GROUP BY PMCustomerID, CustomerName");
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void rb_SaleTemp_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rb_PurchaseTemp_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_PurchaseBalance.Checked == true)
            {
                PurchaseOrderBalance();
            }
            else SaleOrderBalance();
        }

        private void btn_exitForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
    public partial class frm_TempBalance : Form
    {
        public frm_TempBalance()
        {
            InitializeComponent();
        }
        public void PurchaseTemp()
        {
            Main.fillDgv(dgv_Temp, @"sselect PMCustomerID as Customer_ID ,CustomerName ,PMProductID as Product_ID ,PName as Product_Name  ,sum(ProductWeight) as Total_Weight_Receive ,sum(TMQTy) as Return_Weight ,sum(ProductWeight -TMQTy) as Reamining_Weight 
                                        from TvuFrmTempPaid group by PMCustomerID ,CustomerName ,CompanyID ,PMProductID ,PName ");
        }
        public void SaleTemp()
        {
            Main.fillDgv(dgv_Temp, @"select SMCustomerID as Customer_ID,CustomerName ,SMProductID as Product_ID,PName as Product_Name ,sum(ProductWeight) as Total_Weight_Given ,sum(TMQTy) as Return_Weight ,sum(ProductWeight -TMQTy) as Remaining_Payable 
                                        from TvuFrmTempRec group by SMCustomerID, CustomerName, CompanyID, SMProductID, PName ");
        }
        private void frm_TempBalance_Load(object sender, EventArgs e)
        {
        }

        private void btn_exitForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rb_SaleTemp_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_SaleTemp.Checked == true)
            {
                SaleTemp();
            }
            else PurchaseTemp();
        }
    }
}

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
            Main.fillDgv(dgv_Temp, @"select PMCustomerID ,CustomerName ,CompanyID,PMProductID ,PName  ,sum(ProductWeight) as ProductWeight ,sum(TMQTy) as TMQTy ,sum(ProductWeight -TMQTy) as BalQty 
                                        from TvuFrmTempPaid group by PMCustomerID ,CustomerName ,CompanyID ,PMProductID ,PName ");
        }
        public void SaleTemp()
        {
            Main.fillDgv(dgv_Temp, @"select SMCustomerID ,CustomerName ,CompanyID,SMProductID ,PName  ,sum(ProductWeight) as ProductWeight ,sum(TMQTy) as TMQTy ,sum(ProductWeight -TMQTy) as BalQty 
                                        from TvuFrmTempRec group by SMCustomerID ,CustomerName ,CompanyID ,SMProductID ,PName ");
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

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
    public partial class frm_SaleOrderCredit : Form
    {
        int mode;
        public frm_SaleOrderCredit()
        {
            InitializeComponent();
        }

        private void frm_SaleOrderCredit_Load(object sender, EventArgs e)
        {
            enable_disable(false);
        }

        private void dgv_PruchaseCredit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                if (index > -1)
                {
                    DataGridViewRow selectedrow = dgv_PruchaseCredit.Rows[index];
                    txt_SMID.Text = selectedrow.Cells["PMID"].Value.ToString();
                    txt_InvId.Text = selectedrow.Cells["PMNo"].Value.ToString();
                    txt_CustomerID.Text = selectedrow.Cells["PMCustomerId"].Value.ToString();
                    txt_CustomerName.Text = selectedrow.Cells["CustomerName"].Value.ToString();
                    txt_ProductName.Text = selectedrow.Cells["PName"].Value.ToString();
                    //txt_Rate.Text = selectedrow.Cells["PMRate"].Value.ToString();
                    //txt_Amount.Text = selectedrow.Cells["Amount"].Value.ToString();
                    txt_TotalAmount.Text = selectedrow.Cells["PMAmount"].Value.ToString();
                    txt_BalanceAmount.Text = selectedrow.Cells["BalAmt"].Value.ToString();
                    txt_ProductId.Text = selectedrow.Cells["PMProductID"].Value.ToString();

                }
                index = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frm_SaleOrderCredit_Activated(object sender, EventArgs e)
        {
            Main.fillDgv(dgv_PruchaseCredit, "select SMId,SMNo,SMDate,SMCustomerID,CustomerName,SMProductId,PName,ProductWeight,BalAmt,SMRate,SMAmount from TvuFrmCreditSaleOrder where BalAmt>0");
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            float Quantity;
            if (txt_NewAmount.Text == "")
            {
                MessageBox.Show("Please Enter New Amount", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!float.TryParse(txt_NewAmount.Text, out Quantity))
            {
                MessageBox.Show("Invalid Amount Please Re-Check it", "Warnig", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SQL.NonScalarQuery(@"Insert Into CashTemp (CT_Date                                           ,CT_InvID                         ,CT_Type,CT_CompanyId          ,CT_Amount)
                                                    values('" + dtp_date.Value.Date.ToString("yyyyMMdd") + "'," + int.Parse(txt_SMID.Text) + " ,2      ," + Main.CompanyID + "," + Quantity + ")");
                frm_SaleOrderCredit_Activated(sender, e);
                MessageBox.Show("Record Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void enable_disable(bool value)
        {
            txt_InvId.Enabled = value;
            txt_CustomerID.Enabled = value;
            txt_ProductName.Enabled = value;
            txt_Rate.Enabled = value;
            txt_Amount.Enabled = value;
            txt_TotalAmount.Enabled = value;
            txt_BalanceAmount.Enabled = value;
            txt_NewAmount.Enabled = value;
            dgv_PruchaseCredit.Enabled = value;
        }

        private void btn_New_Click(object sender, EventArgs e)
        {

            mode = 1;
            enable_disable(true);
            btn_New.Enabled = false;
            btn_cancel.Enabled = true;
            btn_Save.Enabled = true;

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            enable_disable(false);
            btn_New.Enabled = true;
            btn_cancel.Enabled = false;
            btn_Save.Enabled = false;
        }

        private void txt_Find_TextChanged(object sender, EventArgs e)
        {
            Main.fillDgv(dgv_PruchaseCredit, "select SMId,SMNo,SMDate,SMCustomerID,CustomerName,PName,ProductWeight,BalAmt,SMRate,SMAmount  from TvuFrmCreditSaleOrder where CompanyID=" + Main.CompanyID + " AND + CAST(SMNo as varchar) + CAST(SMCustomerID as varchar) + CAST(SName as varchar) + Cast(Customername as varchar)  like '%" + txt_Find.Text + "%'");

        }

        private void btn_exitForm_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}

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
    public partial class frm_PurchaseTemp : Form
    {
        int mode;
        public frm_PurchaseTemp()
        {
            InitializeComponent();
        }

        private void frm_PurchaseTemp_Load(object sender, EventArgs e)
        {
            enable_disable(false);
        }

        private void dgv_SaleTemp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                if (index > -1)
                {
                    DataGridViewRow selectedrow = dgv_SaleTemp.Rows[index];
                    txt_SMID.Text = selectedrow.Cells["PMID"].Value.ToString();
                    txt_InvId.Text = selectedrow.Cells["PMNo"].Value.ToString();
                    txt_CustomerID.Text = selectedrow.Cells["PMCustomerId"].Value.ToString();
                    txt_ProductName.Text = selectedrow.Cells["PName"].Value.ToString();
                    txt_Rate.Text = selectedrow.Cells["PMRate"].Value.ToString();
                    txt_Amount.Text = selectedrow.Cells["Amount"].Value.ToString();
                    txt_Quantity.Text = selectedrow.Cells["ProductWeight"].Value.ToString();
                    txt_BalanceQuantity.Text = selectedrow.Cells["BalQty"].Value.ToString();
                    txt_ProductId.Text = selectedrow.Cells["PMProductID"].Value.ToString();

                }
                index = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frm_PurchaseTemp_Activated(object sender, EventArgs e)
        {
            Main.fillDgv(dgv_SaleTemp, "select PMId,PMNo,PMDate,pMCustomerID,PMProductId,PName,ProductWeight,BalQty,PMRate,PMAmount from TvuFrmTempPaid where BalQty>0");

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            float Quantity;
            if (txt_NewQuantity.Text == "")
            {
                MessageBox.Show("Please Enter New Quantity", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!float.TryParse(txt_NewQuantity.Text, out Quantity))
            {
                MessageBox.Show("Invalid Quantity Please Re-Check it", "Warnig", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SQL.NonScalarQuery(@"Insert Into tempmaster (TMDate                      ,TMInvID                          ,TMType,TMCSID                ,TMQty)
                                                      values('" + dtp_date.Value.Date.ToString("yyyyMMdd") + "'," + int.Parse(txt_SMID.Text) + " ,1    ," + Main.CompanyID + "," + Quantity + ")");
                SQL.NonScalarQuery("Update ProductMaster set Pbalance = Pbalance - " + float.Parse(txt_NewQuantity.Text) + " where pID = " + int.Parse(txt_ProductId.Text) + "");

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
            txt_Quantity.Enabled = value;
            txt_BalanceQuantity.Enabled = value;
            txt_NewQuantity.Enabled = value;
            dgv_SaleTemp.Enabled = value;
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
            Main.fillDgv(dgv_SaleTemp, "select PMId,pMNo,pMDate,PMCustomerID,PName,ProductWeight,BalQty,PMRate,PMAmount  from TvuFrmTempPaid where CompanyID=" + Main.CompanyID + " AND + CAST(SMNo as varchar) + CAST(SMCustomerID as varchar) + CAST(PName as varchar)  like '%" + txt_Find.Text + "%'");

        }

        private void btn_exitForm_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}

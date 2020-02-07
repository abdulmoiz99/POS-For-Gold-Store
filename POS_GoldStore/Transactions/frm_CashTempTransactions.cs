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
    public partial class frm_CashTempTransactions : Form
    {
        public frm_CashTempTransactions()
        {
            InitializeComponent();
        }
        public void filldgv(String Mode)
        {
            Main.fillDgv(dgv_PruchaseCredit, "select * from TvufrmCashMain where CM_Mode ='" + Mode + "' AND CompanyID =" + Main.CompanyID + "");

        }
        private void frm_CashTempTransactions_Load(object sender, EventArgs e)
        {
            enable_disable(false);
            rb_Payable_CheckedChanged(sender, e);
        }
        public void enable_disable(bool val)
        {
            txt_CustomerID.Enabled = val;
            txt_CustomerName.Enabled = val;
            txt_TotalAmount.Enabled = val;
            txt_BalanceAmount.Enabled = val;
            txt_NewAmount.Enabled = val;
            dgv_PruchaseCredit.Enabled = val;
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            enable_disable(true);
            btn_New.Enabled = false;
            btn_Save.Enabled = true;
            btn_cancel.Enabled = true;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            enable_disable(false);
            btn_New.Enabled = true;
            btn_Save.Enabled = false;
            btn_cancel.Enabled = false;

        }

        private void btn_exitForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_PruchaseCredit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                if (index > -1)
                {
                    DataGridViewRow selectedrow = dgv_PruchaseCredit.Rows[index];
                    txt_CashMasterID.Text = selectedrow.Cells["CM_ID"].Value.ToString();
                    txt_CustomerID.Text = selectedrow.Cells["CM_CustomerID"].Value.ToString();
                    txt_CustomerName.Text = selectedrow.Cells["CustomerName"].Value.ToString();
                    txt_TotalAmount.Text = selectedrow.Cells["CM_Amount"].Value.ToString();
                    txt_BalanceAmount.Text = selectedrow.Cells["CM_Bal"].Value.ToString();



                }
                index = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rb_Payable_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_Payable.Checked == true)
            {
                filldgv("PAY");
            }
            else
            {
                filldgv("RECEIVE");

            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            float AMOUNT = 0;
            if (txt_NewAmount.Text == "")
            {
                MessageBox.Show("Enter Amount", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!float.TryParse(txt_NewAmount.Text, out AMOUNT))
            {
                MessageBox.Show("Invalid Amount", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                float Remaing = 0, NewAmount = 0;
                float.TryParse(txt_BalanceAmount.Text, out Remaing);
                float.TryParse(txt_NewAmount.Text, out NewAmount);

                if (NewAmount > Remaing)
                {
                    MessageBox.Show("Amount Should Be Less Than Remaing Amount", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    SQL.NonScalarQuery("Update CASHMAIn set CM_Bal = CM_Bal -'" + AMOUNT + "'  where CM_ID = " + txt_CashMasterID.Text + "");
                    MessageBox.Show("Record Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    rb_Payable_CheckedChanged(sender, e);
                }
            }
        }
    }
}

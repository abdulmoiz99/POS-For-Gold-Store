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
    public partial class frm_CashTemp : Form
    {
        public frm_CashTemp()
        {
            InitializeComponent();
        }

        private void frm_CashTemp_Activated(object sender, EventArgs e)
        {
            try
            {
                String CustomerCount = SQL.ScalarQuery("SELECT COUNT(CustomerName) FROM  CustomerMaster WHERE CustomerActive =1 and CompanyID=" + Main.CompanyID + "");
                if (CustomerCount == "0")
                {
                    MessageBox.Show("No Custoemr Is Found Please Enter Customer Details ", "Suggestion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    var frm = new frm_AddCustomer();
                    frm.ShowDialog();
                    this.Close();
                }
                else
                {   
                    Main.fillCombo(cmb_CustomerName, "CustomerMaster", "CustomerName", "CustomerID", "CustomerActive=1");

                }
            }
            catch (Exception)
            {
            }
        }

        private void frm_CashTemp_Load(object sender, EventArgs e)
        {

        }

        private void btn_exitForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmb_CustomerName_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_CustomerId.Text = cmb_CustomerName.SelectedValue.ToString();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            float amount;
            string mode = "RECEIVE";
            if (rb_Pay.Checked == true)
            {
                mode = "PAY";
            }

            if (txt_Amount.Text == "")
            {
                MessageBox.Show("Please Enter Amount", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cmb_CustomerName.SelectedIndex < 0)
            {
                MessageBox.Show("Please Select Customer", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!float.TryParse(txt_Amount.Text, out amount))
            {
                MessageBox.Show("Please Enter Correct Amount", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                SQL.NonScalarQuery(@"Insert into CashMain(CM_Date                                                   ,    CM_CustomerID                      ,CM_Amount     ,CM_Bal        ,CM_Mode          ,CompanyID)
                                                   values('" + dtp_CastTempDate.Value.Date.ToString("yyyyMMdd") + "'," + cmb_CustomerName.SelectedValue + " ," + amount + "," + amount + ",'" + mode + "'   ," + Main.CompanyID + ")");
                MessageBox.Show("Record Added Successfull", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            btn_Save.Enabled = true;
            btn_cancel.Enabled = true;
            btn_New.Enabled = false;
            enable_disable(true);
        }
        private void enable_disable(bool val)
        {
            cmb_CustomerName.Enabled = val;
            txt_Amount.Enabled = val;
            dtp_CastTempDate.Enabled = val;
        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            btn_Save.Enabled = false;
            btn_cancel.Enabled = false;
            btn_New.Enabled = true;
            enable_disable(false);

        }
    }
}

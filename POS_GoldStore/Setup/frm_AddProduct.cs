using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_GoldStore.Setup
{
    public partial class frm_AddProduct : Form
    {
        int mode;
        //String FName = "AddProduct";
        public frm_AddProduct()
        {
            InitializeComponent();
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            mode = 1;
            AllClear();
            btn_edit.Enabled = false;
            btn_Delete.Enabled = false;
            btn_New.Enabled = false;
            btn_cancel.Enabled = true;
            btn_Save.Enabled = true;
            txt_Name.Enabled = true;
            txt_PBalance.Enabled = true;
            txt_Remarks.Enabled = true;

            txt_Name.Focus();
            dgv_BrandSetup.Enabled = false;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            mode = 2;
            btn_edit.Enabled = false;
            btn_New.Enabled = false;
            btn_Delete.Enabled = false;
            btn_Save.Enabled = true;
            btn_cancel.Enabled = true;
            txt_Name.Enabled = true;
            txt_PBalance.Enabled = true;
            txt_Remarks.Enabled = true;
            txt_Name.Focus();
            dgv_BrandSetup.Enabled = true;

        }
        private void AllClear()
        {
            txt_Name.Text = String.Empty;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            float balance = 0;
            int active = 1;
            if (rdo_Yes.Checked == true)
            {
                active = 1;
            }

            else active = 0;
            if (txt_Name.Text == "")
            {
                MessageBox.Show("Please Enter Name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_PBalance.Text == "")
            {
                MessageBox.Show("Please Product Balance ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!float.TryParse(txt_PBalance.Text, out balance))
            {
                MessageBox.Show("Please Correct Product Balance ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (mode == 1)
            {

                {
                    DialogResult YesOrNo = MessageBox.Show("Are you sure To INSERT the current Record", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (YesOrNo == DialogResult.Yes)
                    {
                        SQL.NonScalarQuery("Insert Into ProductMaster(PName,PBalance,PActive,CompanyID) values ('" + txt_Name.Text + "'," + balance + "," + active + "," + Main.CompanyID + ")");
                        AllClear();
                        frm_AddProduct_Load(sender, e);
                        btn_cancel_Click(sender, e);
                        MessageBox.Show("Record Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }

                }  }
            else if (mode == 2)
                {

                    DialogResult YesOrNo = MessageBox.Show("Are you sure To UPDATE the current Record", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (YesOrNo == DialogResult.Yes)
                    {
                        SQL.NonScalarQuery("update ProductMaster set PName='" + txt_Name.Text + "',PActive=" + active + ",PBalance =" + balance + " where PID=" + int.Parse(txt_DataGridViewIndex.Text) + "");
                        AllClear();
                        frm_AddProduct_Load(sender, e);
                        btn_cancel_Click(sender, e);
                        MessageBox.Show("Record Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }

                }
            }

        private void btn_Delete_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            mode = 0;
            btn_edit.Enabled = true;
            btn_Delete.Enabled = false;
            btn_New.Enabled = true;
            btn_cancel.Enabled = false;
            btn_Save.Enabled = false;
            txt_Name.Enabled = false;
            txt_PBalance.Enabled = false;
            txt_Remarks.Enabled = false;

            dgv_BrandSetup.Enabled = true;
        }

        private void txt_Find_TextChanged(object sender, EventArgs e)
        {
            Main.fillDgv(dgv_BrandSetup, "select PID,PName,CONVERT(DECIMAL(10,3),PBalance) AS PBalance,PActive from ProductMaster where CompanyID=" + Main.CompanyID + " AND CAST(PName as varchar) like '%" + txt_Find.Text + "%'");

        }

        private void frm_AddProduct_Load(object sender, EventArgs e)
        {
            Main.fillDgv(dgv_BrandSetup, "select PID,PName,CONVERT(DECIMAL(10,3),PBalance) AS PBalance, Pactive from ProductMaster where CompanyID=" + Main.CompanyID + "");

        }

        private void btn_exitForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_BrandSetup_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                int index = e.RowIndex;
                if (index > -1)
                {
                    txt_DataGridViewIndex.Text = index.ToString();
                    DataGridViewRow selectedrow = dgv_BrandSetup.Rows[index];
                    txt_DataGridViewIndex.Text = selectedrow.Cells["PID"].Value.ToString();
                    txt_Name.Text = selectedrow.Cells["PName"].Value.ToString();
                    txt_PBalance.Text = selectedrow.Cells["PBalance"].Value.ToString();
               //     txt_Remarks.Text = selectedrow.Cells["PRemarks"].Value.ToString();
                    bool active = Convert.ToBoolean(selectedrow.Cells["PActive"].Value.ToString());
                    if (active == true) rdo_Yes.Checked = true;
                    else rdo_No.Checked = true;

                }
                index = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void rdo_No_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdo_Yes_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txt_DataGridViewIndex_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_PBalance_KeyPress(object sender, KeyPressEventArgs e)
        {
            Main.OnlyDigits(e);
        }
    }
}

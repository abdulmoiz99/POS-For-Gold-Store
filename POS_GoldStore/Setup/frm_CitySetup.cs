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
    public partial class frm_CitySetup : Form
    {
        int mode;
        public frm_CitySetup()
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
            txt_Name.Focus();
            dgv_BrandSetup.Enabled = true;
        }
        private void AllClear()
        {
            txt_Name.Text = String.Empty;
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            int active = 1;
            if (rdo_Yes.Checked == true)
            {
                active = 1;
            }

            else active = 0;
            if (mode == 1)
            {
               if (txt_Name.Text == "")
                {
                    MessageBox.Show("Please Enter Name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DialogResult YesOrNo = MessageBox.Show("Are you sure To INSERT the current Record", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (YesOrNo == DialogResult.Yes)
                    {
                        SQL.NonScalarQuery("Insert Into CityMaster(CName,CActive,CompanyID) values ('" + txt_Name.Text + "'," + active + "," + Main.CompanyID + ")");
                        AllClear();
                        frm_CitySetup_Load(sender, e);
                        btn_cancel_Click(sender, e);
                        MessageBox.Show("Record Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }

            }
            else if (mode == 2)
            {
                
                    DialogResult YesOrNo = MessageBox.Show("Are you sure To UPDATE the current Record", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (YesOrNo == DialogResult.Yes)
                    {
                        SQL.NonScalarQuery("update CityMaster set CName='" + txt_Name.Text + "',CActive=" + active + " where CID=" + int.Parse(txt_DataGridViewIndex.Text) + "");
                        AllClear();
                        frm_CitySetup_Load(sender, e);
                        btn_cancel_Click(sender, e);
                        MessageBox.Show("Record Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else MessageBox.Show("You Donot Have The Rights To Update Data", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
              
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
            dgv_BrandSetup.Enabled = true;
        }

        private void txt_Find_TextChanged(object sender, EventArgs e)
        {
            Main.fillDgv(dgv_BrandSetup, "select CID,CName,CActive from CityMaster where CompanyID=" + Main.CompanyID + " AND CAST(CName as varchar) like '%" + txt_Find.Text + "%'");

        }

        private void txt_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgv_BrandSetup_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_Name.Text = "";
                int index = e.RowIndex;
                string active = "";
                int Result;
                if (index > -1)
                {
                    txt_DataGridViewIndex.Text = index.ToString();
                    DataGridViewRow selectedrow = dgv_BrandSetup.Rows[index];
                    txt_DataGridViewIndex.Text = selectedrow.Cells[0].Value.ToString();
                    txt_Name.Text = selectedrow.Cells[1].Value.ToString();
                    active = selectedrow.Cells[2].Value.ToString();
                    Result = string.Compare(active, "False");
                    if (Result == 0)
                    {
                        rdo_No.Checked = true;
                    }
                    else
                    {
                        rdo_Yes.Checked = true;
                    }
                }
                index = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frm_CitySetup_Load(object sender, EventArgs e)
        {
            Main.fillDgv(dgv_BrandSetup, "select CID,CName,Cactive from CityMaster where CompanyID=" + Main.CompanyID + "");

        }
    }
}

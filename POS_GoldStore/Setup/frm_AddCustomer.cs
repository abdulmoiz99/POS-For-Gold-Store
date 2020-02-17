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
    public partial class frm_AddCustomer : Form
    {
        int mode;
        public frm_AddCustomer()
        {
            InitializeComponent();
        }
        private void AllClear()
        {
            txt_CustomerName.Text = String.Empty;
            txt_CustomerFName.Text = String.Empty;
            txt_CustomerCNIC.Text = String.Empty;
            txt_CustomerContactNo.Text = String.Empty;
            txt_CustomerAddress.Text = String.Empty;
        }

        private void btn_exitForm_Click(object sender, EventArgs e)
        {
            this.Close();
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
            txt_CustomerName.Enabled = true;
            txt_CustomerFName.Enabled = true;
            txt_CustomerCNIC.Enabled = true;
            txt_CustomerContactNo.Enabled = true;
            txt_CustomerAddress.Enabled = true;
            cmb_City.Enabled = true;
            dgv_Customer.Enabled = false;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            mode = 2;
            btn_edit.Enabled = false;
            btn_New.Enabled = false;
            btn_Delete.Enabled = false;
            btn_Save.Enabled = true;
            btn_cancel.Enabled = true;
            txt_CustomerName.Enabled = true;
            txt_CustomerFName.Enabled = true;
            txt_CustomerCNIC.Enabled = true;
            txt_CustomerContactNo.Enabled = true;
            txt_CustomerAddress.Enabled = true;
            cmb_City.Enabled = true;
            dgv_Customer.Enabled = true;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            mode = 0;
            btn_edit.Enabled = true;
            btn_Delete.Enabled = false;
            btn_New.Enabled = true;
            btn_cancel.Enabled = false;
            btn_Save.Enabled = false;
            txt_CustomerName.Enabled = false;
            txt_CustomerFName.Enabled = false;
            txt_CustomerCNIC.Enabled = false;
            txt_CustomerContactNo.Enabled = false;
            txt_CustomerAddress.Enabled = false;
            cmb_City.Enabled = false;
            dgv_Customer.Enabled = true;

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            int active = 0;
            if (cb_Active.Checked == true)
            {
                active = 1;
            }
            if (txt_CustomerName.Text == "")
            {
                MessageBox.Show("Please Enter Name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_CustomerFName.Text == "")
            {
                MessageBox.Show("Please Enter Father Name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_CustomerCNIC.Text == "")
            {
                MessageBox.Show("Please Enter CNIC", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_CustomerContactNo.Text == "")
            {
                MessageBox.Show("Please Enter Contact no", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_CustomerAddress.Text == "")
            {
                MessageBox.Show("Please Enter Address        j", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (mode == 1)
            {


                DialogResult YesOrNo = MessageBox.Show("Are you sure To INSERT the current Record", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (YesOrNo == DialogResult.Yes)
                {
                    SQL.NonScalarQuery(@"Insert Into CustomerMaster(            CustomerName            ,CustomerFatherName              ,CustomerCNIC                   ,CustomerContactNo                   ,CustomerAddress                   ,CustomerCityId                ,CustomerActive      ,CompanyID) values 
                                                                        ('" + txt_CustomerName.Text + "','" + txt_CustomerFName.Text + "','" + txt_CustomerCNIC.Text + "','" + txt_CustomerContactNo.Text + "','" + txt_CustomerAddress.Text + "'," + cmb_City.SelectedValue + "," + active + "," + Main.CompanyID + ")");
                    AllClear();
                    frm_AddCustomer_Load(sender, e);
                    btn_cancel_Click(sender, e);
                    MessageBox.Show("Record Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }


            else if (mode == 2)
            {
                DialogResult YesOrNo = MessageBox.Show("Are you sure To UPDATE the current Record", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (YesOrNo == DialogResult.Yes)
                {
                    SQL.NonScalarQuery("update CustomerMaster set CustomerName='" + txt_CustomerName.Text + "',CustomerFatherName='" + txt_CustomerFName.Text + "',CustomerCNIC='" + txt_CustomerCNIC.Text + "',CustomerContactNo='" + txt_CustomerContactNo.Text + "',CustomerAddress='" + txt_CustomerContactNo.Text + "',CustomerCityid=" + cmb_City.SelectedValue + ",CustomerActive="+active+" where CustomerId=" + int.Parse(txt_DataGridViewIndex.Text) + "");
                    AllClear();
                    frm_AddCustomer_Load(sender, e);
                    btn_cancel_Click(sender, e);
                    MessageBox.Show("Record Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else MessageBox.Show("You Donot Have The Rights To Update Data", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void frm_AddCustomer_Load(object sender, EventArgs e)
        {
            try
            {
                String ExpenseSetup = SQL.ScalarQuery("SELECT COUNT(CName) FROM  CityMaster WHERE CActive =1 and CompanyID=" + Main.CompanyID + "");
                if (ExpenseSetup == "0")
                {
                    MessageBox.Show("No City Is Found Please Enter City Details ", "Suggestion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    var frm = new frm_CitySetup();
                    frm.ShowDialog();
                    this.Close();
                }
                else
                {
                    Main.fillCombo(cmb_City, "CityMaster", "CName", "CID", "CActive=1");
                }
            }
            catch (Exception)
            {
            }
        }

        private void frm_AddCustomer_Activated(object sender, EventArgs e)
        {
            Main.fillDgv(dgv_Customer, "select * from CustomerMaster");
        }

        private void dgv_BrandSetup_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                int index = e.RowIndex;
                if (index > -1)
                {
                    txt_DataGridViewIndex.Text = index.ToString();
                    DataGridViewRow selectedrow = dgv_Customer.Rows[index];
                    txt_DataGridViewIndex.Text = selectedrow.Cells["CustomerId"].Value.ToString();
                    txt_CustomerName.Text = selectedrow.Cells["CustomerName"].Value.ToString();
                    txt_CustomerFName.Text = selectedrow.Cells["CustomerFatherName"].Value.ToString();
                    txt_CustomerCNIC.Text = selectedrow.Cells["CustomerCNIC"].Value.ToString();
                    txt_CustomerContactNo.Text = selectedrow.Cells["CustomerContactNo"].Value.ToString();
                    txt_CustomerAddress.Text = selectedrow.Cells["CustomerAddress"].Value.ToString();
                    cmb_City.SelectedValue =int.Parse(selectedrow.Cells["CustomerCityID"].Value.ToString());
                    bool active = Convert.ToBoolean(selectedrow.Cells["CustomerActive"].Value.ToString());
                    if (active == true) cb_Active.Checked = true;
                    else cb_Active.Checked = false;
                }
                index = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_Find_TextChanged(object sender, EventArgs e)
        {
            Main.fillDgv(dgv_Customer, "select Customerid,CustomerName,CustomerFatherName,CustomerCNIC,CustomerContactNo,CustomerCityId,CustomerActive from CustomerMaster where CompanyID=" + Main.CompanyID + " AND CAST(CustomerName as varchar) + CAST(CustomerID as varchar) like '%" + txt_Find.Text + "%'");
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_GoldStore.UserManagement
{
    public partial class frm_ChangeUserPassword : Form
    {
        public frm_ChangeUserPassword()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ChangePassword_Click(object sender, EventArgs e)
        {
            if (Main.checkPassword(Main.UserName, txt_OldPassword.Text) == false)
            {
                MessageBox.Show("Invalid Password ", "", MessageBoxButtons.OK);
            }
            else if (txt_OldPassword.Text == "")
            {
                MessageBox.Show("Please Enter Old Password", "", MessageBoxButtons.OK);
            }
            else if (txt_newPassword.Text == "")
            {
                MessageBox.Show("Please Enter New Password", "", MessageBoxButtons.OK);
            }
            else if (string.Compare(txt_newPassword.Text, txt_OldPassword.Text) == 0)
            {
                MessageBox.Show("Password is same as old password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                DialogResult YorN = MessageBox.Show("Are you sure to update password", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (YorN == DialogResult.Yes)
                {
                    SQL.NonScalarQuery("Update login set Password ='" + txt_newPassword.Text + "' where username='" + Main.UserName + "'");
                    MessageBox.Show("Password Updated Successfull", "Success", MessageBoxButtons.OK);
                    this.Close();
                }
            }
        }

        private void frm_ChangeUserPassword_Load(object sender, EventArgs e)
        {
            lab_user.Text = Main.UserName;
        }
    }
}

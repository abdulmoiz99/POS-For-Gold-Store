using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_GoldStore.UserManagemen
{
    public partial class Frm_SalePurchaseReport : Form
    {
        public Frm_SalePurchaseReport()
        {
            InitializeComponent();
        }
        private bool Check()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(SQL.DataSource))
                {
                    connection.Open();
                    return true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Connrction to the Sql Server Failed Application is Exiting", "Exit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {

            if (cmb_CompanyName.SelectedIndex < 0)
            {
                MessageBox.Show("Please Select Company", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Main.CompanyID = int.Parse(cmb_CompanyName.SelectedValue.ToString());
                if (txt_Username.Text != "")
                {

                    if (txt_Password.Text != "")
                    {
                        if (Main.CheckUserName(txt_Username.Text) == true)
                        {
                            if (Main.checkPassword(txt_Username.Text, txt_Password.Text) == true)
                            {
                                Main.UserName = txt_Username.Text;

                                this.Hide();
                                var NEW = new frm_Main();
                                NEW.ShowDialog();

                            }
                            else MessageBox.Show("Invalid Password", "Login", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        }
                        else MessageBox.Show("Invalid Username", "Login", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    }
                    else MessageBox.Show("Please Enter Password", "Login", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else MessageBox.Show("Please Enter UserName", "Login", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

        }

        private void frm_Login_Load(object sender, EventArgs e)
        {
            if (Check() == false)
            {
                Application.Exit();
            }
            else
            {
                String Company = SQL.ScalarQuery("SELECT COUNT(CompanyID) FROM CompanySetup where CompanyActive=1");
                if (Company == "0")
                {
                    MessageBox.Show("No Company Is Created " + System.Environment.NewLine + "Please Create A company First ", "Suggestion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    try
                    {
                        this.Hide();
                        // var frm = new frm_AddRole();
                        //frm.ShowDialog();
                        this.Close();
                    }
                    catch (Exception)
                    {
                    }
                }
                else
                {
                    Main.getCompany(cmb_CompanyName, "CompanySetup", "CompanyName", "CompanyId", "CompanyActive=1");
                    txt_Username.Focus();
                }
            }
        }

        private void txt_Password_Enter(object sender, EventArgs e)
        {
            txt_Password.PasswordChar = '●';
        }
    }
}

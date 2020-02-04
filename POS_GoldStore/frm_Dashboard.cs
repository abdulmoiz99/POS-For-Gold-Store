using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_GoldStore
{
    public partial class frm_Dashboard : Form
    {
        public frm_Dashboard()
        {
            InitializeComponent();
        }
        private void TodayDetails()
        {
            lab_PurchaeAmount.Text = SQL.ScalarQuery("select PurchaseAmt from tvufrmDashboardSummary where convert(varchar,recdate,112) ='" + dateTimePicker1.Value.Date.ToString("yyyyMMdd") + "'");
            lab_SaleAmount.Text = SQL.ScalarQuery("select SaleAmt from tvufrmDashboardSummary where convert(varchar,recdate,112) ='" + dateTimePicker1.Value.Date.ToString("yyyyMMdd") + "'");
            lab_PurchaseRetAmt.Text = SQL.ScalarQuery("select PurchaseRetAmt from tvufrmDashboardSummary where convert(varchar,recdate,112) ='" + dateTimePicker1.Value.Date.ToString("yyyyMMdd") + "'");
            lab_SaleRetAmt.Text = SQL.ScalarQuery("select SaleRetAmt from tvufrmDashboardSummary where convert(varchar,recdate,112) ='" + dateTimePicker1.Value.Date.ToString("yyyyMMdd") + "'");
            lab_TempPaid.Text = SQL.ScalarQuery("select TempPaid from tvufrmDashboardSummary where convert(varchar,recdate,112) ='" + dateTimePicker1.Value.Date.ToString("yyyyMMdd") + "'");
            lab_TempRec.Text = SQL.ScalarQuery("select SaleTempRec from tvufrmDashboardSummary where convert(varchar,recdate,112) ='" + dateTimePicker1.Value.Date.ToString("yyyyMMdd") + "'");
        }
        private void TodayExpense()
        {
            Main.fillDgv(dgv_Expense, "select ESName,EAmount from TvuExpenses where convert(varchar, EDate, 112) = '" + dateTimePicker1.Value.Date.ToString("yyyyMMdd") + "'");
        }
        public bool CheckTodayOpening()
        {
            string Compare = "";
            Compare = SQL.ScalarQuery("SELECT CASE WHEN EXISTS(SELECT TOP 1 * FROM DailyCounter  WHERE DCDate= (select convert(date, GETDATE()))) THEN CAST (1 AS BIT) ELSE CAST (0 AS BIT) END");
            if (string.Compare("True", Compare) == 0) return true;
            else return false;
        }






        private void frm_Dashboard_Load(object sender, EventArgs e)
        {
            try
            {
                TodayDetails();
                TodayExpense();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {

                // Company Name 
                lab_CompanyName.Text = "TECH WORK";// SQL.ScalarQuery("Select CompanyName From CompanySetup where CompanyID=" + Main.CompanyID + "");
                lab_Username.Text = Main.UserName;

            }
            catch (Exception ex)
            {
                //  MessageBox.Show(ex.Message);
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            txt_OpeningBalance.Enabled = false;
            btn_Update.Enabled = false;
            btn_OpenCounter.Enabled = true;
            float OpeningBal = 0;// float.Parse(txt_OpeningBalance.Text);
            if (txt_OpeningBalance.Text == "")
            {
                MessageBox.Show("Please Enter Opening Amount");
            }
            else if (!float.TryParse(txt_OpeningBalance.Text, out OpeningBal))
            {
                MessageBox.Show("Unable To Get Amount", "Warining", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult YorN = MessageBox.Show("Are You Sure To Update The Opening Balance", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (YorN == DialogResult.Yes)
                {
                    if (CheckTodayOpening() == true)
                    {
                        MessageBox.Show("Todays Counter Is Already Open. Do you Want To Update The Counter Value", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        SQL.NonScalarQuery("update dailycounter set DCOpBal =" + OpeningBal + " where DCDate=(select convert(date,GETDATE()))");
                    }
                    else
                    {
                        SQL.NonScalarQuery(@"Insert Into DailyCounter (DCDate,DCopBal,CompanyID)
                                                        values('" + DateTime.Now.ToString("yyyyMMdd") + "'," + OpeningBal + "," + Main.CompanyID + ")");
                    }
                    MessageBox.Show("Balance Updated Successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btn_OpenCounter_Click(object sender, EventArgs e)
        {
            txt_OpeningBalance.Enabled = true;
            btn_Update.Enabled = true;
            btn_OpenCounter.Enabled = false;
            txt_OpeningBalance.Text = string.Empty;
        }

        private void txt_OpeningBalance_KeyPress(object sender, KeyPressEventArgs e)
        {
            Main.OnlyDigits(e);
        }

        private void dateTime(object sender, EventArgs e)
        {
            lab_date.Text = DateTime.Now.ToString();
            TodayDetails();

        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

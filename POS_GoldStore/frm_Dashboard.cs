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
            Lab_TodayPurchase.Text = SQL.ScalarQuery("SELECT isnull(Sum(PMTAmount),0) FROM PurchaseMASTER where PMMode='Cash' And PMDate=(select convert(date, GETDATE()))");
            Lab_TodaySale.Text = SQL.ScalarQuery("SELECT isnull(Sum(SMTAmount),0) FROM SaleMASTER where SMMode='Cash' And SMDate=(select convert(date, GETDATE()))");
            String CashPaid = SQL.ScalarQuery("SELECT COUNT(Paid) FROM TvuFrmDailyCounter  where  RecDate=(select convert(date, GETDATE()))");
            if (CashPaid != "0")
            {
                Lab_TodayPaid.Text = SQL.ScalarQuery("SELECT Sum(Paid) FROM TvuFrmDailyCounter where  RecDate=(select convert(date, GETDATE()))");
            }
            else Lab_TodayPaid.Text = "0";
            String CashRec = SQL.ScalarQuery("SELECT COUNT(receive) FROM TvuFrmDailyCounter where  RecDate=(select convert(date, GETDATE()))");
            if (CashRec != "0")
            {
                Lab_TodayReceive.Text = SQL.ScalarQuery("SELECT Sum(receive) FROM TvuFrmDailyCounter where  RecDate=(select convert(date, GETDATE()))");
            }
            else Lab_TodayReceive.Text = "0";
        }
        public bool CheckTodayOpening()
        {
            string Compare = "";
            Compare = SQL.ScalarQuery("SELECT CASE WHEN EXISTS(SELECT TOP 1 * FROM DailyCounter  WHERE DCDate= (select convert(date, GETDATE()))) THEN CAST (1 AS BIT) ELSE CAST (0 AS BIT) END");
            if (string.Compare("True", Compare) == 0) return true;
            else return false;
        }
        private void TodayProfit()
        {
            lab_TodayProfit.Text = SQL.ScalarQuery("select isnull(sum((Opening-(Payamt+Paid))+(recamt+receive)),0) from TvuFrmDailyCounter where RecDate=(select convert(date,GETDATE()))");
            float Profit;
            if (float.TryParse(lab_TodayProfit.Text, out Profit))
            {
                if (Profit <= 0)
                {
                    pnl_Profit.BackColor = Color.FromArgb(243, 92, 86);
                }
                else pnl_Profit.BackColor = Color.FromArgb(26, 161, 95);
            }
            lab_TodayProfit.Text = Profit.ToString();
        }
  
       
        private void CashFlowAmount()
        {
            string PAmt = SQL.ScalarQuery("SELECT isnull(SUM(CFAmt),0) FROM CashFlow WHERE CFMode = 'PAYABLE'");
            String RAmt = SQL.ScalarQuery("SELECT isnull(SUM(CFAmt),0) FROM CashFlow WHERE CFMode = 'RECEIVABLE'");
            lab_PayAmt.Text = PAmt + "/-";
            lab_RecAmt.Text = RAmt + "/-";
        }
        private void TodayExpense()
        {
            Main.fillDgv(dgv_Expense, "select ESName ,EAmount from TvuExpenses  where EDate=(select convert(date,GETDATE()))");
            String TAmt = SQL.ScalarQuery("SELECT isnull(SUM(EAmount),0) FROM TvuExpenses WHERE EDate=(select convert(date,GETDATE()));");
            if (TAmt == "0")
            {
                lab_ExpenseTotal.Text = "0/-";
            }
            else lab_ExpenseTotal.Text = TAmt + "/-";
            if (dgv_Expense.RowCount <= 0)
            {
                pnl_Expense.Visible = true;
            }
        }

        private void frm_Dashboard_Load(object sender, EventArgs e)
        {
            try
            {
                TodayDetails();
                TodayExpense();
                CashFlowAmount();
                TodayProfit();
               
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
        }
    }
}

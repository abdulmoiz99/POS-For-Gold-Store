﻿using System;
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
            lab_RecCash.Text = SQL.ScalarQuery("select ReceiveAmt from tvufrmDashboardSummary where convert(varchar,recdate,112) ='" + dateTimePicker1.Value.Date.ToString("yyyyMMdd") + "'");
            lab_PaidCash.Text = SQL.ScalarQuery("select PaidAmt from tvufrmDashboardSummary where convert(varchar,recdate,112) ='" + dateTimePicker1.Value.Date.ToString("yyyyMMdd") + "'");
            lab_Expense.Text = SQL.ScalarQuery("select Expense from tvufrmDashboardSummary where convert(varchar,recdate,112) ='" + dateTimePicker1.Value.Date.ToString("yyyyMMdd") + "'");
            lab_CashTempReceive.Text = SQL.ScalarQuery("select CashTempReceive from tvufrmDashboardSummary where convert(varchar,recdate,112) ='" + dateTimePicker1.Value.Date.ToString("yyyyMMdd") + "'");
            lab_CashTempPay.Text = SQL.ScalarQuery("select CashTempPay from tvufrmDashboardSummary where convert(varchar,recdate,112) ='" + dateTimePicker1.Value.Date.ToString("yyyyMMdd") + "'");


            lab_ClosingBalance.Text = SQL.ScalarQuery("select ClosingBal from tvufrmDashboardSummary where convert(varchar,recdate,112) ='" + dateTimePicker1.Value.Date.ToString("yyyyMMdd") + "'");
            lab_PervClosing.Text = SQL.ScalarQuery("select ClosingBal from tvufrmDashboardSummary where convert(varchar,recdate,112) ='" + dateTimePicker1.Value.Date.ToString("yyyyMMdd") + "' -1");
            lab_OpeningBalance.Text = SQL.ScalarQuery("select Opbal from tvufrmDashboardSummary where convert(varchar,recdate,112) ='" + dateTimePicker1.Value.Date.ToString("yyyyMMdd") + "'");
            lab_CashReceiveable.Text = SQL.ScalarQuery("Select ((select SUM(CM_Bal) from TvuFrmCashMain where CM_Mode ='PAY')+(select SUM(BalAmt) as Receiveable from TvuFrmCreditSaleOrder)) as Payabel");
            lab_CashPayable.Text = SQL.ScalarQuery("Select ((select SUM(CM_Bal) from TvuFrmCashMain where CM_Mode ='RECEIVE')+(select SUM(BalAmt) as Receiveable from TvuFrmCreditPurchaseOrder)) as Payable");


        }
        private void TodayExpense()
        {
            Main.fillDgv(dgv_Expense, "select ESName,EAmount from TvuExpenses where convert(varchar, EDate, 112) = '" + dateTimePicker1.Value.Date.ToString("yyyyMMdd") + "'");
        }
        private void TotalProductPayableReceiveable()
        {
            Main.fillDgv(dgv_ProductWeight, "Select PName,Payable,Receiveable from TvufrmProductdetails");
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
                Main.fillDgv(dgv_ProductWeight, @"select * from TvuFrmProductSummary");
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
            //TodayDetails();
            // Main.fillDgv(dgv_ProductWeight, "Select * from TvufrmProductSummary");
          
      


        }
        public static bool CheckRecord(string name)
        {
            string Compare = "";
            Compare = SQL.ScalarQuery("SELECT CASE WHEN EXISTS (SELECT TOP 1 * FROM login  WHERE username = '" + name + "' And CompanyID=" + Main.CompanyID + ") THEN CAST (1 AS BIT) ELSE CAST (0 AS BIT) END");
            if (string.Compare("True", Compare) == 0) return true;
            else return false;
        }
        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btn_exitForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

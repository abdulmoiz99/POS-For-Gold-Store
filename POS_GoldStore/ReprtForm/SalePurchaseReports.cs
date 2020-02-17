using CrystalDecisions.CrystalReports.Engine;
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

namespace POS_GoldStore.ReprtForm
{
    public partial class SalePurchaseReports : Form
    {
        public SalePurchaseReports()
        {
            InitializeComponent();
        }

        private void btn_exitForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SalePurchaseReports_Load(object sender, EventArgs e)
        {
            cmb_Mode.SelectedIndex = 0;
        }
        private void AllPurchase()
        {
            try
            {
                if (SQL.Con.State == ConnectionState.Open)
                {
                    SQL.Con.Close();
                }
                SQL.Con.Open();
                Cursor = Cursors.WaitCursor;
                ReportDocument myReport = new ReportDocument();
                string reportPath = (Application.StartupPath + @"\Reports\PurchaseDetails.rpt");
                var ds = new DataSet();
                String SqlQuery = " select * from PurchaseMaster where CONVERT(varchar, PMDate,112) between '" + dtp_FromDate.Value.Date.ToString("yyyyMMdd") + "' AND '" + dtp_ToDate.Value.Date.ToString("yyyyMMdd") + "'";
                var adapter = new SqlDataAdapter(SqlQuery, SQL.Con);
                adapter.Fill(ds, "PurchaseMaster");
                myReport.Load(reportPath);
                myReport.SetDataSource(ds);
                var frm = new frm_ReportForm();
                frm.crystalReportViewer1.ReportSource = myReport;
                frm.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                SQL.Con.Close();
                Cursor = Cursors.Default;
            }
        }
        private void CustomPurchses(String Mode)
        {
            try
            {
                if (SQL.Con.State == ConnectionState.Open)
                {
                    SQL.Con.Close();
                }
                SQL.Con.Open();
                Cursor = Cursors.WaitCursor;
                ReportDocument myReport = new ReportDocument();
                string reportPath = (Application.StartupPath + @"\Reports\PurchaseDetails.rpt");
                var ds = new DataSet();
                String SqlQuery = " select * from PurchaseMaster where PMMode ='"+Mode+"' AND CONVERT(varchar, PMDate,112) between '" + dtp_FromDate.Value.Date.ToString("yyyyMMdd") + "' AND '" + dtp_ToDate.Value.Date.ToString("yyyyMMdd") + "'";
                var adapter = new SqlDataAdapter(SqlQuery, SQL.Con);
                adapter.Fill(ds, "PurchaseMaster");
                myReport.Load(reportPath);
                myReport.SetDataSource(ds);
                var frm = new frm_ReportForm();
                frm.crystalReportViewer1.ReportSource = myReport;
                frm.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                SQL.Con.Close();
                Cursor = Cursors.Default;
            }
        }
        private void btn_Generate_Click(object sender, EventArgs e)
        {
            if (cmb_Mode.SelectedIndex < 0)
            {
                MessageBox.Show("Please Select Mode", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (rb_Purchase.Checked == true)
            {
                if (cmb_Mode.SelectedIndex == 0)
                {
                    AllPurchase();
                }
                else
                {
                    CustomPurchses(cmb_Mode.Text);
                }
            }
            else
            {

            }
        }

    }
}

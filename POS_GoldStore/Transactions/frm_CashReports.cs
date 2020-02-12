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
    public partial class frm_CashReports : Form
    {
        public frm_CashReports()
        {
            InitializeComponent();
        }

        private void btn_exitForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rb_Payable_CheckedChanged(object sender, EventArgs e)
        {
            if(rb_Payable.Checked==true)
            {
                Main.fillDgv(dgv_List, "select * from TvuFrmCashMainSummary where MODE= 'PAY'");
            }
            else
            {
                Main.fillDgv(dgv_List, "select * from TvuFrmCashMainSummary where MODE ='RECEIVE'");

            }
        }
        private void Search(string MODE,string search)
        {
            Main.fillDgv(dgv_List, "select * from TvuFrmCashMainSummary  Where Mode = '"+MODE+"' AND Cast(Customer_Name as varchar) like '%"+search+"%'");
        }
        private void txt_Find_TextChanged(object sender, EventArgs e)
        {
            if(rb_Payable.Checked==true)
            {
                Search("PAY", txt_Find.Text);
            }
            else Search("RECEIVE", txt_Find.Text);
             
        }
    }
}

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
                Main.fillDgv(dgv_Temp, "select * from TvuFrmCashMainSummary where MODE= 'PAY'");
            }
            else
            {
                Main.fillDgv(dgv_Temp, "select * from TvuFrmCashMainSummary where MODE ='RECEIVE'");

            }
        }
    }
}

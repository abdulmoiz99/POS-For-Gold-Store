using POS_GoldStore.Setup;
using POS_GoldStore.Transactions;
using POS_GoldStore.UserManagement;
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
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            try
            {
                //FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                Left = Top = 0;
                Width = Screen.PrimaryScreen.WorkingArea.Width;
                Height = Screen.PrimaryScreen.WorkingArea.Height;
                //var frm = new frm_Main();
                //frm.MdiParent = this; // assign MdiParent of FormB to FormC
                //frm.Dock = DockStyle.Fill;
                //frm.Show();

            }
            catch (Exception)
            {
            }
        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var frm = new frm_AddProduct();
                frm.MdiParent = this; // assign MdiParent of FormB to FormC
                frm.Dock = DockStyle.Fill;
                frm.Show();

            }
            catch (Exception)
            {
            }
        }

        private void addPartyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var frm = new frm_AddCustomer();
                frm.MdiParent = this; // assign MdiParent of FormB to FormC
                frm.Dock = DockStyle.Fill;
                frm.Show();

            }
            catch (Exception)
            {
            }
        }

        private void purchaseOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var frm = new frm_PurchaseOrder();
                frm.MdiParent = this; // assign MdiParent of FormB to FormC
                frm.Dock = DockStyle.Fill;
                frm.Show();

            }
            catch (Exception)
            {
            }
        }

        private void saleOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var frm = new frm_SaleOrder();
                frm.MdiParent = this; // assign MdiParent of FormB to FormC
                frm.Dock = DockStyle.Fill;
                frm.Show();

            }
            catch (Exception)
            {
            }
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var frm = new frm_ChangeUserPassword();
                frm.MdiParent = this; // assign MdiParent of FormB to FormC
                frm.Dock = DockStyle.Fill;
                frm.Show();

            }
            catch (Exception)
            {
            }
        }

        private void voucherSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var frm = new frm_DocSetup();
                frm.MdiParent = this; // assign MdiParent of FormB to FormC
                frm.Dock = DockStyle.Fill;
                frm.Show();

            }
            catch (Exception)
            {
            }
        }
    }
}

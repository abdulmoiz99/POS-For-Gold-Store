using POS_GoldStore.Setup;
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
    public partial class frm_SaleOrder : Form
    {
        int intSMNoo;
        int mode;
        string TransactionMode;
        public void AmountFormula()
        {
            double Weight = 0;
            double Rate = 0;
            double.TryParse(txt_ProductWeight.Text, out Weight);
            double.TryParse(txt_ProductRate.Text, out Rate);
            double Amount = (Weight / 11.664) * Rate;
            double output = ((double)((int)(Amount * 1000.0))) / 1000.0;
            txt_Amount.Text = output.ToString();
            lab_Amount.Text = output.ToString();
            ReturnBalance();
        }
        public void enable_disable(bool TorF)
        {
            cmb_CustomerName.Enabled = TorF;
            txt_CICellNo.Enabled = TorF;
            txt_CIRemarks.Enabled = TorF;
            cmb_ProductName.Enabled = TorF;
            txt_ProductWeight.Enabled = TorF;
            txt_ProductRate.Enabled = TorF;
            dtp_InvoiceDate.Enabled = TorF;
        }
        public void GenerateInvoiceNo()
        {
            try
            {
                String DocNo = SQL.ScalarQuery("Select DocNo from DocType where DocType='Sale' and CompanyId=" + Main.CompanyID + "");
                txt_InvoiceNo.Text = DocNo;
                string Compare = "";
                Compare = SQL.ScalarQuery("SELECT CASE WHEN EXISTS (SELECT TOP 1 * FROM SaleMaster  WHERE SMDocId =" + cmb_InvoiceType.SelectedValue + " ) THEN CAST (1 AS BIT) ELSE CAST (0 AS BIT) END");
                if (string.Compare("True", Compare) == 0)
                {
                    String SMNoo = SQL.ScalarQuery("Select SMNoo from SaleMaster where SMId=(SELECT MAX(SMId) FROM SaleMaster)");
                    if (SMNoo != "")
                    {
                        intSMNoo = int.Parse(SMNoo) + 1;
                        txt_InvoiceNo.Text += intSMNoo.ToString();
                    }
                }
                else
                {
                    String SMNoo = SQL.ScalarQuery("select DocStartFrom from DocType where DocId=" + cmb_InvoiceType.SelectedValue + " ");
                    if (SMNoo != "")
                    {
                        intSMNoo = int.Parse(SMNoo);
                        txt_InvoiceNo.Text += intSMNoo.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("123" + ex.Message);
            }
        }
        public void getTransactionMode()
        {
            if (rdo_Cash.Checked == true)
            {
                TransactionMode = "CASH";
            }
            else if (rdo_Credit.Checked == true)
            {
                TransactionMode = "CREDIT";
            }
            if (rdo_Temp.Checked == true)
            {
                TransactionMode = "TEMP";
            }
        }
        public void GetCustomerDetails()
        {
            txt_CICellNo.Text = SQL.ScalarQuery("Select CustomerContactNo from CustomerMaster where CustomerId=" + cmb_CustomerName.SelectedValue + "");
            txt_CustomerId.Text = SQL.ScalarQuery("Select CustomerId from CustomerMaster where CustomerId=" + cmb_CustomerName.SelectedValue + "");
            txt_CustomerId.Enabled = false;
        }
        public frm_SaleOrder()
        {
            InitializeComponent();
            lab_Weight.Text = "";
            lab_Rec.Text = "";
            lab_Return.Text = "";
            lab_Amount.Text = "";
        }

        private void btn_exitForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_SaleOrder_Activated(object sender, EventArgs e)
        {
            try
            {
                String CustomerCount = SQL.ScalarQuery("SELECT COUNT(CustomerName) FROM  CustomerMaster WHERE CustomerActive =1 and CompanyID=" + Main.CompanyID + "");
                String ProductCount = SQL.ScalarQuery("SELECT COUNT(PName) FROM  ProductMaster WHERE PActive =1 and CompanyID=" + Main.CompanyID + "");
                String PurchaseInvType = SQL.ScalarQuery("SELECT COUNT(DocType) FROM  DocType WHERE Doctype ='Sale' and CompanyID=" + Main.CompanyID + "");

                if (CustomerCount == "0")
                {
                    MessageBox.Show("No Custoemr Is Found Please Enter Customer Details ", "Suggestion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    var frm = new frm_AddCustomer();
                    frm.ShowDialog();
                    //this.Close();
                }
                else if (ProductCount == "0")
                {
                    MessageBox.Show("No Product Is Found Please Enter Product Details ", "Suggestion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    var frm = new frm_AddProduct();
                    frm.ShowDialog();
                    //this.Close();
                }
                else if (PurchaseInvType == "0")
                {
                    MessageBox.Show("No Voucher Is Found Please Enter Voucher Detials ", "Suggestion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    var frm = new frm_AddProduct();
                    frm.ShowDialog();
                    //this.Close();
                }
                else
                {
                    Main.fillCombo(cmb_CustomerName, "CustomerMaster", "CustomerName", "CustomerID", "CustomerActive=1");
                    Main.fillCombo(cmb_ProductName, "ProductMaster", "PName", "PID", "PActive=1");
                    Main.fillCombo(cmb_InvoiceType, "Doctype", "Doctype", "DocID", "Doctype='Sale'");

                }
            }
            catch (Exception)
            {
            }
            GenerateInvoiceNo();
          //  cmb_InvoiceType.SelectedIndex = 1;
        }

        private void cmb_CustomerName_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetCustomerDetails();
        }

        private void txt_ProductWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            Main.OnlyDigits(e);
        }

        private void txt_ProductWeight_TextChanged(object sender, EventArgs e)
        {
            AmountFormula();
            lab_Weight.Text = txt_ProductWeight.Text;
        }

        private void txt_ProductRate_TextChanged(object sender, EventArgs e)
        {
            AmountFormula();
        }

        private void frm_SaleOrder_Load(object sender, EventArgs e)
        {
            enable_disable(false);
            Main.fillDgv(dgv_ProductDetails, "Select PName , PBalance from ProductMaster Where PActive = 1 and CompanyID =" + Main.CompanyID + "");
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            mode = 1;
            enable_disable(true);
            btn_New.Enabled = false;
            btn_cancel.Enabled = true;
            btn_Save.Enabled = true;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            mode = 0;
            enable_disable(false);
            btn_New.Enabled = true;
            btn_cancel.Enabled = false;
            btn_Save.Enabled = false;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (cmb_CustomerName.SelectedIndex < 0)
            {
                MessageBox.Show("Please Select Customer Name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_ProductWeight.Text == "")
            {
                MessageBox.Show("Please Enter Product Weight", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_ProductRate.Text == "")
            {
                MessageBox.Show("Please Enter Product Rate", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                getTransactionMode();
                SQL.NonScalarQuery(@"Insert into SaleMaster(SMDocId                             ,SMNo                         ,SMNoo           ,SMDate                                                   ,SMCustomerID                           ,SMRemarks                   ,SMProductID                          ,ProductWeight                                , SMRate                                    ,SMAmount                              ,SMMode                                                       ,CompanyID)
                                                         values(" + cmb_InvoiceType.SelectedValue + ",'" + txt_InvoiceNo.Text + "'," + intSMNoo + ",'" + dtp_InvoiceDate.Value.Date.ToString("yyyyMMdd") + "'," + cmb_CustomerName.SelectedValue + " ,'" + txt_CIRemarks.Text + "'," + cmb_ProductName.SelectedValue + ",'" + float.Parse(txt_ProductWeight.Text) + "','" + float.Parse(txt_ProductRate.Text) + "','" + float.Parse(txt_Amount.Text) + "','" + TransactionMode + "'," + Main.CompanyID + ")");
                SQL.NonScalarQuery("Update ProductMaster set Pbalance = Pbalance - " + float.Parse(txt_ProductWeight.Text) + " where pID = " + cmb_ProductName.SelectedValue + "");

                MessageBox.Show("Record Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GenerateInvoiceNo();
                frm_SaleOrder_Load(sender, e);
            }
        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }
        public void ReturnBalance()
        {
            double received;
            double.TryParse(txt_Received.Text, out received);
            double Total = received - Convert.ToDouble(txt_Amount.Text);
            Total = Math.Round(Total, 0);
            txt_Return.Text = Total.ToString();
            lab_Return.Text = Total.ToString();

        }
        private void txt_Received_TextChanged(object sender, EventArgs e)
        {
            ReturnBalance();
            lab_Rec.Text = txt_Received.Text;
        }

        private void txt_Received_TextChanged_1(object sender, EventArgs e)
        {
            ReturnBalance();
            lab_Rec.Text = txt_Received.Text;
        }
    }

}

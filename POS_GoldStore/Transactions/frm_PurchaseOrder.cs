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
    public partial class frm_PurchaseOrder : Form
    {
        int intPMNoo;
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
                String DocNo = SQL.ScalarQuery("Select DocNo from DocType where DocType='Purchase' and CompanyId=" + Main.CompanyID + "");
                txt_InvoiceNo.Text = DocNo;
                string Compare = "";
                Compare = SQL.ScalarQuery("SELECT CASE WHEN EXISTS (SELECT TOP 1 * FROM PurchaseMaster  WHERE PMDocId =" + cmb_InvoiceType.SelectedValue + " ) THEN CAST (1 AS BIT) ELSE CAST (0 AS BIT) END");
                if (string.Compare("True", Compare) == 0)
                {
                    String PMNoo = SQL.ScalarQuery("Select PMNoo from PurchaseMaster where PMId=(SELECT MAX(PMId) FROM PurchaseMaster)");
                    if (PMNoo != "")
                    {
                        intPMNoo = int.Parse(PMNoo) + 1;
                        txt_InvoiceNo.Text += intPMNoo.ToString();
                    }
                }
                else
                {
                    String PMNoo = SQL.ScalarQuery("select DocStartFrom from DocType where DocId=" + cmb_InvoiceType.SelectedValue + " ");
                    if (PMNoo != "")
                    {
                        intPMNoo = int.Parse(PMNoo);
                        txt_InvoiceNo.Text += intPMNoo.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
        public frm_PurchaseOrder()
        {
            InitializeComponent();
            lab_Weight.Text = "";
            lab_Rec.Text = "";
            lab_Return.Text = "";
            lab_Amount.Text = "";
        }
        public void AllClear()
        {
            txt_CIRemarks.Text = "";
            txt_ProductWeight.Text = "";
            txt_ProductRate.Text = "";
            txt_Amount.Text = "";
            txt_Given.Text = "";
            txt_Return.Text = "";
        }
        private void btn_exitForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_PurchaseOrder_Activated(object sender, EventArgs e)
        {
            try
            {
                String CustomerCount = SQL.ScalarQuery("SELECT COUNT(CustomerName) FROM  CustomerMaster WHERE CustomerActive =1 and CompanyID=" + Main.CompanyID + "");
                String ProductCount = SQL.ScalarQuery("SELECT COUNT(PName) FROM  ProductMaster WHERE PActive =1 and CompanyID=" + Main.CompanyID + "");
                String PurchaseInvType = SQL.ScalarQuery("SELECT COUNT(DocType) FROM  DocType WHERE Doctype ='Purchase' and CompanyID=" + Main.CompanyID + "");

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
                    Main.fillCombo(cmb_InvoiceType, "Doctype", "Doctype", "DocID", "Doctype='Purchase'");

                }
            }
            catch (Exception)
            {
            }
            GenerateInvoiceNo();

        }
        public void GetCustomerDetails()
        {
            txt_CICellNo.Text = SQL.ScalarQuery("Select CustomerContactNo from CustomerMaster where CustomerId=" + cmb_CustomerName.SelectedValue + "");
            txt_CustomerId.Text = SQL.ScalarQuery("Select CustomerId from CustomerMaster where CustomerId=" + cmb_CustomerName.SelectedValue + "");
            txt_CustomerId.Enabled = false;
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

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void frm_PurchaseOrder_Load(object sender, EventArgs e)
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
            float PWeight = 0, PAmount = 0;
            if (cmb_CustomerName.SelectedIndex < 0)
            {
                MessageBox.Show("Please Select Customer Name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_ProductWeight.Text == "")
            {
                MessageBox.Show("Please Enter Product Weight", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_ProductRate.Text == "" && rdo_Temp.Checked == false)
            {
                MessageBox.Show("Please Enter Product Rate", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!float.TryParse(txt_ProductWeight.Text, out PWeight))
            {
                MessageBox.Show("Invalid Product Weight", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!float.TryParse(txt_ProductRate.Text, out PAmount))
            {
                MessageBox.Show("Invalid Product Rate", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                float Rate;
                if (rdo_Temp.Checked == true)
                {
                    Rate = 0;
                }
                else Rate = float.Parse(txt_ProductRate.Text);
                getTransactionMode();
                SQL.NonScalarQuery(@"Insert into PurchaseMaster(PMDocId                              ,PMNo                        ,PMNoo           ,PMDate                                                   ,PMCustomerID                           ,PMRemarks                   ,PMProductID                          ,ProductWeight    ,PMRate        ,PMAmount         ,PMMode                  ,PMDueDate                                                 ,CompanyID)
                                                         values(" + cmb_InvoiceType.SelectedValue + ",'" + txt_InvoiceNo.Text + "'," + intPMNoo + ",'" + dtp_InvoiceDate.Value.Date.ToString("yyyyMMdd") + "'," + cmb_CustomerName.SelectedValue + " ,'" + txt_CIRemarks.Text + "'," + cmb_ProductName.SelectedValue + ",'" + PWeight + "','" + Rate + "','" + PAmount + "','" + TransactionMode + "','" + dtp_InvoiceDate.Value.Date.ToString("yyyyMMdd") + "'," + Main.CompanyID + ")");


                SQL.NonScalarQuery("Update ProductMaster set Pbalance = Pbalance + " + float.Parse(txt_ProductWeight.Text) + " where pID = " + cmb_ProductName.SelectedValue + "");
                MessageBox.Show("Record Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GenerateInvoiceNo();
                AllClear();
                frm_PurchaseOrder_Load(sender, e);
            }
        }
        public void ReturnBalance()
        {
            double received;
            double.TryParse(txt_Given.Text, out received);
            double Total = received - Convert.ToDouble(txt_Amount.Text);
            Total = Math.Round(Total, 0);
            txt_Return.Text = Total.ToString();
            lab_Return.Text = Total.ToString();

        }
        private void txt_Received_TextChanged(object sender, EventArgs e)
        {
            ReturnBalance();
            lab_Rec.Text = txt_Given.Text;
        }

        private void txt_Amount_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdo_Temp_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo_Temp.Checked == true)
            {
                lab_RatePerTola.Visible = false;
                lab_Amt.Visible = false;
                lab_Given.Visible = false;
                lab_Ret.Visible = false;
                txt_ProductRate.Visible = false;
                txt_Amount.Visible = false;
                txt_Given.Visible = false;
                txt_Return.Visible = false;
            }
            else
            {
                lab_RatePerTola.Visible = true;
                lab_Amt.Visible = true;
                lab_Given.Visible = true;
                lab_Ret.Visible = true;
                txt_ProductRate.Visible = true;
                txt_Amount.Visible = true;
                txt_Given.Visible = true;
                txt_Return.Visible = true;
            }
        }

        private void btn_Balance_Click(object sender, EventArgs e)
        {
            if(dgv_ProductDetails.Visible==true)
            {
                dgv_ProductDetails.Visible = false;
            }
            else
            {
                dgv_ProductDetails.Visible = true;
            }
        }
    }
}

namespace POS_GoldStore.Transactions
{
    partial class frm_TotalBalance
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_CustomerID = new System.Windows.Forms.TextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_exitForm = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmb_CustomerName = new SergeUtils.EasyCompletionComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_CashReceiveable = new System.Windows.Forms.TextBox();
            this.txt_CashPayable = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lab_bal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(83)))), ((int)(((byte)(121)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(672, 32);
            this.panel1.TabIndex = 205;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.label1.Location = new System.Drawing.Point(57, 142);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 24);
            this.label1.TabIndex = 200;
            this.label1.Text = "Customer ID :";
            // 
            // txt_CustomerID
            // 
            this.txt_CustomerID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_CustomerID.Enabled = false;
            this.txt_CustomerID.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txt_CustomerID.Location = new System.Drawing.Point(212, 143);
            this.txt_CustomerID.Name = "txt_CustomerID";
            this.txt_CustomerID.Size = new System.Drawing.Size(249, 27);
            this.txt_CustomerID.TabIndex = 194;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(174)))), ((int)(((byte)(174)))));
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancel.Location = new System.Drawing.Point(212, 244);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(249, 43);
            this.btn_cancel.TabIndex = 130;
            this.btn_cancel.TabStop = false;
            this.btn_cancel.Text = "  &Calculate";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_exitForm
            // 
            this.btn_exitForm.BackColor = System.Drawing.Color.White;
            this.btn_exitForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_exitForm.FlatAppearance.BorderSize = 0;
            this.btn_exitForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exitForm.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exitForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btn_exitForm.Image = global::POS_GoldStore.Properties.Resources.icons8_close_window_36;
            this.btn_exitForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_exitForm.Location = new System.Drawing.Point(554, 0);
            this.btn_exitForm.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_exitForm.Name = "btn_exitForm";
            this.btn_exitForm.Size = new System.Drawing.Size(118, 63);
            this.btn_exitForm.TabIndex = 1017;
            this.btn_exitForm.TabStop = false;
            this.btn_exitForm.Text = "     &Close";
            this.btn_exitForm.UseVisualStyleBackColor = false;
            this.btn_exitForm.Click += new System.EventHandler(this.btn_exitForm_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(11, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(288, 36);
            this.label4.TabIndex = 1;
            this.label4.Text = "Customer Balance ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(174)))), ((int)(((byte)(174)))));
            this.panel2.Controls.Add(this.btn_exitForm);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(672, 63);
            this.panel2.TabIndex = 206;
            // 
            // cmb_CustomerName
            // 
            this.cmb_CustomerName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_CustomerName.FormattingEnabled = true;
            this.cmb_CustomerName.Location = new System.Drawing.Point(212, 196);
            this.cmb_CustomerName.Name = "cmb_CustomerName";
            this.cmb_CustomerName.Size = new System.Drawing.Size(249, 29);
            this.cmb_CustomerName.TabIndex = 209;
            this.cmb_CustomerName.SelectedIndexChanged += new System.EventHandler(this.cmb_CustomerName_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.label3.Location = new System.Drawing.Point(13, 200);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 24);
            this.label3.TabIndex = 200;
            this.label3.Text = "Customer Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.label2.Location = new System.Drawing.Point(54, 345);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 24);
            this.label2.TabIndex = 211;
            this.label2.Text = "Total Cash Receiveable :";
            // 
            // txt_CashReceiveable
            // 
            this.txt_CashReceiveable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_CashReceiveable.Enabled = false;
            this.txt_CashReceiveable.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txt_CashReceiveable.Location = new System.Drawing.Point(326, 346);
            this.txt_CashReceiveable.Name = "txt_CashReceiveable";
            this.txt_CashReceiveable.Size = new System.Drawing.Size(249, 27);
            this.txt_CashReceiveable.TabIndex = 210;
            // 
            // txt_CashPayable
            // 
            this.txt_CashPayable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_CashPayable.Enabled = false;
            this.txt_CashPayable.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txt_CashPayable.Location = new System.Drawing.Point(326, 390);
            this.txt_CashPayable.Name = "txt_CashPayable";
            this.txt_CashPayable.Size = new System.Drawing.Size(249, 27);
            this.txt_CashPayable.TabIndex = 210;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.label5.Location = new System.Drawing.Point(102, 393);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(217, 24);
            this.label5.TabIndex = 211;
            this.label5.Text = "Total Cash Payable :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // lab_bal
            // 
            this.lab_bal.AutoSize = true;
            this.lab_bal.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_bal.ForeColor = System.Drawing.Color.SpringGreen;
            this.lab_bal.Location = new System.Drawing.Point(328, 440);
            this.lab_bal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_bal.Name = "lab_bal";
            this.lab_bal.Size = new System.Drawing.Size(78, 56);
            this.lab_bal.TabIndex = 212;
            this.lab_bal.Text = "00";
            this.lab_bal.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.label6.Location = new System.Drawing.Point(212, 454);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 24);
            this.label6.TabIndex = 213;
            this.label6.Text = "Balance :";
            // 
            // frm_TotalBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 617);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lab_bal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_CashPayable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_CashReceiveable);
            this.Controls.Add(this.cmb_CustomerName);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_CustomerID);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_TotalBalance";
            this.Text = "frm_TotalBalance";
            this.Activated += new System.EventHandler(this.frm_TotalBalance_Activated);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_CustomerID;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_exitForm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private SergeUtils.EasyCompletionComboBox cmb_CustomerName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_CashReceiveable;
        private System.Windows.Forms.TextBox txt_CashPayable;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lab_bal;
        private System.Windows.Forms.Label label6;
    }
}
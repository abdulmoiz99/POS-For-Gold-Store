namespace POS_GoldStore.ReprtForm
{
    partial class SalePurchaseReports
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_exitForm = new System.Windows.Forms.Button();
            this.label33 = new System.Windows.Forms.Label();
            this.rb_Sale = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_FromDate = new System.Windows.Forms.DateTimePicker();
            this.cmb_Mode = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_ToDate = new System.Windows.Forms.DateTimePicker();
            this.btn_Generate = new System.Windows.Forms.Button();
            this.rb_Purchase = new System.Windows.Forms.RadioButton();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(174)))), ((int)(((byte)(174)))));
            this.panel2.Controls.Add(this.btn_exitForm);
            this.panel2.Controls.Add(this.label33);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(487, 66);
            this.panel2.TabIndex = 1041;
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
            this.btn_exitForm.Location = new System.Drawing.Point(369, 0);
            this.btn_exitForm.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_exitForm.Name = "btn_exitForm";
            this.btn_exitForm.Size = new System.Drawing.Size(118, 66);
            this.btn_exitForm.TabIndex = 1016;
            this.btn_exitForm.Text = "     &Close";
            this.btn_exitForm.UseVisualStyleBackColor = false;
            this.btn_exitForm.Click += new System.EventHandler(this.btn_exitForm_Click);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.ForeColor = System.Drawing.Color.White;
            this.label33.Location = new System.Drawing.Point(13, 13);
            this.label33.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(301, 33);
            this.label33.TabIndex = 1;
            this.label33.Text = "Sale Purchase Reports";
            // 
            // rb_Sale
            // 
            this.rb_Sale.AutoSize = true;
            this.rb_Sale.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Sale.Location = new System.Drawing.Point(257, 105);
            this.rb_Sale.Name = "rb_Sale";
            this.rb_Sale.Size = new System.Drawing.Size(57, 24);
            this.rb_Sale.TabIndex = 1042;
            this.rb_Sale.Text = "Sale";
            this.rb_Sale.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 1043;
            this.label1.Text = "TYPE :";
            // 
            // dtp_FromDate
            // 
            this.dtp_FromDate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_FromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_FromDate.Location = new System.Drawing.Point(141, 187);
            this.dtp_FromDate.Name = "dtp_FromDate";
            this.dtp_FromDate.Size = new System.Drawing.Size(255, 26);
            this.dtp_FromDate.TabIndex = 1044;
            // 
            // cmb_Mode
            // 
            this.cmb_Mode.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Mode.FormattingEnabled = true;
            this.cmb_Mode.Items.AddRange(new object[] {
            "ALL",
            "CASH",
            "CREDIT",
            "TEMP"});
            this.cmb_Mode.Location = new System.Drawing.Point(141, 144);
            this.cmb_Mode.Name = "cmb_Mode";
            this.cmb_Mode.Size = new System.Drawing.Size(255, 28);
            this.cmb_Mode.TabIndex = 1045;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 1043;
            this.label2.Text = "MODE :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 1043;
            this.label3.Text = "FROM DATE :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 1043;
            this.label4.Text = "TO DATE :";
            // 
            // dtp_ToDate
            // 
            this.dtp_ToDate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_ToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ToDate.Location = new System.Drawing.Point(141, 219);
            this.dtp_ToDate.Name = "dtp_ToDate";
            this.dtp_ToDate.Size = new System.Drawing.Size(255, 26);
            this.dtp_ToDate.TabIndex = 1044;
            // 
            // btn_Generate
            // 
            this.btn_Generate.Location = new System.Drawing.Point(141, 261);
            this.btn_Generate.Name = "btn_Generate";
            this.btn_Generate.Size = new System.Drawing.Size(255, 39);
            this.btn_Generate.TabIndex = 1046;
            this.btn_Generate.Text = "Generate";
            this.btn_Generate.UseVisualStyleBackColor = true;
            this.btn_Generate.Click += new System.EventHandler(this.btn_Generate_Click);
            // 
            // rb_Purchase
            // 
            this.rb_Purchase.AutoSize = true;
            this.rb_Purchase.Checked = true;
            this.rb_Purchase.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Purchase.Location = new System.Drawing.Point(141, 105);
            this.rb_Purchase.Name = "rb_Purchase";
            this.rb_Purchase.Size = new System.Drawing.Size(99, 24);
            this.rb_Purchase.TabIndex = 1042;
            this.rb_Purchase.TabStop = true;
            this.rb_Purchase.Text = "Purchase ";
            this.rb_Purchase.UseVisualStyleBackColor = true;
            // 
            // SalePurchaseReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 369);
            this.Controls.Add(this.btn_Generate);
            this.Controls.Add(this.cmb_Mode);
            this.Controls.Add(this.dtp_ToDate);
            this.Controls.Add(this.dtp_FromDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rb_Purchase);
            this.Controls.Add(this.rb_Sale);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SalePurchaseReports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalePurchaseReports";
            this.Load += new System.EventHandler(this.SalePurchaseReports_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_exitForm;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.RadioButton rb_Sale;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_FromDate;
        private System.Windows.Forms.ComboBox cmb_Mode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_ToDate;
        private System.Windows.Forms.Button btn_Generate;
        private System.Windows.Forms.RadioButton rb_Purchase;
    }
}
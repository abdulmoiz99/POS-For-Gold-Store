﻿namespace POS_GoldStore.Setup
{
    partial class frm_CitySetup
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_CitySetup));
            this.txt_DataGridViewIndex = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_exitForm = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dgv_BrandSetup = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ITActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_Find = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdo_No = new System.Windows.Forms.RadioButton();
            this.rdo_Yes = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_New = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BrandSetup)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_DataGridViewIndex
            // 
            this.txt_DataGridViewIndex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_DataGridViewIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DataGridViewIndex.Location = new System.Drawing.Point(361, 437);
            this.txt_DataGridViewIndex.Name = "txt_DataGridViewIndex";
            this.txt_DataGridViewIndex.Size = new System.Drawing.Size(24, 29);
            this.txt_DataGridViewIndex.TabIndex = 193;
            this.txt_DataGridViewIndex.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(174)))), ((int)(((byte)(174)))));
            this.panel2.Controls.Add(this.btn_exitForm);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(561, 63);
            this.panel2.TabIndex = 191;
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
            this.btn_exitForm.Location = new System.Drawing.Point(443, 0);
            this.btn_exitForm.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_exitForm.Name = "btn_exitForm";
            this.btn_exitForm.Size = new System.Drawing.Size(118, 63);
            this.btn_exitForm.TabIndex = 1017;
            this.btn_exitForm.Text = "     &Close";
            this.btn_exitForm.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(11, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 36);
            this.label4.TabIndex = 1;
            this.label4.Text = "City Setup";
            // 
            // dgv_BrandSetup
            // 
            this.dgv_BrandSetup.AllowUserToAddRows = false;
            this.dgv_BrandSetup.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgv_BrandSetup.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_BrandSetup.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_BrandSetup.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_BrandSetup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_BrandSetup.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.ITActive});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(83)))), ((int)(((byte)(121)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_BrandSetup.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_BrandSetup.Location = new System.Drawing.Point(17, 272);
            this.dgv_BrandSetup.Name = "dgv_BrandSetup";
            this.dgv_BrandSetup.ReadOnly = true;
            this.dgv_BrandSetup.RowTemplate.Height = 35;
            this.dgv_BrandSetup.Size = new System.Drawing.Size(338, 198);
            this.dgv_BrandSetup.TabIndex = 189;
            this.dgv_BrandSetup.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_BrandSetup_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "CID";
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "CName";
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 170;
            // 
            // ITActive
            // 
            this.ITActive.DataPropertyName = "CActive";
            this.ITActive.HeaderText = "Active";
            this.ITActive.Name = "ITActive";
            this.ITActive.ReadOnly = true;
            this.ITActive.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ITActive.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // txt_Name
            // 
            this.txt_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Name.Enabled = false;
            this.txt_Name.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.Location = new System.Drawing.Point(106, 118);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(249, 33);
            this.txt_Name.TabIndex = 185;
            this.txt_Name.TextChanged += new System.EventHandler(this.txt_Name_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Save);
            this.groupBox2.Controls.Add(this.btn_cancel);
            this.groupBox2.Controls.Add(this.btn_Delete);
            this.groupBox2.Controls.Add(this.btn_edit);
            this.groupBox2.Controls.Add(this.btn_New);
            this.groupBox2.Location = new System.Drawing.Point(361, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(190, 302);
            this.groupBox2.TabIndex = 187;
            this.groupBox2.TabStop = false;
            // 
            // txt_Find
            // 
            this.txt_Find.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Find.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Find.Location = new System.Drawing.Point(6, 16);
            this.txt_Find.Name = "txt_Find";
            this.txt_Find.Size = new System.Drawing.Size(289, 22);
            this.txt_Find.TabIndex = 163;
            this.txt_Find.TextChanged += new System.EventHandler(this.txt_Find_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(83)))), ((int)(((byte)(121)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(561, 32);
            this.panel1.TabIndex = 190;
            // 
            // rdo_No
            // 
            this.rdo_No.AutoSize = true;
            this.rdo_No.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_No.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.rdo_No.Location = new System.Drawing.Point(175, 166);
            this.rdo_No.Name = "rdo_No";
            this.rdo_No.Size = new System.Drawing.Size(58, 28);
            this.rdo_No.TabIndex = 188;
            this.rdo_No.Text = "No";
            this.rdo_No.UseVisualStyleBackColor = true;
            // 
            // rdo_Yes
            // 
            this.rdo_Yes.AutoSize = true;
            this.rdo_Yes.Checked = true;
            this.rdo_Yes.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_Yes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.rdo_Yes.Location = new System.Drawing.Point(106, 166);
            this.rdo_Yes.Name = "rdo_Yes";
            this.rdo_Yes.Size = new System.Drawing.Size(63, 28);
            this.rdo_Yes.TabIndex = 186;
            this.rdo_Yes.TabStop = true;
            this.rdo_Yes.Text = "Yes";
            this.rdo_Yes.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.label1.Location = new System.Drawing.Point(13, 118);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 24);
            this.label1.TabIndex = 183;
            this.label1.Text = "Name :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.txt_Find);
            this.groupBox1.Location = new System.Drawing.Point(17, 205);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 52);
            this.groupBox1.TabIndex = 192;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.label2.Location = new System.Drawing.Point(12, 166);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 24);
            this.label2.TabIndex = 184;
            this.label2.Text = "Active :";
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(174)))), ((int)(((byte)(174)))));
            this.btn_Save.Enabled = false;
            this.btn_Save.FlatAppearance.BorderSize = 0;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Image = ((System.Drawing.Image)(resources.GetObject("btn_Save.Image")));
            this.btn_Save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Save.Location = new System.Drawing.Point(8, 134);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(172, 43);
            this.btn_Save.TabIndex = 131;
            this.btn_Save.Text = "  &Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(174)))), ((int)(((byte)(174)))));
            this.btn_cancel.Enabled = false;
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Image = ((System.Drawing.Image)(resources.GetObject("btn_cancel.Image")));
            this.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancel.Location = new System.Drawing.Point(8, 246);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(172, 43);
            this.btn_cancel.TabIndex = 130;
            this.btn_cancel.Text = "  &Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(174)))), ((int)(((byte)(174)))));
            this.btn_Delete.Enabled = false;
            this.btn_Delete.FlatAppearance.BorderSize = 0;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ForeColor = System.Drawing.Color.White;
            this.btn_Delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_Delete.Image")));
            this.btn_Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Delete.Location = new System.Drawing.Point(8, 190);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(172, 43);
            this.btn_Delete.TabIndex = 129;
            this.btn_Delete.Text = "  &Delete";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(174)))), ((int)(((byte)(174)))));
            this.btn_edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_edit.FlatAppearance.BorderSize = 0;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.ForeColor = System.Drawing.Color.White;
            this.btn_edit.Image = ((System.Drawing.Image)(resources.GetObject("btn_edit.Image")));
            this.btn_edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_edit.Location = new System.Drawing.Point(8, 78);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(172, 43);
            this.btn_edit.TabIndex = 128;
            this.btn_edit.Text = "  &Edit";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_New
            // 
            this.btn_New.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(174)))), ((int)(((byte)(174)))));
            this.btn_New.FlatAppearance.BorderSize = 0;
            this.btn_New.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_New.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_New.ForeColor = System.Drawing.Color.White;
            this.btn_New.Image = ((System.Drawing.Image)(resources.GetObject("btn_New.Image")));
            this.btn_New.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_New.Location = new System.Drawing.Point(8, 22);
            this.btn_New.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(172, 43);
            this.btn_New.TabIndex = 127;
            this.btn_New.Text = "&New";
            this.btn_New.UseVisualStyleBackColor = false;
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(301, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 170;
            this.pictureBox1.TabStop = false;
            // 
            // frm_CitySetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(561, 476);
            this.Controls.Add(this.txt_DataGridViewIndex);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgv_BrandSetup);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rdo_No);
            this.Controls.Add(this.rdo_Yes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_CitySetup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_CitySetup";
            this.Load += new System.EventHandler(this.frm_CitySetup_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BrandSetup)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_DataGridViewIndex;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_New;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_exitForm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.DataGridView dgv_BrandSetup;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_Find;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdo_No;
        private System.Windows.Forms.RadioButton rdo_Yes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ITActive;
    }
}
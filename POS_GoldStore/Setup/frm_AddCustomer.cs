﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_GoldStore.Setup
{
    public partial class frm_AddCustomer : Form
    {
        public frm_AddCustomer()
        {
            InitializeComponent();
        }

        private void btn_exitForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
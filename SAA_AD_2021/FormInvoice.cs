﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAA_AD_2021
{
    public partial class FormInvoice : Form
    {
        public FormInvoice()
        {
            InitializeComponent();
        }

        private void btnhowtopay_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPaymentMethod b = new FormPaymentMethod();
            b.ShowDialog();

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            FormDashboard b = new FormDashboard();
            b.ShowDialog();

        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafeeling_Ka
{
    public partial class ucForgotPass : UserControl
    {
        public ucForgotPass()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ucForgotPass FP = new ucForgotPass();

            FP.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ucForgotPass_Load(object sender, EventArgs e)
        {
            
        }
    }
}

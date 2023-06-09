﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiddleEarthBank
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Start_Load(object sender, EventArgs e)
        {
            BtnApllyLoan.Enabled = false;
        }

        private void BtnControl()
        {
            if (string.IsNullOrWhiteSpace(name.Text))
            {
                errorProvider1.SetError(name, "You must enter your name");
                BtnApllyLoan.Enabled = false;
                name.Focus();
            }
            else if (!name.Text.All(Char.IsLetter))
            {
                errorProvider1.SetError(name, "The name must only contain letters");
                BtnApllyLoan.Enabled = false;
                name.Focus();
            }
            else
            {
                errorProvider1.SetError(name, string.Empty);
                BtnApllyLoan.Enabled = true;
            }
        }


        private void name_TextChanged(object sender, EventArgs e)
        {
            BtnControl();
        }

        private void BtnApllyLoan_Click(object sender, EventArgs e)
        {
            using (Loan LoanWindow = new Loan(name.Text))
                LoanWindow.ShowDialog();
        }
    }
}

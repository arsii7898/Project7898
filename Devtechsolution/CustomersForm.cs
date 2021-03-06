﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Devtechsolution
{
    public partial class CustomersForm : Form
    {
        public CustomersForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
            SalesForm sf = new SalesForm();
            sf.Show();
            this.Hide();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 db = new Form1();
            db.Show();
            this.Hide();


        }

        private void label1_Click(object sender, EventArgs e)
        {
            EmployeeForm eform = new EmployeeForm();
            eform.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            SuppliersForm sform = new SuppliersForm();
            sform.Show();
            this.Hide();
        }

        private void CustomersForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }
    }
}

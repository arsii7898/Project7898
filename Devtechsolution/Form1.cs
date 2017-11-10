using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
           
            SalesForm sf = new SalesForm();
            sf.Show();
            this.Hide();
         
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
            SalesForm sf = new SalesForm();
            sf.Show();
            this.Hide();
           
        }

        private void label9_Click(object sender, EventArgs e)
        {
           
            CustomersForm cform = new CustomersForm();
            cform.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
            CustomersForm cform = new CustomersForm();
            cform.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            EmployeeForm eform = new EmployeeForm();
            eform.Show();
            this.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            EmployeeForm eform = new EmployeeForm();
            eform.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            InventoryForm iform = new InventoryForm();
            iform.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            InventoryForm iform = new InventoryForm();
            iform.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            SuppliersForm sform = new SuppliersForm();
            sform.Show();
            this.Hide();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            SuppliersForm sform = new SuppliersForm();
            sform.Show();
            this.Hide();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }
    }
}

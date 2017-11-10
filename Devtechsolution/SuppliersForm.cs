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
    public partial class SuppliersForm : Form
    {
        public SuppliersForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            SalesForm sf = new SalesForm();
            sf.Show();
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

        private void label4_Click(object sender, EventArgs e)
        {
            InventoryForm iform = new InventoryForm();
            iform.Show();
            this.Hide();
        }

        private void SuppliersForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 db = new Form1();
            db.Show();
            this.Hide();
        }
    }
}

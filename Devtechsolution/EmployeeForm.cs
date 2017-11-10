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
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            CustomersForm cform = new CustomersForm();
            cform.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 db = new Form1();
            db.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            SalesForm sf = new SalesForm();
            sf.Show();
            this.Hide();

        }

        private void label4_Click(object sender, EventArgs e)
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
    }
}

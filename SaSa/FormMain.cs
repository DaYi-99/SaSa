
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaSa
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void ptClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ptKH_Click(object sender, EventArgs e)
        {
            Forms.Customer.FormCustomer cus = new Forms.Customer.FormCustomer();
            cus.Show();
        }

        private void ptSP_Click(object sender, EventArgs e)
        {
            Forms.Product.FormProduct pro = new Forms.Product.FormProduct();
            pro.Show();
        }


       

        private void FormMain_Load(object sender, EventArgs e)
        {
            
        }

        private void mnuKho_QLHH_Click(object sender, EventArgs e)
        {
            Forms.Product.FormProduct pro = new Forms.Product.FormProduct();
            pro.Show();
        }

        private void mnuDM_KH_Click(object sender, EventArgs e)
        {
            Forms.Customer.FormCustomer cus = new Forms.Customer.FormCustomer();
            cus.Show();
        }

        private void mnuDM_NV_Click(object sender, EventArgs e)
        {
            Forms.Employee.FormEmployee em = new Forms.Employee.FormEmployee();
            em.Show();
        }

        private void mnuKho_QLMH_Click(object sender, EventArgs e)
        {
            Forms.Product.FormProductType proty = new Forms.Product.FormProductType();
            proty.Show();
        }

        private void mnuHDB_Click(object sender, EventArgs e)
        {
            Forms.Invoice.FormInvoice hdb = new Forms.Invoice.FormInvoice();
            hdb.Show();
        }
    }
}


using SaSa.DAL;
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

        //------ Khai báo biến thuộc lớp DataTable ----------
        DataTable myTable = new DataTable();
        //DataRow myRow = null;

        public FormMain(string txt)
        {
            InitializeComponent();
            //if(txt=="dayi") lbTenDN.Text = "Nghĩa";
            SqlCommand tenv = new SqlCommand("select TENNV from NHANVIEN where UN ='" + txt + "'", DAL_Connect.myconn);
            SqlDataReader rd = tenv.ExecuteReader();
            while (rd.Read() == true)
            {
                lbTenDN.Text = rd[0].ToString();
            }
            rd.Close();

            this.Refresh();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            SqlDataAdapter s = new SqlDataAdapter("Select MAKH from HDB_Tam",
                    DAL_Connect.myconn);
            s.Fill(myTable);

            foreach (DataRow row in myTable.Rows)
            {
                ListViewItem item = new ListViewItem(row["MAKH"].ToString());
                //item.SubItems.Add(row[""].ToString());
                lvddh.Items.Add(item);
            }
            lvddh.View = View.List;
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


        private void hdb_Create_Click(object sender, EventArgs e)
        {
            Forms.Invoice.FormInvoice hdb = new Forms.Invoice.FormInvoice();
            hdb.Show();
        }

        private void mnuDM_NCU_Click(object sender, EventArgs e)
        {
            Forms.Supplier.FormSupplier sup = new Forms.Supplier.FormSupplier();
            sup.Show();
        }

        private void mnuHDM_Click(object sender, EventArgs e)
        {
            Forms.Supplier.FormPurchase pur = new Forms.Supplier.FormPurchase();
            pur.Show();
        }

        private void mnuDT_Click(object sender, EventArgs e)
        {
            Forms.Profit.FormProfit fp = new Forms.Profit.FormProfit();
            fp.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
        }

        private void hdb_View_Click(object sender, EventArgs e)
        {
            Forms.Invoice.FormViewInvoice vi = new Forms.Invoice.FormViewInvoice();
            vi.Show();
        }
    }
}

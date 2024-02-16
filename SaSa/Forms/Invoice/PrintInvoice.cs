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

namespace SaSa.Forms.Invoice
{
    public partial class PrintInvoice : Form
    {
        public PrintInvoice(string txt)
        {
            InitializeComponent();
            txtmahd.Text = txt;
        }

        private void PrintInvoice_Load(object sender, EventArgs e)
        {
            CR_Invoice cr = new CR_Invoice();

            //SqlDataAdapter da = new SqlDataAdapter("select *,(select sum(THANHTIEN) from HDB_CT_Tam) as TongTien " +
            //    "from HDB_CT_Tam where MAHDB='" + txtmahd.Text + "'", DAL.DAL_Connect.myconn);
            SqlDataAdapter da = new SqlDataAdapter("Select b.TENSP, b.DVT, a.SL, a.DONGIA, a.THANHTIEN, " +
                    " from HDB_CT_Tam as a, SANPHAM as b, where a.MAHDB = '" + txtmahd.Text + "' and " +
                    "a.MASP = b.MASP",
                    DAL_Connect.myconn);
            DataSet ds = new DataSet(); 
            da.Fill(ds);
            cr.SetDataSource(ds.Tables[0]); 
            crvInvoice.ReportSource = cr;
        }

    }
}

//,(select TongTien from HDB where MAHDB='HDB_1') as TongTien
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

namespace SaSa.Forms.Profit
{
    public partial class FormProfit : Form
    {

        //------ Khai báo biến thuộc lớp DataTable ----------
        DataTable myTable = new DataTable();
        DataRow myRow = null;

        public FormProfit()
        {
            InitializeComponent();
            //Set di chuyển form theo thanh tiêu đề
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }

        // TASKBAR ICON
        private void ptClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ptMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        // TASKBAR ICON



        //Set di chuyển form theo thanh tiêu đề -- O
        bool drag = false;
        Point star = new Point(0, 0);
        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            star = new Point(e.X, e.Y);
        }

        private void panelTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - star.X, p.Y - star.Y);
            }
        }

        private void panelTitle_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }
        //Set di chuyển form theo thanh tiêu đề -- X


        // FILL DATA THU MAHDB,MANV,NGAY_HDB,MAKH,TongTien
        private void FillThu()
        {
            SqlCommand s = new SqlCommand("Select * FROM HDB",DAL_Connect.myconn);
            SqlDataReader r = s.ExecuteReader();
            myTable = this.dtsThu.Tables[0]; //dataset
            int STT = 1;
            while (r.Read() == true)
            {
                myRow = myTable.NewRow();
                myRow[0] = STT;
                myRow[1] = r.GetString(0).ToString(); //mahdb
                myRow[2] = r.GetString(1).ToString(); //manv
                myRow[3] = r.GetDateTime(2).ToString(); //ngay ban
                myRow[4] = r.GetString(3).ToString(); //makh
                myRow[5] = r.GetDecimal(4).ToString(); //tong tien
                myTable.Rows.Add(myRow);
                STT += 1;
            }
            this.drvThu.DataSource = myTable;
            r.Close();
        }

        private void FormProfit_Load(object sender, EventArgs e)
        {
            //FillThu();
        }

        private void tabcontrolDT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabcontrolDT.SelectedIndex==0)
            {

            }
            else if (tabcontrolDT.SelectedIndex==1)
            {

            }
            else if (tabcontrolDT.SelectedIndex==2)
            {
                myTable.Clear();
                FillThu();
            }
        }
    }
}

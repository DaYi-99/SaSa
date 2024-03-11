using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaSa
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        BUS.BUS_Connect cn = new BUS.BUS_Connect();
        BUS.BUS_Staff cus = new BUS.BUS_Staff();

        public static string SN = string.Empty;
        public static string DB = string.Empty;
        public static string UI = string.Empty;
        public static string PW = string.Empty;

        //test
        public static string DT = string.Empty;

        private void btn_Login_Click(object sender, EventArgs e)
        {
            //test
            //DT = @"(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\DaYi_Projects\Asp.Net\Winform\SaSa\SaSa\DatabaseLo.mdf;Integrated Security=True";

            //DTO.DTO_Connect lg = new DTO.DTO_Connect(DT);
            //test

            // truy cập cơ sở dữ liệu
            SN = @"HARRY\ASUS";
            DB = "SQL_SaSa";
            UI = "sa";
            PW = "25031999";

            DTO.DTO_Connect lg = new DTO.DTO_Connect(SN, DB, UI, PW);

            if (cn.DBKetNoi(lg) == true)
            {
                DTO.DTO_Staff nv = new DTO.DTO_Staff(this.txtUN.Texts.Trim(), this.txtPW.Texts.Trim());
                SqlDataReader rd = cus.getDataStoredProcedure("Check_Login", nv);
                if (rd.Read() == true)
                {
                    rd.Close();
                    Form fm = new FormMain(txtUN.Texts);
                    fm.Show();
                    this.Hide();

                }
                rd.Close();
            }

        }

        private void pt_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            txtUN.PlaceholderText = "Tên đăng nhập";
            txtPW.PlaceholderText = "Mật khẩu";
        }


        //move form
        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        protected override void OnMouseDown(MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                this.Capture = false;
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
            base.OnMouseDown(e);
        }
        //end move form
    }
}

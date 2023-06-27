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

        private void btn_Login_Click(object sender, EventArgs e)
        {
            // truy cập cơ sở dữ liệu
            SN = @"HARRY\SQLEXPRESS";
            DB = "SQL_SaSa";
            UI = "sa";
            PW = "123";

            DTO.DTO_Connect lg = new DTO.DTO_Connect(SN, DB, UI, PW);

            if (cn.DBKetNoi(lg) == true)
            {
                DTO.DTO_Staff nv = new DTO.DTO_Staff(this.txtUN.Texts.Trim(), this.txtPW.Texts.Trim());
                SqlDataReader rd = cus.getDataStoredProcedure("Check_Login", nv);
                if (rd.Read() == true)
                {
                    rd.Close();
                    Form fm = new FormMain();
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
    }
}

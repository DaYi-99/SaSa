using SaSa.BUS;
using SaSa.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaSa.Forms.Customer
{
    public partial class FormCustomer : Form
    {

        //------ Khai báo biến thuộc lớp BUS_CDBCustomer của tầng BUS
        BUS_Customer kh = new BUS_Customer();

        //------ Khai báo biến thuộc lớp DataTable ----------
        DataTable myTable = new DataTable();
        DataRow myRow = null;

        public FormCustomer()
        {
            InitializeComponent();
            //Set di chuyển form theo thanh tiêu đề
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }



        private void FormCustomer_Load(object sender, EventArgs e)
        {
            FillData();
            btnLuu.Enabled = false;
            btnFile.Visible = false;
            btntimkiem.Hide();


        }




        // Fill data vào datagridview từ database
        private void FillData()
        {
            // Đổ dữ liệu từ database vào Datagridview cho form Khách hàng
            SqlCommand cmd = new SqlCommand("select * from KHACHHANG", DAL_Connect.myconn);
            SqlDataReader rd = cmd.ExecuteReader();
            myTable = this.dtsCustomer.Tables[0]; //dataset
            int STT = 1;
            while (rd.Read() == true)
            {
                myRow = myTable.NewRow();
                myRow[0] = STT;
                myRow[1] = rd.GetString(0).ToString(); //makh
                myRow[2] = rd.GetString(1).ToString(); //tenkh
                myRow[3] = rd.GetString(2).ToString(); //sdt
                myRow[4] = rd.GetString(3).ToString();  //diachi
                myTable.Rows.Add(myRow);
                STT += 1;
            }
            this.drvCustomer.DataSource = myTable;
            rd.Close();
        }

        // Xử lý nút đóng
        private void ptClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Thao tác nhấn 1 dòng trong datagridview
        private void drvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //int i = e.RowIndex;
            //DataGridViewRow row = drvCustomer.Rows[i];
            //txtmakh.Text = row.Cells[1].Value.ToString();
            //txttenkh.Text = row.Cells[2].Value.ToString();
            //txtsdt.Text = row.Cells[3].Value.ToString();
            //txtdiachi.Text = row.Cells[4].Value.ToString();
        }

        // Thao tác nhấn 2 lần 1 dòng trong datagridview
        private void drvCustomer_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(txtmakh.Text != "")
            {
                FormC_Details c_d = new FormC_Details(txtmakh.Text);
                c_d.Show();
            }
        }

        // Hàm xoá textbox
        private void ClearTxt()
        {
            txtmakh.Text = "";
            txttenkh.Text = "";
            txtsdt.Text = "";
            txtdiachi.Text = "";
        }

        // Xử lý button thêm
        private void btnThem_Click(object sender, EventArgs e)
        {
            txtcode.Text = "0";

            ClearTxt();
            btnLuu.Enabled = true;


            SqlDataReader dr = kh.getDataStoredProcedure("KH_TAOMAKH");
            if (dr.Read() == true)
            {
                this.txtmakh.Text = dr.GetString(0).ToString();
            }
            dr.Close();

            btnFile.Show();
            btntimkiem.Hide();
        }

        // Xử lý button xoá
        private void btnXoa_Click(object sender, EventArgs e)
        {
            ClearTxt();
            btnLuu.Enabled = true;
            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = true;
        }

        // Xử lý button sửa
        private void btnSua_Click(object sender, EventArgs e)
        {
            ClearTxt();
            btnLuu.Enabled = true;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = false;
        }

        // Xử lý button Lưu
        private void btnLuu_Click(object sender, EventArgs e)
        {
            // LƯU - Thao tác thêm
            if (txtcode.Text == "0")
            {
                if (txttenkh.Text == "" && txtsdt.Text == "" && txtdiachi.Text == "")
                {
                    MessageBox.Show("Vui lòng điền đẩy đủ thông tin.", "Thông báo!");
                }
                //else if (txtsdt.Text.Length > 10 || txtsdt.Text.Length < 10)
                //{
                //    MessageBox.Show("Số điện thoại không được ngắn hơn hoặc quá 10 kí tự");
                //}
                else
                {
                    //Thêm khách hàng mới vào bảng khách hàng
                    //DTO_Customer newkh = new DTO_Customer(this.txtmakh.Text.Trim(), this.txttenkh.Text.Trim(),
                    //                                    this.txtsdt.Text.Trim(), this.txtdiachi.Text.Trim());
                    //kh.pr_THEMKH(newkh);

                    //SqlCommand check = new SqlCommand("select * from KHACHHANG where MAKH ='"+ txtmakh.Text +"'",DAL_Connect.myconn);
                    //SqlDataReader rcheck = check.ExecuteReader();
                    //while(rcheck.Read()==true)
                    //{
                    //    MessageBox.Show("Mã khách hàng đã tồn tại","Thông báo!");
                    //}
                    //rcheck.Close();

                    SqlCommand newkh = new SqlCommand("insert into KHACHHANG " +
                        "values('"+ txtmakh.Text +"',N'"+ txttenkh.Text +"','"+ txtsdt.Text +"',N'"+ txtdiachi.Text +"')",DAL_Connect.myconn);
                    SqlDataReader rnewkh = newkh.ExecuteReader();
                    rnewkh.Read();
                    rnewkh.Close();

                    MessageBox.Show("Đã thêm khách hàng - " + txttenkh.Text, "Thông báo!");

                    myTable.Clear();
                    FillData();
                }

                ClearTxt();
                //btnLuu.Enabled = false;
            }
            // LƯU - Thao tác xoá
            else if (txtcode.Text == "1")
            {
                if (this.txtmakh.Text == "")
                {
                    MessageBox.Show("Vui lòng chọn khách hàng cần xoá!");
                }
                else
                {
                    DialogResult dlr = MessageBox.Show("Bạn muốn xoá khách hàng [" + this.txttenkh.Text.ToString() + "]?", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (dlr == DialogResult.OK)
                    {
                        //-- khởi tạo hàm xoá khách hàng
                        //DTO_Customer xkh = new DTO_Customer(this.txtmakh.Text.Trim());

                        //-- gọi hàm xoá khách hàng
                        //kh.pr_XOAKH(xkh);

                        //SqlCommand delkh = new SqlCommand("alter table HDB nocheck constraint all" +
                        //    "delete from KHACHHANG where MAKH='" + txtmakh.Text +"' " +
                        //    "alter table HDB check constraint all", DAL_Connect.myconn);
                        SqlCommand delkh = new SqlCommand("delete from KHACHHANG where MAKH='" + txtmakh.Text + "' ",DAL_Connect.myconn);
                        SqlDataReader rdelkh = delkh.ExecuteReader();
                        rdelkh.Read();
                        rdelkh.Close();

                        MessageBox.Show("Xoá khách hàng [" + this.txttenkh.Text.ToString() + "] thành công!");
                        myTable.Clear();
                        FillData();
                    }
                    txtmakh.Text = "";
                    txttenkh.Text = "";
                    txtsdt.Text = "";
                    txtdiachi.Text = "";
                }
            }
            // LƯU - Thao tác sửa
            //else if (btnSua.Enabled == false) 
            else if (txtcode.Text == "2")
            {
                if (this.txtmakh.Text == "")
                {
                    MessageBox.Show("Vui lòng chọn khách hàng cần sửa thông tin!");
                }
                else
                {
                    //DTO_Customer suakh = new DTO_Customer(this.txttenkh.Text.Trim(),
                    //                                    this.txtsdt.Text.Trim(), this.txtdiachi.Text.Trim());
                    //kh.pr_SUAKH(suakh);

                    SqlCommand upd = new SqlCommand("update KHACHHANG set " +
                        "TENKH =N'"+ txttenkh.Text +"'," +
                        "SDT ='"+ txtsdt.Text +"'," +
                        "DC =N'"+ txtdiachi.Text +"'" +
                        "where MAKH='"+ txtmakh.Text +"'",DAL_Connect.myconn);
                    SqlDataReader rupd = upd.ExecuteReader();
                    rupd.Read();
                    rupd.Close();

                    MessageBox.Show("Sửa khách hàng [" + this.txttenkh.Text.ToString() + "] thành công!");
                    myTable.Clear();
                    FillData();
                }
            }

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ClearTxt();
            myTable.Clear();
            FillData();
            txtcode.Text = String.Empty;


            btnLuu.Enabled = false;


            btnFile.Hide();
            btntimkiem.Hide();
        }



        //Set di chuyển form theo thanh tiêu đề -- O
        bool drag = false;
        Point star = new Point(0, 0);

        private void panelTopBar_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            star = new Point(e.X, e.Y);
        }

        private void panelTopBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - star.X, p.Y - star.Y);
            }
        }

        private void panelTopBar_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }
        //Set di chuyển form theo thanh tiêu đề -- X




        // them du lieu tu excel vao database va update len datagridview
        //private void btnExcel_Click(object sender, EventArgs e)
        //{
            
        //}

        private void btnFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Excel Sheet(*.xlsx)|*xlsx|All Files(*.*)|(*.*)";
            if (op.ShowDialog() == DialogResult.OK)
            {
                string filepath = op.FileName;
                string con = "Provider=Microsoft.ACE.OLEDB.16.0;Data Source=" + filepath + ";Extended Properties='Excel 8.0;HDR=YES;IMEX=1;'";

                con = string.Format(con, filepath, "yes");

                OleDbConnection excelconnection = new OleDbConnection(con);
                excelconnection.Open();

                DataTable dtexcel = excelconnection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);

                string excelsheet = dtexcel.Rows[0]["TABLE_NAME"].ToString();

                OleDbCommand com = new OleDbCommand("Select * from [" + excelsheet + "]", excelconnection);
                //com.CommandTimeout = 10;
                OleDbDataAdapter oda = new OleDbDataAdapter(com);

                DataTable dt = new DataTable();
                oda.Fill(dt);
                excelconnection.Close();
                //drvCustomer.DataSource = dt;

                using (SqlBulkCopy bulkCopy = new SqlBulkCopy(DAL_Connect.myconn))
                {
                    bulkCopy.DestinationTableName = "dbo.KHACHHANG";
                    bulkCopy.WriteToServer(dt);
                }

                MessageBox.Show("Đã thêm mới khách hàng thành công");
            }

            
            myTable.Clear();
            FillData();
        }

        private void drvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (drvCustomer.Columns[e.ColumnIndex].Name == "del")
            {
                txtcode.Text = "1";

                int r = drvCustomer.CurrentCell.RowIndex;

                txtmakh.Text = drvCustomer.Rows[r].Cells[1].Value.ToString();
                txttenkh.Text = drvCustomer.Rows[r].Cells[2].Value.ToString();

                DialogResult dr = MessageBox.Show("Bạn có muốn xoá khách hàng - " + txttenkh.Text,"Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dr==DialogResult.Yes)
                {
                    SqlCommand delkh = new SqlCommand("delete from KHACHHANG where MAKH='" + txtmakh.Text + "' ", DAL_Connect.myconn);
                    SqlDataReader rdelkh = delkh.ExecuteReader();
                    rdelkh.Read();
                    rdelkh.Close();

                    MessageBox.Show("Xoá khách hàng [ " + this.txttenkh.Text.ToString() + " ] thành công!");
                    myTable.Clear();
                    FillData();

                    ClearTxt();
                }   
            }
            else if (drvCustomer.Columns[e.ColumnIndex].Name == "upd")
            {

                ClearTxt();
                btnLuu.Enabled = true;
                txtcode.Text = "2";

                int r = drvCustomer.CurrentCell.RowIndex;

                txtmakh.Text    = drvCustomer.Rows[r].Cells[1].Value.ToString();
                txttenkh.Text   = drvCustomer.Rows[r].Cells[2].Value.ToString();
                txtsdt.Text     = drvCustomer.Rows[r].Cells[3].Value.ToString();
                txtdiachi.Text  = drvCustomer.Rows[r].Cells[4].Value.ToString();
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            ClearTxt();
            txttenkh.Focus();
            btntimkiem.Show();
            btnFile.Hide();
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            if (txttenkh.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng muốn tìm");
            }
            else
            {
                myTable.Clear();

                SqlCommand findkh = new SqlCommand("select * from KHACHHANG where TENKH='" + txttenkh.Text + "' ", DAL_Connect.myconn);
                SqlDataReader rfindkh = findkh.ExecuteReader();

                myTable = this.dtsCustomer.Tables[0]; //dataset
                int STT = 1;

                while (rfindkh.Read()==true)
                {
                        myRow = myTable.NewRow();
                        myRow[0] = STT;
                        myRow[1] = rfindkh.GetString(0).ToString(); //makh
                        myRow[2] = rfindkh.GetString(1).ToString(); //tenkh
                        myRow[3] = rfindkh.GetString(2).ToString(); //sdt
                        myRow[4] = rfindkh.GetString(3).ToString();  //diachi
                        myTable.Rows.Add(myRow);
                        STT += 1; 
                }
                this.drvCustomer.DataSource = myTable;
                rfindkh.Close();
            }
        }
    }
}


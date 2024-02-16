using SaSa.DAL;
using SaSa.DTO;
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

namespace SaSa.Forms.Employee
{
    public partial class FormEmployee : Form
    {
        // Bus
        BUS.BUS_Staff bus_staff = new BUS.BUS_Staff();

        //------ Khai báo biến thuộc lớp DataTable ----------
        DataTable myTable = new DataTable();
        DataRow myRow = null;

        public FormEmployee()
        {
            InitializeComponent();
            //Set di chuyển form theo thanh tiêu đề
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }

        //-- 1. Form Employee  ---

        //-- Đóng Form
        private void ptClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //-- Đổ dữ liệu vào DataGridView khi Load Form
        private void FillData()
        {
            // Đổ dữ liệu từ database vào Datagridview cho form Nhân viên
            SqlCommand cmd = new SqlCommand("select * from NHANVIEN", DAL_Connect.myconn);
            SqlDataReader rd = cmd.ExecuteReader();
            //myTable.Clear();
            myTable = this.dtsEmployee.Tables[0]; //dataset
            int STT = 1;
            while (rd.Read() == true)
            {
                myRow = myTable.NewRow();
                myRow[0] = STT;
                myRow[1] = rd.GetString(0).ToString(); //manv
                myRow[2] = rd.GetString(1).ToString(); //tennv
                myRow[3] = rd.GetString(2).ToString(); //dt
                myRow[4] = rd.GetString(3).ToString();  //cccd
                myRow[5] = rd.GetDateTime(4).ToString();  //namsinh
                myRow[6] = rd.GetString(5).ToString(); //email
                myRow[7] = rd.GetString(6).ToString(); //tendn
                myRow[8] = rd.GetString(7).ToString(); //matkhau
                myTable.Rows.Add(myRow);
                STT += 1;
            }
            this.drvEmployee.DataSource = myTable;
            rd.Close();
        }

        //-- Thao tác chọn hàng - dòng trong DataGridView để đổ lên TextBox
        private void drvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = e.RowIndex;
            DataGridViewRow row = drvEmployee.Rows[i];
            txtmanv.Text = row.Cells[1].Value.ToString();
            txttennv.Text = row.Cells[2].Value.ToString();
            txtsdt.Text = row.Cells[3].Value.ToString();
            txtcccd.Text = row.Cells[4].Value.ToString();
            dtpns.Text = row.Cells[5].Value.ToString();
            txtemail.Text = row.Cells[6].Value.ToString();
            txttendn.Text = row.Cells[7].Value.ToString();
            txtmatkhau.Text = row.Cells[8].Value.ToString();
        }

        //-- Form Load
        private void FormEmployee_Load(object sender, EventArgs e)
        {
            FillData();
            btnLuu.Enabled = false;
            txtmanv.Enabled = false;

            txttennv2.Hide();
            txtcccd2.Hide();
            txtsdt2.Hide();

        }

        //-- Hàm xoá TextBox
        private void ClearTxt()
        {
            txtmanv.Text = "";
            txttennv.Text = "";
            txtcccd.Text = "";
            txtsdt.Text = "";
            txtemail.Text = "";
            txttendn.Text = "";
            txtmatkhau.Text = "";
        }

        // Dữ liệu nhập vào phải là số - SDT | CCCD
        private void txtsdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        //-- 1. Close  ---


        //-- 2. Sự kiện các button trong Form --

        //-- Sự kiện cho nút thêm
        private void btnThem_Click(object sender, EventArgs e)
        {
            ClearTxt();
            btnLuu.Enabled = true;

            SqlDataReader dr = bus_staff.getDataStoredProcedure("pr_TAOMANV");
            if (dr.Read() == true)
            {
                this.txtmanv.Text = dr.GetString(0).ToString();
                dr.Close();
            }

            // Disable nút Thêm
            btnThem.Enabled = false;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnTim.Enabled = true;

            // Enable textbox để thêm mới
            txtcccd.Enabled = true;
            txtsdt.Enabled = true;
            txtemail.Enabled = true;
            dtpns.Enabled = true;
            txttendn.Enabled = true;
            txtmatkhau.Enabled = true;
        }

        //-- Sự kiện cho nút xoá
        private void btnXoa_Click(object sender, EventArgs e)
        {
            ClearTxt();
            btnLuu.Enabled = true;

            // Disable nút Xoá
            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = true;
            btnTim.Enabled = true;

            // Disable textbox
            txttennv.Enabled = false;
            txtcccd.Enabled = false;
            txtsdt.Enabled = false;
            txtemail.Enabled = false;
            dtpns.Enabled = false;
            txttendn.Enabled = false;
            txtmatkhau.Enabled = false;
        }

        //-- Sự kiện cho nút sửa
        private void btnSua_Click(object sender, EventArgs e)
        {
            ClearTxt();
            btnLuu.Enabled = true;

            // Disable nút Sửa
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = false;
            btnTim.Enabled = true;

            // Enable textbox để sửa
            txttennv.Enabled = true;
            txtcccd.Enabled = true;
            txtsdt.Enabled = true;
            txtemail.Enabled = true;
            dtpns.Enabled = true;
            txttendn.Enabled = true;
            txtmatkhau.Enabled = true;
        }

        //-- Sự kiện cho nút tìm
        private void btnTim_Click(object sender, EventArgs e)
        {
            ClearTxt();
            btnLuu.Enabled = false;

            // Disable nút Tìm
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnTim.Enabled = false;

            // Disable textbox
            txtmanv.Enabled = false;
            txtemail.Enabled = false;
            dtpns.Enabled = false;
            txttendn.Enabled = false;
            txtmatkhau.Enabled = false;

            // Hide textbox
            txttennv.Hide();
            txtsdt.Hide();
            txtcccd.Hide();

            // Show textbox phục vụ cho tìm kiếm
            txttennv2.Show();
            txtsdt2.Show();
            txtcccd2.Show();



        }

        //-- Sự kiện cho nút lưu
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(btnThem.Enabled == false)
            {
                if (txttennv.Text == "" && txtsdt.Text == "" && txtcccd.Text == "")
                {
                    MessageBox.Show("Vui lòng điền đẩy đủ thông tin.", "Thông báo!");
                }
                else if (txtsdt.Text.Length > 10 || txtsdt.Text.Length < 10)
                {
                    MessageBox.Show("Số điện thoại không được ngắn hơn hoặc quá 10 kí tự");
                }
                else
                {
                    //Thêm nhân viên mới vào bảng nhân viên
                    DTO_Staff newnv = new DTO_Staff(this.txtmanv.Text.Trim(), this.txttennv.Text.Trim(),
                                                        this.txtsdt.Text.Trim(), this.txtcccd.Text.Trim(),
                                                        this.dtpns.Value, this.txtemail.Text,
                                                        this.txttendn.Text, this.txtmatkhau.Text);
                    bus_staff.pr_THEMNV(newnv);
                    //MessageBox.Show("Thêm nhân viên " + this.txtTennv.Texts.ToString() + " thành công!");
                    myTable.Clear();
                    FillData();
                    btnThem.Enabled = true;
                }
            }
            if(btnXoa.Enabled == false)
            {
                if (this.txtmanv.Text == "")
                {
                    MessageBox.Show("Vui lòng chọn nhân viên cần xoá!");
                }
                else
                {
                    DialogResult dlr = MessageBox.Show("Bạn muốn xoá nhân viên " + this.txttennv.Text.ToString() + "?", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (dlr == DialogResult.OK)
                    {
                        //-- khởi tạo hàm xoá nhân viên
                        DTO_Staff xnv = new DTO_Staff(this.txtmanv.Text.Trim());

                        //-- gọi hàm xoá nhân viên
                        bus_staff.pr_XOANV(xnv);
                        MessageBox.Show("Xoá nhân viên " + this.txttennv.Text.ToString() + " thành công!");
                        myTable.Clear();
                        FillData();
                        btnXoa.Enabled = true;
                    }
                }
            }
            if (btnSua.Enabled == false)
            {
                if (txtmanv.Text == "")
                {
                    MessageBox.Show("Vui lòng chọn nhân viên cần sửa thông tin!");
                }
                else
                {
                    DTO_Staff suanv = new DTO_Staff(this.txtmanv.Text.Trim(), this.txttennv.Text.Trim(),
                                                        this.txtsdt.Text.Trim(), this.txtcccd.Text.Trim(),
                                                        this.dtpns.Value, this.txtemail.Text,
                                                        this.txttendn.Text, this.txtmatkhau.Text);
                    bus_staff.pr_SUANV(suanv);
                    MessageBox.Show("Sửa nhân viên " + this.txttennv.Text.ToString() + " thành công!");
                    myTable.Clear();
                    FillData();
                    btnSua.Enabled = true;
                }
            }
            btnLuu.Enabled = false;

        }

        //-- Sự kiện cho nút huỷ
        private void btnHuy_Click(object sender, EventArgs e)
        {
            ClearTxt();
            btnLuu.Enabled = false;
            myTable.Clear();
            FillData();

            //Enable button
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnTim.Enabled = true;
            
            // Hide textbox tìm kiếm
            txttennv2.Hide();
            txtcccd2.Hide();
            txtsdt2.Hide();

            // Show textbox
            txttennv.Show();
            txtcccd.Show();
            txtsdt.Show();

            // Enable textbox
            txttennv.Enabled = true;
            txtcccd.Enabled = true;
            txtsdt.Enabled = true;
            txtemail.Enabled = true;
            dtpns.Enabled = true;
            txttendn.Enabled = true;
            txtmatkhau.Enabled = true;
        }

        //-- 2. Close --



        //-- 3. Thao tác tìm kiếm --

        //-- Hàm phục vụ cho thao tác tìm kiếm
        private void FindData()
        {
            //---- Gọi hàm khởi tạo thông tin nhân viên để phục vụ tìm kiếm
            DTO_Staff tnv = new DTO_Staff(this.txttennv2.Text.Trim(), this.txtsdt2.Text.Trim(),
                this.txtcccd2.Text.Trim());

            //-----Gọi hàm tìm kiếm nhân viên
            SqlDataReader rd = bus_staff.getDataStoredProcedured("pr_TIMNV", tnv);
            myTable.Clear();
            myTable = this.dtsEmployee.Tables[0];
            int STT = 1;
            while (rd.Read() == true)
            {
                myRow = myTable.NewRow();
                myRow[0] = STT;
                myRow[1] = rd.GetString(0).ToString(); //manv
                myRow[2] = rd.GetString(1).ToString(); //tennv
                myRow[3] = rd.GetString(2).ToString(); //dt
                myRow[4] = rd.GetString(3).ToString();  //cccd
                myRow[5] = rd.GetDateTime(4).ToString();  //namsinh
                myRow[6] = rd.GetString(5).ToString(); //email
                myRow[7] = rd.GetString(6).ToString(); //tendn
                myRow[8] = rd.GetString(7).ToString(); //matkhau
                myTable.Rows.Add(myRow);
            }
            this.drvEmployee.DataSource = myTable;
            rd.Close();
        }
        private void txtcccd2_TextChanged(object sender, EventArgs e)
        {
            FindData();
        }
        private void txttennv2_TextChanged(object sender, EventArgs e)
        {
            FindData();
        }
        private void txtsdt2_TextChanged(object sender, EventArgs e)
        {
            FindData();
        }
        //-- 3. Close --


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
    }
}


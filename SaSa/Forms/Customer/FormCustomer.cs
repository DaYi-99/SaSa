using SaSa.BUS;
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
        }

        private void FormCustomer_Load(object sender, EventArgs e)
        {
            FillData();
            btnLuu.Enabled = false;
        }

        private void FillData()
        {
            // Đổ dữ liệu từ database vào Datagridview cho form Khách hàng
            SqlCommand cmd = new SqlCommand("select *, (select SUM(SL) from HDB) as TONGSL from KHACHHANG", DAL_Connect.myconn);
            //SqlCommand cmd = new SqlCommand("select * from KHACHHANG", DAL_Connect.myconn);
            SqlDataReader rd = cmd.ExecuteReader();
            //myTable.Clear();
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
                myRow[5] = rd.GetInt32(4).ToString();  //diachi
                myTable.Rows.Add(myRow);
                STT += 1;
            }
            this.drvCustomer.DataSource = myTable;
            rd.Close();
        }

        private void ptClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void drvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = e.RowIndex;
            DataGridViewRow row = drvCustomer.Rows[i];
            txtmakh.Texts = row.Cells[1].Value.ToString();
            txttenkh.Texts = row.Cells[2].Value.ToString();
            txtsdt.Texts = row.Cells[3].Value.ToString();
            txtdc.Texts = row.Cells[4].Value.ToString();
        }

        private void drvCustomer_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FormC_Details c_d = new FormC_Details(txttenkh.Texts);
            c_d.Show();
        }

        private void ClearTxt()
        {
            txtmakh.Texts = "";
            txttenkh.Texts = "";
            txtsdt.Texts = "";
            txtdc.Texts = "";
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            ClearTxt();
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;

            SqlDataReader dr = kh.getDataStoredProcedure("KH_TAOMAKH");
            if (dr.Read() == true)
            {
                this.txtmakh.Texts = dr.GetString(0).ToString();
            }
            dr.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            ClearTxt();
            btnLuu.Enabled = true;
            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ClearTxt();
            btnLuu.Enabled = true;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled==false)
            {
                if (txttenkh.Texts == "" && txtsdt.Texts == "" && txtdc.Texts == "")
                {
                    MessageBox.Show("Vui lòng điền đẩy đủ thông tin.", "Thông báo!");
                }
                else if (txtsdt.Texts.Length > 10 || txtsdt.Texts.Length < 10)
                {
                    MessageBox.Show("Số điện thoại không được ngắn hơn hoặc quá 10 kí tự");
                }
                else
                {
                    //Thêm khách hàng mới vào bảng khách hàng
                    DTO_Customer newkh = new DTO_Customer(this.txtmakh.Texts.Trim(), this.txttenkh.Texts.Trim(),
                                                        this.txtsdt.Texts.Trim(), this.txtdc.Texts.Trim());
                    kh.pr_THEMKH(newkh);
                    //MessageBox.Show("Thêm khách hàng " + this.txtTenKH.Texts.ToString() + " thành công!");
                    myTable.Clear();
                    FillData();
                }
            }
            else if (btnXoa.Enabled==false)
            {
                if (this.txtmakh.Texts == "")
                {
                    MessageBox.Show("Vui lòng chọn khách hàng cần xoá!");
                }
                else
                {
                    DialogResult dlr = MessageBox.Show("Bạn muốn xoá khách hàng " + this.txttenkh.Texts.ToString() + "?", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (dlr == DialogResult.OK)
                    {
                        //-- khởi tạo hàm xoá khách hàng
                        DTO_Customer xkh = new DTO_Customer(this.txtmakh.Texts.Trim());

                        //-- gọi hàm xoá khách hàng
                        kh.pr_XOAKH(xkh);
                        MessageBox.Show("Xoá khách hàng " + this.txttenkh.Texts.ToString() + " thành công!");
                        myTable.Clear();
                        FillData();
                    }
                }
            }
            else if (btnSua.Enabled==false)
            {
                if (this.txtmakh.Texts == "")
                {
                    MessageBox.Show("Vui lòng chọn khách hàng cần sửa thông tin!");
                }
                else
                {
                    DTO_Customer suakh = new DTO_Customer(this.txttenkh.Texts.Trim(),
                                                        this.txtsdt.Texts.Trim(), this.txtdc.Texts.Trim());
                    kh.pr_SUAKH(suakh);
                    MessageBox.Show("Sửa khách hàng " + this.txttenkh.Texts.ToString() + " thành công!");
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

            
            btnLuu.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
        }

        
    }
}

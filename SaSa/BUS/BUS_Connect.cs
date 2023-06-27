using SaSa.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaSa.BUS
{
    public class BUS_Connect
    {
        //------ 1. Khai báo biến thuộc lớp DAL_KetNoi ở tầng DAL
        DAL.DAL_Connect cn = new DAL.DAL_Connect();

        //------ 2. Viết hàm để gọi hàm kết nối CSDL ở tầng DAL
        public bool DBKetNoi(DTO.DTO_Connect lg)
        {
            return cn.DBKetNoi(lg);

        }
        //------ 3. Viết hàm để gọi hàm đóng kết nối CSDL ở tầng DAL
        //public bool DisDBConnect()
        //{
        //    return cn.DisDBConnect();

        //}

        //---- 4. Viết hàm đưa dữ liệu  DataTable và trả về DataTable
        public DataTable getDataTable(DataTable dt, string sql)
        {
            return cn.getDataTable(dt, sql);
        }

        //internal bool DBKetNoi(DTO_Connect lg)
        //{
        //    throw new NotImplementedException();
        //}
    }
}

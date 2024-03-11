using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaSa.DTO
{
    public class DTO_Connect
    {
        private string _Servername;
        private string _Database;
        private string _UserID;
        private string _Password;

        public string Servername { get => _Servername; set => _Servername = value; }
        public string Database { get => _Database; set => _Database = value; }
        public string UserID { get => _UserID; set => _UserID = value; }
        public string Password { get => _Password; set => _Password = value; }

        //test
        public string Data { get => _Data; set => _Data = value; }

        //-- 2. Viết hàm khởi tạo (constructor) không có tham số
        public DTO_Connect() { }

        //-- 3. Viết hàm khởi tạo (constructor) có tham số
        public DTO_Connect(string sv, string db, string ui, string pw)
        {
            this.Servername = sv;
            this.Database = db;
            this.UserID = ui;
            this.Password = pw;
        }

        //test
        private string _Data;
        public DTO_Connect(string data)
        {
            this.Data = data;
        }
    }
}

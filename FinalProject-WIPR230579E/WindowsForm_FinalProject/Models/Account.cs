using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsForm_FinalProject.Connection;

namespace WindowsForm_FinalProject.Models
{
    class Account
    {
        protected string ID { get; set; }
        protected string Username { get; set; }
        protected string Password { get; set; }

        public Account(string ID)
        {
            this.ID = ID;
        }
        public Account(string ID, string Username, string Password)
        {
            this.ID = ID;
            this.Username = Username;
            this.Password = Password;
        }
        public Account(string Username, string Password)
        {
            this.Username = Username;
            this.Password = Password;
        }
        public int UpdateTaiKhoan()
        {
            string[] paras = new string[3] { "@ID", "@Username", "@Password"};
            object[] values = new object[3] { ID, Username, Password};
            return MyDB.Execute_Sql("procedureUpdateTaiKhoan", CommandType.StoredProcedure, paras, values);
        }
        public int InsertTaiKhoan()
        {
            string[] paras = new string[3] { "@ID", "@Username", "@Password" };
            object[] values = new object[3] { ID, Username, Password };
            return MyDB.Execute_Sql("procedureInsertTaiKhoan", CommandType.StoredProcedure, paras, values);
        }
        public int DeleteTaiKhoan()
        {
            string[] paras = new string[1] { "@ID"};
            object[] values = new object[1] { ID };
            return MyDB.Execute_Sql("procedureDeleteTaiKhoan", CommandType.StoredProcedure, paras, values);
        }
        public static DataSet FillDataSetTaiKhoan()
        {
            return MyDB.FillDataSet("SELECT * FROM viewGetTaiKhoan", CommandType.Text);
        }
        public DataSet FillDataSet_getTaiKhoanByID()
        {
            DataSet ds = new DataSet();
            string[] paras = new string[1] { "@ID" };
            object[] values = new object[1] { ID };
            ds = MyDB.FillDataSet("procedureGetTaiKhoanByID", CommandType.StoredProcedure, paras, values);
            return ds;
        }
    }
}

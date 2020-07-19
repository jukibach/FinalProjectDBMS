using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using WindowsForm_FinalProject.Connection;
using System.Data.SqlClient;
using WindowsForm_FinalProject.Connection;

namespace WindowsForm_FinalProject.Models
{
    class LoginModel
    {
        protected string Username { get; set; }
        protected string Password { get; set; }
        public LoginModel()
        {

        }
        public LoginModel(string Username)
        {
            this.Username = Username;
        }
        public LoginModel(string Username, string Password)
        {
            this.Username = Username;
            this.Password = Password;
        }
        public string GetIDNhanVien()
        {

            SqlCommand SQLCommand = new SqlCommand("SELECT IDNhanVien FROM dbo.TaiKhoan WHERE Username = @Username", MyDB.Getconnection());
            SQLCommand.Parameters.Add("@Username", SqlDbType.VarChar).Value = Username;
            if (MyDB.Getconnection().State == ConnectionState.Closed)
                MyDB.Getconnection().Open();
            string result = (string)SQLCommand.ExecuteScalar();
            if (MyDB.Getconnection().State == ConnectionState.Open)
                MyDB.Getconnection().Close();
            return result;
        }
        public DataSet CheckDangNhap()
        {
            string[] paras = new string[2] { "@Username", "@Password" };
            object[] values = new object[2] { Username, Password };
            return MyDB.FillDataSet("procedureCheckDangNhap", CommandType.StoredProcedure, paras, values);
        }
       
    }
}

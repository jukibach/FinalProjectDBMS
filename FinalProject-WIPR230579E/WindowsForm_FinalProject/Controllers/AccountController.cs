using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsForm_FinalProject.Models;

namespace WindowsForm_FinalProject.Controllers
{
    class AccountController
    {
        public static DataSet FillDataSet_getTaiKhoanByID(string ID)
        {
            try
            {
                Account taiKhoan = new Account(ID);
                return taiKhoan.FillDataSet_getTaiKhoanByID();

            }
            catch
            {
                return null;
            }
        }
        // Method Update
        public static int UpdateTaiKhoan(string ID, string Username, string Password)
        {
            try
            {
                Account taiKhoan = new Account(ID, Username, Password);
                return taiKhoan.UpdateTaiKhoan();
            }
            catch
            {
                return 0;
            }

        }
        public static int InsertTaiKhoan(string ID, string Username, string Password)
        {
            try
            {
                Account taiKhoan = new Account(ID, Username, Password);
                return taiKhoan.InsertTaiKhoan();
            }
            catch
            {
                return 0;
            }

        }
        public static int DeleteTaiKhoan(string ID)
        {
            try
            {
                Account taiKhoan = new Account(ID);
                return taiKhoan.DeleteTaiKhoan();
            }
            catch
            {
                return 0;
            }

        }
       
        public static DataSet CheckDangNhap(string Username, string Password)
        {
            try
            {
                LoginModel dangNhap = new LoginModel(Username, Password);
                return dangNhap.CheckDangNhap();
            }
            catch
            {
                return null;
            }

        }
    }

}
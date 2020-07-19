using WindowsForm_FinalProject.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForm_FinalProject.Models;

namespace WindowsForm_FinalProject.Views
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        public static string nameAdmin = "";
        
        private void buttonDangNhap_Click(object sender, EventArgs e)
        {
            string Username = textBoxTenDangNhap.Text;
            string Password = textBoxMatKhau.Text;
            DataTable table = AccountController.CheckDangNhap(Username, Password).Tables[0];
            DataRow row = null;
            if (table != null)
            {
                try
                {
                    row = table.Rows[0];
                    nameAdmin = (string)row["Username"];
                    
                    MainForm frm = new MainForm(nameAdmin);
                    this.Hide();
                    frm.ShowDialog();
                    textBoxTenDangNhap.Text = "Username";
                    textBoxMatKhau.Text = "Password";
                    this.Show();
                }
                catch (Exception)
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng");
                }
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng");
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxTenDangNhap_Leave(object sender, EventArgs e)
        {
            if (textBoxTenDangNhap.Text == "")
            {
                textBoxTenDangNhap.Text = "Username";
            }
        }

        private void textBoxTenDangNhap_Click(object sender, EventArgs e)
        {
            if (textBoxTenDangNhap.Text == "Username")
            {
                textBoxTenDangNhap.Text = "";
            }
        }

        private void textBoxMatKhau_Click(object sender, EventArgs e)
        {
            if (textBoxMatKhau.Text == "Password")
            {
                textBoxMatKhau.UseSystemPasswordChar = true;
                textBoxMatKhau.Text = "";
            }
        }

        private void textBoxMatKhau_Leave(object sender, EventArgs e)
        {
            if (textBoxMatKhau.Text == "")
            {
                
                textBoxMatKhau.UseSystemPasswordChar = false;
                textBoxMatKhau.Text = "Password";
            }
        }
    }
}

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
    public partial class AccountForm : Form
    {
        public AccountForm()
        {
            InitializeComponent();
        }
        public void HienThiDanhSachTaiKhoan()
        {
            dataGridViewTaiKhoan.DataSource = Account.FillDataSetTaiKhoan().Tables[0];
            dataGridViewTaiKhoan.Dock = DockStyle.Fill;
            dataGridViewTaiKhoan.RowHeadersVisible = false;
            dataGridViewTaiKhoan.BorderStyle = BorderStyle.None;
        }
        void bingding()
        {
            txtID.DataBindings.Clear();
            txtID.DataBindings.Add("Text", dataGridViewTaiKhoan.DataSource, "ID");
            txtUsername.DataBindings.Clear();
            txtUsername.DataBindings.Add("Text", dataGridViewTaiKhoan.DataSource, "Username");
            txtPassword.DataBindings.Clear();
            txtPassword.DataBindings.Add("Text", dataGridViewTaiKhoan.DataSource, "Password");
            txtRePassword.DataBindings.Clear();
            txtRePassword.DataBindings.Add("Text", dataGridViewTaiKhoan.DataSource, "Password");
        }
        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string ID = "";
            try
            {
                ID = txtID.Text;
            }
            catch { }

            string Username = "";
            try
            {
                Username = txtUsername.Text;
            }
            catch { }

            string Password = "";
            try
            {
                Password = txtPassword.Text;
            }
            catch { }

            int i = 0;

            i = AccountController.InsertTaiKhoan(ID, Username, Password);
            if (i > 0)
            {
                MessageBox.Show("Thêm thành công");

            }
            else
                MessageBox.Show("Thêm không thành công");
            AccountForm_Load(sender, e);

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string ID = "";
            try
            {
                ID = txtID.Text;
            }
            catch { }

            string Username = "";
            try
            {
                Username = txtUsername.Text;
            }
            catch { }

            string Password = "";
            try
            {
                Password = txtPassword.Text;
            }
            catch { }

            int i = 0;

            i = AccountController.InsertTaiKhoan(ID, Username, Password);
            if (i > 0)
            {
                MessageBox.Show("Sửa thành công");

            }
            else
                MessageBox.Show("Sửa không thành công");
            AccountForm_Load(sender, e);

        }

        private void AccountForm_Load(object sender, EventArgs e)
        {
            HienThiDanhSachTaiKhoan();
            bingding();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = "";
            try
            {
                id = txtID.Text;
            }
            catch { }
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn xóa ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int i = 0;
                i = AccountController.DeleteTaiKhoan(id);
                if (i > 0)
                {
                    MessageBox.Show(" Xóa thành công");
                    HienThiDanhSachTaiKhoan();
                }
                else
                    MessageBox.Show("Xóa không thành công");
            }
            else
                return;
        }
    }
}

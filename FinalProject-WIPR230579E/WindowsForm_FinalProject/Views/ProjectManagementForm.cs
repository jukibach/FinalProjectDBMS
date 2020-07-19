using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using WindowsForm_FinalProject.Controllers;
using WindowsForm_FinalProject.Models;

namespace WindowsForm_FinalProject.Views
{
    public partial class ProjectManagementForm : Form
    {
        public int ID = 0;
        //private List<Project> lstProject;
        //private List<Student> listStudents;
        public ProjectManagementForm(/*ref List<Project> Projects, List<Student> Students*/)
        {
            InitializeComponent();
            this.cPBegin.DataPropertyName = nameof(Project.PBegin);
            this.cPEnd.DataPropertyName = nameof(Project.PEnd);
            this.cPName.DataPropertyName = nameof(Project.PName);
            this.cPType.DataPropertyName = nameof(Project.PType);
            this.cPContent.DataPropertyName = nameof(Project.PContent);
            this.cID.DataPropertyName = nameof(Project.PID);


     
        }
        public static ProjectManagementForm PF = new ProjectManagementForm();

        private void ProjectForm_Load(object sender, EventArgs e)
        {

            DisplayProjects();
            bingding();
            //dis_end(true);
            //Views.uctGoiMon.uctGM.uctGoiMon_Load(sender, e);
        }
        void dis_end(bool e)
        {
            txtID.Enabled = e;
            txtPName.Enabled = e;
            txtContent.Enabled = e;
            ccbType.Enabled = e;
            dateBegin.Enabled = e;
            dateEnd.Enabled = e;

            btnAddP.Enabled = e;
            btnDeleteP.Enabled = e;
            btnUpdate.Enabled = e;
        }
        void bingding()
        {
            txtID.DataBindings.Clear();
            txtID.DataBindings.Add("Text", dataProject.DataSource, "PID");
            txtPName.DataBindings.Clear();
            txtPName.DataBindings.Add("Text", dataProject.DataSource, "PName");
            txtContent.DataBindings.Clear();
            txtContent.DataBindings.Add("Text", dataProject.DataSource, "PContent");
            ccbType.DataBindings.Clear();
            ccbType.DataBindings.Add("Text", dataProject.DataSource, "PType");
            dateBegin.DataBindings.Clear();
            dateBegin.DataBindings.Add("Text", dataProject.DataSource, "PBegin");
            dateEnd.DataBindings.Clear();
            dateEnd.DataBindings.Add("Text", dataProject.DataSource, "PEnd");
        }

        private void DisplayProjects()
        {
            //BindingSource source = new BindingSource();
            //source.DataSource = ProjectController.getAllProject(); ;
            //this.dataProject.DataSource = source;

            dataProject.DataSource = Project.FillDataSetProject().Tables[0];
            dataProject.Dock = DockStyle.Fill;
            dataProject.RowHeadersVisible = false;
            dataProject.BorderStyle = BorderStyle.Fixed3D;

        }
        private void btnAddP_Click(object sender, EventArgs e)
        {
            string PID = "";
            try
            {
                PID = this.txtID.Text;
            }
            catch { return; }
            string PName = "";
            try
            {
                PName = this.txtPName.Text;
            }
            catch { }
            string PContent = "";
            try
            {
                PContent = this.txtContent.Text;
            }
            catch { }
            string PType = "";
            try
            {
                PType = this.ccbType.Text.Trim();
            }
            catch { }
            DateTime PBegin = this.dateBegin.Value, PEnd = this.dateEnd.Value; ;


            if (PName == "")
                MessageBox.Show("Hãy nhập tên bàn");
            else
            {
                int i = 0;
                i = ProjectController.InsertProject(PID, PName, PContent, PType, PBegin, PEnd);
                if (i > 0)
                {
                    MessageBox.Show("Thêm mới thành công");
                    DisplayProjects();
                }
                else
                    MessageBox.Show("Thêm mới không thành công");
            }
            this.DisplayProjects();


        }
        //private bool checkbegin(Project project)
        //{
        //    var u =lstProject.Where(x => x.PBegin == project.PBegin).Count();
        //    return (u > 0);
        //}
        //private bool checkend(Project project)
        //{
        //    var u = lstProject.Where(x => x.PEnd == project.PEnd).Count();
        //    return (u > 0);
        //}
        //private bool checkname(Project project)
        //{
        //    var u = lstProject.Where(x => x.PName == project.PName).Count();
        //    return (u > 0);
        //}
        private void btnDeleteP_Click(object sender, EventArgs e)
        {
            string pid = "";
            try
            {
                pid = txtID.Text;
            }
            catch { }
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn xóa ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int i = 0;
                i = ProjectController.DeleteProject(pid);
                if (i > 0)
                {
                    MessageBox.Show(" Xóa thành công");
                    DisplayProjects();
                    ProjectForm_Load(sender, e);
                }
                else
                    MessageBox.Show("Xóa không thành công");
            }
            else
                return;
        }
        
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string PID = "";
            try
            {
                PID = this.txtID.Text;
            }
            catch { return; }
            string PName = "";
            try
            {
                PName = this.txtPName.Text;
            }
            catch { }
            string PContent = "";
            try
            {
                PContent = this.txtContent.Text;
            }
            catch { }
            string PType = "";
            try
            {
                PType = this.ccbType.Text.Trim();
            }
            catch { }
            DateTime PBegin = this.dateBegin.Value, PEnd = this.dateEnd.Value;

            if (PName == "")
                MessageBox.Show("Hãy nhập tên bàn");
            else
            {
                int i = 0;
                i = ProjectController.UpdateProject(PID, PName, PContent, PType, PBegin, PEnd);
                if (i > 0)
                {
                    MessageBox.Show(" Sửa thành công");
                    DisplayProjects();
                    ProjectForm_Load(sender, e);
                }
                else
                    MessageBox.Show("Sửa không thành công");
            }
            ProjectForm_Load(sender, e);
        }

  

        private void dataProject_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //string PID = "";
            //try
            //{
            //    PID = this.txtID.Text;
            //}
            //catch { return; }
            //string PName = "";
            //try
            //{
            //    PName = this.txtPName.Text;
            //}
            //catch { }
            //string PContent = "";
            //try
            //{
            //    PContent = this.txtContent.Text;
            //}
            //catch { }
            //string PType = "";
            //try
            //{
            //    PType = this.ccbType.Text.Trim();
            //}
            //catch { }
            //DateTime PBegin = this.dateBegin.Value, PEnd = this.dateEnd.Value;

            //if (PName == "")
            //    MessageBox.Show("Hãy nhập tên bàn");
            //else
            //{
            //    this.BeginInvoke(new MethodInvoker(() =>
            //    {
            //        int i = 0;
            //        i = ProjectController.UpdateProject(PID, PName, PContent, PType, PBegin, PEnd);
            //        if (i > 0)
            //        {
            //            MessageBox.Show(" Sửa thành công");
            //            DisplayProjects();
            //            ProjectForm_Load(sender, e);
            //        }
            //        else
            //            MessageBox.Show("Sửa không thành công");
            //    }));
            //}
            //ProjectForm_Load(sender, e);

        }
    }
}

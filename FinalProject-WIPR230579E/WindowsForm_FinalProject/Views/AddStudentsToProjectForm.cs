using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForm_FinalProject.Controllers;
using WindowsForm_FinalProject.Models;

namespace WindowsForm_FinalProject.Views
{
    public partial class AddStudentsToProjectForm : Form
    {
        public AddStudentsToProjectForm()
        {
            InitializeComponent();
            this.cbbCourse.DisplayMember = "PName";
            this.cbbCourse.ValueMember = "PID";
            //this.cbbCourse.SelectedIndex = 1;
            this.cbbCourse.DataSource = ProjectController.getAllNameProject().Tables[0];
           

            this.cID.DataPropertyName = nameof(Student.ID);
            this.cFullname.DataPropertyName = nameof(Student.Fullname);
            this.cBirthday.DataPropertyName = nameof(Student.Birthday);
            this.cGender.DataPropertyName = nameof(Student.Gender);
            this.cClass.DataPropertyName = nameof(Student.Class);
            this.cEmail.DataPropertyName = nameof(Student.Email);
            this.cPhone.DataPropertyName = nameof(Student.Phone);
            this.cPicture.DataPropertyName = nameof(Student.Picture);


        }
        private void DisplayStudent(string courseID)
        {
            //BindingSource source = new BindingSource();
            //source.DataSource = ProjectController.getAllProject(); ;
            //this.dataProject.DataSource = source;

            //dataStudent.DataSource = Student.StudentByProject(courseID).Tables[0];
            dataStudent.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataStudent.RowTemplate.Height = 80;
            dataStudent.DataSource = Student.StudentByProject(courseID).Tables[0];
            picCol = (DataGridViewImageColumn)dataStudent.Columns[2];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataStudent.Dock = DockStyle.Fill;
            dataStudent.RowHeadersVisible = false;
            dataStudent.BorderStyle = BorderStyle.Fixed3D;

        }
        private void btnAddP_Click(object sender, EventArgs e)
        {
            string studentID = this.txtID.Text.ToString();
            string courseID;
            courseID = this.cbbCourse.SelectedValue.ToString();
            int i = 0;
            i = Project.InsertStudentToProject(studentID, courseID);
            if (i > 0)
            {
                MessageBox.Show("Thêm mới thành công");
                DisplayStudent(courseID); 
            }
            else
                MessageBox.Show("Thêm mới không thành công");
        }

        private void cbbCourse_SelectedValueChanged(object sender, EventArgs e)
        {
           
        }

        private void btnFindC_Click(object sender, EventArgs e)
        {
            string courseID;
            courseID = this.cbbCourse.SelectedValue.ToString();
            DisplayStudent(courseID);
        }
    }
}

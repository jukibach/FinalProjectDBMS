using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using WindowsForm_FinalProject.Models;
using WindowsForm_FinalProject.Controllers;
using System.Globalization;

namespace WindowsForm_FinalProject.Views
{
    public partial class AssessmentForm : Form
    {
        StudentProjectController studentProjectController = new StudentProjectController();
        StudentController studentController = new StudentController();
        Score score = new Score();
        public AssessmentForm(/*ref List<Student> students, List<Project> projects*/)
        {
            InitializeComponent();
            this.cPID.DataPropertyName = nameof(Project.PID);
            this.cPBegin.DataPropertyName = nameof(Project.PBegin);
            this.cEnd.DataPropertyName = nameof(Project.PEnd);
            this.cPName.DataPropertyName = nameof(Project.PName);
            this.cPType.DataPropertyName = nameof(Project.PType);
            this.cPContent.DataPropertyName = nameof(Project.PContent);
            this.cScore.DataPropertyName = nameof(Project.Score);
            this.cComment.DataPropertyName = nameof(Project.Comment);

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            Score score = new Score();
            if (score.createScoreTable() == false)
            {
                DataTable dt = StudentProjectController.FillDataSetProject(this.txtID.Text.ToString()).Tables[0];
                bs.DataSource = dt;
                this.dataSearchID.DataSource = bs;

                dt = StudentController.FillDataSet_getStudentById(this.txtID.Text).Tables[0];

                foreach (DataRow row in dt.Rows)
                {
                    this.label5.Text = "Name:  " + row[1].ToString();
                    this.label6.Text = "Email: " + row[6].ToString();
                    this.label7.Text = "Phone: " + row[7].ToString();
                    this.label8.Text = "Gender: " + row[4].ToString();
                    this.label9.Text = "BirthDay: " + DateTime.ParseExact(row[3].ToString(), "dd-MMM-yy hh:mm:ss tt", CultureInfo.InvariantCulture).ToString("dd-MM-yyyy"); //"dd-MM-yyyy"
                    this.label10.Text = "Class: " + row[5].ToString();
                }
                this.cbbCourse.DisplayMember = "PName";
                this.cbbCourse.ValueMember = "PID";
                this.cbbCourse.DataSource = StudentProjectController.getInfoProjectName(this.txtID.Text.ToString()).Tables[0];
            };

        }

        private void dataSearchID_Click(object sender, EventArgs e)
        {
            txtID.Text = dataSearchID.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnAssess_Click(object sender, EventArgs e)
        {
      
            try 
            {

                string ID = this.txtID.Text;
                string courseID = this.cbbCourse.SelectedValue.ToString();
                double scoreValue = Convert.ToDouble(txtScore.Text);
                 string comment = this.txtComment.Text;
                if (score.insertScore(ID, courseID, scoreValue, comment))
                {
                    MessageBox.Show("Student Score Inserted", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Student Score Not Inserted", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            
                BindingSource bs = new BindingSource();
                DataTable dt = StudentProjectController.FillDataSetProject(this.txtID.Text.ToString()).Tables[0];
                bs.DataSource = dt;
                this.dataSearchID.DataSource = bs;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

        }

        private void dataSearchID_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
        
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //try
            //{

                string ID = this.txtID.Text;
                string courseID = this.cbbCourse.SelectedValue.ToString();
                double scoreValue = Convert.ToDouble(txtScore.Text);
                string comment = this.txtComment.Text;
                if (score.updateScore(ID, courseID, scoreValue, comment))
                {
                    MessageBox.Show("Student Score Updated", "Update Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Student Score Not Updated", "Update Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                BindingSource bs = new BindingSource();
                DataTable dt = StudentProjectController.FillDataSetProject(this.txtID.Text.ToString()).Tables[0];
                bs.DataSource = dt;
                this.dataSearchID.DataSource = bs;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Update Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}

        }
    }
}

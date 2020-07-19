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

namespace WindowsForm_FinalProject.Views
{
    public partial class PrintScoreForm : Form
    {
        public PrintScoreForm()
        {
            InitializeComponent();
        }

        private void PrintScoreForm_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = StudentProjectController.getStudentScore().Tables[0];
            this.ListBoxProjects.DisplayMember = "PName";
            this.ListBoxProjects.ValueMember = "PID";
            ListBoxProjects.DataSource = StudentProjectController.getProjectName().Tables[0];
            dataGridView1.RowTemplate.Height = 80;

        }

        private void ListBoxProjects_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = StudentProjectController.getStudentScore(this.ListBoxProjects.SelectedValue.ToString()).Tables[0];
        }
    }
}

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
//using WindowsForm_FinalProject.Controllers;
namespace WindowsForm_FinalProject.Views
{
    public partial class MainForm : Form
    {
        StudentForm SForm;
        ProjectManagementForm PForm;
        AssessmentForm SEForm;
        AddStudentsToProjectForm classForm;
        List<Project> listProjects; // store projects
        List<Student> listStudents;// store students
        PrintScoreForm printScoreForm;
        AccountForm account;
        public MainForm(string nameAdmin) /**/
        {
            InitializeComponent();
            listProjects = new List<Project>();
            listStudents = new List<Student>();
        }
        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(this.SForm is null || this.SForm.IsDisposed)
            {
                this.SForm = new StudentForm();
                this.SForm.MdiParent = this;
                SForm.Show();
            }
            else
            {
                this.SForm.Select();
            }
        }

        private void projectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(this.PForm is null|| this.PForm.IsDisposed)
            {
                this.PForm = new ProjectManagementForm();
                this.PForm.MdiParent = this;
                PForm.Show();
            }
            else
            {
                this.PForm.Show();
            }
        }

        private void MainForm_MdiChildActivate(object sender, EventArgs e)
        {
            if(this.ActiveMdiChild is null)
            {
                return;
            }
            this.ActiveMdiChild.WindowState = FormWindowState.Maximized;
            if(this.ActiveMdiChild.Tag == null)
            {
                TabPage tp = new TabPage(this.ActiveMdiChild.Text);
                tp.Tag = this.ActiveMdiChild;
                tp.Parent = this.tabControl1;
                this.tabControl1.SelectedTab = tp;
                this.ActiveMdiChild.Tag = tp;
                this.ActiveMdiChild.FormClosed += ActiveMdiChild_FormClosed;
            }
        }

        private void ActiveMdiChild_FormClosed(object sender, FormClosedEventArgs e)
        {
           ((sender as Form).Tag as TabPage).Dispose();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.tabControl1.SelectedTab != null && this.tabControl1.SelectedTab.Tag != null)
            {
                (this.tabControl1.SelectedTab.Tag as Form).Select();
            }
        }

        private void estimateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.SEForm is null || this.SEForm.IsDisposed)
            {
                this.SEForm = new AssessmentForm();
                this.SEForm.MdiParent = this;
                SEForm.Show();
            }
            else
            {
                this.SEForm.Select();
            }

        }

        private void MainForm_Load_1(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is MdiClient)
                {
                    ctrl.BackColor = Color.Aquamarine;
                }
            }
        }

        private void classToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.classForm is null || this.classForm.IsDisposed)
            {
                this.classForm = new AddStudentsToProjectForm();
                this.classForm.MdiParent = this;
                classForm.Show();
            }
            else
            {
                this.classForm.Select();
            }
        }

        private void printScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.printScoreForm is null || this.printScoreForm.IsDisposed)
            {
                this.printScoreForm = new PrintScoreForm();
                this.printScoreForm.MdiParent = this;
                printScoreForm.Show();
            }
            else
            {
                this.printScoreForm.Select();
            }
        }

        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.account is null || this.account.IsDisposed)
            {
                this.account = new AccountForm();
                this.account.MdiParent = this;
                account.Show();
            }
            else
            {
                this.account.Select();
            }
        }



        //private void databaseToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    TestDB.insertUsertoDatabase();
        //}
    }
}

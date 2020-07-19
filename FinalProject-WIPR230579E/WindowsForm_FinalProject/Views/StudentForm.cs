using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForm_FinalProject.Controllers;
using WindowsForm_FinalProject.Models;

namespace WindowsForm_FinalProject.Views
{
    public partial class StudentForm : Form
    {
        DateTimePicker dtp;
        private List<Student> listStudents;
        ComboBox cbb;
        StudentController studentController = new StudentController();
        DataTable tableStudent = new DataTable();

        public StudentForm(/*ref List<Student> students*/)
        {
            InitializeComponent();
            this.cFullname.DataPropertyName = nameof(Student.Fullname);
            this.cID.DataPropertyName = nameof(Student.ID);
            this.cBirthday.DataPropertyName = nameof(Student.Birthday);
            this.cGender.DataPropertyName = nameof(Student.Gender);
            this.cClasss.DataPropertyName = nameof(Student.Class);
            this.cEmail.DataPropertyName = nameof(Student.Email);
            this.cPhone.DataPropertyName = nameof(Student.Phone);
            this.cPicture.DataPropertyName = nameof(Student.Picture);


           
        }
        //public static StudentForm SF = new StudentForm();

        private void Student_Load(object sender, EventArgs e)
        {
            DisplayStudent();
            bingding();
        }

        //void dis_end(bool e)
        //{
        //    txtID.Enabled = e;
        //    txt.Enabled = e;
        //    txtContent.Enabled = e;
        //    ccbType.Enabled = e;
        //    dateBegin.Enabled = e;
        //    dateEnd.Enabled = e;

        //    btnAddP.Enabled = e;
        //    btnDeleteP.Enabled = e;
        //    btnUpdate.Enabled = e;
        //}
        void ClearData()
        {
            txtID.Text = "";
            txtFullname.Text = "";
            txtGender.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
            
        }
        void bingding()
        {
            txtID.DataBindings.Clear();
            txtID.DataBindings.Add("Text", dataStudent.DataSource, "ID");
            txtFullname.DataBindings.Clear();
            txtFullname.DataBindings.Add("Text", dataStudent.DataSource, "Fullname");
            dtpBirthday.DataBindings.Clear();
            dtpBirthday.DataBindings.Add("Text", dataStudent.DataSource, "Birthday");
            txtGender.DataBindings.Clear();
            txtGender.DataBindings.Add("Text", dataStudent.DataSource, "Gender");
            txtClass.DataBindings.Clear();
            txtClass.DataBindings.Add("Text", dataStudent.DataSource, "Class");
            txtEmail.DataBindings.Clear();
            txtEmail.DataBindings.Add("Text", dataStudent.DataSource, "Email");
            txtPhone.DataBindings.Clear();
            txtPhone.DataBindings.Add("Text", dataStudent.DataSource, "Phone");
            pictureStudent.DataBindings.Clear();
            pictureStudent.DataBindings.Add("Text", dataStudent.DataSource, "Picture");
        }

        private void DisplayStudent()
        {
            //BindingSource source = new BindingSource();
            //source.DataSource = ProjectController.getAllProject(); ;
            //this.dataProject.DataSource = source;
            tableStudent = Student.FillDataSetStudent().Tables[0];
            string[] selectedColumns = new[] { "ID", "Fullname", "Picture", "Birthday", "Gender", "Class", "Email", "Phone" };
            dataStudent.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataStudent.RowTemplate.Height = 80;
            //dataStudent.DataSource = Student.FillDataSetStudent().Tables[0];
            dataStudent.DataSource = new DataView(tableStudent).ToTable(false, selectedColumns);

            picCol = (DataGridViewImageColumn)dataStudent.Columns[2];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;

            dataStudent.Dock = DockStyle.Fill;
            dataStudent.RowHeadersVisible = false;
            dataStudent.BorderStyle = BorderStyle.Fixed3D;

        }
        private bool checkID(Student student)
        {
            var u = listStudents.Where(x => x.ID == student.ID).Count();
            return (u > 0);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string ID = "";
            string Name = "";
            string gender = "";
            string email = "";
            string phone = "";
            string Class = "";
            DateTime birthday = this.dtpBirthday.Value;
            MemoryStream Picture = new MemoryStream();
           
            try
            {
                ID = this.txtID.Text;
                Name = this.txtFullname.Text;
                gender = this.txtGender.Text; 
                email = this.txtEmail.Text;
                phone = this.txtPhone.Text;
                Class = this.txtClass.Text;
                if (pictureStudent.Image != null)
                    pictureStudent.Image.Save(Picture, pictureStudent.Image.RawFormat);
                else
                {
                    Properties.Resources.Student.Save(Picture, Properties.Resources.Student.RawFormat);
                }
            }
            catch { return; }
          
          

        
            if (ID == "")
                MessageBox.Show("Hãy nhập tên bàn");
            else
            {
                int i = 0;
                i = StudentController.InsertStudent(ID, Name, Picture, birthday, gender, Class, email,phone);
                if (i > 0)
                {
                    MessageBox.Show("Thêm mới thành công");
                    DisplayStudent();
                    ClearData();
                }
                else
                    MessageBox.Show("Thêm mới không thành công");
            }
            


        }
        private void ClearText()
        {
            this.txtFullname.Text = string.Empty;
            this.txtID.Text = string.Empty;
            this.txtGender.Text = string.Empty;
            this.txtClass.Text = string.Empty;
            this.txtEmail.Text = string.Empty;
            this.txtPhone.Text = string.Empty;
        }
        private void dataStudent_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.ColumnIndex == 1)
            //{
            //    return;
            //}
            //int index = e.RowIndex;
            //Student nStudent = new Student();

            ////nStudent.ID = this.dataStudent.CurrentRow.Cells[0].Value.ToString();
            ////if (nStudent.ID.Length <= 0)
            ////{
            ////    return;
            ////}

            //////ID
            //if (this.dataStudent.CurrentRow.Cells[0].Value is null)
            //{
            //    this.dataStudent.CurrentRow.Cells[0].Value = "";
            //}
            //else nStudent.ID = this.dataStudent.CurrentRow.Cells[0].Value.ToString();
            ////FullName
            //if (this.dataStudent.CurrentRow.Cells[1].Value is null)
            //{
            //    this.dataStudent.CurrentRow.Cells[1].Value = "";
            //}
            //else nStudent.Fullname = this.dataStudent.CurrentRow.Cells[1].Value.ToString();

            ////Birthday
            //if (this.dataStudent.CurrentRow.Cells[2].Value is null)
            //{
            //    this.dataStudent.CurrentRow.Cells[2].Value = DateTime.Now.Date;
            //}
            //else nStudent.Birthday = DateTime.ParseExact(this.dataStudent.CurrentRow.Cells[2].Value.ToString(), "dd-MMM-yy hh:mm:ss tt", CultureInfo.InvariantCulture).Date;
            ////Gender
            //if (this.dataStudent.CurrentRow.Cells[3].Value is null)
            //{
            //    this.dataStudent.CurrentRow.Cells[3].Value = "";
            //}
            //else nStudent.Gender = this.dataStudent.CurrentRow.Cells[3].Value.ToString();
            ////Class
            //if (this.dataStudent.CurrentRow.Cells[4].Value is null)
            //{
            //    this.dataStudent.CurrentRow.Cells[4].Value = "";
            //}
            //else nStudent.Class = this.dataStudent.CurrentRow.Cells[4].Value.ToString();
            ////Email
            //if (this.dataStudent.CurrentRow.Cells[5].Value is null)
            //{
            //    this.dataStudent.CurrentRow.Cells[5].Value = "";
            //}
            //else nStudent.Email = this.dataStudent.CurrentRow.Cells[5].Value.ToString();

            ////Phone
            //if (this.dataStudent.CurrentRow.Cells[6].Value is null)
            //{
            //    this.dataStudent.CurrentRow.Cells[6].Value = "";
            //}
            //else nStudent.Phone = this.dataStudent.CurrentRow.Cells[6].Value.ToString();

            //if (StudentController.UpdateStudent(nStudent) == false)
            //{
            //    MessageBox.Show("Cannot update!");
            //}
            /////////////////////////////
            //int count = listStudents.Where(x => x.ID == nStudent.ID).Count();

            //if (count == 0)
            //{
            //    listStudents.Add(nStudent);
            //}
            //else if (count == 1 && this.dataStudent.Rows.Count == (listStudents.Count() + 1))
            //{
            //    int listindex = this.listStudents.FindIndex(x => x.ID == nStudent.ID);
            //    if (index != e.RowIndex)
            //    {
            //        MessageBox.Show("Same existed ID!");
            //        this.dataStudent.Rows[index].Cells[cGender.Index].Value = listStudents[e.RowIndex].Gender;
            //        this.dataStudent.Rows[index].Cells[cFullname.Index].Value = listStudents[e.RowIndex].Fullname;
            //        this.dataStudent.Rows[index].Cells[cBirthday.Index].Value = listStudents[e.RowIndex].Birthday;
            //        this.dataStudent.Rows[index].Cells[cEmail.Index].Value = listStudents[e.RowIndex].Email;
            //        this.dataStudent.Rows[index].Cells[cPhone.Index].Value = listStudents[e.RowIndex].Phone;
            //        this.dataStudent.Rows[index].Cells[cClasss.Index].Value = listStudents[e.RowIndex].Class;
            //        this.dataStudent.Rows[index].Cells[cID.Index].Value = listStudents[e.RowIndex].ID;
            //        return;
            //    }
            //    listStudents[index] = nStudent;
            //}
            //else if (count == 1 && this.dataStudent.Rows.Count != listStudents.Count())
            //{
            //    MessageBox.Show("Same existed ID!");

            //    return;
            //}
            //else if (count > 1)
            //{
            //    MessageBox.Show("Same existed ID!");
            //    return;
            //}


        }

        private void dataStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //try
            //{
            //    if (this.dataStudent.Columns[e.ColumnIndex].DataPropertyName == nameof(Student.Birthday))
            //    {

            //        dtp = new DateTimePicker();
            //        dtp.Visible = true;
            //        dtp.Format = DateTimePickerFormat.Custom;

            //        Rectangle rtg = this.dataStudent.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
            //        dtp.Size = new Size(rtg.Width, rtg.Height);
            //        dtp.Location = new Point(rtg.X, rtg.Y);
            //        try
            //        {
            //            dtp.Value = DateTime.ParseExact(this.dataStudent.CurrentRow.Cells[2].Value.ToString(), "dd-MM-yyyy HH:mm:ss tt", CultureInfo.CreateSpecificCulture("hu-HU")).Date;

            //        }
            //        catch
            //        {
            //            dtp.Value = DateTime.Now;
            //            dtp.Visible = false;
            //            dtp.Dispose();
            //        }
            //        dtp.CloseUp += Dtp_CloseUp;
            //        dtp.TextChanged += Dtp_TextChanged;

            //    }
            //    this.dataStudent.Controls.Add(dtp);

            //    if (this.dataStudent.Columns[e.ColumnIndex].DataPropertyName == nameof(Student.Gender))
            //    {
            //        cbb = new ComboBox();
            //        cbb.Visible = true;
            //        Rectangle rect = this.dataStudent.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
            //        cbb.Size = new Size(rect.Width, rect.Height);
            //        cbb.Location = new Point(rect.X, rect.Y);
            //        cbb.Items.Add("Male");
            //        cbb.Items.Add("Female");

            //        cbb.DropDownClosed += Cbb_DropDownClosed;
            //        cbb.TextChanged += Cbb_TextChanged;

            //    }
            //    this.dataStudent.Controls.Add(cbb);
            //}
            //catch
            //{
            //    return;
            //}

        }

        private void Cbb_TextChanged(object sender, EventArgs e)
        {

            //this.dataStudent.CurrentRow.Cells[3].Value = cbb.SelectedItem.ToString();

            //Student student = StudentController.getExistStudentName(
            //    this.dataStudent.CurrentRow.Cells[0].Value.ToString());
            //student.Gender = cbb.SelectedItem.ToString();
            //if (StudentController.UpdateStudent(student) == false)
            //{
            //    MessageBox.Show("Cannot update!");
            //}

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
                i = StudentController.DeleteStudent(id);
                if (i > 0)
                {
                    MessageBox.Show(" Xóa thành công");
                    DisplayStudent();
                    ClearData();
                    Student_Load(sender, e);
                }
                else
                    MessageBox.Show("Xóa không thành công");
            }
            else
                return;
        }

        private void dataStudent_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach(DataGridViewRow row in dataStudent.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.Azure;
                row.DefaultCellStyle.ForeColor = Color.Red;
            }
        }

        //private void btnFind_Click(object sender, EventArgs e)
        //{
        //    string id = this.txtID.Text.ToString();
        //    BindingSource bs = new BindingSource();
        //    DataTable dt = new DataTable();
        //    dt = StudentController.FillDataSet_getStudentById(id).Tables[0];
        //    this.dataStudent.DataSource = dt;
        //}

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string ID = "";
            try
            {
                ID = this.txtID.Text;
            }
            catch { return; }
            string Name = "";
            try
            {
                Name = this.txtFullname.Text;
            }
            catch { }
            DateTime birthday = this.dtpBirthday.Value;
            string gender = "";
            try
            {
                gender = this.txtGender.Text.Trim();
            }
            catch { }

            string email = "";
            try
            {
                email = this.txtEmail.Text.Trim();
            }
            catch { }
            string phone = "";
            try
            {
                phone = this.txtPhone.Text.Trim();
            }
            catch { }
            string Class = "";
            try
            {
                Class = this.txtClass.Text.Trim();
            }
            catch { }

            MemoryStream Picture = new MemoryStream();
            try
            {
                if (pictureStudent.Image != null)
                    pictureStudent.Image.Save(Picture, pictureStudent.Image.RawFormat);
                else
                {
                    Properties.Resources.Student.Save(Picture, Properties.Resources.Student.RawFormat);
                }
            }
            catch { }

            if (ID == "")
                MessageBox.Show("Hãy nhập tên bàn");
            else
            {
                int i = 0;
                i = StudentController.UpdateStudent(ID, Name, Picture, birthday, gender, Class, email, phone);
                if (i > 0)
                {
                    MessageBox.Show("Thêm mới thành công");
                    DisplayStudent();
                    Student_Load(sender, e);
                }
                else
                    MessageBox.Show("Thêm mới không thành công");
            }
            Student_Load(sender, e);
        }

   
        private void btnFind_Click(object sender, EventArgs e)
        {

            if (txtSearch.Text == "")
                MessageBox.Show("Hãy nhập vào ô tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            else
            {
                if (cbbSearch.Text == "ID")
                {
                    string ID = txtSearch.Text.ToString();
                    DataTable dt = new DataTable();
                    dt = StudentController.FillDataSet_getStudentById(ID).Tables[0];
                    if (dt.Rows.Count > 0)
                    {
                        dataStudent.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("ID" + txtSearch.Text + "Không có trong dữ liệu!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (cbbSearch.Text == "Name")
                {
                    string Name = txtSearch.Text.ToString();
                    DataTable dt = new DataTable();
                    dt = StudentController.FillDataSet_getStudentByName(Name).Tables[0];

                    if (dt.Rows.Count > 0)
                    {
                        dataStudent.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("Tên " + txtSearch.Text + " Không có trong dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //if (cbbSearch.Text == "ID")
            //{
            //    string ID= txtSearch.Text.ToString();
            //    DataTable dt = new DataTable();
            //    dt = StudentController.FillDataSet_getStudentById(ID).Tables[0];
            //    dataStudent.DataSource = dt;
            //}
            //if (cbbSearch.Text == "Name")
            //{
            //    string name = txtSearch.Text.ToString();
            //    DataTable dt = new DataTable();
            //    dt = StudentController.FillDataSet_getStudentByName(name).Tables[0];
            //    dataStudent.DataSource = dt;
            //}
        }

        private void buttonUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Select Image(*.jpg,*.png,*.gif)|*.jpg;*.png;*.gif";
            if((ofd.ShowDialog() == DialogResult.OK))
            {
                pictureStudent.Image = Image.FromFile(ofd.FileName);
                pictureStudent.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnDeletePic_Click(object sender, EventArgs e)
        {
            pictureStudent.Image = WindowsForm_FinalProject.Properties.Resources.Student;
        }

        private void dataStudent_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            string ID = dataStudent.CurrentRow.Cells[0].Value.ToString();
            //DataTable table = StudentController.FillDataSet_getStudentById(ID).Tables[0];
           try
            {
                DataRow row = tableStudent.Rows.Cast<DataRow>().Where(x => x.Field<string>("ID") == ID).First();
                if (row["Picture"] == DBNull.Value)
                {
                    pictureStudent.Image = Properties.Resources.Student;
                }
                else
                {
                    byte[] stream = (byte[])row["Picture"];
                    MemoryStream memoryStream = new MemoryStream(stream);

                    pictureStudent.Image = Image.FromStream(memoryStream);
                    pictureStudent.Show();
                }
            }
            catch
            {
            }
            //DataRow row = table.AsEnumerable()
            //   .SingleOrDefault(r => r.Field<string>("ID") == ID);

        }
    }
}

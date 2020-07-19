using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsForm_FinalProject.Connection;

namespace WindowsForm_FinalProject.Models
{
    class Student
    {
        public Student()
        {
            this.Projects = new HashSet<Project>();
        }

        public string ID { get; set; }
        public string Fullname { get; set; }
        public MemoryStream Picture { get; set; }

        public System.DateTime Birthday { get; set; }
        public string Gender { get; set; }
        public string Class { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public virtual ICollection<Project> Projects { get; set; }
        public Student(string ID)
        {
            this.ID = ID;
        }
      
        public Student(string ID, string fullname, MemoryStream Picture, DateTime birthday, string gender, string Class, string email, string phone)
        {
            this.ID = ID;
            this.Fullname = fullname;
            this.Picture = Picture;
            this.Birthday = birthday;
            this.Gender = gender;
            this.Class = Class;
            this.Email = email;
            this.Phone = phone;
        }
        public override string ToString()
        {
            return this.ID;
        }
        public int InsertStudent()
        {
            string[] paras = new string[8] { "@ID", "@Fullname", "@Picture", "@Birthday", "@Gender", "@Class", "@Email", "@Phone" };
            object[] values = new object[8] { ID, Fullname, Picture.ToArray(), Birthday, Gender, Class, Email, Phone };
            return MyDB.Execute_Sql("procedureInsertStudent", CommandType.StoredProcedure, paras, values);
        }
        public int UpdateStudent()
        {
            string[] paras = new string[8] { "@ID", "@Fullname", "@Picture", "@Birthday", "@Gender", "@Class", "@Email", "@Phone" };
            object[] values = new object[8] { ID, Fullname, Picture.ToArray(), Birthday, Gender, Class, Email, Phone };
            return MyDB.Execute_Sql("procedureUpdateStudent", CommandType.StoredProcedure, paras, values);
        }
        public int DeleteStudent()
        {
            string[] paras = new string[1] { "@ID" };
            object[] values = new object[1] { ID };
            return MyDB.Execute_Sql("procedureDeleteStudent", CommandType.StoredProcedure, paras, values);
        }
        public static DataSet FillDataSetStudent()
        {
            return MyDB.FillDataSet("SELECT * FROM dbo.viewStudent", CommandType.Text);
        }
        public DataSet obtainInformationStudentByID()
        {
            DataSet ds = new DataSet();
            string[] paras = new string[1] { "@ID" };
            object[] values = new object[1] { ID };
            ds = MyDB.FillDataSet("procedureObtainStudentByID", CommandType.StoredProcedure, paras, values);
            return ds;
        }
        public static DataSet StudentByProject(string IDProject)
        {
            return MyDB.FillDataSet("select * from Student WHERE ID in ( SELECT Student_ID FROM StudentProjects WHERE Project_PID='" + IDProject + "');", CommandType.Text);
        }
        public static DataSet StudentFeedback(string IDProject)
        {
            return MyDB.FillDataSet("select * from Student WHERE ID in ( SELECT Student_ID FROM StudentProjects WHERE Project_PID='" + IDProject + "');", CommandType.Text);
        }
        public DataSet obtainInformationStudentByName()
        {
            DataSet ds = new DataSet();
            string[] paras = new string[1] { "@Fullname" };
            object[] values = new object[1] { ID };
            ds = MyDB.FillDataSet("procedureObtainStudentByName", CommandType.StoredProcedure, paras, values);
            return ds;
        }
    }

}

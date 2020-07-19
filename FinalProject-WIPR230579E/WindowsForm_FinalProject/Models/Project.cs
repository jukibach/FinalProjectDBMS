using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsForm_FinalProject.Connection;

namespace WindowsForm_FinalProject.Models
{
    public class Project
    {
   
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        //public Project()
        //{
        //    //this.Students = new HashSet<Student>();
        //}

        public string PID { get; set; }
        public string PName { get; set; }
        public string PContent { get; set; }
        public string PType { get; set; }
        public DateTime PBegin { get; set; }
        public DateTime PEnd { get; set; }
        public string Score { get; set; }
        public string Comment { get; set; }
        //public virtual ICollection<Student> Students { get; set; }

        public Project(string PID)
        {
            this.PID = PID;
        }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Student> Students { get; set; }

        public Project(string PID, string PName, string PContent, string PType, DateTime PBegin, DateTime PEnd)
        {
            this.PID = PID;
            this.PName = PName;
            this.PContent = PContent;
            this.PType = PType;
            this.PBegin= PBegin;
            this.PEnd = PEnd;
        }

        
        public int InsertProject()
        {
            string[] paras = new string[6] { "@PID", "@PName", "@PContent", "@PType", "@PBegin", "@PEnd" };
            object[] values = new object[6] { PID, PName, PContent, PType, PBegin, PEnd };
            return MyDB.Execute_Sql("procedureInsertProject", CommandType.StoredProcedure, paras, values);
        }
        public int UpdateProject()
        {
            string[] paras = new string[6] { "@PID", "@PName", "@PContent", "@PType", "@PBegin", "@PEnd" };
            object[] values = new object[6] { PID, PName, PContent, PType, PBegin, PEnd };
            return MyDB.Execute_Sql("procedureUpdateProject", CommandType.StoredProcedure, paras, values);
        }
        public int DeleteProject()
        {
            string[] paras = new string[1] { "@PID" };
            object[] values = new object[1] { PID };
            return MyDB.Execute_Sql("procedureDeleteProject", CommandType.StoredProcedure, paras, values);
        }
        public static DataSet FillDataSetProject()
        {
            return MyDB.FillDataSet("SELECT * FROM dbo.viewProject", CommandType.Text);
        }
       
        internal DataSet FillDataSet_getProjectById()
        {
            
            DataSet ds = new DataSet();
            string[] paras = new string[1] { "@PID" };
            object[] values = new object[1] { PID };
            ds = MyDB.FillDataSet("procedureGetBanByID", CommandType.StoredProcedure, paras, values);
            return ds;
            
        }
        public static int InsertStudentToProject(string ID, string PID)
        {
            try
            {
                string[] paras = new string[2] { "@ID", "@PID" };
                object[] values = new object[2] { ID, PID };
                return MyDB.Execute_Sql("InsertStudentToProject", CommandType.StoredProcedure, paras, values);
            }
            catch
            {
                return 0;
            }
        }
    }
}

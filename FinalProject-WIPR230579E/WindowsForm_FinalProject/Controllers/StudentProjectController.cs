using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsForm_FinalProject.Connection;
using WindowsForm_FinalProject.Models;
namespace WindowsForm_FinalProject.Controllers
{
    class StudentProjectController
    {
        public claData data = new claData();
        //public int getproject(string IDStudent)
        //{
        //    //DataTable check = data.readdata("select * from Project WHERE PID in ( SELECT Project_PID FROM StudentProjects WHERE Student_ID='" + IDStudent + "');");
        //    DataSet check = MyDB.Execute_Sql("Select distinct(Project.PID), Project.PName, Project.PContent, Project.PType, Project.PBegin, Project.PEnd, Score.score, Score.comment " +
        //        "from Project Left Join Score ON(Project.PID = Score.PID)"+
        //        "Where Project.PID in (SELECT Project_PID FROM StudentProjects WHERE Student_ID = '" + IDStudent + "');");

        //    return check;
        //}
        public static DataSet FillDataSetProject(string IDStudent)
        {
            //DataSet check = MyDB.FillDataSet("Select distinct(Project.PID), Project.PName, Project.PContent, Project.PType, Project.PBegin, Project.PEnd, Score.score, Score.comment " +
            //    "from Project Left Join Score ON(Project.PID = Score.PID)" +
            //    "Where Project.PID in (SELECT Project_PID FROM StudentProjects WHERE Student_ID = '" + IDStudent + "');", CommandType.Text);
            string[] para = new string[1] { "@ID" };
            object[] value = new object[1] { IDStudent};
            return MyDB.FillDataSet("procedureGetProjectsByStudent",CommandType.StoredProcedure, para, value);
        }
      
        public static DataSet getInfoProjectName(string IDStudent)
        {
            string[] para = new string[1] { "@ID" };
            object[] value = new object[1] { IDStudent };
            return MyDB.FillDataSet("procedureProjectsForCombobox", CommandType.StoredProcedure, para, value);
        }
        public static DataSet getProjectName()
        {
            return MyDB.FillDataSet("SELECT * FROM dbo.viewProject", CommandType.Text);
        }
        public static DataSet getStudentScore()
        {

            return MyDB.FillDataSet("SELECT * FROM dbo.viewScore", CommandType.Text);
        }
        public static DataSet getStudentScore(string PID)
        {
            string[] para = new string[1] { "@PID" };
            object[] value = new object[1] { PID };
            return MyDB.FillDataSet("procedureGetAllScoreByProject", CommandType.StoredProcedure, para, value);
        }
        
        //public int getIDProject(string PName)
        //{
        //    DataTable dt = data.readdata("select PID from Project WHERE PName ='" + PName + "');");
        //    return dt;
        //}
    }
}

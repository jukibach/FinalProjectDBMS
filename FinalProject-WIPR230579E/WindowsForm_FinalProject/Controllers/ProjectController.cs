using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForm_FinalProject.Connection;
using WindowsForm_FinalProject.Models;

namespace WindowsForm_FinalProject.Controllers
{
     public class ProjectController
    {
        public claData data = new claData();
        //public static bool checkExistProject(int PID)
        //{
        //    using (var _context = new DBProjectsEntities())
        //    {
        //        var student = from u in _context.Projects
        //                      where u.PID == PID
        //                      select u;
        //        if (student.Count() == 1)
        //        {
        //            return true;
        //        }

        //        return false;

        //    }
        //}
        //public static bool checkExistProject(int PID)
        //{
        //    using (var _context = new DBProjectsEntities())
        //    {
        //        var student = from u in _context.Projects
        //                      where u.PID == PID
        //                      select u;
        //        if (student.Count() == 1)
        //        {
        //            return true;
        //        }

        //        return false;

        //    }
        //}
        //public static Project getExistProject(int PID)
        //{
        //    using (var _context = new DBProjectsEntities())
        //    {
        //        var student = from u in _context.Projects
        //                      where u.PID == PID
        //                      select u;
        //        if (student.Count() == 1)
        //        {
        //            return student.Single();
        //        }

        //        return null;

        //    }
        //}
        //public static bool AddProject(Project project)
        //{

        //        using (var _context = new DBProjectsEntities())
        //        {
        //            foreach(var u in project.Students)
        //            {
        //                var student = (from x in _context.Students
        //                               where x.ID == u.ID
        //                               select x).SingleOrDefault();
        //                student.Projects.Add(project);
        //            }
        //            project.Students.Clear();
        //            _context.Projects.AddOrUpdate(project);
        //            _context.SaveChanges();
        //            return true;
        //        }

        //}
        public static DataSet getAllProject()
        {
            return MyDB.FillDataSet("SELECT * FROM dbo.viewProject", CommandType.Text);

        }
        public static DataSet getAllNameProject()
        {
            return MyDB.FillDataSet("SELECT * FROM dbo.viewProject", CommandType.Text);
        }
       
        public static int InsertProject(string PID, string PName, string PContent, string PType, DateTime PBegin, DateTime PEnd)
        {
            try
            {
                Models.Project _project = new Models.Project(PID, PName, PContent, PType, PBegin,  PEnd);
                return _project.InsertProject();
            }
            catch
            {
                return 0;
            }
        }
        public static int UpdateProject(string PID, string PName, string PContent, string PType, DateTime PBegin, DateTime PEnd)
        {
            try
            {
                Models.Project _project = new Models.Project(PID, PName, PContent, PType, PBegin, PEnd);
                return _project.UpdateProject();
            }
            catch
            {
                return 0;
            }

        }
        public static int DeleteProject(string PID)
        {
            try
            {
                Project _project = new Project(PID);
                return _project.DeleteProject();
            }
            catch
            {
                return 0;
            }

        }
    }
}

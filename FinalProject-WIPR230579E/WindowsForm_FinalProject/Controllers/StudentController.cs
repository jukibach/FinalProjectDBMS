using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsForm_FinalProject.Models;

namespace WindowsForm_FinalProject.Controllers
{
    public class StudentController
    {
        claData data = new claData();
        //public static bool checkExistStudentName(string ID)
        //{
        //    using (var _context = new DBProjectsEntities())
        //    {
        //        var student = from u in _context.Students
        //                      where u.ID == ID
        //                      select u;
        //        if (student.Count() == 1)
        //        {
        //            return true;
        //        }

        //        return false;

        //    }
        //}
        //public static Student getExistStudentName(string ID)
        //{
        //    using (var _context = new DBProjectsEntities())
        //    {
        //        var student = (from u in _context.Students
        //                      where u.ID == ID
        //                      select u);
        //        if (student.Count() == 1)
        //        {
        //            return student.Single();
        //        }
        //        return null;

        //    }
        //}
        //public static bool AddStudents(Student student)
        //{
        //    try
        //    {
        //        using (var _context = new DBProjectsEntities())
        //        {
        //            _context.Students.Add(student);
        //            _context.SaveChanges();
        //            return true;
        //        }
        //    }
        //    catch
        //    { return false; }
        //}
        //public static List<Student> getAllStudents()
        //{
        //    using (var _context = new DBProjectsEntities())
        //    {
        //        var students = (from u in _context.Students.AsEnumerable()
        //                        select new
        //                        {
        //                            ID = u.ID,
        //                            Fullname = u.Fullname,
        //                            Birthday = u.Birthday,
        //                            Gender = u.Gender,
        //                            Class = u.Class,
        //                            Email = u.Email,
        //                            Phone = u.Phone,
        //                        })
        //                    .Select(x => new Student
        //                    {
        //                        ID = x.ID,
        //                        Fullname = x.Fullname,
        //                        Birthday = x.Birthday,
        //                        Gender = x.Gender,
        //                        Class = x.Class,
        //                        Email = x.Email,
        //                        Phone = x.Phone,
        //                    });
        //        return students.ToList();
        //    }

        //}
        //public static List<Student> getAllStudents(string ID)
        //{
        //    using (var _context = new DBProjectsEntities())
        //    {
        //        var students = (from u in _context.Students.AsEnumerable()
        //                        where u.ID.Contains(ID)
        //                        select new
        //                        {
        //                            Fullname = u.Fullname,
        //                            ID = u.ID,
        //                            Birthday = u.Birthday,
        //                            Gender = u.Gender,
        //                            Class = u.Class,
        //                            Email = u.Email,
        //                            Phone = u.Phone,
        //                        })
        //                    .Select(x => new Student
        //                    {
        //                        Fullname = x.Fullname,
        //                        ID = x.ID,
        //                        Birthday = x.Birthday,
        //                        Gender = x.Gender,
        //                        Class = x.Class,
        //                        Email = x.Email,
        //                        Phone = x.Phone,
        //                    });
        //        return students.ToList();
        //    }

        //}
        //public static bool DeleteStudent(string ID)
        //{

        //    using (var _context = new DBProjectsEntities())
        //    {
        //        var student = (from u in _context.Students
        //                       where u.ID == ID
        //                       select u).SingleOrDefault();

        //        _context.Students.Remove(student);
        //        _context.SaveChanges();
        //        return true;
        //    }
        //}
        //public static bool UpdateStudent(Student useradd)
        //{
        //    using (var _context = new DBProjectsEntities())
        //    {
        //        var student = (from u in _context.Students
        //                       where u.ID == useradd.ID
        //                       select u).SingleOrDefault();
        //        student.Fullname = useradd.Fullname;
        //        student.Birthday = useradd.Birthday;
        //        student.Gender = useradd.Gender;
        //        student.Class = useradd.Class;
        //        student.Email = useradd.Email;
        //        student.Phone = useradd.Phone;

        //        //context.Students.AddOrUpdate(student);
        //        _context.SaveChanges();
        //        return true;
        //    }
        //}
        
        public static DataSet FillDataSet_getStudentById(string id)
        {
            try
            {
                Student student = new Student(id);
                return student.obtainInformationStudentByID();
            }
            catch
            {
                return null;
            }
        }
        public static int InsertStudent(string ID, string fullname, MemoryStream Picture, DateTime birthday, string gender, string Class, string email, string phone)
        {
            try
            {
                Student _student = new Student(ID, fullname, Picture, birthday, gender, Class, email, phone);
                return _student.InsertStudent();
            }
            catch
            {
                return 0;
            }
        }
        public static int UpdateStudent(string ID, string fullname, MemoryStream Picture,DateTime birthday, string gender, string Class, string email, string phone)
        {
            try
            {
                Student _student = new Student(ID, fullname, Picture ,birthday, gender, Class, email, phone);
                return _student.UpdateStudent();
            }
            catch
            {
                return 0;
            }

        }
        public static int DeleteStudent(string ID)
        {
            try
            {
                Student _student= new Student(ID);
                return _student.DeleteStudent();
            }
            catch
            {
                return 0;
            }

        }
        public static DataSet FillDataSet_getStudentByName(string Fullname)
        {
            try
            {
                Student student = new Student(Fullname);
                return student.obtainInformationStudentByName();
            }
            catch
            {
                return null;
            }
        }
    }
}

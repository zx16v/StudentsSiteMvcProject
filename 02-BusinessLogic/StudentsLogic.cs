using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShimiTest
{

    public class StudentViewModel
    {
        public int ID { get; set; }
        public string First_name_ { get; set; }
        public string Last_name_ { get; set; }
        public System.DateTime Date_of_birth { get; set; }
        public string Israeli_ID_ { get; set; }
        public string Description_ { get; set; }
        public string CityName { get; set; }
    }


    public class StudentsLogic : BaseLogic
    {
        public List<GetAllStudents_Result> GetAllStudents()
        {
             
            return DB.GetAllStudents().ToList();
        }

        public GetAllStudents_Result GetStudent1(int id)
        {
            var Student = DB.GetAllStudents().Where(c => c.ID.Equals(id)).SingleOrDefault();
            return Student;
        }

        public Student GetStudent(int id)
        {
            return DB.Students.Where(c => c.ID.Equals(id)).SingleOrDefault();
        }

        public StudentViewModel getStudent2(int id)
        {
            StudentViewModel student = new StudentViewModel();
            var Student = DB.GetAllStudents().Where(c => c.ID.Equals(id)).SingleOrDefault();
            student.ID = Student.ID;
            student.First_name_ = Student.First_name_;
            student.Last_name_ = Student.Last_name_;
            student.Israeli_ID_ = Student.Israeli_ID_;
            student.CityName = Student.CityName;
            student.Date_of_birth = Student.Date_of_birth;
            return student;
        }



    }
}

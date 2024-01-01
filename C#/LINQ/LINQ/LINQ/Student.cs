using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LINQ
{
    public class Student
    {
        public  int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }

        public static List<Student> GetAllStudent()
        {
            List<Student> listStudents = new List<Student>();
            Student student1 = new Student
            {
                ID=101,
                Name="Mark",
                Gender="Male"
            };
            listStudents.Add(student1);
            Student student2 = new Student
            {
                ID = 102,
                Name = "Maty",
                Gender = "FeMale"
            };
            listStudents.Add(student2);
            Student student3 = new Student
            {
                ID = 103,
                Name = "John",
                Gender = "Male"
            };
            listStudents.Add(student3);
            return listStudents;
        }
    }
}
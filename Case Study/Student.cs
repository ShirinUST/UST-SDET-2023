using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Study
{
    internal class Student
    {
        public Student(int studentID, string? name, string? email)
        {
            StudentID = studentID;
            Name = name;
            Email = email;
        }

        public int StudentID {  get; set; }
        public string? Name { get; set; }
        public string? Email {  get; set; }
        public static List<Student> Students= new List<Student>();

        public static void AddStudent(Student student)
        {
            var obj=Students.Find(x=>x.StudentID==student.StudentID);
            if(obj==null) 
            {
                Students.Add(student);
                Console.WriteLine("Student Added Successfully");

            }
            else
            {
                Console.WriteLine("Student already exist....");
            }
        }

    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class LINQExample
    {
        public void Exampl1()
        {
            List<string> list = new List<string>();
            list.Add("C Tutorial");
            list.Add("Java Tutorial");
            list.Add("C# Tutorial");
            list.Add("DBMS");
            list.Add("UI Tutorial");
            list.Add("Web Tech Tutorial");

            //var course=from item in list
            //           where item.Equals("DBMS")
            //           select item;
            var course = list.Where(x => x.Contains("C"));
            foreach (var item in course)
                Console.WriteLine(item);
        }
        public void Exampl2() 
        {
            List<Student> students = new List<Student>();
            students.Add(new Student(1, "Vishnu", "MCA"));
            students.Add(new Student(2, "Gokul", "MTech"));
            students.Add(new Student(3, "Shirin", "MBA"));
            students.Add(new Student(4, "Jachithra", "Electrical"));

            Student student = students.FirstOrDefault(x => x.Id == 3);
            //foreach(var student in stud)
                Console.WriteLine(student.Id+" "+student.Name+" "+student.Department);

            List<Student> stud1 =(List<Student>) students.FindAll(x => x.Name == "Shirin"||x.Name=="Vishnu");
            foreach (var stud in stud1)
                Console.WriteLine(stud.Id + " " + stud.Name + " " + stud.Department);
        }
        public void Exampl3()
        {
            ArrayList array= new ArrayList();
            array.Add(1);
            array.Add(2);
            array.Add("Three");
            array.Add(4);
            array.Add("Five");
            var numbers = array.OfType<int>();
            var strings = array.OfType<string>();
            foreach( var s in numbers)
            {
                Console.WriteLine(s);
            }
            foreach( var s in strings)
            { Console.WriteLine(s); }
        }
        public void SortingOrderBy()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student(1, "Vishnu", "MCA"));
            students.Add(new Student(2, "Gokul", "MTech"));
            students.Add(new Student(3, "Shirin", "MBA"));
            students.Add(new Student(4, "Jachithra", "Electrical"));
            var result=students.OrderBy(x=>x.Name).ThenBy(x=>x.Department);
            foreach( var student in result)
                Console.WriteLine(student.Id+" "+student.Name+" "+student.Department);
        }
    }
}

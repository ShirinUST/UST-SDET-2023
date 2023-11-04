using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Case_Study
{
    internal class Course:IEnrollable
    {
        public string? CourseCode {  get; set; }
        public string? Title { get; set; }
        public string? Instructor { get; set; }
        public int MaxCount {  get; set; }
        public static List<Course> courses = new List<Course>();

        public Course(string? courseCode, string? title, string? instructor ,int maxCount)
        {
            CourseCode = courseCode;
            Title = title;
            Instructor = instructor;
            MaxCount = maxCount;
        }

        public void RegisterCourse(int id,string code)
        {
            var obj = Course.courses.Find(x => x.CourseCode == code);
            if (obj != null)
            {
                Enrollment enrol = new(obj.CourseCode, obj.Title, obj.Instructor, obj.MaxCount, id);
                Enrollment.enrollments.Add(enrol);
            }
            else
            {
                Console.WriteLine("No such Course exist...");
            }
        }

        public void WithdrawCourse(int sId, string cCode)
        {
            var delEnroll = Enrollment.enrollments.Find(x => x.ID == sId && x.CourseCode == cCode);
            if (delEnroll != null)
            {
                Enrollment.enrollments.Remove(delEnroll);
            }
            else
            {
                Console.WriteLine("You are not registered to that course......");
            }
        }
        public static void DisplayCourse()
        {
            foreach (var c in courses)
            {
                Console.WriteLine(c.CourseCode+"           "+c.Title+"            "+c.Instructor+"           "+c.MaxCount);
            }
        }

    }
}

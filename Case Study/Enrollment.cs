using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Study
{
    internal class Enrollment:Course
    {
        public Enrollment(string? courseCode, string? title, string? instructor, int maxCount,int id) : base(courseCode, title, instructor, maxCount)
        {
            ID= id;
        }
        public static List<Enrollment> enrollments= new List<Enrollment>();
        public int ID {  get; set; }
        
    }
}

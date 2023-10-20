using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class TeachingStaff:StaffDetails
    {
        public string? Specialization {  get; set; }    
        public int Semester {  get; set; }  
        public void DisplayTStaffDetails()
        {
            Console.WriteLine("Specialization: {0}\nSemester: {1}",Specialization,Semester);
        }
    }
}

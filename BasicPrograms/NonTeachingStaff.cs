using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class NonTeachingStaff:StaffDetails
    {
        public string? Responsibilities { get; set; }
        public int Experience { get; set; }
        public void DisplayNTStaffDetails()
        {
            Console.WriteLine("Responsiblities: {0}\nExperiense: {1}", Responsibilities, Experience);
        }
    }
}

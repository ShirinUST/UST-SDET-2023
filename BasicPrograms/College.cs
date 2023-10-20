using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class College
    {
        public int CollegeId {  get; set; }
        public string? CollegeName { get; set; }
        public string? CollegeType { get; set; }

        public string DisplayCollegeDetails()
        {
            return $"College Id: {CollegeId}\nCollege Name: {CollegeName}\nCollege Type: {CollegeType}";
        }
    }
}

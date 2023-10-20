using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class StaffDetails:College
    {
        public int StaffId {  get; set; }
        public string? Name { get; set; }
        public string? Department { get; set; }=string.Empty;

        public void DisplayStaffDetails()
        {
            Console.WriteLine("Id: {0}\nName: {1}\nDepartment: {2}",StaffId,Name,Department);
        }
    }
}

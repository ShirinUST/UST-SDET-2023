using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class Doctor : IDoctor,IAppointment
    {
        public int Did { get; set; }
        public string? DName { get; set; }
        public void AddNewDoctor(int did, string? name)
        {
            Did = did;
            DName = name;
        }

        public void ModifyDoctor(int did, string? name)
        {
            Did = did;
            DName = name;
        }
        public void DisplayDoctor()
        {
            Console.WriteLine("Doctor Id: {0}\nName: {1}",Did,DName);
        }

        public void BookAppointment(int docId, string? pName)
        {
            Console.WriteLine("Appontment booked to the Id {0} by the {1}",docId,pName);
        }

        public void DeleteAppointment(string? pName)
        {
            Console.WriteLine("Canceled appointment for {0}",pName);
        }
    }
}

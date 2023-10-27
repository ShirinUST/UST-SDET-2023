using Assignments.ExceptionMessage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Patient
    {
        public static List<Patient> patients=new List<Patient>();

        public Patient(int patientId, string? name, int age, string? diagnosis)
        {
            PatientId = patientId;
            Name = name;
            Age = age;
            Diagnosis = diagnosis;
        }

        public int PatientId { get; set; }
        public string? Name { get; set;}
        public int Age {  get; set; }
        public string? Diagnosis { get; set; }

        public static void AddPatientDetails(Patient p)
        {
            //if(p.Age<0 || p.Age>120)
            // {
            //     throw new AgeException(CustomException.ExceptMessage["Age"]);
            // }
            //if(String.IsNullOrWhiteSpace(p.Name))
            // {
            //     throw new NameException(CustomException.ExceptMessage["Name"]);
            // }
            //if(String.IsNullOrWhiteSpace(p.Diagnosis))
            // {
            //     throw new DiagException(CustomException.ExceptMessage["Diag"]);
            // }
            //patients.Add(p);
            FileStream fs = new FileStream("D:\\C# ClassWork\\Basic Solution\\Sample\\PatientDetails.txt",
                FileMode.Append, FileAccess.Write);
            StreamWriter sw=new StreamWriter(fs);
            sw.WriteLine("Id : {0}  Name : {1}  Age : {2}  Diagnosis : {3}", p.PatientId, p.Name, p.Age, p.Diagnosis);
            sw.Flush();
            sw.Close();
            fs.Close();

        }
        public static void DisplayPatient()
        {
            foreach(Patient patient in patients)
            {
                Console.WriteLine("Patient Id : {0}  Name : {1}  Age : {2}  Diagnosis : {3}  ",patient.PatientId,patient.Name,patient.Age,patient.Diagnosis);
            }
            FileStream fs = new FileStream("D:\\C# ClassWork\\Basic Solution\\Sample\\PatientDetails.txt",
               FileMode.Open, FileAccess.Read);
            StreamReader sr=new StreamReader(fs);
            string txt=sr.ReadToEnd();
            Console.WriteLine(txt);
            sr.Close();
            fs.Close();
        }
    }
}

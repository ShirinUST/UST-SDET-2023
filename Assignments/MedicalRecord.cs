using Assignments.ExceptionMessage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class MedicalRecord:Patient
    {
        public static List<MedicalRecord> med = new List<MedicalRecord>();
        public MedicalRecord(int patientId, string? name, int age, string? diagnosis, int recordId, double totalCost) : base(patientId, name, age, diagnosis)
        {
            PatientId = patientId;
            Name = name;
            Age = age;
            Diagnosis = diagnosis;
            RecordId = recordId;
            TotalCost = totalCost;
        }

        public int RecordId {  get; set; }
        public double TotalCost { get; set; }
        public static void AddMedicalRecord(MedicalRecord medical)
        {
            //Patient p=new(medical.PatientId,medical.Name,medical.Age,medical.Diagnosis);
            //AddPatientDetails(p);
            if(String.IsNullOrWhiteSpace(medical.Name))
            {
                throw new InvalidPatientDataException(CustomException.ExceptMessage["Name"]);
            }
            if (String.IsNullOrWhiteSpace(medical.Diagnosis))
            {
                throw new InvalidPatientDataException(CustomException.ExceptMessage["Diag"]);
            }
            if (medical.TotalCost<0)
            {
                throw new InvalidMedicalRecordException(CustomException.ExceptMessage["Cost"]);
            }
            med.Add(medical);
        }
        public static void DisplayMed()
        {
            foreach(var item in med)
            {
                Console.WriteLine("Patient Id : {0}  Patient Name : {1}  Age : {2}  Diagnosis : {3}  Record Id : {4}  TreatmentCost : {5}",item.PatientId,item.Name,item.Age,item.Diagnosis,item.RecordId,item.TotalCost);
            }
        }

    }
}

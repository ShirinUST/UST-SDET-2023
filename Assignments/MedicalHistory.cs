using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class MedicalHistory
    {
        public static List<MedicalHistory> History = new List<MedicalHistory>();
        public MedicalHistory(int recordId, int patientId, string? description, string? date)
        {
            RecordId = recordId;
            PatientId = patientId;
            Description = description;
            Date = date;
        }

        public int RecordId { get; set; }
        public int PatientId { get; set; }
        public string? Description { get; set; }
        public string? Date {  get; set; }
        public static void AddHistoryToList(MedicalHistory history)
        {
            History.Add(history);

        }

        public static void AddHistoryToFile(MedicalHistory history)
        {
            FileStream fs = new FileStream("D:\\C# ClassWork\\Basic Solution\\Sample\\PatientHistory.txt",
               FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("{0} {1} {2} {3}", history.RecordId, history.PatientId,history.Description,history.Date);
            sw.Flush();
            sw.Close();
            fs.Close();

        }
        public static void DisplayPatient(int id)
        {
            FileStream fs = new FileStream("D:\\C# ClassWork\\Basic Solution\\Sample\\PatientHistory.txt",
               FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string? line = sr.ReadLine();
            while(line != null)
            {
                string[] a=line.Split(" ");
                int n = int.Parse(a[1]);
                if (n==id)
                {
                    Console.WriteLine("RecId:{0}  Patient Id:{1}  Description:{2}  Date:{3}", a[0], a[1], a[2], a[3]);
                }
                line = sr.ReadLine();
            }
            sr.Close();
            fs.Close();

        }


    }
}

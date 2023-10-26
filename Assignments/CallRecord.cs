using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class CallRecord
    {
        public static List<CallRecord> callRecords = new List<CallRecord>();
        public CallRecord(int callId, long phoneNumber, double timeStamp)
        {
            CallId = callId;
            PhoneNumber = phoneNumber;
            TimeStamp = timeStamp;
        }

        public int CallId {  get; set; }
        public long PhoneNumber {  get; set; }
        public double TimeStamp {  get; set; }

        public static void DisplayCallHistory(long phone)
        {
            var list = callRecords.FindAll(x => x.PhoneNumber == phone);
            if (list.Count > 0)
            {
                Console.WriteLine("Records of Phone Number: "+phone);
                foreach (var record in list)
                {
                    Console.WriteLine("Call Id: {0}  Timestamp: {1}  ",record.CallId,record.TimeStamp);
                }
            }
            else
            {
                Console.WriteLine("No record found...");
            }
        }
        public static void DisplayTotalNumberOfCalls()
        {

            Dictionary<long, int> callCount = new Dictionary<long, int>();
            foreach (var callRecord in callRecords)
            {
                if (callCount.ContainsKey(callRecord.PhoneNumber))
                {
                    callCount[callRecord.PhoneNumber]++;
                }
                else
                {
                    callCount[callRecord.PhoneNumber] = 1;
                }
            }
            Console.WriteLine("Calling Count:");
            foreach (var i in callCount.Keys)
            {
                Console.WriteLine(i+" : " + callCount[i]);
            }
        }
    }
}

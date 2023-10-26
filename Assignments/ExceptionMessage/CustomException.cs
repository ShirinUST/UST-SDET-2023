using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.ExceptionMessage
{
    internal class CustomException
    {
        public static Dictionary<string, string> ExceptMessage = new Dictionary<string, string>()
        {
            {"Age","Age Must be between 0 and 120" },
            {"Name","Name cannot be null or empty" },
            {"Diag","Diagnosis cannot be null or empty"}
        };
    }
}

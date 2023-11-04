using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Study.CustomException
{
    internal class EnrollmentException
    {
        public static Dictionary<string, string> EnrollEx = new Dictionary<string, string>()
        {
            {"full","Course Already Full" },
            {"enroll","You are already registered to this course" }
        };
    }
    internal class UserException:Exception
    {
        public UserException(string message):base(message)
        { }
    }
}

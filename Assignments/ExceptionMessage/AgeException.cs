using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.ExceptionMessage
{
    internal class AgeException:Exception
    {
        public AgeException(string message):base(message)
        { 
        }
    }

    internal class NameException : Exception
    {
        public NameException(string message) : base(message)
        {
        }
    }

    internal class DiagException : Exception
    {
        public DiagException(string message) : base(message)
        {
        }
    }

    internal class InvalidPatientDataException : Exception
    {
        public InvalidPatientDataException(string message) : base(message)
        {
        }
    }
    internal class InvalidMedicalRecordException : Exception
    {
        public InvalidMedicalRecordException(string message) : base(message)
        {
        }
    }

}

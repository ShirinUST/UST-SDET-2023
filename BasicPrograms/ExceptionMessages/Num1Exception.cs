using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms.ExceptionMessages
{
    internal class Num1Exception:Exception
    {
        public Num1Exception(string message):base(message) 
        {
        }
    }
    internal class Num2Exception : Exception
    {
        public Num2Exception(string message) : base(message)
        {
        }
    }
}

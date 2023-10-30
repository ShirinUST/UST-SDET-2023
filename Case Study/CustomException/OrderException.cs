using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Study.CustomException
{
    internal class OrderException:Exception
    {
        public OrderException(string message):base(message) 
        { }
    }
    internal class CustomExceptions
    {
        public static Dictionary<string, string> OrderEx = new Dictionary<string, string>()
        {
            {"order","Out of Stock" }
        };
    }
}

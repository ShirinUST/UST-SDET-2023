using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms.ExceptionMessages
{
    internal class MyExceptions
    {
       public static Dictionary<int,string> exmsgList = new Dictionary<int,string>()
        {
           { 1, "Dont give zero for denominator" },
           { 2, "Index is out of range" },
           { 3, "Unknown" },
           {4,"Below 100" },
           {5,"Above 100" }
        };
    }
}

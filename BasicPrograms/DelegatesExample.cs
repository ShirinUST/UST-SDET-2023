using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class DelegatesExample
    {
        //public int Num1 { get; set; }
        //public int Num2 { get; set; }
        public void Add(int num1,int num2)
        {
            Console.WriteLine(num1+num2);
        }
        public void Sub(int num1, int num2)
        {
            Console.WriteLine(num1 - num2);
        }
        public void MethodA()
        {
            Console.WriteLine("Hello");
        }
    }
}

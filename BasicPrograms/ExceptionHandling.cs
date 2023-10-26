using BasicPrograms.ExceptionMessages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class ExceptionHandling
    {
        public ExceptionHandling(int num1, int num2)
        {
            Num1 = num1;
            Num2 = num2;
        }

        public int Num1 { get; set; }
        public int Num2 { get; set; }
        public void Divide()
        {
           
                int[] num = {10,20,30};
                //double res = Num1 / Num2;
                //Console.WriteLine(res);

                //for(int i = 0;i<=3;i++)
                    for (int i = 0; i <= 3; i++)
                    {
                    int res = num[i] / Num2;
                    Console.WriteLine(res);
                }
            
            
        }
        public void NumCheck()
        {
            if(Num1>100)
            {
                Console.WriteLine("congrats");
            }
            else
            {
                throw new Num1Exception(MyExceptions.exmsgList[4]);
            }
        }
        public void NumCheckOne()
        {
            if (Num2 < 100)
            {
                Console.WriteLine("congrats");
            }
            else
            {
                throw new Num2Exception(MyExceptions.exmsgList[5]);
            }
        }
    }
}

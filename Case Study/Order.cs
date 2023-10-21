using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Study
{
    internal class Order:Customer
    {
       
        public string? OrderDate {  get; set; }
        public double TotalCost {  get; set; }
        public void GetOrderDetails()
        {
            Console.WriteLine("Order Date : "+OrderDate);
            Console.WriteLine("TotalCost : " + TotalCost);
        }
    }
}

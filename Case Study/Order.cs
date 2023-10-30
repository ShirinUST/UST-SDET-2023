using Case_Study.CustomException;
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
        public void PPOrderVerification(int id)
        {
            var a=PhysicalProduct.Products.Find(x => x.ProductId == id);
            if(a.StockQuantity<=0)
            {
                throw new OrderException(CustomExceptions.OrderEx["order"]);
            }
        }
        public void DPOrderVerification(int id)
        {
            var a = DigitalProduct.Products.Find(x => x.ProductId == id);
            if (a.StockQuantity <= 0)
            {
                throw new OrderException(CustomExceptions.OrderEx["order"]);
            }
        }
    }
}

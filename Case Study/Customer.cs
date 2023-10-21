using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Study
{
    internal class Customer
    {

        public string? Name { get; set; }
        public int Contact {  get; set; }
        public int CustomerId {  get; set; }

        public void GetCustomerDetails()
        {
            Console.WriteLine("Name: {0}\nContact: {1}\nCustomerId: {2}",Name,Contact,CustomerId);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Customer
    {
        public static List<Customer> customers = new List<Customer>();
        public Customer(int customerId, string customerName, int phoneNumber, double balance)
        {
            CustomerId = customerId;
            CustomerName = customerName;
            PhoneNumber = phoneNumber;
            Balance = balance;
        }

        public int CustomerId {  get; set; }
        public string CustomerName { get; set; }
        = string.Empty;
        public int PhoneNumber {  get; set; }
        public double Balance {  get; set; }

        public static void GetCustomerDetails(int ph)
        {
            //foreach (var customer in customers)
            //{
            //    if(customer.PhoneNumber==ph)
            //    {
            //        Console.WriteLine("Customer Name : {0}   Balance : {1} ",customer.CustomerName,customer.Balance);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Customer Not Found");
            //            }
            //}
            var cust = customers.Find(x => x.PhoneNumber == ph);
            if (cust != null)
            {
                Console.WriteLine("Customer Name : {0}   Balance : {1} ", cust.CustomerName, cust.Balance);
            }
            else
                Console.WriteLine("Customer Not Found");
        }
        public static void DisplayAllCustomers()
        {
            Console.WriteLine();
            Console.WriteLine("Customer Details");
            foreach (var customer in customers)
            {
                Console.WriteLine();
                Console.WriteLine("Customer Id:{0}  Customer Name:{1}  Phone Number:{2}  Balance:{3}  ",customer.CustomerId,customer.CustomerName,customer.PhoneNumber,customer.Balance);
            }
            
        }

    }
}

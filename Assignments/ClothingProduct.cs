using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class ClothingProduct : Product
    {
        public string? Size {  get; set; }
        public ClothingProduct(string? productName, double price, int quantity, string? size) : base(productName, price, quantity)
        {
            ProductName = productName;
            Price = price;
            Quantity = quantity;
            Size = size;
        }
        public void DisplaySize()
        {
            Console.WriteLine("Size of Cloth: "+Size);
        }
    }
}

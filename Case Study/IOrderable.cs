using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Study
{
    internal interface IOrderable
    {
        public void PlaceOrder();
        public void ProcessPayment();
        public void DeliverProduct();

    }
}

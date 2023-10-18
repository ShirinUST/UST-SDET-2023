//stub code

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class Electricity
    {
        int consumerNumber, previousReading, currentReading;
        string? consumerName;

        public Electricity(int consumerNumber, int previousReading, int currentReading, string? consumerName)
        {
            this.consumerNumber = consumerNumber;
            this.previousReading = previousReading;
            this.currentReading = currentReading;
            this.consumerName = consumerName;
        }

        //public  Electricity()
        // {
        //     consumerNumber = 123456;
        //     previousReading = 500;
        //     currentReading = 1500;
        //     consumerName = "Shirin";
        // }
        public double CalculateBill()
        {
            double billamount;//if we assign zero while we are giving it some value then it will show warning
            int reading = currentReading - previousReading;
            if(reading<=100)
            {
                billamount = reading * 2.00;
            }
            else if(reading<=200 &&  reading>=101)
            {
                billamount = (100 * 2) + ((reading - 100) * 2.5);
            }
            else if(reading<=400 && reading>=201)
            {
                billamount = (100 * 2) + (100 * 2.5) + ((reading - 200) * 3.5);
            }
            else
            {
                billamount = (100*2)+(100*2.5)+(200*3.5)+((reading-400)*5.00);
            }
            return billamount;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class LifeInsurance : InsurancePolicyAbstract
    {
        public int Age { get; set; }
        public override double CalculatePremium()
        {
            if (Age < 15)
                PremiumAmount = 1000;
            else if (Age < 30)
                PremiumAmount = 3000;
            else if (Age < 60)
                PremiumAmount = 3500;
            else
                PremiumAmount = 4000;
            return PremiumAmount;


        }
    }
}

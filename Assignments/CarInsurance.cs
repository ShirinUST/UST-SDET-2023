using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class CarInsurance : InsurancePolicyAbstract
    {
        public double Price {  get; set; }
        public override double CalculatePremium()
        {
            if (Price > 1000000)
                PremiumAmount +=PremiumAmount* 0.5;
            else if (Price > 500000)
                PremiumAmount +=PremiumAmount* 0.4;
            else if (Price > 100000)
                PremiumAmount +=PremiumAmount* 0.3;
            else
                PremiumAmount += PremiumAmount*0.2;
            return PremiumAmount;

        }
    }
}

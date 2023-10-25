using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class InsurancePolicy
    {
        string? policyName;
        int policyId;
        double premiumAmount;

        public InsurancePolicy(string? policyName, int policyId, double premiumAmount)
        {
            this.policyName = policyName;
            this.policyId = policyId;
            this.premiumAmount = premiumAmount;
        }

        public void RenewPolicy(double newPremium)
        {
            premiumAmount= newPremium;
            Console.WriteLine("Policy Name:{0}\nPolicy Id: {1}\nPremium Amount: {2}",policyName,policyId,premiumAmount);
        }
        public void RenewPolicy()
        {
            premiumAmount += premiumAmount * 0.1;
            Console.WriteLine("Policy Name: {0}\nPolicy Id: {1}\nPremium Amount: {2}", policyName, policyId, premiumAmount);
        }
    }
}

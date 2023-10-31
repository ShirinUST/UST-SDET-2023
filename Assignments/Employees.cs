using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Employees
    {
        public int EmployeeId {  get; set; }
        public string? EmployeeName { get; set; }
        public double PerformanceRating {  get; set; }

        public double PerformanceBonusCalculation(Employees emp)
        {
            return emp.PerformanceRating * 5000;
        }
        public double FestivalBonusCalculation(Employees emp)
        {
            return emp.PerformanceRating * 7000;
        }
        public double ProfitBonusCalculation(Employees emp)
        {
            return emp.PerformanceRating * 4000;
        }

    }
}

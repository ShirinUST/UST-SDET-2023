using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Study
{
    internal interface IEnrollable
    {
        public void RegisterCourse(int id,string code);
        public void WithdrawCourse(int id,string code);
    }
}

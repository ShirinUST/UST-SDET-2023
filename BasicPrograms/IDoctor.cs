using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal interface IDoctor
    {
        public void AddNewDoctor(int did,string? name);
        public void ModifyDoctor(int did, string? name);
    }
}

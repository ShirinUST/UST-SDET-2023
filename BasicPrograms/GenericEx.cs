using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class GenericEx<T>
    {
        //private T val1, val2;
        private T[] arrays;

        //public GenericEx(T val1, T val2)
        //{
        //    Val1 = val1;
        //    Val2 = val2;
        //}
        public GenericEx(T[] arrays)
        {
            Arrays = arrays;
        }
        public T[] Arrays { get=> arrays; set=> arrays = value; }
        //public T Val1 { get => val1; set => val1 = value; }
        //public T Val2 { get => val2; set => val2 = value; }
        public void Display()
        {
            foreach(var item in Arrays)
            {
                Console.WriteLine(item);
            }
        }
    }
}

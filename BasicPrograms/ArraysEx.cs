using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class ArraysEx
    {
        readonly int[] numbers = new int[5];
        int[,] numberTwo = new int[3, 3];
        public void OneDim()
        {
            //int[] numbers;
            //numbers = new int[5];
          
            numbers[0] = 100;
            numbers[1] = 200;
            for(int i=0;i<numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            //numbers = new int[10];
            numbers[1] = 123;
            Array.Sort(numbers);
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            Array.Clear(numbers);
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

        }
        public void TwoDim()
        {
            numberTwo[0,0] = 100;
            numberTwo[0,1] = 200;
            numberTwo[0, 2] = 300;
            numberTwo[1, 1] = 400;
            foreach (var number in numberTwo)
            {
                Console.WriteLine(number);
            }

            int[,] numberTwos={ { 1,2,3},{ 4,5,6},{ 7,8,9 } };

            foreach (var number in numberTwos)
            {
                Console.WriteLine(number);
            }



        }
        public void JaggedArray()
        {
            int[][,] arr = new int[][,]
            {
                new int[,] { { 1, 2 }, { 3, 4 } },
                new int[,] { { 100, 200 }, { 300, 400 }, { 1000, 2000 } },
                 new int[,] { { 7,8,8 }, { 3,1,7 }, { 0,6,8} },
                 new int[,] { { 11,22 }, { 99,88 }, { 0,9} }
            };
            //foreach (var number in arr)
            //{
            //    Console.WriteLine(number[0,0]);
            //}
            for(int i=0;i<arr.Length;i++)
            {
                int x = 0;
                for(int j = 0; j < arr[i].GetLength(x); j++)
                {
                    for(int k = 0; k < arr[j].Rank;k++)
                    {
                        Console.WriteLine(arr[i][j,k]+" ");
                    }
                    Console.WriteLine();
                }
                x++;
                Console.WriteLine();
            }
        }
    }
}

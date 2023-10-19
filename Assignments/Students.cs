using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Students
    {
        string? name,grade;
        double[] marks = new double[3];

        public Students(string? name, string? grade, double[] marks)
        {
            Name = name;
            Grade = grade;
            Marks = marks;
        }

        public string? Name { get => name; set => name = value; }
        public string? Grade { get => grade; set => grade = value; }
        public double[] Marks { get => marks; set => marks = value; }

        public double CalculateAverage()
        {
            //double sum = 0;
            //foreach(var number in marks)
            //{
            //    sum += number;
            //}
            return Marks.Average();
        }
        public double GetSum()
        {
            //double sum = 0;
            //foreach (var number in marks)
            //{
            //    sum += number;
            //}
            return Marks.Sum();

        }
        public string GetMarksSummary()
        {
            return $"{Name} has {Marks.Length} marks.\nHighest Mark:{Marks.Max()} , Lowest Mark:{Marks.Min()}";
        }
    }
}

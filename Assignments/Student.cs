using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Student
    {
        string? fullName;
        int markOne,markTwo,markThree;

        public Student(string? fullName, int markOne, int markTwo, int markThree)
        {
            this.fullName = fullName;
            this.markOne = markOne;
            this.markTwo = markTwo;
            this.markThree = markThree;
        }

        public double CalculateAverage()
        {
            double average;
            int totalMark;
            totalMark = markOne + markTwo + markThree;
            average = totalMark / 3;
            return average;

        }
        public string GetGrade()
        {
            string? grade;
            double avg=CalculateAverage();
            if (avg > 90)
                grade = "A+";
            else if (avg > 80)
                grade = "A";
            else if (avg > 65)
                grade = "B";
            else if (avg > 50)
                grade = "C";
            else
                grade = "F";
            return grade;
        }
        public int GetTotalMarks()
        {
            return markOne + markTwo + markThree;
        }
    }
}

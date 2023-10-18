//18-10-2023

using Assignments;

Console.WriteLine("Enter Name:");
string? name=Console.ReadLine();
Console.WriteLine("Enter 3 Marks:");
int markOne=Convert.ToInt32(Console.ReadLine());
int markTwo = Convert.ToInt32(Console.ReadLine());
int markThree = Convert.ToInt32(Console.ReadLine());
Student student = new(name,markOne,markTwo,markThree);
Console.WriteLine("Name : "+name);
Console.WriteLine("Total Marks = "+student.GetTotalMarks());
Console.WriteLine("Average Score = "+student.CalculateAverage());
Console.WriteLine("Grade = "+student.GetGrade());




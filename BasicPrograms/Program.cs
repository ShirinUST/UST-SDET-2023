﻿//driver code

//Console.WriteLine("Enter 2 numbers:");
//int numberOne, numberTwo,result;
//numberOne=Convert.ToInt32(Console.ReadLine());
//numberTwo=Convert.ToInt32(Console.ReadLine());
//result=numberOne+numberTwo;
//Console.WriteLine("answer is "+ result);

/*string? wordOne,wordTwo,wordThree;
wordOne=Console.ReadLine();
wordTwo=Console.ReadLine();
wordThree = wordOne + " " + wordTwo;
Console.WriteLine(wordThree);
Console.WriteLine(wordThree.ToUpper());*/

using BasicPrograms;
using BasicPrograms.ExceptionMessages;

//Calculation calculation = new Calculation();
//int numberOne, numberTwo;
//numberOne=Convert.ToInt32(Console.ReadLine());
//numberTwo=Convert.ToInt32(Console.ReadLine());
//calculation.Add(numberOne,numberTwo);

//Electricity electricity=new Electricity();
//Electricity electricity = new(12345,9000,9300,"sheri");
//Console.WriteLine(electricity.CalculateBill());
//Console.WriteLine(electricity.consumerName);

//Employee employee = new(101,"Shirin","IT",10000);
//Console.WriteLine("Employee Id: {0} \nName : {1} \nDepartment : {2}",employee.EmployeeId,employee.EmployeeName,employee.Department);
//Console.WriteLine();
//Console.WriteLine("Salary : "+employee.CalculateSalary());

//ArraysEx arraysEx = new ArraysEx();
//arraysEx.OneDim();
//arraysEx.TwoDim();
//arraysEx.JaggedArray();



//StudentMarks marks = new(101, "Shirin", "EKM", 100, 100, 90, 0, 0);

/*StudentGrade marks = new();
marks.RollNo = 111;
marks.StudentName = "Jachithra";
marks.City = "TVM";
marks.Mark1 = 30;
marks.Mark2 = 50;
marks.Mark3 = 40;

marks.DisplayStudentDetails();
Console.WriteLine("Total : "+marks.CalculateTotal());
Console.WriteLine("Average : "+marks.CalculateAverage());
Console.WriteLine("Grade : " + marks.CalculateGrade());
*/

/*
Console.WriteLine("1. Teaching Staff  2. NonTeaching Staff  3. Student");
switch(Convert.ToInt32(Console.ReadLine()))
{
    case 1:
        TeachingStaff teachingstaff = new();
        Console.WriteLine("Enter College Id:");
        teachingstaff.CollegeId=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter College Name: ");
        teachingstaff.CollegeName = Console.ReadLine();
        Console.WriteLine("Enter College Type: ");
        teachingstaff.CollegeType = Console.ReadLine();
        Console.WriteLine("Enter Staff Id:");
        teachingstaff.StaffId= Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Staff Name:");
        teachingstaff.Name= Console.ReadLine();
        Console.WriteLine("Enter Department:");
        teachingstaff.Department = Console.ReadLine();
        Console.WriteLine("Enter Specialization");
        teachingstaff.Specialization= Console.ReadLine();
        Console.WriteLine("Enter Semester");
        teachingstaff.Semester= Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine(teachingstaff.DisplayCollegeDetails());
        teachingstaff.DisplayStaffDetails();
        teachingstaff.DisplayTStaffDetails();
        break;
    case 2:
        NonTeachingStaff nonTeachingStaff = new();
        Console.WriteLine("Enter College Id:");
        nonTeachingStaff.CollegeId = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter College Name: ");
        nonTeachingStaff.CollegeName = Console.ReadLine();
        Console.WriteLine("Enter College Type: ");
        nonTeachingStaff.CollegeType = Console.ReadLine();
        Console.WriteLine("Enter Staff Id:");
        nonTeachingStaff.StaffId = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Staff Name:");
        nonTeachingStaff.Name = Console.ReadLine();
        Console.WriteLine("Enter Department:");
        nonTeachingStaff.Department = Console.ReadLine();
        Console.WriteLine("Enter Responsibilities:");
        nonTeachingStaff.Responsibilities = Console.ReadLine();
        Console.WriteLine("Enter Experience:");
        nonTeachingStaff.Experience= Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine(nonTeachingStaff.DisplayCollegeDetails());
        nonTeachingStaff.DisplayStaffDetails();
        nonTeachingStaff.DisplayNTStaffDetails();
        break;
        case 3:
        StudentDetails studentDetails = new StudentDetails();
        Console.WriteLine("Enter College Id:");
        studentDetails.CollegeId = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter College Name: ");
        studentDetails.CollegeName = Console.ReadLine();
        Console.WriteLine("Enter College Type: ");
        studentDetails.CollegeType = Console.ReadLine();
        Console.WriteLine("Enter RollNo:");
        studentDetails.RollNo= Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Name:");
        studentDetails.StudentName = Console.ReadLine();
        Console.WriteLine("Enter City:");
        studentDetails.City = Console.ReadLine();
        Console.WriteLine(studentDetails.DisplayCollegeDetails());
        studentDetails.DisplayStudentDetails();
        break;




}
*/

/*
EV ev = new();
ev.VehicleNumber = 444;
ev.Brand = "XX";
ev.Model = "AA";
Console.WriteLine(ev.setTypeForVeh());

PV pv = new();
pv.VehicleNumber = 444;
pv.Brand = "XX";
pv.Model = "AA";
Console.WriteLine(pv.setTypeForVeh());

*/

//21-10-2023

//IDoctor doctor = new Doctor();
/*Doctor doc= new Doctor();
doc.AddNewDoctor(111,"shirin");
doc.DisplayDoctor();
doc.ModifyDoctor(122,"Jachithra");
doc.DisplayDoctor();
doc.BookAppointment(111, "Tom");
doc.DeleteAppointment("Tom");
*/

/*
NonGeneric nonGeneric = new NonGeneric();
nonGeneric.ArrayListHandling();
nonGeneric.StackHandling();
nonGeneric.QueueHandling();
nonGeneric.HashHandling();
*/
/*
Generic generic = new Generic();
generic.ListHandling();
generic.StackHandling();
generic.QueueHandling();
generic.DictionaryHandling();

*/
/*
ExceptionHandling exception = new ExceptionHandling(99, 101);
try
{
    exception.NumCheck();
}
catch(Num1Exception ex) {
    Console.WriteLine(ex.Message);
}
try
{
    exception.NumCheckOne();
}
catch(Num2Exception ex)
{
    Console.WriteLine(ex.Message);
}*/
//try
//{
//    exception.Divide();
//}
//catch (ArithmeticException ex)
//{
//    /*Console.WriteLine("Dont give zero for denominator" + ex.Message);
//    Console.WriteLine(ex.StackTrace);
//    Console.WriteLine(ex.Source);*/

//    Console.WriteLine(MyExceptions.exmsgList[1]);
//}
//catch (IndexOutOfRangeException ex)
//{
//    Console.WriteLine(MyExceptions.exmsgList[2]);
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}
//finally { Console.WriteLine(" Age Done"); }

//FileOperations fop = new();
//fop.CreateFile();
//fop.WriteFile();    
//fop.ReadData();
//fop.CopyMoveFile();
//fop.DeleteFile();
//fop.FileProperties();

//GenericEx<int> generic = new GenericEx<int>(10,20);
//Console.WriteLine(generic.Val1+" "+generic.Val2);

//GenericEx<double> generic1 = new GenericEx<double>(10.25, 2.2222222);
//Console.WriteLine(generic1.Val1 + " " + generic1.Val2);

//GenericEx<string> generic2 = new GenericEx<string>("hi", "shirin");
//Console.WriteLine(generic2.Val1 + " " + generic2.Val2);

//GenericEx<int> genericArray = new GenericEx<int>(new int[3] {1,2,3});
//genericArray.Display();

//31-10-2023
public delegate void NewDelegate();//declarative statement. it will declare outside the main.
public delegate void DelegateSum(int num1, int num2);
class Program:DelegatesExample
{
    //public static NewDelegate MethodA;
    public static void Main(string[] args)
    {
        DelegatesExample delex = new();
        NewDelegate newDelegate =delex.MethodA;
        newDelegate.Invoke();
        newDelegate();
        DelegateSum sum = delex.Add;
        //sum(1, 2);
        DelegateSum sub=delex.Sub;
        //sub(10,20);
        DelegateSum newOp = sum + sub;
        newOp(10, 20);

    }
}
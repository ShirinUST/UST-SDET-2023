//18-10-2023

using Assignments;
using Assignments.ExceptionMessage;

//Student Class

//Console.WriteLine("Enter Name:");
//string? name=Console.ReadLine();
//Console.WriteLine("Enter 3 Marks:");
//int markOne=Convert.ToInt32(Console.ReadLine());
//int markTwo = Convert.ToInt32(Console.ReadLine());
//int markThree = Convert.ToInt32(Console.ReadLine());
//Student student = new(name,markOne,markTwo,markThree);
//Console.WriteLine("Name : "+name);
//Console.WriteLine("Total Marks = "+student.GetTotalMarks());
//Console.WriteLine("Average Score = "+student.CalculateAverage());
//Console.WriteLine("Grade = "+student.GetGrade());

//19-10-2023

//Product Class

//Product product1=new Product("Bread",45.00,4);
//Product product2 = new Product("Egg", 5.5, 10);
//Product product3 = new Product("Milk", 30, 5);

//Product[] products = {product1,product2,product3};
//foreach (Product product in products)
//{
//    Console.WriteLine("Name: {0}\nPrice: {1}\nQuantity: {2}\nTotalValue: {3}",product.ProductName,product.Price,product.Quantity,product.ProductValue());
//    Console.WriteLine();
//}

//Students Class

/*

Students[] student = new Students[]
{
    new ("Tom","A",new double[]{100,90,80}),
    new ("Maya","B",new double[]{50,60,80}),
    new ("Jerry","A+",new double[]{100,90,100})
};

foreach(Students s in student)
{
    Console.WriteLine("Name : "+s.Name);
    Console.WriteLine("Grade : "+s.Grade);
    Console.WriteLine("Sum of Marks : "+s.GetSum());
    Console.WriteLine("Average of Marks : "+s.CalculateAverage());
    double[] mark = new double[3];
    int i = 0;
    Console.WriteLine("Marks are :");
    foreach (var m in s.Marks)
    {
        mark[i] = m;
        Console.Write(mark[i]+"\t");
        i++;
    }
    Console.WriteLine("\n"+s.GetMarksSummary());
    Console.WriteLine();
}


*/

//20-10-2023
//single Inheritance
/*
ElectronicsProduct electronicsProduct = new("TV",25000,2,3);
Console.WriteLine("Product Name:"+electronicsProduct.ProductName);
Console.WriteLine("Price : "+electronicsProduct.Price);
Console.WriteLine("Quantity : "+electronicsProduct.Quantity);
electronicsProduct.DisplayWarrantyPeriod();
Console.WriteLine(electronicsProduct.ProductValue());

*/

//Multi-level inheritance
/*
DigitalProduct digitalProduct = new("Camera", 100000, 2, 5, "png");
Console.WriteLine("Product Name: "+digitalProduct.ProductName);
Console.WriteLine("Price : " + digitalProduct.Price);
Console.WriteLine("Quantity : "+digitalProduct.Quantity);
Console.WriteLine("Total Value : " + digitalProduct.ProductValue());
digitalProduct.DisplayWarrantyPeriod();
digitalProduct.DisplayFileFormat();
*/
//Heirarchical inheritance
/*
ElectronicsProduct electronicsProduct = new("TV", 25000, 2, 3);
DigitalProduct digitalProduct = new("Camera", 100000, 2, 5, "png");
ClothingProduct clothingProduct = new("T-shirt", 1500, 30, "small");
Console.WriteLine("Total Value of Electronics Product : "+electronicsProduct.ProductValue());
Console.WriteLine("Total Value of Clothing Product : " + clothingProduct.ProductValue());
Console.WriteLine("Total Value of Digital Product : " + digitalProduct.ProductValue());
*/

//23-10-2023
/*
Employee employee = new("Shirin", "Safwana", 24, 999);
employee.DisplayInfo();
*/
/*
Circle circle = new Circle();
circle.Radius = 5;
circle.Draw();

Rectangle rectangle = new Rectangle();
rectangle.Length = 5;
rectangle.Width = 10;
rectangle.Draw();
*/

//25-10-2023
//1.
/*
InsurancePolicy policy = new("Life", 123, 1200);
policy.RenewPolicy();
policy.RenewPolicy(2000);

*/
//2.
/*
CarInsurance car = new();
car.PolicyName = "Vaahan";
car.PolicyId = 123;
car.PremiumAmount = 10000;
car.Price = 250000;
Console.WriteLine("Car Insurance\nPolicy Name:{0}\nPolicy Id:{1}\nPremium Amount:{2}\nNew Premium Amount:{3}",car.PolicyName,car.PolicyId,car.PremiumAmount, car.CalculatePremium());

Console.WriteLine();

LifeInsurance life = new();
life.PolicyName = "Jeevan";
life.PolicyId = 1001;
life.PremiumAmount = 100000;
life.Age = 35;
Console.WriteLine("Life Insurance\nPolicy Name:{0}\nPolicy Id:{1}\nPremium Amount:{2}\nNew Premium Amount:{3}", life.PolicyName, life.PolicyId, life.PremiumAmount, life.CalculatePremium());

*/

//26-10-2023
//1.
/*
Customer customer1 = new(101, "Tom", 98765432, 12000);
Customer customer2 = new(102, "Maya", 7654321, 50000);
Customer customer3 = new(103, "Anu", 65432123, 25000);
Customer.customers.Add(customer1);
Customer.customers.Add(customer2);
Customer.customers.Add(customer3);
Console.WriteLine("Enter Phone Number: ");
int phno=Convert.ToInt32(Console.ReadLine());
Customer.GetCustomerDetails(phno);
Customer.DisplayAllCustomers();
*/
//2.
/*
CallRecord call1 = new(111, 9876543210, 10);
CallRecord call2 = new(222, 1234567890, 30);
CallRecord call3 = new(333, 9876543210, 15);
CallRecord call4 = new(444, 9876543210, 6);
CallRecord call5 = new(555, 1234567890, 8);
CallRecord.callRecords.Add(call1);
CallRecord.callRecords.Add(call2);
CallRecord.callRecords.Add(call3);
CallRecord.callRecords.Add(call4);
CallRecord.callRecords.Add(call5);
Console.WriteLine("Enter Phone Number: ");
long ph = Convert.ToInt64(Console.ReadLine());
CallRecord.DisplayCallHistory(ph);
CallRecord.DisplayTotalNumberOfCalls();

*/
//3.
//Patient pat1= new Patient(1,"Anu",23,"Fever");
//Patient pat2= new Patient(2,"Gokul",24,"Fever");
//Patient pat3= new Patient(3,"Jachithra",25,"");
/*
try
{
    Patient.AddPatientDetails(pat1);
}
catch(AgeException ex)
{
    Console.WriteLine(ex.Message);
}
catch(NameException nex)
{
    Console.WriteLine(nex.Message);
}
catch(DiagException dex)
{ Console.WriteLine(dex.Message);}
*/
//try
//{
//    Patient.AddPatientDetails(pat2);
//}
//catch (AgeException ex)
//{
//    Console.WriteLine(ex.Message);
//}
//catch (NameException nex)
//{
//    Console.WriteLine(nex.Message);
//}
//catch (DiagException dex)
//{ Console.WriteLine(dex.Message); }

//try 
//{ 
//    Patient.AddPatientDetails(pat3);
//} 
//    catch (AgeException ex) { Console.WriteLine(ex.Message); } 
//    catch (NameException nex) { Console.WriteLine(nex.Message); } 
//    catch (DiagException dex) { Console.WriteLine(dex.Message);}
/*catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}
Patient.DisplayPatient();
*/
//27-10-2023
//1.
/*
MedicalRecord mr = new(101, "Anu", 50, "Heart Failure",1111,50000);
try
{
    MedicalRecord.AddMedicalRecord(mr);
}
catch(InvalidPatientDataException ipdx)
{
    Console.WriteLine(ipdx.Message);
}
catch (InvalidMedicalRecordException imrx)
{
    Console.WriteLine(imrx.Message);
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}
MedicalRecord.DisplayMed();
*/

//2.
/*
int n = 1;

do
{
    Console.WriteLine("********MENU**********");
Console.WriteLine("1.Add Patient Details   2.Display Patient Details  3.Exit");
Console.WriteLine("-----------------------------------------------------------");
int ch=Convert.ToInt32(Console.ReadLine());
    switch(ch){
        case 1:
            Console.WriteLine("Enter Patient Id:");
            int patId=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Patient Name:");
            string? name=Console.ReadLine();
            Console.WriteLine("Enter Age:");
            int age=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Diagnosis:");
            string? diag=Console.ReadLine();
            Patient pat=new(patId, name, age, diag);
            Patient.AddPatientDetails(pat);
            break;
        case 2:
            Console.WriteLine("Patient Details are....");
            Patient.DisplayPatient();
            break;
        case 3:
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Invalid Entry");
            break;
    }
    Console.WriteLine("Do you want to Continue 1.Continue 0.Exit");
    n=Convert.ToInt32(Console.ReadLine());
} while (n == 1);
*/

//3.
/*
int n = 1;

do
{
    Console.WriteLine("********MENU**********");
    Console.WriteLine("1.Add Patient Details   2.Display History of a Patient  3.Exit");
    Console.WriteLine("-----------------------------------------------------------");
    int ch = Convert.ToInt32(Console.ReadLine());
    switch (ch)
    {
        case 1:
            Console.WriteLine("Enter Record Id:");
            int recId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Patient Id:");
            int patId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Description:");
            string? desc = Console.ReadLine();
            Console.WriteLine("Enter Date:");
            string? date = Console.ReadLine();
            MedicalHistory med=new(recId,patId,desc,date);
            MedicalHistory.AddHistoryToList(med);
            MedicalHistory.AddHistoryToFile(med);
            break;
        case 2:
            Console.WriteLine("Enter patient Id to Search: ");
            int id=Convert.ToInt32(Console.ReadLine());
            MedicalHistory.DisplayPatient(id);
            break;
        case 3:
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Invalid Entry");
            break;
    }
    Console.WriteLine("Do you want to Continue 1.Continue 0.Exit");
    n = Convert.ToInt32(Console.ReadLine());
} while (n == 1);
*/

//30-10-2023
//1.
/*
HotelRoom hotel = new HotelRoom(101, "Single", true);
RoomReservation<HotelRoom> reservation = new();
reservation.BookHotel(hotel);
Console.WriteLine("Hotel booked");
Console.WriteLine("Details are:");
string? status;
foreach(var item in RoomReservation<HotelRoom>.hotel)
{
    if (item.IsBooked)
        status = "Occupied";
    else 
        status = "Not Occupied";
    Console.WriteLine("Room Number:{0} Room Type:{1} Status:{2} ",item.RoomNumber,item.RoomType,status);
}
Console.WriteLine("Enter the room number to delete:");
int rNo = Convert.ToInt32(Console.ReadLine());
var room= HotelRoom.GetRoom(rNo);
if (room != null)
{
    reservation.CancelHotel(room);
    Console.WriteLine("Room canceled");
}
else
{
    Console.WriteLine("Room doesn't exist");
}
*/

//31-10-2023
//1.
class Program
{
    public delegate double BonusDelegate(Employees employees);
    public static void Main(string[] args)
    {
        Employees employ = new();
        Console.WriteLine("Enter Employee Id:");
        employ.EmployeeId=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Employee Name");
        employ.EmployeeName=Console.ReadLine();
        Console.WriteLine("Enter Performance Rating(1.0 - 5.0):");
        employ.PerformanceRating=Convert.ToDouble(Console.ReadLine());
        int n;
        do
        {
            Console.WriteLine("Choose Bonus Calculation Method :");
            Console.WriteLine("1.Performace Bonus   2.Festival Bonus    3.Account Profit Bonus  4.Total Bonus");
            Console.WriteLine("Enter Option:");
            int opt = Convert.ToInt32(Console.ReadLine());
            double bon;
            switch (opt)
            {
                case 1:
                    Console.WriteLine("Performance Bonus");
                    BonusDelegate bonus = employ.PerformanceBonusCalculation;
                    bon = bonus(employ);
                    DisplayDetails(employ, bon);
                    break;
                case 2:
                    Console.WriteLine("Festival Bonus");
                    BonusDelegate bonus1 = employ.FestivalBonusCalculation;
                    bon = bonus1(employ);
                    DisplayDetails(employ, bon);
                    break;
                case 3:
                    Console.WriteLine("Account Profit Bonus");
                    BonusDelegate bonus2 = employ.ProfitBonusCalculation;
                    bon = bonus2(employ);
                    DisplayDetails(employ, bon);
                    break;
                case 4:
                    Console.WriteLine("Total Bonus");
                    BonusDelegate bon1 = employ.PerformanceBonusCalculation;
                    BonusDelegate bon2 = employ.FestivalBonusCalculation;
                    BonusDelegate bon3 = employ.ProfitBonusCalculation;
                    bon = bon1(employ) + bon2(employ) + bon3(employ);
                    DisplayDetails(employ, bon);
                    break;

                default:
                    Console.WriteLine("Choose valid option.....");
                    break;

            }
            Console.WriteLine("1.Continue  2.Exit");
            n=Convert.ToInt32(Console.ReadLine());
        } while (n == 1);
        
    }
    public static void DisplayDetails(Employees emp, double b)
    {
        Console.WriteLine("Id: {0}\nName: {1}\nRating: {2}\nBonus: {3}", emp.EmployeeId, emp.EmployeeName, emp.PerformanceRating, b);
    }

}

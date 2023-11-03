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
//2.
/*
Inventory<string> inventory = new Inventory<string>();
int choice, option;
do
{
    Console.WriteLine("Choose The Menu");
    Console.WriteLine("1.Add Product\n2.Update Product\n3.RemoveProduct\n4.Search ProductById\n5.Search Product By Name");
    choice = Convert.ToInt32(Console.ReadLine());
    switch (choice)
    {
        case 1:
            Console.WriteLine("Enter The Product Id");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The ProductName");
            string? productname = Console.ReadLine();
            Console.WriteLine("Enter The Price");
            double price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the quantity in stock");
            int qty = Convert.ToInt32(Console.ReadLine());
            inventory.AddProduct(new Products<string>(id, productname, price, qty));
            break;
        case 2:
            Console.WriteLine("Enter the product id Do You want update");
            int proid = Convert.ToInt32(Console.ReadLine());
            var prId = inventory.FindProductById(proid);
            if (prId != null)
            {
                Console.WriteLine("Enter the Product Name");
                string? name = Console.ReadLine();
                Console.WriteLine("Enter the price");
                double pric = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the qty");
                int qt = Convert.ToInt32(Console.ReadLine());
                inventory.UpdateProduct(proid, name, pric, qt);
                Console.WriteLine("Successfully Updated");

            }
            else
            {
                Console.WriteLine("No Product Found!!!");
            }

            break;
        case 3:
            Console.WriteLine("Enter the product Id Do You Want Delete");
            int ids = Convert.ToInt32(Console.ReadLine());
            var data = inventory.FindProductById(ids);
            if (data != null)
            {
                inventory.DeleteProduct(ids);
                Console.WriteLine("Product Deleted Success!!!!");
            }
            else
            {
                Console.WriteLine("No Product available!!!");
            }
            break;
        case 4:
            Console.WriteLine("View Product BY Id");
            Console.WriteLine("Enter The Product Id");
            int pid = Convert.ToInt32(Console.ReadLine());
            Products<string> pro = inventory.FindProductById(pid);
            if (pro != null)
            {
                Console.WriteLine($"Product Id:{pro.ProductId}\nProduct Name:{pro.ProductName}" +
                    $"\nPrice:{pro.Price}\nQuantity:{pro.QuantityInStock}");
            }
            else
            {
                Console.WriteLine("No Product Available");
            }



            break;
        case 5:
            Console.WriteLine("Search Product By Name");
            string? proname = Console.ReadLine();
            List<Products<string>> dat = inventory.FindProductByName(proname);
            if (dat != null)
            {
                foreach (Products<string> p in dat)
                {
                    Console.WriteLine($"Product Id:{p.ProductId}\nProduct Name:{p.ProductName}" +
                    $"\nPrice:{p.Price}\nQuantity:{p.QuantityInStock}");
                }
            }
            else
            {
                Console.WriteLine("No Product Found!!!");
            }
            break;
        case 6:
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Invalid Option!!!!");
            break;
    }
    Console.WriteLine("Do you want to continue \n1. Yes \n2.No");
    option = Convert.ToInt32(Console.ReadLine());

} while (option == 1);
*/


//31-10-2023
//1.
/*
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

*/

//class Program
//{
//    public delegate string DelegateMessageOne(string message);
//    public delegate string DelegateMessageTwo(string message);
//    public static void Main(string[] args)
//    {
//        HotelEvent hotelEvent = new("Marriage", "12.00:5-11-2023", "Grand Hyatt", 2000);
//        DelegateMessageOne delegateMessageOne = HotelEvent.EventRegistration;
//        if (hotelEvent != null)
//        {
//            Console.WriteLine(delegateMessageOne($"{hotelEvent.EventName} is Successfully Registered the event on {hotelEvent.EventDate} at {hotelEvent.Location}"));
//        }
//        else
//        {
//            Console.WriteLine(delegateMessageOne("Unsuccessfully registered"));
//        }
//        HotelEvent hotelEventone = new("Birthday Celebration", "19:00:12-11-2023", "Mariott",  200);

//        DelegateMessageTwo delegateMessageTwo = HotelEvent.EventRegistration;
//        if (hotelEventone != null)
//        {
//            Console.WriteLine(delegateMessageTwo($"{hotelEventone.EventName} is Successfully Registered the event on {hotelEventone.EventDate} at {hotelEventone.Location}"));
//        }
//        else
//        {
//            Console.WriteLine(delegateMessageTwo("Unsuccessfully registered"));
//        }
//    }
//}

//1-11-2023

//1.

//TourismDestination tourism = new("Great wall", "China", 3.5);
//TourismDestination tourism1 = new("Taj Mahal", "India", 4);
//TourismDestination tourism2 = new("Seoul", "Korea", 4.5);
//TourismDestination tourism3= new("Athirappilly", "India", 5);
//TourismDestination tourism4= new("Niagra Waterfalls", "USA", 3.5);
//TourismDestination.tour.Add(tourism);
//TourismDestination.tour.Add(tourism1);
//TourismDestination.tour.Add(tourism2);
//TourismDestination.tour.Add(tourism3);
//TourismDestination.tour.Add(tourism4);
//TourismDestination.SortingRating();

//2.
/*
TouristDestination tourism = new("Great wall", "China", 3.5,5000);
TouristDestination tourism1 = new("Taj Mahal", "India", 4,2000);
TouristDestination tourism2 = new("Seoul", "Korea", 4.5,10000);
TouristDestination tourism3= new("Athirappilly", "India", 5,3000);
TouristDestination tourism4= new("Niagra Waterfalls", "USA", 3.5,15000);
TouristDestination.tour.Add(tourism);
TouristDestination.tour.Add(tourism1);
TouristDestination.tour.Add(tourism2);
TouristDestination.tour.Add(tourism3);
TouristDestination.tour.Add(tourism4);
int n;
do
{
    Console.WriteLine("1.Search based on Rating   2.Search based on Price  3.Search based on location  4.Exit");
    int opt=Convert.ToInt32(Console.ReadLine());
    switch(opt)
    {
        case 1:
            Console.WriteLine("Enter a rating to search:");
            double rate = Convert.ToDouble(Console.ReadLine());
            TouristDestination.SearchByRating(rate);
            break;
        case 2:
            Console.WriteLine("Based On Price:");
            TouristDestination.SortByPrice();
            break;
        case 3:
            Console.WriteLine("Enter location to search:");
            string? loc = Console.ReadLine();
            TouristDestination.FiltertByLocation(loc);
            break;
        case 4:
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Invalid Entry");
            break;

    }
    Console.WriteLine("1.Continue  2.Exit");
    n=Convert.ToInt32(Console.ReadLine());
} while (n == 1);

*/

//2-11-2023

//1.

//Hotel hotel = new Hotel("Munnar", "India", 3, "Double", 45);
//Hotel hotel1 = new Hotel("Kashmir", "India", 4, "Single", 40);
//Hotel hotel2 = new Hotel("Burj Khalifa", "Dubai", 4.5, "Soute", 10);

//await hotel.HotelBookingig(6, hotel);
//await hotel1.HotelBookingig(5, hotel1);
//await hotel2.HotelBookingig(5, hotel2);

//2.
/*
TourPackage package = new TourPackage(1, "Trivandrum", "12-11-2024", 1300);
TourPackage package1 = new TourPackage(2, "Kochi", "12-10-2024", 1200);
TourPackage package2 = new TourPackage(3, "Alappuzha", "2-2-2023", 1100);

TourPackage.TourPackages.Add(package1);
TourPackage.TourPackages.Add(package2);
TourPackage.TourPackages.Add(package);


Thread thread = new Thread(TourPackage.HotelReservation);

Thread thread1 = new Thread(TourPackage.HotelReservation);

thread1.Start();
thread1.Join();
thread.Start();


*/

// 03-11-2023

//1.
/*
int n;
do { 
Console.WriteLine("MENU");
Console.WriteLine("1.Add Task   2.Remove Task   3.Mark Task as Completed.   4.View Tasks   5.Exit");
Console.WriteLine("-------------------------------------------------------------------------------");
int opt = Convert.ToInt32(Console.ReadLine());
switch(opt)
{
    case 1:
        Console.WriteLine("Enter Task Id:");
        int id= Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Task Description:");
        string? desc=Console.ReadLine();
        //Console.WriteLine("Is it completed:");
        string? comp = "Not Completed";//Console.ReadLine();
        TaskItem task=new(id, desc, comp);
        TaskItem.TodoList.Add(task);
        Console.WriteLine("Successfully added");
        break;
        case 2:
        Console.WriteLine("Enter Task Id:");
        int taskId=Convert.ToInt32(Console.ReadLine());
        TaskItem.RemoveTask(taskId);
        break;
        case 3:
        Console.WriteLine("Is it completed or not:");
        int tasId=Convert.ToInt32(Console.ReadLine());
        TaskItem.UpdateTask(tasId);
        break;
        case 4:
        if (TaskItem.TodoList.Count > 0)
        {
            Console.WriteLine("Tasks are.... ");
            TaskItem.DisplayTasks();
        }
        else
        {
            Console.WriteLine("No tasks available.");
        }
        break;
        case 5:
        Environment.Exit(0);
        break;
    default:
        Console.WriteLine("Invalid entry");
        break;

}
Console.WriteLine("1.Continue    2.Exit");
n=Convert.ToInt32(Console.ReadLine());
}while (n == 1) ;
*/

//2.

FamilyMembers grandparent = new FamilyMembers("Grandparent", 70);
FamilyMembers parent1 = new FamilyMembers("Parent 1", 40);
FamilyMembers parent2 = new FamilyMembers("Parent 2", 38);
FamilyMembers child1 = new FamilyMembers("Child 1", 12);
FamilyMembers child2 = new FamilyMembers("Child 2", 8);

grandparent.AddChild(parent1);
grandparent.AddChild(parent2);
parent1.AddChild(child1);
parent2.AddChild(child2);

FamilyTree familyTree = new FamilyTree(grandparent);
familyTree.DisplayFamilyTree();
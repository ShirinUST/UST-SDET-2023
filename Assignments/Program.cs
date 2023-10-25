//18-10-2023

using Assignments;

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




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

ElectronicsProduct electronicsProduct = new("TV",25000,2,3);
Console.WriteLine("Product Name:"+electronicsProduct.ProductName);
Console.WriteLine("Price : "+electronicsProduct.Price);
Console.WriteLine("Quantity : "+electronicsProduct.Quantity);
electronicsProduct.DisplayWarrantyPeriod();
Console.WriteLine(electronicsProduct.ProductValue());




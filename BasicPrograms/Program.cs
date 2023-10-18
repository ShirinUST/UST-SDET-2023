//driver code

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

//Calculation calculation = new Calculation();
//int numberOne, numberTwo;
//numberOne=Convert.ToInt32(Console.ReadLine());
//numberTwo=Convert.ToInt32(Console.ReadLine());
//calculation.Add(numberOne,numberTwo);

//Electricity electricity=new Electricity();
Electricity electricity = new(12345,9000,9300,"sheri");
Console.WriteLine(electricity.CalculateBill());
//Console.WriteLine(electricity.consumerName);



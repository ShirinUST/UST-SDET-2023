
using Case_Study;
using Case_Study.CustomException;

/*
int nob = 0;
Genre[] genres = new Genre[nob];
Console.WriteLine("*******Online Bookstore**********");
Console.WriteLine("Menu");
Console.WriteLine();
Order order = new Order();
int n = 1;
do
{
    Console.WriteLine("1.Add Book\n2.Add Customer\n3.Search book\n4.Buy Book\n5.Exit");
    int choice = Convert.ToInt32(Console.ReadLine());
    switch (choice)
    {
        case 1:
            Console.WriteLine("Enter no: of books:");
            nob=Convert.ToInt32(Console.ReadLine());
            genres=new Genre[nob];
            for (int i = 0; i < nob; i++)
            {
                Console.WriteLine("Enter Book Name: ");
                string? title = Console.ReadLine();
                Console.WriteLine("Enter Author Name:");
                string? author = Console.ReadLine();
                Console.WriteLine("Enter ISBN: ");
                int isbn = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Price: ");
                double price = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Available or Not:");
                string? avail = Console.ReadLine();
                Console.WriteLine("Enter Genre : ");
                string? genre = Console.ReadLine();
                Genre genre1 = new Genre(title, author, isbn, price, avail, genre);
                genres[i]=genre1;
            }
            Console.WriteLine("Successfully Added");
            break;
        case 2:
            Console.WriteLine("Enter Name: ");
            order.Name= Console.ReadLine();
            Console.WriteLine("Contact: ");
            order.Contact = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Customer Id: ");
            order.CustomerId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Customer added successfully.....");
            break;
        case 3:
            if (genres.Length > 0)
            {
                Console.WriteLine("Enter book Name: ");
                string? nam = Console.ReadLine();
                foreach (var book in genres)
                {
                    if (book.Title == nam)
                    {
                        Console.WriteLine("Title : " + book.Title);
                        Console.WriteLine("Author : " + book.Author);
                        Console.WriteLine("IsBN : " + book.Isbn);
                        Console.WriteLine("Price : " + book.Price);
                        Console.WriteLine("Genre : " + book.TypeOfBook);
                        Console.WriteLine("Availability : " + book.Availability);
                        break;
                    }
                }
            }
            else
                Console.WriteLine("No books here");
            break;
            case 4:
            if (genres.Length > 0)
            {
                Console.WriteLine("Enter book Name: ");
                string? nam1 = Console.ReadLine();
                foreach (var book in genres)
                {
                    if (book.Title == nam1)
                    {
                        Console.WriteLine("Enter date: ");
                        order.OrderDate= Console.ReadLine();
                        order.TotalCost = book.Price;
                        Console.WriteLine("Order Confirmed!!!!");
                        order.GetOrderDetails();
                        order.GetCustomerDetails();
                        Console.WriteLine("Title : " + book.Title);
                        Console.WriteLine("Author : " + book.Author);
                        Console.WriteLine("IsBN : " + book.Isbn);
                        Console.WriteLine("Price : " + book.Price);
                        Console.WriteLine("Genre : " + book.TypeOfBook);
                        Console.WriteLine("Availability : " + book.Availability);
                        Console.WriteLine("Thank You!!!!Have a nice day.......");

                    }
                }

            }
            else
                Console.WriteLine("No books here");
            break;
        case 5:
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Invalid option");
            break;


    }
    Console.WriteLine("Do you want to continue :\n1.Yes   2.No");
    n = Convert.ToInt32(Console.ReadLine());

} while (n == 1);
*/

/*
try
{
    Console.WriteLine("********************************");
    Console.WriteLine("******S-Mart*******");
    Console.WriteLine("-----------------------------");
    Customer1 customer1 = new Customer1();
    customer1.CustomerID = 1;
    customer1.CustomerName = "Shirin";
    customer1.Email = "shirin@gmail.com";
    Customer1.customers.Add(customer1);
    Customer1 customer2 = new Customer1();
    customer2.CustomerID = 2;
    customer2.CustomerName = "Jachithra";
    customer2.Email = "jachithra@g.com";
    Customer1.customers.Add(customer2);
    Customer1 customer3 = new Customer1();
    customer3.CustomerID = 3;
    customer3.CustomerName = "Gokul";
    customer3.Email = "gokul@g.com";
    Customer1.customers.Add(customer3);

    while (true)
    {
        Console.WriteLine("Menu\n1.User\n2.Admin");
        int option = Convert.ToInt32(Console.ReadLine());

        if (option == 1)

        {
            Console.WriteLine("Enter the Customer Id");
            int cId = Convert.ToInt32(Console.ReadLine());
            if (Customer1.customers.Find(x => x.CustomerID == cId) == null)
            {
                Console.WriteLine("Customer not found");
                break;
            }
            while (true)
            {
                Console.WriteLine("Choose your option\n1.Add product to cart\n2.view all product\n3.place order\n4.Support\n5.view orders");
                int optionuser = Convert.ToInt32(Console.ReadLine());

                switch (optionuser)
                {

                    case 1:
                        Console.WriteLine("Digital Products are.....");
                        Console.WriteLine("-------------------------------");
                        foreach (var item in DigitalProduct.Products)
                        {
                            Console.WriteLine("Product Id:{0}  Product Name:{1}  Price:{2}  Quantity:{3}  Download Link:{4}  File Format:{5} ", item.ProductId, item.Name, item.Price, item.StockQuantity, item.DownloadLink, item.FileFormat);
                        }
                        Console.WriteLine("Physical Products are......");
                        Console.WriteLine("------------------------------------");
                        foreach (var item in PhysicalProduct.Products)
                        {
                            Console.WriteLine("Product Id:{0}  Product Name:{1}  Price:{2}  Quantity:{3}  Weight:{4}  Dimension:{5} ", item.ProductId, item.Name, item.Price, item.StockQuantity, item.Weight, item.Dimension);
                        }

                        Console.WriteLine("Enter Product id for add to cart");
                        int productId = Convert.ToInt32(Console.ReadLine());
                        Customer1? customerOne = Customer1.customers.Find(x => x.CustomerID == cId);
                        if (DigitalProduct.Products.Find(x => x.ProductId == productId) == null)
                        {
                            if (PhysicalProduct.Products.Find(x => x.ProductId == productId) == null)
                            {
                                Console.WriteLine("Invalid product id");
                            }
                            else
                            {
                                
                                    Order od = new Order();
                                    od.PPOrderVerification(productId);
                                    customerOne.ordersPP.Add(PhysicalProduct.Products.Find(x => x.ProductId == productId));
                                    Console.WriteLine("Product added to cart");
                                
                                
                            }
                        }
                        else
                        {
                            
                                Order od1 = new Order();
                                od1.DPOrderVerification(productId);
                                customerOne.orders.Add(DigitalProduct.Products.Find(x => x.ProductId == productId));
                                Console.WriteLine("Product added to cart");
                            
                            
                        }
                        break;
                    case 2:
                        Console.WriteLine("Products are");
                        if (DigitalProduct.Products.Count == 0 && PhysicalProduct.Products.Count == 0)
                        {
                            Console.WriteLine("No Product Found found");
                        }
                        foreach (var item in DigitalProduct.Products)
                        {
                            Console.WriteLine("Productid:{0}\tProduct Name:{1}\tPrice:{2}\tProduct Quantity:{3}\tFileFormat:{4}\tDownloadlink:{5}", item.ProductId,
                                item.Name, item.Price, item.StockQuantity, item.FileFormat, item.DownloadLink);
                        }
                        foreach (var item in PhysicalProduct.Products)
                        {
                            Console.WriteLine("Productid:{0}\tProduct Name:{1}\tPrice:{2}\tProduct Quantity:{3}\tWeight:{4}" +
                                "\tDimension:{5}", item.ProductId,
                                item.Name, item.Price, item.StockQuantity, item.Weight, item.Dimension);
                        }
                        break;
                    case 3:
                        Customer1 customer = Customer1.customers.Find(x => x.CustomerID == cId);
                        if (customer.orders.Count == 0 && customer.ordersPP.Count == 0)
                        {
                            Console.WriteLine("no product found in cart");
                        }
                        else
                        {
                            foreach (var item in customer.orders)
                            {
                                Console.WriteLine("Productid:{0}\tProduct Name:{1}\tPrice:{2}\tProduct Quantity:{3}\tFileFormat:{4}\tDownloadlink:{5}", item.ProductId,
                                 item.Name, item.Price, item.StockQuantity, item.FileFormat, item.DownloadLink);
                                item.PlaceOrder();
                                item.ProcessPayment();
                                item.DeliverProduct();

                            }
                            foreach (var item in customer.ordersPP)
                            {
                                Console.WriteLine("Productid:{0}\tProduct Name:{1}\tPrice:{2}\tProduct Quantity:{3}\tWeight:{4}" +
                               "\tDimension:{5}", item.ProductId,
                               item.Name, item.Price, item.StockQuantity, item.Weight, item.Dimension);
                                item.PlaceOrder();
                                item.ProcessPayment();
                                item.DeliverProduct();
                            }
                            Console.WriteLine("Do you want to place all the order\n1.yes\n2.no");
                            int confirm = Convert.ToInt32(Console.ReadLine());
                            if (confirm == 1)
                            {
                                customer.confirmedorders.AddRange(customer.orders);
                                customer.orders.Clear();
                                customer.confirmedordersPP.AddRange(customer.ordersPP);
                                customer.ordersPP.Clear();
                                Console.WriteLine("order placed successfully");
                            }
                            else
                            {
                                Console.WriteLine("removing everything in cart");
                            }


                        }



                        break;
                    case 4:
                        Console.WriteLine("Customer Support 96456636727");
                        break;
                    case 5:
                        Customer1 customerTwo = Customer1.customers.Find(x => x.CustomerID == cId);
                        if (customerTwo.confirmedorders.Count == 0 && customerTwo.confirmedordersPP.Count == 0)
                        {
                            Console.WriteLine("No order found");
                        }
                        else
                        {
                            Console.WriteLine("Orders are");
                            foreach (var item in customerTwo.confirmedorders)
                            {
                                Console.WriteLine("Productid:{0}\tProduct Name:{1}\tPrice:{2}\tProduct Quantity:{3}\tFileFormat:{4}\tDownloadlink:{5}", item.ProductId,
                                item.Name, item.Price, item.StockQuantity, item.FileFormat, item.DownloadLink);
                            }
                            foreach (var item in customerTwo.confirmedordersPP)
                            {
                                Console.WriteLine("Productid:{0}\tProduct Name:{1}\tPrice:{2}\tProduct Quantity:{3}\tWeight:{4}" +
                               "\tDimension:{5}", item.ProductId,
                               item.Name, item.Price, item.StockQuantity, item.Weight, item.Dimension);
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid input");

                        break;
                }

                Console.WriteLine("Do you want to continue as user\n1.yes\n2.no");
                int optuser = Convert.ToInt32(Console.ReadLine());
                if (optuser == 1)
                {
                    continue;
                }
                else if (optuser == 2)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
            }


        }

        else if (option == 2)
        {
            Console.WriteLine("choose option\n1.Add Product\n2.View Products");
            int optionadmin = Convert.ToInt32(Console.ReadLine());
            if (optionadmin == 1)
            {
                Console.WriteLine("choose the option \n1.Digital Product\n2.Physical Product");
                int optionProduct = Convert.ToInt32(Console.ReadLine());
                if (optionProduct == 1)
                {
                    Console.WriteLine("Enter Product id");
                    int productid = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Product Name");
                    string? productName = Console.ReadLine();
                    Console.WriteLine("enter the price");
                    double productCost = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter the fileformat");
                    string? fileFormat = Console.ReadLine();
                    Console.WriteLine("Enter downloadLink");
                    string? downloadLink = Console.ReadLine();
                    Console.WriteLine("Enter the Quantity");
                    int quantity = Convert.ToInt32(Console.ReadLine());


                    DigitalProduct digitalProduct = new DigitalProduct();
                    digitalProduct.Name = productName;
                    digitalProduct.ProductId = productid;
                    digitalProduct.FileFormat = fileFormat;
                    digitalProduct.DownloadLink = downloadLink;
                    digitalProduct.Price = productCost;
                    digitalProduct.StockQuantity = quantity;
                    DigitalProduct.Products.Add(digitalProduct);
                }
                else if (optionProduct == 2)
                {
                    Console.WriteLine("Enter Product id");
                    int productid = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Product Name");
                    string? productName = Console.ReadLine();
                    Console.WriteLine("enter the price");
                    double productCost = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter the Weight");
                    int weight = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter dimension");
                    string? dimension = Console.ReadLine();
                    Console.WriteLine("Enter the Quantity");
                    int quantity = Convert.ToInt32(Console.ReadLine());

                    PhysicalProduct physicalProduct = new PhysicalProduct();
                    physicalProduct.Name = productName;
                    physicalProduct.ProductId = productid;
                    physicalProduct.Price = productCost;
                    physicalProduct.Dimension = dimension;
                    physicalProduct.Weight = weight;
                    physicalProduct.StockQuantity = quantity;


                    PhysicalProduct.Products.Add(physicalProduct);
                }
                else
                {
                    Console.WriteLine("Invalid");
                }
            }
            else if (optionadmin == 2)
            {
                Console.WriteLine("choose the option \n1.Digital Product\n2.Physical Product");
                int option2Product = Convert.ToInt32(Console.ReadLine());
                if (option2Product == 1)
                {
                    DigitalProduct dp = new DigitalProduct();
                    foreach (var item in DigitalProduct.Products)
                    {
                        Console.WriteLine("Product Id:{0}  Product Name:{1}  Price:{2}  Quantity:{3}  Download Link:{4}  File Format:{5} ", item.ProductId, item.Name, item.Price, item.StockQuantity, item.DownloadLink, item.FileFormat);
                    }

                }
                else if (option2Product == 2)
                {
                    // PhysicalProduct dp = new PhysicalProduct();
                    foreach (var item in PhysicalProduct.Products)
                    {
                        Console.WriteLine("Product Id:{0}  Product Name:{1}  Price:{2}  Quantity:{3}  Weight:{4}  Dimension:{5} ", item.ProductId, item.Name, item.Price, item.StockQuantity, item.Weight, item.Dimension);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid");
                }

            }
        }
        else
        {
            Console.WriteLine("invalid option");
        }
        Console.WriteLine("do you want to continue\n1.yes\n2.no");
        int opt = Convert.ToInt32(Console.ReadLine());
        if (opt == 1)
        {
            continue;
        }
        else if (opt == 2)
        {
            Environment.Exit(0);
        }
        else
        {
            Console.WriteLine("invalid input");
        }

    }
}
catch (OrderException oex)
{
    Console.WriteLine(oex.Message);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

*/
class Program
{
    public delegate void DelegateOne(int id, string code);
    public static void Main(string[] args)
    {

   
Console.WriteLine("*******BigHit College*********");
int n;
do
{
    Console.WriteLine("Users");
    Console.WriteLine("1. Admin   2.  Student  3. Exit ");
    int optionOne = Convert.ToInt32(Console.ReadLine());
    switch (optionOne)
    {
        case 1:
            Console.WriteLine("-------Admin Panel-------");
            int a;
            do
            {
                Console.WriteLine("1. Add Courses    2. View Courses  3. View Students  4. View Enrolled Student Details  5. Exit ");
                int optAdmin = Convert.ToInt32(Console.ReadLine());
                switch (optAdmin)
                {
                    case 1:
                        Console.WriteLine("Enter Course Code: ");
                        string? courseCode = Console.ReadLine();
                        Console.WriteLine("Enter Title:");
                        string? title = Console.ReadLine();
                        Console.WriteLine("Enter Instructor Name:");
                        string? instruct = Console.ReadLine();
                        Console.WriteLine("Enter Maximum count of Students:");
                        int maxCount = Convert.ToInt32(Console.ReadLine());
                        Course course = new(courseCode, title, instruct, maxCount);
                        Course.courses.Add(course);
                        Console.WriteLine("Course Added Successfully........");
                        break;
                    case 2:
                        Course.DisplayCourse();
                        break;
                    case 3:
                        foreach(var student in Student.Students)
                        {
                            Console.WriteLine(student.StudentID+"     "+student.Name+"     "+student.Email);
                        }
                        break;
                    case 4:
                        Console.WriteLine();
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid Entry......");
                        break;


                }
                Console.WriteLine("1. Continue   2. Exit");
                a = Convert.ToInt32(Console.ReadLine());
            } while (a == 1);
            break;
        case 2:
            Console.WriteLine("---------Student Panel----------");
            int b;
            do
            {
                Console.WriteLine("1. Add Student    2. Enroll Course    3. Cancel Course    4. View my Courses    5. Exit");
                int optStudent = Convert.ToInt32(Console.ReadLine());
                switch (optStudent)
                {
                    case 1:
                        Console.WriteLine("Enter Your ID:");
                        int stdId = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Your Name:");
                        string? name = Console.ReadLine();
                        Console.WriteLine("Enter Your Email:");
                        string? email = Console.ReadLine();
                        Student student = new(stdId, name, email);
                        Student.AddStudent(student);
                        break;
                        case 2:
                        Course.DisplayCourse();
                        Course cours = new Course("1001", "qwerty", "Manu", 10);
                        DelegateOne delegateRegister = new DelegateOne(cours.RegisterCourse);
                        Console.WriteLine("Enter Your ID:");
                        int id=Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the Course Code You want to Enroll:");
                        string? code = Console.ReadLine();
                        delegateRegister(id,code);
                        break;
                    case 3:
                        Course cour = new Course("1000","qwerty","Manu",10);
                        DelegateOne delegateRemove = new DelegateOne(cour.WithdrawCourse);
                        Console.WriteLine("Do you really want to Cancel the course:");
                        Console.WriteLine("then enter Course Code ");
                        string? cCode=Console.ReadLine();
                        Console.WriteLine("Enter Your Id:");
                        int sId=Convert.ToInt32(Console.ReadLine());
                        delegateRemove(sId, cCode);
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid entry");
                        break;
                }
                Console.WriteLine("1. Continue   2. Exit");
                b = Convert.ToInt32(Console.ReadLine());
            } while(b==1);
            break;
        case 3:
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Invalid Entry");
            break;

    }
    Console.WriteLine("1. Continue   2. Exit");
    n=Convert.ToInt32(Console.ReadLine());
} while (n == 1);
    }
}
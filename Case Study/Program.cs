
using Case_Study;

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
        Console.WriteLine("Enter the customer id");
        int cId = Convert.ToInt32(Console.ReadLine());
        if (Customer1.customers.Find(x => x.CustomerID == cId) == null)
        {
            Console.WriteLine("Customer not found");
            break;
        }
        while (true)
        {
            Console.WriteLine("choose your option\n1.Add product to cart\n2.view all product\n3.place order\n4.Support\n5.view orders");
            int optionuser = Convert.ToInt32(Console.ReadLine());

            switch (optionuser)
            {

                case 1:

                    Console.WriteLine("Enter Product id for add to cart");
                    int productId = Convert.ToInt32(Console.ReadLine());
                    Customer1? customerOne = Customer1.customers.Find(x => x.CustomerID == cId);
                    if (DigitalProduct.Products.Find(x => x.ProductId == productId) == null)
                    {
                        if (PhysicalProduct.Products.Find(x => x.ProductId == productId) == null)
                        {
                            Console.WriteLine("invalid product id");
                        }
                        else
                        {
                            customerOne.ordersphy.Add(PhysicalProduct.Products.Find(x => x.ProductId == productId));
                            Console.WriteLine("product added to cart");
                        }
                    }
                    else
                    {
                        customerOne.orders.Add(DigitalProduct.Products.Find(x => x.ProductId == productId));
                        Console.WriteLine("product added to cart");
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
                    if (customer.orders.Count == 0 && customer.ordersphy.Count == 0)
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
                        foreach (var item in customer.ordersphy)
                        {
                            Console.WriteLine("Productid:{0}\tProduct Name:{1}\tPrice:{2}\tProduct Quantity:{3}\tWeight:{4}" +
                           "\tDimension:{5}", item.ProductId,
                           item.Name, item.Price, item.StockQuantity, item.Weight, item.Dimension);
                            item.PlaceOrder();
                            item.ProcessPayment();
                            item.DeliverProduct();
                        }
                        Console.WriteLine("do you want to place all the order\n1.yes\n2.no");
                        int confirm = Convert.ToInt32(Console.ReadLine());
                        if (confirm == 1)
                        {
                            customer.confirmedorders.AddRange(customer.orders);
                            customer.orders.Clear();
                            customer.confirmedordersphy.AddRange(customer.ordersphy);
                            customer.ordersphy.Clear();
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
                    if (customerTwo.confirmedorders.Count == 0 && customerTwo.confirmedordersphy.Count == 0)
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
                        foreach (var item in customerTwo.confirmedordersphy)
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
        Console.WriteLine("choose option\n1.Add Product\n2.View report");
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

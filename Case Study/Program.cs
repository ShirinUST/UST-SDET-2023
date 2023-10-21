
using Case_Study;

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

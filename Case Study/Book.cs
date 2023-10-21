using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Study
{
    internal class Book
    {
        public Book(string? title, string? author, int isbn,double price, string? availability)
        {
            Title = title;
            Author = author;
            Isbn = isbn;
            Availability = availability;
            Price = price;
        }

        public string? Title { get; set; }  
        public string? Author { get; set; }
        public int Isbn {  get; set; }
        public double Price {  get; set; }
        public string? Availability {  get; set; }

    }
}

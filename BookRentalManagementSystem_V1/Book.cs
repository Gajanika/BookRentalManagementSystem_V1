using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRentalManagementSystem_V1
{
    internal class Book
    {
        public int BookId;
        public string Title;
        public string Author;
        public decimal RentalPrice;

        public static string TotalBooks;



        public Book(int bookId, string title, string author, decimal rentalprice)
        {
         
            BookId = bookId;
            Title = title;
            Author = author;
            RentalPrice = rentalprice;
              
        }

        public override string ToString()
        {
            return $"ID:{BookId},Title:{Title};Author{Author},RentalPrice{RentalPrice}";
        }
        public string DisplayBookInfo() 
        {
            return ToString();
        }
    }

}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC5.ViewModel
{
    public class Book
    {
        public string ID { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public DateTime DateOfRelease { get; set; }

        public static List<Book> GetBooks()
        {
            List<Book> list = new List<Book>();
            list.Add(new Book{
              ID="001",
              Title="programming book",
              Price=300,
              DateOfRelease=Convert.ToDateTime("2015-04-09") 


            });
            list.Add(new Book
            {
                ID = "002",
                Title = "programming book",
                Price = 300,
                DateOfRelease = Convert.ToDateTime("2015-04-09")


            });
            list.Add(new Book
            {
                ID = "003",
                Title = "programming book",
                Price = 300,
                DateOfRelease = Convert.ToDateTime("2015-04-09")


            });
            list.Add(new Book
            {
                ID = "004",
                Title = "programming book",
                Price = 300,
                DateOfRelease = Convert.ToDateTime("2015-04-09")


            });
            list.Add(new Book
            {
                ID = "005",
                Title = "programming book",
                Price = 300,
                DateOfRelease = Convert.ToDateTime("2015-04-09")


            });
            list.Add(new Book
            {
                ID = "006",
                Title = "programming book",
                Price = 300,
                DateOfRelease = Convert.ToDateTime("2015-04-09")


            });
            list.Add(new Book
            {
                ID = "007",
                Title = "programming book",
                Price = 300,
                DateOfRelease = Convert.ToDateTime("2015-04-09")


            });
            return list;
        }
    }
}
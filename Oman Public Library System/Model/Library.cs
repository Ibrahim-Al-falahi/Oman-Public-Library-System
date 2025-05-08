using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oman_Public_Library_System.Model
{
    internal class Library
    {

        public int Id { get; set; }
        public string Name { get; set; }

        List<Book> books;
        public Library(int id, string name)
        {
            Id = id;
            Name = name;
            books = new List<Book>();
        }

        
        public void AddBook(Book book)
        {
            books.Add(book);
        }



    }
}

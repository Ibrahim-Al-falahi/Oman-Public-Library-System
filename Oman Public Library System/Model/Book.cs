using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oman_Public_Library_System.Model
{
    internal class Book
    {

        public int Id { get; set; }
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public Book(int id, string iSBN, string title, string author)
        {
            Id = id;
            ISBN = iSBN;
            Title = title;
            Author = author;
        }



    }
}

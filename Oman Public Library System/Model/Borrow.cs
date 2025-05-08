using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oman_Public_Library_System.Model
{
    internal class Borrow
    {
        public int Id { get; set; }
        public DateOnly BorrowDate { get; set; }
        public bool Returned { get; set; }
        public Borrow(int id, DateOnly borrowDate, bool returned)
        {
            Id = id;
            BorrowDate = borrowDate;
            Returned = returned;
        }



    }
}

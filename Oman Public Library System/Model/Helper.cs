using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oman_Public_Library_System.Model
{
    internal class Helper
    {
        List<Borrow> borrows= new List<Borrow>();

        public void Add(Borrow borrow)
        {
            borrows.Add(borrow);
        }

        public bool ReturnBook(int Mid,int Bid)
        {
            foreach (var item in borrows)
            {
                if (item.MemberId == Mid && item.BookId== Bid)
                {
                    return true;
                    
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        public void View(int id)
        {
            foreach (var item in borrows)
            {
                if(item.MemberId==id)
                Console.WriteLine(item.ToString());
                else Console.WriteLine("No Books borrowed");
            }
        }

        public void OverDue()
        {
            //foreach (var item in borrows)
            //{
            //    Console.WriteLine(item.BorrowDate> DateTime.Now);
            //}
            
        }
    }
}

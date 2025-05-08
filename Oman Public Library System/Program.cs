using Oman_Public_Library_System.Model;

namespace Oman_Public_Library_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Borrow> borrows; borrows= new List<Borrow>();

            borrows.Add(new Borrow(1,new DateOnly(1999,5,1),true,1,1));

        }
    }
}

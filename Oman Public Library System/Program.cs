using Oman_Public_Library_System.Model;

namespace Oman_Public_Library_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Borrow> borrows; borrows= new List<Borrow>();

            borrows.Add(new Borrow(1,new DateOnly(1999,5,1),true,1,1));

            Helper helper = new Helper();
            Staff staff = new Staff(1, "Ahmed");
            Library library = new Library(1, "Sohar");

            Member m = new Member("Yas", 1, new DateOnly(1999, 5, 1));
            Book book = new Book(1, "1999-22-525-69", "Space", "Mark");
            Borrow borrow = new Borrow(1, new DateOnly(2024, 10, 29), true, 1, 1);

            staff.AddMember(m);
            library.AddBook(book);
            helper.Add(borrow);

            int mid=int.Parse(Console.ReadLine());
            int bid = int.Parse(Console.ReadLine());
            helper.ReturnBook(mid, bid);


            int target = int.Parse(Console.ReadLine());
            helper.View(target);

            //helper.OverDue();
            

        }
    }
}

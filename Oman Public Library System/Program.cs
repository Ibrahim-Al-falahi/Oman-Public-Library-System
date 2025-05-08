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

            Book book1 = new Book(1, "1999-22-525-69", "Space", "Mark");

            Book book2 = new Book(2, "1999-22-525-69", "Space", "Mark");

            Book book3 = new Book(3, "1999-22-525-69", "Space", "Mark");


            Member member1 = new Member("Yas", 1, new DateOnly(1999, 5, 1));

            Member member2 = new Member("hadeel", 2, new DateOnly(1999, 5, 1));

            Member member3 = new Member("ahmed", 3, new DateOnly(1999, 5, 1));


            Staff staff1 = new Staff(1, "Ahmed");

            Staff staff2 = new Staff(2, "Ali");

            string choice = "0";
            int MemberId = 0;
            int BookId = 0;
            int BorrowId = 0;
            while (choice!="7")
            {

                Console.WriteLine("1. Register New Member");
                Console.WriteLine("2. Add New Book");
                Console.WriteLine("3. Borrow Book");
                Console.WriteLine("4. Return Book");
                Console.WriteLine("5. View Member Borrowed Books");
                Console.WriteLine("6. Show Overdue Books");
                Console.WriteLine("7. Exit");
                

                 choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        string name =Console.ReadLine();
                        DateOnly date =DateOnly.Parse(Console.ReadLine());

                        staff.AddMember(new Member(name, MemberId++,date));
                        break;
                    case "2":
                        Console.WriteLine("--- Add New Book ----");

                        string ISBN = Console.ReadLine();

                        Console.WriteLine(ISBN);



                        string Title = Console.ReadLine();

                        Console.WriteLine(Title);


                        string Author = Console.ReadLine();

                        Console.WriteLine(Author);

                        Console.WriteLine("Book added Succesfully");
                        library.AddBook(new Book(BookId++, ISBN, Title, Author));
                        break;
                    case "3":
                        Console.WriteLine("--- Borrow Book ----");

                        int MemberId_ = Convert.ToInt32(Console.ReadLine());
                        int BookId_ = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(MemberId);


                        DateOnly date_target = new(Convert.ToDateTime(Console.ReadLine());

                        Console.WriteLine(date_target);


                        Console.WriteLine("Book borrowed Succesfully");
                        helper.Add(new Borrow(BorrowId++, date_target, false,MemberId_,BookId_));
                        break;
                    case "4":
                        int mid = int.Parse(Console.ReadLine());
                        int bid = int.Parse(Console.ReadLine());
                        helper.ReturnBook(mid, bid);
                        break;
                    case "5":
                        int target = int.Parse(Console.ReadLine());
                        helper.View(target, staff);
                        break;
                    case "6":
                        helper.OverDue();
                        break;

                    case "7":
                        Console.WriteLine("Bye");
                        break;

                }


            }

            
            
            

            


            

            
            

        }
    }
}

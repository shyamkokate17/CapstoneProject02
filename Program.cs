
using System;

namespace LibraryManagment
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.Write("*******Welcome For Something new learn here*********** !!!\n\n");
            Console.WriteLine("\nEnter your password :");
            string password = Console.ReadLine();

            if (password == "Password")
            {
                bool close = true;
                while (close)
                {


                    Console.WriteLine();
                    Console.WriteLine("   ***Welcome in Shri Gajanan Library: ***\n");
                    Console.WriteLine("  *****************************");
                    Console.WriteLine("    !  Enter 1 For 'Librarian' ! ");
                    Console.WriteLine("    !  Enter 2 For 'Borrower'  !  ");
                    Console.WriteLine("    !  Enter 3 For 'Exit'      !   ");
                    Console.WriteLine("  *****************************");
                    string chosen = Console.ReadLine();
                    int x = int.Parse(chosen);

                    Librarian l = new Librarian();
                    Students s = new Students();

                    switch (x)
                    {
                        case 1:
                            l.LibrarianPortal();
                            break;
                        case 2:
                            s.studentPortal();
                            break;
                        case 3:
                            close = false;
                            Console.WriteLine("*****Thanks you!!! Welcome Again with Your Dream*******");
                            break;

                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid password!!!!!>>Please check it");
            }

        }
    }
}
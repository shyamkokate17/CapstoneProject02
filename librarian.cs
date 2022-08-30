

using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagment
{
    internal class Librarian
    {
        public void LibrarianPortal()
        {
            Console.Write("*****Enter Password for Librarian:  ****** !!!");
            Console.WriteLine("\nEnter Librarian password :");
            string password = Console.ReadLine();

            if (password == "SSGMCE@77")
            {

                bool close = true;
                while (close)
                {
                    Console.WriteLine();
                    Console.WriteLine("*----*----Welcome Sir here--*---*");
                    Console.WriteLine();
                    Console.WriteLine("   ------------------------------------");
                    Console.WriteLine("   *   Enter (1) for Books             * ");
                    Console.WriteLine("   *   Enter (2) to end this session   * ");
                    Console.WriteLine("   ------------------------------------");

                    Librarian l = new Librarian();

                    string LibrarianChoice = Console.ReadLine();
                    int y = int.Parse(LibrarianChoice);

                    Books b = new Books();

                    if (y == 1)
                    {
                        b.Booksportal();
                    }
                    else if (y==2) {
                        close= false;

                    }

                }
            }
            else
            {
                Console.WriteLine("****Please Enter Correct Password!!!*****");
            }

        }
    }
}


using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagment
{
    internal class StuBorrow : Students
    {
        public static void BorrowBook()
        {
            Addition t = new Addition();
            Console.Write(" Enter Book Code: ");
            int borrow = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            foreach (Book b in t)
            {
                if (b.ID.Equals(borrow))
                {
                    if (b.Borrowed == true)
                    {
                        Console.WriteLine("************Book is already Issued: Sorry**********");

                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine(b.ID + ":" + b.Name);
                        b.Quantity--; 
                        Console.WriteLine("**********-Book Successfully Issued by You##***********");

                        b.Borrowed = true;
                        Console.WriteLine();

                    }
                }


            }
        }
        public static void ReturnBook()
        {
            Addition t = new Addition();
            Console.Write(">===>  Enter Book Code to Return:  ");
            int returning = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            foreach (Book b in t)
            {
                if (b.ID.Equals(returning))
                {
                    if (b.Borrowed == true)
                    {
                        b.Borrowed = false;

                        Console.WriteLine($">>>Book ID-{b.ID} BookName-{b.Name}------- Succesfully returned---------------");
                        b.Quantity++;
                        Console.WriteLine();

                    }
                    else
                    {
                        Console.WriteLine("**********You Have not Borrowed this book***********");
                        Console.WriteLine();

                    }
                }


            }
        }


    }
}
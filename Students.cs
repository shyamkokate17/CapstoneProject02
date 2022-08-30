

using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagment
{
    internal class Students
    {
        public void studentPortal()

        {

            Console.WriteLine();
            Console.WriteLine("***************************************");
            Console.WriteLine("  Press 1 to BorrowBook           ");
            Console.WriteLine("  Press 2 to ReturnBook            ");
            Console.WriteLine("  Press 3 to View Available Books in our Library  ");
            Console.WriteLine("  Press 4 to Exit        ");
            Console.WriteLine("");
            Console.WriteLine();
            int x = Convert.ToInt32(Console.ReadLine());

            Addition t = new Addition();

            StudentBook obj = new StudentBook();

            if (x == 1)
            {
                obj.BorrowOperation();
                studentPortal();
            }
            else if (x == 2)
            {
                obj.ReturnOperation();
                studentPortal();
            }
            else if (x == 3)
            {
                Console.WriteLine("{0,5}  {1,-60}  {2,-15}  {3, 10}", "BookID", "BookName", "BPrice","BQuantity");
                Console.WriteLine("---------------------------------------------------------------------------------------------------------");
                foreach (Book b in t)
                {
                    Console.WriteLine($"{b.ID,5}    {b.Name,-60}  {b.Price,-15}  {b.Quantity,10}");
                    
                }
                Console.WriteLine("---------------------------------------------------------------------------------------------------------");
                studentPortal();

            }
            else if (x == 4)
            {

            }


        }

    }
}
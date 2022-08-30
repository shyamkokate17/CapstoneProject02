
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagment
{
    internal class Books
    {
        public void Booksportal()
        {
            Console.WriteLine();
            Console.WriteLine(" 1>    For Adding                            ");
            Console.WriteLine(" 2>    For Removing                          ");
            Console.WriteLine(" 3>    For Viewing all the available books   ");
            Console.WriteLine(" 4>    For Back                              ");

            Console.WriteLine();

            Addition t = new Addition();

            string input = Console.ReadLine();
            int z = int.Parse(input);

            if (z == 1)
            {
                Console.Write("   *-  How Many Books you Want to Add Now: ");
                int quantity = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < quantity; i++)
                {
                    Console.Write("   >>  Please Enter Book ID: ");
                    int BookID = Convert.ToInt32(Console.ReadLine());
                    Console.Write("   >>  Please Enter Book Name: ");
                    string BName = Console.ReadLine();
                    Console.Write("   >>  Book Price: ");
                    double BookPrice = Convert.ToDouble(Console.ReadLine());
                    Console.Write("   >>  Enter Book Quantity: ");
                    int BookQuantity=int.Parse(Console.ReadLine());

                    Console.WriteLine();
                    t.ADD(new Book { ID=BookID, Name=BName, Price=BookPrice ,Quantity=BookQuantity});

                }

                
                Console.WriteLine("{0,5}  {1,-60}  {2,-15}  {3,10}\n", "BookID", "BookName", "BPrice","Quantity");
                Console.WriteLine("---------------------------------------------------------------------------------------------------------");
                foreach (Book x in t)
                {
                    Console.WriteLine($"{x.ID,5}    {x.Name,-60}  {x.Price,-15}   {x.Quantity,10}");
                }
                Console.WriteLine("---------------------------------------------------------------------------------------------------------\n");

                Booksportal();

            }
            else if (z == 2)
            {
                Console.Write(" >>  Type Book code for Remove: ");
                int i = Convert.ToInt32(Console.ReadLine());
                t.Rem(i);

                foreach (Book x in t)
                {

                    Console.WriteLine($"   *-  Book ID>{x.ID}  Book Name-{x.Name} ");
                }
                Console.WriteLine();
                Booksportal();
            }
            else if (z==3)
            {
                Console.WriteLine("{0,5}  {1,-60}  {2,-15}  {3,10}", "BookID", "BookName", "BPrice","BQuantity");
                Console.WriteLine("---------------------------------------------------------------------------------------------------------");
                foreach (Book x in t)
                {
                    Console.WriteLine($"{x.ID,5}    {x.Name,-60}  {x.Price,-15} {x.Quantity,10}");
                }
                Console.WriteLine();
                Booksportal();
            }
            else
            {
                Console.WriteLine("****************************************");
                Console.WriteLine("   Enter [1] for Books              ");

                Console.WriteLine("   Enter [2] to end this session    ");
                Console.WriteLine("****************************************");
                int y = Convert.ToInt32(Console.ReadLine());
                if (y == 1)
                {
                    Booksportal();
                }

                else if (y == 2)
                {

                }
                else
                {
                    Console.WriteLine(">>>Invalid Input: please select proper option: ");

                }
            }
        }


       



    }
}


using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagment
{
    internal class Addition : IEnumerable
    {
        public static List<Book> books = new List<Book>
        {
            

            new Book{ID=1,  Name="JAVA",Price=567,Quantity=33},
            new Book{ID=2,  Name="C# --(C Sharps with Dot Net)" ,Price=675,Quantity=21  },
            new Book{ID=3,  Name="RS Aggrawal (Aptitude)",Price=430,Quantity=2},
            new Book{ID=4,  Name="Reasoning",Price=330,Quantity=12},
            new Book{ID=5,  Name="General Awareness",Price=343,Quantity=10 },
            new Book{ID=6,  Name="SQL",Price=231,Quantity=5 },
            new Book{ID=7,  Name="The Economics over the World" ,Price=654,Quantity=5 },
            new Book{ID=8,  Name="Shri BaghwatGita" ,Price=234,Quantity=70 },
            new Book{ID=9,  Name="Indians Politics",Price=459,Quantity=55 },
            new Book{ID=10, Name="The New Stock Market",Price=989, Quantity = 5},
            new Book{ID=11, Name="Web Development (Edition 2022)",Price=654,Quantity= 8},
            new Book{ID=12, Name="HTML From Beginers to Masters",Price=430, Quantity = 9},
            new Book{ID=13, Name="CSS in Advances",Price=220, Quantity = 10},
            new Book{ID=14, Name="C/C++ ",Price=233.99, Quantity = 15}

        };

        public void ADD(Book NewBook)
        {

            if (books == null)
            {
                books = new List<Book>();

            }
            books.Add(NewBook);
        }

     

        public void Rem(int i)
        {
            if (books != null)
            {
                books.RemoveAll(r => r.ID == i);

            }

        }
        public IEnumerator GetEnumerator()
        {
            if (books != null)
            {
                return books.GetEnumerator();
            }
            else
            {
                return null;
            }

        }

    }



    public class Book
    {
        public Boolean Borrowed { get; set; }
        public int ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public int Quantity { get; set; }


    }
}
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Linq;

namespace lynq
{
    class books
    {      
          public int BookID { get; set; }
          public string Title { get; set; }
          public string Author { get; set; }
          public int Price { get; set; }
    }
    class Day24Apr7Tasks
    {
        public static void Main()
        {
            IList<books> Booklist = new List<books>()
            {
            new  books()  { BookID = 1 ,Title="Avatar the last air bender",Author="Gene luen yang",Price =60000},
            new  books()  { BookID = 2 ,Title="The legend of korra",Author="Gene",Price =50000},
            new  books()  { BookID = 3 ,Title="Doremon",Author="Fujiko F.fujio",Price =20000},
            new  books()  { BookID = 4 ,Title="Shin-chan",Author="Yoshito usui",Price =10000},
            };
            var qry1 = from Boo in Booklist
                       select Boo;
            Console.WriteLine("Task 1 Displaying all data");
            foreach (var B in qry1)
                Console.WriteLine(B.BookID + " " + B.Title + " " + B.Author + " " + B.Price);

            Console.WriteLine("Task 2 Displaying books by Particular Author");
            Console.WriteLine("Enter the Author name : ");
            String Uauthor = Console.ReadLine();

            var qry2 = from Boo in Booklist
                       where Boo.Author == Uauthor
                       select Boo.Title;
            foreach (var B in qry2)
                Console.WriteLine(B);

            Console.WriteLine("Task 3 Displaying books ordered by price ");
            var qry3 = from Boo in Booklist
                       orderby Boo.Price
                       select Boo;
            foreach (var B in qry3)
                Console.WriteLine(B.BookID + " " + B.Title + " " + B.Author + " " + B.Price);

            Console.WriteLine("Task 4 Displaying books ordered by Author");
            var qry4 = from Boo in Booklist
                       orderby Boo.Author
                       select Boo;
            foreach (var B in qry4)
                Console.WriteLine(B.BookID + " " + B.Title + " " + B.Author + " " + B.Price);
        }
    }
}

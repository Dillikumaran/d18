using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1day10
{
    class task1day10

    {
        string name;int age;
          public task1day10()
            {
                Console.WriteLine("Enter your name and age  :");
                string name = Console.ReadLine();
                int age = Convert.ToInt32 (Console.ReadLine());
                Console.WriteLine("Your name is {0} and your age is {1}",name,age);
            }
           public task1day10(string name,int age)
        { 
            Console.WriteLine("Your name is {0} and your age is {1} ", name, age);
        }
        public static void Main()
        {
            task1day10 obj = new task1day10();
            Console.WriteLine("Enter your name and age :");
            string name = Console.ReadLine();
            int age = Convert.ToInt32(Console.ReadLine());
            task1day10 obj1 = new task1day10(name, age);
            Console.ReadLine();
        }
     }
}

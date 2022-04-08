using System;
using System.Collections.Generic;
using System.Text;

namespace lynq
{
    class Day25Apr8
    {
        public static int countgoat(int Heads,
                                int Legs)
        {
            int count = 0;

            count = (Legs) -  2 * (Heads);
            count = count / 2;

            return count;
        }

       
        public static void Main()
        {
            Console.WriteLine("Enter the no of legs :");
            int Legs = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the no of eyes :");
            int eyes =Convert.ToInt32(Console.ReadLine());
            int Heads = eyes / 2;

            int goat = countgoat(Heads, Legs);

            Console.WriteLine("Goats = " +
                               goat);
            Console.WriteLine("Duck = " +
                             (Heads - goat));
        }
    }
}

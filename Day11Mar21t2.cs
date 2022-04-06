using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace ConsoleApp1
{
    class day21task2
    {
        public static void Main()
        {
            Console.WriteLine("Enter your Employee id : ");
            int Eid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your Name : ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your Gender : ");
            string gender = Console.ReadLine();
            Console.WriteLine("Enter your Age : ");
            int age = Convert.ToInt32(Console.ReadLine());
            FileStream fs = new FileStream("F:\\fstream\\task2.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(fs);
            sw.BaseStream.Seek(0, SeekOrigin.End);
            sw.WriteLine("Employee ID : {0} \n Name : {1} \n Gender : {2} \n Age : {3}", Eid, name, gender, age);
            sw.Flush();
            fs.Close();
            FileStream fs1 = new FileStream(@"f:\fstream\task2.txt", FileMode.Open, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs1);
            string a = sr.ReadToEnd();
            Console.WriteLine(a);
            fs1.Close();
            Console.ReadLine();
        }
    }
}

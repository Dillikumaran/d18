using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    [Serializable]
    class day12task2
    {
        public String name = "Dilli";
        public string gender = "male";
        public int empId = 39290020;
        public int age = 19;

    }
    class readwrite
    {
        public void infile()
        {
            day12task2 emp = new day12task2();
            FileStream fs = new FileStream("Employee.txt", FileMode.OpenOrCreate, FileAccess.Write);
            BinaryFormatter f = new BinaryFormatter();
            f.Serialize(fs, emp);
            fs.Close();
        }
        public void outfile()
        {
            FileStream fs1 = new FileStream("Employee.txt", FileMode.Open, FileAccess.Read);
            BinaryFormatter r = new BinaryFormatter();
            day12task2 emp1 = (day12task2)r.Deserialize(fs1);
            Console.WriteLine(emp1.empId);
            Console.WriteLine(emp1.name);
            Console.WriteLine(emp1.gender);
            Console.WriteLine(emp1.age);
            Console.ReadLine();
        }
        public static void Main()
        {
            readwrite sere = new readwrite();
            sere.infile();
            sere.outfile();
        }
    }
}


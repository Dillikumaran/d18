using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace ConsoleApp1
{
    class day21task1
    {
        public static void Main()
        {
            ArrayList dessertlist = new ArrayList();
            dessertlist.Add("kesari");
            dessertlist.Add("laddu");
            dessertlist.Add("jalebi");
            dessertlist.Add("khewar");
            FileStream fs = new FileStream("F:\\fstream\\task1.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(fs);
            sw.BaseStream.Seek(0, SeekOrigin.End);
            foreach(string o in dessertlist)
            sw.WriteLine(o);
            sw.Flush();
            fs.Close();
            FileStream fs1 = new FileStream(@"f:\fstream\task1.txt", FileMode.Open, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs1);
            string outlist = sr.ReadToEnd();
            Console.WriteLine(outlist);
            fs1.Close();
            FileInfo fi = new FileInfo(@"F:\fstream\task1.txt");
            Console.WriteLine(fi.Length);
            Console.WriteLine(fi.CreationTime);
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2day10
{
    class salesmarketing
    {
        public int Empdetail()
        {
            Console.WriteLine("Enter your Employee ID :");
            int Empid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your name :");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your Gender :");
            string gender = Console.ReadLine();
            Console.WriteLine("Enter your year of Experiance :");
            int yoe=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your salery :");
            int sal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Employee ID : {0} \n Name : {1} \n Gender : {2} \n Year of experience : {3} \n Salery : {4} ",Empid,name,gender,yoe,sal);
            return sal;
        }
        public virtual void bonus(int sal)
        {
            int salery = sal;
            float total,bonus ;
            bonus = (salery * 20)/100;
            total = salery + bonus;
            Console.WriteLine(" Bonus : {0} \n Total salery : {1}",bonus,total);

        }
    }
    class production:salesmarketing
    {
        public override void bonus(int sal)
        {
            int salery = sal; float total, bonus;
            bonus = (salery * 10) / 100;
            total = salery + bonus;
            Console.WriteLine(" Bonus : {0} \n Total salery : {1}",bonus, total);
        }
    }
    class task2day10
    {
        public static void Main()
        {
            Console.WriteLine("Enter your department (sales or production): ");
            string dep = Console.ReadLine();
            switch(dep)
            {
                case "sales":
                    {
                        production obj = new production();
                        int salery = obj.Empdetail();
                        salesmarketing obj1 = new salesmarketing();
                        obj1.bonus(salery);
                    }
                    break;
                case "production":
                    {
                        production obj2 = new production();
                        int salery = obj2.Empdetail();
                        obj2.bonus(salery);
                    }
                    break;
                default:
                    break;
           
            }
        }

    }
}

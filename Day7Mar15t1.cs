using System;
class task1day7
{
public static void Main(string[] args)
{
Console.WriteLine("Enter your name :");
string name = Console.ReadLine();
Console.WriteLine("Enter your age :");
int age= Convert.ToInt32(Console.ReadLine());
for (int i = 0;i<age;i++)
{
Console.WriteLine(name);
Console.WriteLine(age);
}
}
}

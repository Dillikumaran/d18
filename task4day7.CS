using System;
class task4day7
{
public static void Main()
{
int [] marks=new int[5];
Console.WriteLine("Enter your marks : ");

for(int i=0;i<5;i++)
{
marks[i]=Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine();
int sum = marks[0]+marks[1]+marks[2]+marks[3]+marks[4];
int percentage = sum/5;
for (int i = 0;i<5;i++)
{
Console.Write(marks[i]+"\t");
}
Console.WriteLine();
Console.WriteLine("sum: "+sum);
Console.WriteLine("percentage : "+percentage);

}
}
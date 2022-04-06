using System;
class arithmetic1:arithmetic2
{
public void add(int num1,int num2)
{
int n1 = num1;
int n2 = num2;
int sum = n1+n2;
Console.WriteLine("Sum of the numbers = "+sum);
}
public void subtract(int num1,int num2)
{
int n1 = num1;
int n2 = num2;
int sub=n1-n2;
Console.WriteLine("Subtraction of the numbers = "+sub);
}
}
class arithmetic2
{
public void mul(int num1,int num2)
{
int n1 = num1;
int n2 = num2;
int product = n1*n2;
Console.WriteLine("product of the two numbers = "+product);
}
public void div(int num1,int num2)
{
int n1 = num1;
int n2 = num2;
float division = n1/n2;
Console.WriteLine("Division of the numbers = "+division);
}
}
class inherit
{
public static void Main()
{
int num1,num2;
Console.WriteLine("Enter two numers : ");
num1 =Convert.ToInt32(Console.ReadLine());
num2 =Convert.ToInt32(Console.ReadLine()); 
arithmetic1 obj = new arithmetic1 ();
obj.add(num1,num2);
obj.subtract(num1,num2);
obj.mul(num1,num2);
obj.div(num1,num2);
}
}

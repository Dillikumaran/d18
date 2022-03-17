using System;
abstract class calculator
{
public abstract void add(int a,int b);
public abstract void sub(int a,int b);
public abstract void mul(int a,int b);
public abstract void div(int a,int b);
}
class Calculator:calculator
{
public override void add(int a,int b)
{
int c;
c= a+b;
Console.WriteLine("Addition is : "+c);
}
public override void sub(int a,int b)
{
int c;
c=a-b;
Console.WriteLine("Subtraction is : "+c);
}
public override void mul(int a,int b)
{
int c;
c = a*b;
Console.WriteLine("Multiplication is : "+c);
}
public override void div(int a,int b)
{
double c;
c = a/b;
Console.WriteLine("Division is : "+c);
}
}
class implementation
{
public static void Main()
{
int a,b;
Console.WriteLine("Enter two numbers : ");
a =Convert.ToInt32(Console.ReadLine());
b =Convert.ToInt32(Console.ReadLine());
Calculator obj = new Calculator();
obj.add(a,b);
obj.sub(a,b);
obj.mul(a,b);
obj.div(a,b);
}
}
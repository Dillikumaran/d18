using System;
class Gst
{
public float calculatetax(int num1)
{
float Gst=num1*12/100;
return Gst;
}
}
class Vat:Gst
{
public float calculatetax(int num1)
{
float Vat = num1*20/100;
return Vat;
}
}
class bill
{
public static void Main()
{
int num1;
Console.WriteLine("Enter the bill amount");
num1 =Convert.ToInt32(Console.ReadLine()); 
Gst obj = new Gst();
float gst =obj.calculatetax(num1);
Vat obj1 = new Vat();
float vat = obj1.calculatetax(num1);
Console.WriteLine("Bill amount"+num1+"\n"+"Gst for the amount = "+gst+"\n"+"Vat for the amount = "+vat+"\n"+"Total amount (including gst and vat) : "+(num1+gst+vat));
}
}

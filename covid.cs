using System;
class covid
{
public static void Main()
{
string Hist,Temp,Cough;
Console.WriteLine("Do you have any travel history?");
Hist = Console.ReadLine();
if(Hist == "yes")
{
Console.WriteLine("Do you have high temperature ?");
Temp = Console.ReadLine();
if(Temp=="yes")
{
Console.WriteLine("Do you have cough /cold ? ");
Cough = Console.ReadLine();
if(Cough == "yes")
{
Console.WriteLine("Take a swab test!!!");
}
else
{
Console.WriteLine("Take medicines");
}
}
else
{
Console.WriteLine("Stay in home quarantine");
}
}
else
{
Console.WriteLine("you don't have covid");
}
}
}
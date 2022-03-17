using System;
interface Accomodate
{
void accomodation();
}
interface Food
{
void food();
}
class Silver : Accomodate
{
public void accomodation()
{
Console.WriteLine("3 Days accomodation at resort");
}
}
class Gold : Accomodate, Food
{
public void accomodation()
{
Console.WriteLine("5 Days accomodation at resort");
}
public void food()
{
Console.WriteLine("2 Dinners on the house");
}
}
class Platinum :Accomodate,Food
{
public void accomodation()
{
Console.WriteLine("7 Days accomodation at resort");
}
public void food()
{
Console.WriteLine("5 Dinners on the house");
}
}
class implement
{
public static void Main()
{
Console.WriteLine("Enter the membership silver||gold ||platinum :");
string mem = Console.ReadLine();
switch(mem)
{
case "silver":
{
Silver obj = new Silver();
obj.accomodation();
}
break;
case"gold":
{
Gold obj  = new Gold();
obj.accomodation();
obj.food();
}
break;
case"platinum":
{
Platinum obj = new Platinum();
obj.accomodation();
obj.food();
}
break;
default:
break;
}
}
}
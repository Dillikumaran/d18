using System;
class task3day7
{
public static void Main()
{
int A=250,B=450,C=350;
Console.WriteLine("Enter the no.of packages needed :");
int npack =Convert.ToInt32( Console.ReadLine());
switch (npack)
{
case 1:
{
Console.WriteLine("Enter the pack : AorBorC");
string pack1 = Console.ReadLine();
switch(pack1)
{
case "A":Console.WriteLine("Rate for the selected package : "+A);
break;
case "B":Console.WriteLine("Rate for the selected package : "+B);
break;
case "C":Console.WriteLine("Rate for the selected package : "+C);
break;
default:
break;
}
}
break;
case 2:
{
Console.WriteLine("Enter the combo pack:(AB,BC,CA)");
string cpack = Console.ReadLine();
switch(cpack)
{
case "AB":Console.WriteLine("Rate for the selected packages : "+(A+B));
break;
case "BC":Console.WriteLine("Rate for the selected packages : "+(B+C));
break;
case "CA":Console.WriteLine("Rate for the selected packages : "+(C+A));
break;
default:
break;
}
}
break;
case 3:Console.WriteLine("Rate for the selected packages : "+(C+A+B));
break;
default:
break;
}
}
}

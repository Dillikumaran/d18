using System;
class task5
{
public static void Main()
{
int amount,consumed;
Console.WriteLine("Enter consumed unit:");
consumed = Convert.ToInt32(Console.ReadLine());
if (consumed<=200)
{
amount = consumed *2;
Console.WriteLine(amount);
}
 else if((consumed>200) && (consumed<=350))
{
consumed = consumed-200;
amount =consumed*3;
Console.WriteLine(amount+400);
}
else if((consumed>350) && (consumed<=500))
{
consumed = consumed-350;
amount = consumed *5;
Console.WriteLine(amount+450+400);
}
else
{
consumed = consumed-500;
amount = consumed *7;
Console.WriteLine(amount+750+450+400);
}
}
}

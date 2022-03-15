using System;
class task5day7
{
public static void Main()
{
string [][] product = new string[3][];
product[0] = new string[]{"biscuits","nutri choice","milk shakthi","sunfeast","milk bikis"};
product[1]= new string[]{"chocolates","dairy milk","kitkat","munch","5star","kinderjoy"};
product[2] =new string[]{"Drinks","fanta","7up","frooti","bovonto","milkshake","sprite"};

for(int i= 0;i<product.Length;i++)
{
   for(int j=0;j<product[i].Length;j++)
    {
     Console.Write(product[i][j]+"\t");
     }
Console.WriteLine();
}
}
}
using System;
class t3d8
{
public void validate(string mail,string pass)
{
if((mail == "dilliskumaran@gmail.com")&&(pass=="password"))
Console.WriteLine("LOGGED IN SUCCESSFULLY!!!");
else
Console.WriteLine("Enter a valid credentials");
}
public void validate(string Pass,int memId)
{
if((memId == 39290020)&&(Pass=="pin"))
Console.WriteLine("LOGGED IN SUCCESSFULLY!!!");
else
Console.WriteLine("Enter a valid credentials");
}
public void validate(long mobNo,string pass)
{
if((mobNo == 9677054298)&&(pass=="pin"))
Console.WriteLine("LOGGED IN SUCCESSFULLY!!!");
else
Console.WriteLine("Enter a valid credentials");
}
public static void Main()
{
Console.WriteLine("Login with A-mailid or B-mobileNumber or C-membershipId");
string options=Console.ReadLine();
switch (options)
{
case "A":
{
Console.WriteLine("Enter the email ID : ");
string mail=Console.ReadLine();
Console.WriteLine("Enter password : ");
string pass=Console.ReadLine();
t3d8 obj = new t3d8();
obj.validate(mail,pass);
}
break;
case "B":
{
Console.WriteLine("Enter the mobile NO : ");
long mobNo=Convert.ToInt64(Console.ReadLine());
Console.WriteLine("Enter password : ");
string pass=Console.ReadLine();
t3d8 obj1 = new t3d8();
obj1.validate(mobNo,pass);
}
break;
case "C":
{
Console.WriteLine("Enter the Membership ID : ");
int memId=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter password : ");
string Pass=Console.ReadLine();
t3d8 obj2 = new t3d8();
obj2.validate(Pass,memId);
}
break;
default:
break;
}
}
}

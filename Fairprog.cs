using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

namespace TaskProdbcon
{
    class customer
    {
        SqlConnection con = new SqlConnection("data source = DESKTOP-DJ7CM1A ;database = dillidb;user id = sa;password = P@ssw0rd");
        public void New_login()
        {
            Console.WriteLine("Enter your Name : ");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter your Gender(M/F) : ");
            string Gen = Console.ReadLine();
            Console.WriteLine("Enter your DoB : ");
            string DoB = Console.ReadLine();
            Console.WriteLine("Enter your ContactNo : ");
            string Cont = Console.ReadLine();
            Console.WriteLine("Enter your EmailID : ");
            String Email = Console.ReadLine();
            Console.WriteLine("Enter your city : ");
            string City = Console.ReadLine();
            con.Open();
            SqlCommand Cmd = new SqlCommand("Insert into CustomerTable(Name,Gender,DoB,ContactNo,EmailID,City) values('" + Name + "','" + Gen + "','" + DoB + "','" + Cont + "','" + Email + "','" + City + "')", con);
            Cmd.ExecuteNonQuery();
            con.Close();
            Console.WriteLine("New user Login has been successfully created!!!");
        }
    }
    class product
    {
        SqlConnection con = new SqlConnection("data source = DESKTOP-DJ7CM1A ;database = dillidb;integrated security = true");
        public void prodList()
        {
            con.Open();
            SqlCommand Cmd = new SqlCommand("select * from ProductTable", con);
            SqlDataReader dr = Cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine("ProdID : " + dr[0] + " Name : " + dr[1] + " Price : " + dr[2] + " MFD : " + dr[3] + " ExpDate : " + dr[4]);
            }
            con.Close();
        }
        public int Billing(int quant, int prodID)
        {
            int prod = prodID;
            con.Open();
            switch (prod)
            {
                case 1:
                    int Quantity = quant;
                    Console.WriteLine("You've selected "+quant+" packs of MilkBikies ");
                    SqlCommand cmd1 = new SqlCommand("select Price* " + Quantity + " from ProductTable where ProdId = " + prod + "", con);
                    SqlDataReader dr1 = cmd1.ExecuteReader();
                    while (dr1.Read())
                    {
                        int Total1 = Convert.ToInt32(dr1[0]);
                        Console.WriteLine(" Total Amount " + Total1);
                        return Total1;
                    }
                    break;
                case 2:
                    int Quantity2 = quant;
                    Console.WriteLine("You've selected "+quant+" sachets of sunrise Coffee powder");
                    SqlCommand cmd2 = new SqlCommand("select Price* " + Quantity2 + " from ProductTable where ProdId = " + prod + "", con);
                    SqlDataReader dr2 = cmd2.ExecuteReader();
                    while (dr2.Read())
                    {
                        int Total2 = Convert.ToInt32(dr2[0]);
                        Console.WriteLine(" Total Amount " + Total2);
                        return Total2;
                    }
                    break;
                case 3:
                    int Quantity3 = quant;
                    Console.WriteLine("You've selected "+quant+" packets of AAVIN Milk 500ML ");
                    SqlCommand cmd3 = new SqlCommand("select Price* " + Quantity3 + " from ProductTable where ProdId = " + prod + "", con);
                    SqlDataReader dr3 = cmd3.ExecuteReader();
                    while (dr3.Read())
                    {
                        int Total3 = Convert.ToInt32(dr3[0]);
                        Console.WriteLine(" Total Amount " + Total3);
                        return Total3;
                    }
                    break;
                case 4:
                    int Quantity4 = quant;
                    Console.WriteLine("You've selected "+quant+" pack of Marie gold biscuits");
                    SqlCommand cmd4 = new SqlCommand("select Price* " + Quantity4 + " from ProductTable where ProdId = " + prod + "", con);
                    SqlDataReader dr4 = cmd4.ExecuteReader();
                    while (dr4.Read())
                    {
                        int Total4 = Convert.ToInt32(dr4[0]);
                        Console.WriteLine(" Total Amount " + Total4);
                        return Total4;
                    }
                    break;
                case 5:
                    int Quantity5 = quant;
                    Console.WriteLine("You've selected "+quant+" kg of sugar");
                    SqlCommand cmd5 = new SqlCommand("select Price* " + Quantity5 + " from ProductTable where ProdId = " + prod + "", con);
                    SqlDataReader dr5 = cmd5.ExecuteReader();
                    while (dr5.Read())
                    {
                        int Total5 = Convert.ToInt32(dr5[0]);
                        Console.WriteLine(" Total Amount " + Total5);
                        return Total5;
                    }
                    break;
                case 6:
                    int Quantity6 = quant;
                    Console.WriteLine("You've selected "+quant+" packcets of LAYS");
                    SqlCommand cmd6 = new SqlCommand("select Price* " + Quantity6 + " from ProductTable where ProdId = " + prod + "", con);
                    SqlDataReader dr6 = cmd6.ExecuteReader();
                    while (dr6.Read())
                    {
                        int Total6 = Convert.ToInt32(dr6[0]);
                        Console.WriteLine(" Total Amount " + Total6);
                        return Total6;
                    }
                    break;
                default:
                    {
                        Console.WriteLine("Invalid Product ID");
                        return 0;
                    }
            }
            con.Close();
            return 0;
        }
    }
    class validation
    {
        bool result;
        public bool check(int custId)
        {
            SqlConnection con = new SqlConnection("data source = DESKTOP-DJ7CM1A ;database = dillidb;integrated security = true");
            con.Open();
            SqlCommand cmd = new SqlCommand("select CustID from CustomerTable where CustID = " + custId, con);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                int valid = Convert.ToInt32(dr[0]);
                if (custId == valid)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            con.Close();
            return result;
        }
    }
    class Fairprog
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your Customer ID : ");
            int CustId = Convert.ToInt32(Console.ReadLine());
            validation val = new validation();
            if (val.check(CustId))
            {
                product obj = new product();
                obj.prodList();
                Console.WriteLine("Enter the ProductId you want to purchase:");
                int prodID = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Quantity");
                int quant = Convert.ToInt32(Console.ReadLine());
                int Tot = obj.Billing(quant, prodID);
                SqlConnection con = new SqlConnection("data source = DESKTOP-DJ7CM1A ;database = dillidb;integrated security = true");
                con.Open();
                SqlCommand Cmd = new SqlCommand("Insert into Purchase(CustID,ProdID,Quantity,Total_Amount) values('" + CustId + "','" + prodID + "','" + quant + "','" + Tot + "')", con);
                Cmd.ExecuteNonQuery();
                con.Close();
            }
            else
            {
                Console.WriteLine("Enter y to retry and a valid customerId or n to create new user login");
                string option = Console.ReadLine();
                if (option == "n")
                {
                    customer obj1 = new customer();
                    obj1.New_login();
                    Console.WriteLine("DO YOU WANT TO CONTINUE WITH SHOPPING (y/n) ?");
                    string conti = Console.ReadLine();
                    while (conti == "y")
                    {
                        product obj = new product();
                        obj.prodList();
                        Console.WriteLine("Enter the ProductId you want to purchase:");
                        int prodID = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the Quantity");
                        int quant = Convert.ToInt32(Console.ReadLine());
                        int Tot = obj.Billing(quant, prodID);
                        SqlConnection con = new SqlConnection("data source = DESKTOP-DJ7CM1A ;database = dillidb;integrated security = true");
                        con.Open();
                        SqlCommand Cmd = new SqlCommand("Insert into Purchase(CustID,ProdID,Quantity,Total_Amount) values('" + CustId + "','" + prodID + "','" + quant + "','" + Tot + "')", con);
                        Cmd.ExecuteNonQuery();
                        con.Close();

                    }
                }
                else if (option == "y")
                {
                    Console.WriteLine("Enter your Customer ID : ");
                    int CustId2 = Convert.ToInt32(Console.ReadLine());
                    validation val2 = new validation();
                    if (val.check(CustId2))
                    {
                        product obj = new product();
                        obj.prodList();
                        Console.WriteLine("Enter the ProductId you want to purchase:");
                        int prodID = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the Quantity");
                        int quant = Convert.ToInt32(Console.ReadLine());
                        int Tot = obj.Billing(quant, prodID);
                        SqlConnection con = new SqlConnection("data source = DESKTOP-DJ7CM1A ;database = dillidb;integrated security = true");
                        con.Open();
                        SqlCommand Cmd = new SqlCommand("Insert into Purchase(CustID,ProdID,Quantity,Total_Amount) values('" + CustId + "','" + prodID + "','" + quant + "','" + Tot + "')", con);
                        Cmd.ExecuteNonQuery();
                        con.Close();


                    }
                }
            }
            Console.WriteLine("Enter the CustomerID To display the Purchase details");
            int CusId = Convert.ToInt32(Console.ReadLine());
            SqlConnection con1 = new SqlConnection("data source = DESKTOP-DJ7CM1A ;database = dillidb;integrated security = true");
            con1.Open();
            SqlCommand Cmd1 = new SqlCommand("select * from Purchase where CustID =" + CusId + "", con1);
            SqlDataReader dr = Cmd1.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine("BillNo : " + dr[0] + " CustId : " + dr[1] + " ProductId : " + dr[2] + " Quantity : " + dr[3] + " Total_Amount : " + dr[4] + " Date : " + dr[5]);
            }
            con1.Close();
            Console.WriteLine("Enter the date to display the purchase details by Date : ");
            var date1 = Convert.ToString(Console.ReadLine());
            
            SqlConnection con2 = new SqlConnection("data source = DESKTOP-DJ7CM1A ;database = dillidb;integrated security = true");
            con2.Open();
            SqlCommand Cmd2 = new SqlCommand("select * from Purchase where Date = '" + date1 + "'", con2);
            SqlDataReader dr2 = Cmd2.ExecuteReader();
            while (dr2.Read())
            {
                Console.WriteLine("BillNo : " + dr2[0] + " CustId : " + dr2[1] + " ProductId : " + dr2[2] + " Quantity : " + dr2[3] + " Total_Amount : " + dr2[4] + " Date : " + dr2[5]);
            }
            con2.Close();
        }
    }
}


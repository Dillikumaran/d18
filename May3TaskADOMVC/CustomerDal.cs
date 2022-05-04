using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using AdoMvcRam.Models;
using System.IO;
using Microsoft.AspNetCore.Mvc;

namespace AdoMvcRam.DalCustomer
{
    public class CustomerDal
    {
        public string Connect = "";

        public CustomerDal()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
            Connect = builder.GetSection("ConnectionStrings:Conn").Value;
        }
        public List<CustomerList> Showcust()
        {
            List<CustomerList> listCustomer = new List<CustomerList>();
            using (SqlConnection con = new SqlConnection(Connect))
            {
                using (SqlCommand cmd = new SqlCommand("Showcust", con))
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    IDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        listCustomer.Add(new CustomerList()
                        {
                            CustomerId = int.Parse(reader["CustId"].ToString()),
                            CustomerName = reader["CustomerName"].ToString(),
                            EmailId = reader["EmailId"].ToString(),
                            MobileNo = reader["Contact"].ToString()
                        });
                    }
                    con.Close();
                }
            }
            return listCustomer;
        }
        public int putdata(string CustName,string EmailId,string MobileNo)
        {
           //string CustomerName = c.CustomerName;
           //string EmailId = c.EmailId;
           //string MobileNo = c.MobileNo;

            using (SqlConnection con = new SqlConnection(Connect))
            {
                using (SqlCommand Cmd = new SqlCommand("Insdata '"+CustName+"','"+EmailId+"','"+MobileNo+"'", con))
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    int result = Cmd.ExecuteNonQuery();
                    con.Close();
                    return result;
                }
            }
        }
    }
}

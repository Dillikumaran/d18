using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DbConn
{
    class Day27Apr12tasks
    {
        SqlConnection con = new SqlConnection("data source = DESKTOP-DJ7CM1A ;database = dillidb;user id = sa;password = P@ssw0rd");
        public void InsQ()
        {
            Console.WriteLine("Enter studentName : ");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter ContactNo  : ");
            String Cont = Console.ReadLine();
            con.Open();
            SqlCommand Cmd = new SqlCommand("Insert into dbo.Tbl_EnrollmentTask(StudentName,ContactNo) values('" + Name + "','" + Cont + "')", con);
            Cmd.ExecuteNonQuery();
            con.Close();
        }
        public void UpdateQ()
        {
            Console.WriteLine("Enter student ID to be updated : ");
            int sId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Gender  : ");
            String Gen = Console.ReadLine();
            con.Open();
            SqlCommand Cmd = new SqlCommand("update Tbl_EnrollmentTask set Gender = '" + Gen + "' where studentId = " +sId+"", con);
            Cmd.ExecuteNonQuery();
            con.Close();
        }
        public void delQ()
        {
            Console.WriteLine("Enter student ID to be Deleted : ");
            int sId = Convert.ToInt32(Console.ReadLine());
            con.Open();
            SqlCommand Cmd = new SqlCommand("delete from Tbl_EnrollmentTask where studentId = "+sId+"", con);
            Cmd.ExecuteNonQuery();
            con.Close();
        }
        public void InsSp()
        {
            Console.WriteLine("Enter studentName : ");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter ContactNo  : ");
            String Cont = Console.ReadLine();
            SqlCommand cmd = new SqlCommand("sp_Inst", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@Contact", SqlDbType.VarChar).Value = Cont;
            cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = Name;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void UpdateSp()
        {
            Console.WriteLine("Enter student ID to be updated : ");
            int sId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Gender  : ");
            String Gen = Console.ReadLine();
            SqlCommand cmd = new SqlCommand("sp_Updt", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@sId", SqlDbType.Int).Value = sId;
            cmd.Parameters.Add("@Gen", SqlDbType.Char).Value = Gen;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void DelSp()
        {
            Console.WriteLine("Enter student ID to be Deleted : ");
            int sId = Convert.ToInt32(Console.ReadLine());
            SqlCommand cmd = new SqlCommand("sp_Delt", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@sId", SqlDbType.Int).Value = sId;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public static void Main()
        {
            Day27Apr12tasks obj = new Day27Apr12tasks();
            obj.InsQ();
            obj.UpdateQ();
            obj.delQ();
            obj.InsSp();
            obj.UpdateSp();
            obj.DelSp();
        }
    }
}

using System;
using System.Data.SqlClient;
using System.Data;

namespace ConsoleApp2
{
    internal class Program1
    {
        static void Main(string[] args)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=ANSHU\\SQLEXPRESS; initial catalog=school; integrated security=true");
                con.Open();
                SqlCommand com=con.CreateCommand();
                com.Connection = con;
                com.CommandText = "Insert into Courses values(@title,@credits,@code)";
                SqlParameter p2 = new SqlParameter("@title", SqlDbType.VarChar);
                SqlParameter p3 = new SqlParameter("@credits", SqlDbType.Int);
                SqlParameter p4 = new SqlParameter("@code", SqlDbType.NVarChar);
                string credits,title, code;
               title= Console.ReadLine();
               credits= Console.ReadLine();
                code=Console.ReadLine();
                
                p2.Value = title;
                p3.Value = credits;
                p4.Value = code;
                
                com.Parameters.Add(p2);
                com.Parameters.Add(p3);
                com.Parameters.Add(p4);
                com.ExecuteNonQuery();
                Console.WriteLine("Inserted");
                con.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

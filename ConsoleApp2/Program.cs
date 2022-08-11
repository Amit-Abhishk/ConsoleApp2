using System;
using System.Data.SqlClient;
using System.Data;
namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
      
        {
            try
            {   //step 1 connection
                SqlConnection con = new SqlConnection("Data Source=ANSHU\\SQLEXPRESS; initial catalog=school;integrated security=true");
                con.Open();
                Console.WriteLine("Hello World!");
               //step 2 command
                SqlCommand cmd = con.CreateCommand();
               //step 3 join connection with cmd
                cmd.Connection = con; //associate command
                cmd.CommandText = "select * from Courses";

                SqlDataReader dr = cmd.ExecuteReader();
             
             while (dr.Read())
                {
                    Console.WriteLine("CourseId :" + dr[0] + " Title :" + dr[1] + " Number Of Credits :" + dr[2] +" Course Code: " + dr[3]);

                }
                dr.Close(); con.Close();



            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }

            
        }
    }
}

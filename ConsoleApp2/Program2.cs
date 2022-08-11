/*using System;
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
                SqlCommand com = con.CreateCommand();
                com.Connection = con;
                com.CommandText = "Update Courses set CourseCode=@coursecode where Courseid=@id";

                com.ExecuteNonQuery();
                Console.WriteLine("updated");
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
*/
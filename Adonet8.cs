using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adonet
{
    class Adonet8
    {
        static SqlConnection con;

        public static void Main(string[] args)
        {
            try
            {

                // Creating Connection  
                con = new SqlConnection("data source=.; database=Bhuvan; integrated security=SSPI");
                // writing sql query  
                SqlCommand cm = new SqlCommand("update Dept  set department = 'HR'  where id = 103 ", con);
                // Opening Connection  
                con.Open();
                // Executing the SQL query  
                cm.ExecuteNonQuery();
                // Displaying a message  
                Console.WriteLine("Column updated Successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong.\n" + e);
            }
            // Closing the connection  
            finally
            {
                Console.ReadLine();
                con.Close();
            }
        }
    }
}

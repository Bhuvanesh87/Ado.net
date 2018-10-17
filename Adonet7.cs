using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adonet
{
    class Adonet7
    {
        static SqlConnection con;

        public static void Main(string[] args)
        {
            try
            {

                // Creating Connection  
                con = new SqlConnection("data source=.; database=Bhuvan; integrated security=SSPI");
                // writing sql query  
                SqlCommand cm = new SqlCommand("ALTER TABLE Dept ADD department  varchar(255)", con);
                // Opening Connection  
                con.Open();
                // Executing the SQL query  
                cm.ExecuteNonQuery();
                // Displaying a message  
                Console.WriteLine("Column inserted Successfully");
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

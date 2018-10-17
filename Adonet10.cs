using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adonet
{
    class Adonet10
    {
        static void Main(string[] args)
        {
            new Adonet10().CreateTable();
            Console.Read();
        }

        public void CreateTable()
        {
            SqlConnection con = null;
            try
            {
                // Creating Connection  
                con = new SqlConnection("data source=.; database=Bhuvan; integrated security=SSPI");
                // writing sql query  
                SqlCommand cm = new SqlCommand("SELECT * FROM student2 RIGHT OUTER JOIN Dept ON student2.id = Dept.id; ", con);
                // Opening Connection  
                con.Open();
                // Executing the SQL query  
                SqlDataReader sdr = cm.ExecuteReader();
                // Iterating Data  
                while (sdr.Read())
                {

                    Console.WriteLine(sdr["id"] + "       " + sdr["name"] + "              " + sdr["email"] + "            "+"          " + sdr["mobileno"] + "                " + sdr["department"]); // Displaying Record  
                }
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

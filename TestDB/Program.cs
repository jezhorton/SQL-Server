using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TestDB
{
    class Program
    {
        static void Main(string[] args)
        {

            string yes = String.Format("This is true {0}", "cake");
            using (SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=testDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")){
                con.Open();
                Console.WriteLine(con.State);
                SqlCommand insertCommand = new SqlCommand("INSERT INTO pls (name, id) VALUES ('S', '2')", con);
                SqlCommand selectCommand = new SqlCommand("SELECT * FROM pls", con);
                SqlCommand updateString = new SqlCommand("UPDATE pls SET name = 'John' WHERE id = '2'");
                SqlCommand deleteString = new SqlCommand("DELETE FROM ");
                insertCommand.ExecuteReader();
                //selectCommand.Read;
                con.Close();
            }

            Test test1 = new Test();
            test1.Type = "Dancing queen";

        }
    }
    class Test
    {
        string name = "", type = "", genre = "";

        public string Name { get => name; set => name = value; }
        public string Type { get => type; set => type = value; }
        public string Genre { get => genre; set => genre = value; }
    }
}

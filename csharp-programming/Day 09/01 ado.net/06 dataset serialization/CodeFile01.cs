using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Xml;
using System.IO;

namespace training_basic_csharp {
    class Program {
        static void Main(string[] args) {
            string connectionString = ConfigurationManager.ConnectionStrings["Biblio"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand authorCommand = connection.CreateCommand();
            authorCommand.CommandType = CommandType.Text;
            authorCommand.CommandText = "SELECT Au_ID, Author FROM Authors WHERE Au_ID < 10";

            DataSet biblioDataSet = new DataSet();
            SqlDataAdapter authorsAdapter = new SqlDataAdapter(authorCommand);
            authorsAdapter.Fill(biblioDataSet, "Authors");

            Console.WriteLine("Serializing Graph to XML Stream...");
            Stream s = File.Open("ds.xml", FileMode.Create, FileAccess.Write);
            biblioDataSet.WriteXml(s);
            s.Close();
            Console.WriteLine("Serialization Complete.");

            Console.WriteLine("Deserializing Graph from XML Stream...");
            Stream r = File.Open("ds.xml", FileMode.Open, FileAccess.Read);
            DataSet biblioDataSet2 = new DataSet();
            biblioDataSet2.ReadXml(r);
            r.Close();
            Console.WriteLine("Deserializing Complete...");

            Console.WriteLine("After deserialization BiblioDataSet2 contains {0} Authors.",
                biblioDataSet2.Tables["Authors"].Rows.Count);

            foreach (DataRow authorRow in biblioDataSet2.Tables["Authors"].Rows) {
                Console.WriteLine(authorRow["Au_ID"] + "\t" + authorRow["Author"]);
            }
        }
    }
}
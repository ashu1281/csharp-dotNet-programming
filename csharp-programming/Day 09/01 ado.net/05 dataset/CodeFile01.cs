using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

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
            foreach (DataRow theRow in biblioDataSet.Tables["Authors"].Rows) {
                Console.WriteLine(theRow["Au_ID"] + "\t" + theRow["Author"]);
            }
        }
    }
}
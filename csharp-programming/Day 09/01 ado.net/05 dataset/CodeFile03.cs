using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

// dataadapter with update
namespace training_basic_csharp {
    class Program {
        static void Main(string[] args) {
            string connectionString = ConfigurationManager.ConnectionStrings["Biblio"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand authorsCommand = connection.CreateCommand();
            authorsCommand.CommandType = CommandType.Text;
            authorsCommand.CommandText = "SELECT Au_ID, Author, 'Year Born' FROM Authors WHERE Au_ID < 10";

            DataSet biblioDataSet = new DataSet();
            SqlDataAdapter authorsAdapter = new SqlDataAdapter(authorsCommand);
            authorsAdapter.Fill(biblioDataSet, "Authors");

            SqlCommandBuilder authorCommandBuilder = new SqlCommandBuilder(authorsAdapter);
            Console.WriteLine("Author name before change: {0}", biblioDataSet.Tables["Authors"].Rows[0]["Author"]);
            biblioDataSet.Tables["Authors"].Rows[0]["Author"] = "Jacobb, Rusell";

            authorsAdapter.Update(biblioDataSet, "Authors");

            Console.WriteLine("Author name after change: {0}", biblioDataSet.Tables["Authors"].Rows[0]["Author"]);
        }
    }
}
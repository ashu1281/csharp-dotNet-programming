using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

// data adapter with parametric command 
namespace training_basic_csharp {
    class Program {
        static void Main(string[] args) {
            string connectionString = ConfigurationManager.ConnectionStrings["Biblio"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand authorsCommand = connection.CreateCommand();
            authorsCommand.CommandType = CommandType.Text;
            authorsCommand.CommandText = @"SELECT Au_ID, Author FROM Authors 
                                          WHERE Au_ID >= @from AND Au_ID < @to";
            SqlParameter fromParam = new SqlParameter("@from", 100);
            SqlParameter toParam = new SqlParameter("@to", 200);
            authorsCommand.Parameters.Add(fromParam);
            authorsCommand.Parameters.Add(toParam);

            DataSet biblioDataSet = new DataSet();//create empty data set
            SqlDataAdapter authorsAdapter = new SqlDataAdapter(authorsCommand);
            authorsAdapter.Fill(biblioDataSet, "Authors");

            foreach (DataRow theRow in biblioDataSet.Tables["Authors"].Rows) {
                Console.WriteLine(theRow["Au_ID"] + "\t" + theRow["Author"]);
            }
        }
    }
}
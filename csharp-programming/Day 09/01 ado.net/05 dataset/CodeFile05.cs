using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

// adding constraint
namespace training_basic_csharp {
    class Program {
        static void Main(string[] args) {
            string connectionString = ConfigurationManager.ConnectionStrings["Biblio"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand authorsCommand = connection.CreateCommand();
            authorsCommand.CommandType = CommandType.Text;
            authorsCommand.CommandText = "SELECT Au_ID, Author FROM Authors";

            DataSet biblioDataSet = new DataSet();
            SqlDataAdapter authorsAdapter = new SqlDataAdapter(authorsCommand);
            authorsAdapter.Fill(biblioDataSet, "Authors");

            SqlCommandBuilder authorCommandBuilder = new SqlCommandBuilder(authorsAdapter);

            biblioDataSet.Tables["Authors"].Constraints.Add(
                new UniqueConstraint(biblioDataSet.Tables["Authors"].Columns["Author"]));

            DataRow authorRow = biblioDataSet.Tables["Authors"].NewRow();
            authorRow["Au_ID"] = "17002";
            authorRow["Author"] = "Babage, Charls";

            try {
                biblioDataSet.Tables["Authors"].Rows.Add(authorRow);
                authorsAdapter.Update(biblioDataSet, "Authors");
            }
            catch (Exception e) {
            }

            Console.WriteLine("# rows after change: {0}", biblioDataSet.Tables["Authors"].Rows.Count);
        }
    }
}
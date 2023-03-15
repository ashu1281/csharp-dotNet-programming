using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

// delete row
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

            Console.WriteLine("# rows before change: {0}", biblioDataSet.Tables["Authors"].Rows.Count);

            DataColumn[] keys = new DataColumn[1];
            keys[0] = biblioDataSet.Tables["Authors"].Columns["Au_ID"];
            biblioDataSet.Tables["Authors"].PrimaryKey = keys;

            DataRow authorRow = biblioDataSet.Tables["Authors"].Rows.Find("17001");

            if (authorRow != null) {
                Console.WriteLine("Removing Author with Au_ID 17000");
                authorRow.Delete();
                authorsAdapter.Update(biblioDataSet, "Authors");
            }

            Console.WriteLine("# rows after change: {0}", biblioDataSet.Tables["Authors"].Rows.Count);
        }
    }
}
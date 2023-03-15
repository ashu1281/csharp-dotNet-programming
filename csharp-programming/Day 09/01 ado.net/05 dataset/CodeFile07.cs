using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

// traversing relation
namespace training_basic_csharp {
    class Program {
        static void Main(string[] args) {
            string connectionString = ConfigurationManager.ConnectionStrings["Biblio"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand publishersCommand = connection.CreateCommand();
            publishersCommand.CommandType = CommandType.Text;
            publishersCommand.CommandText = "SELECT * FROM Publishers WHERE PubID < 4";

            SqlCommand titlesCommand = connection.CreateCommand();
            titlesCommand.CommandType = CommandType.Text;
            titlesCommand.CommandText = "SELECT * FROM Titles WHERE PubID < 4";

            DataSet biblioDataSet = new DataSet();
            SqlDataAdapter publishersAdapter = new SqlDataAdapter(publishersCommand);
            SqlDataAdapter titlesAdapter = new SqlDataAdapter(titlesCommand);

            publishersAdapter.Fill(biblioDataSet, "Publishers");
            titlesAdapter.Fill(biblioDataSet, "Titles");

            DataRelation pubTitlesRel = biblioDataSet.Relations.Add("PubTitles",
                biblioDataSet.Tables["Publishers"].Columns["PubID"],
                biblioDataSet.Tables["Titles"].Columns["PubID"]);

            foreach (DataRow pubRow in biblioDataSet.Tables["Publishers"].Rows) {
                Console.WriteLine("PubID: " + pubRow["PubID"] + " Name: " + pubRow["Name"]);
                foreach (DataRow titleRow in pubRow.GetChildRows(pubTitlesRel)) {
                    Console.WriteLine("  Title: " + titleRow["Title"].ToString().PadRight(30).Substring(0, 30));
                }
            }
        }
    }
}
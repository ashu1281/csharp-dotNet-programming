using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace training_basic_csharp {
    class Program {
        static void Main(string[] args) {
            string connectionString = ConfigurationManager.ConnectionStrings["Biblio"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlTransaction transaction = connection.BeginTransaction();

            SqlCommand authorCommand = new SqlCommand();
            authorCommand.Connection = connection;
            authorCommand.CommandType = CommandType.Text;
            authorCommand.CommandText = "INSERT INTO Authors(Au_ID, Author, [Year Born]) Values(17000, \'Scott Meyers\', 1970)";
            authorCommand.Transaction = transaction;
            authorCommand.ExecuteNonQuery();

            transaction.Commit();//Transaction la commit karto
          //  transaction.Rollback();//rollback karto

            connection.Close();
        }
    }
}

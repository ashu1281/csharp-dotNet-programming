using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace csharp_programming
{
    class Program
    {
        public static void Main()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["Biblio"].ConnectionString;
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                SqlCommand authorCommand = connection.CreateCommand();
                authorCommand.CommandType = CommandType.StoredProcedure;
                authorCommand.CommandText = "AuthorDetails";
                SqlParameter authorId = new SqlParameter("@au_id", 1);
                authorCommand.Parameters.Add(authorId);

                SqlDataReader authorReader= authorCommand.ExecuteReader();

                if (authorReader.HasRows)
                {
                    authorReader.Read();
                    Console.WriteLine("\t{0}\t{1}", authorReader["Au_ID"], authorReader["Author"]);

                }
               

                authorReader.Close();
                connection.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
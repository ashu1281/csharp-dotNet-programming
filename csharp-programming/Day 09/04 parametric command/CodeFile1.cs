using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.Common;


//same as codefile02 but using Provider factory
namespace csharp_programming
{
    class Program
    {
        private static DbProviderFactory _providerFactory = SqlClientFactory.Instance;
        public static void Main(string[] args)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["Biblio"].ConnectionString;
                DbConnection connection = _providerFactory.CreateConnection();
                connection.ConnectionString = connectionString;
                connection.Open();

                DbCommand authorCommand = connection.CreateCommand();
                authorCommand.CommandType = CommandType.Text;
                authorCommand.CommandText = @"SELECT Au_ID, Author FROM Authors
                                               Where Au_ID >= @from AND Au_ID < @to";


                DbParameter fromParam = _providerFactory.CreateParameter();
                fromParam.ParameterName = "@from";
                fromParam.Value = 1;

                DbParameter toParam= _providerFactory.CreateParameter();
                toParam.ParameterName = "@to";
                toParam.Value = 10;


                authorCommand.Parameters.Add(fromParam);
                authorCommand.Parameters.Add(toParam);


                DbDataReader authorReader = authorCommand.ExecuteReader();

                while (authorReader.Read())
                {
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

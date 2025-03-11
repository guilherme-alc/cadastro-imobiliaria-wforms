using Microsoft.Data.SqlClient;

namespace CadastroImobiliaria.Database
{
    public class Conexao
    {
        public static SqlConnection ObterConexao()
        {
            string connectionString = @"";

            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                throw new Exception($"Falha ao conectar com o banco de dados {ex.Message}");
            }
            return connection;
        }
        public static void FecharConexao(SqlConnection connection)
        {
            connection.Close();
        }
    }
}

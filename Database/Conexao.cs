using System.Data;
using Microsoft.Data.SqlClient;

namespace CadastroImobiliaria.Database
{
    public class Conexao
    {
        private static readonly string connectionString = @"Server=;Database=imobiliaria;User Id=;Password=;Trust Server Certificate=True";
        public static SqlConnection ObterConexao()
        {

            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                return connection;
            }
            catch (SqlException ex)
            {
                throw new Exception("Erro ao conectar ao banco de dados. Verifique a conexão.", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro inesperado ao obter a conexão.", ex);
            }
        }
        public static void FecharConexao(SqlConnection connection)
        {
            try
            {
                if (connection != null && connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Erro ao fechar a conexão com o banco de dados.", ex);
            }
        }
    }
}

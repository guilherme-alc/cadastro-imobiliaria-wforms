using System.Data;
using Microsoft.Data.SqlClient;

namespace CadastroImobiliaria.Database
{
    public class Conexao
    {
        private static SqlConnection _connection;
        private static readonly string _connectionString = @"Server=;Database=;User Id=;Password=;TrustServerCertificate=;";
        private Conexao() { }
        public static SqlConnection ObterConexao()
        {
            if (_connection == null)
                _connection = new SqlConnection(_connectionString);

            if(_connection.State != ConnectionState.Open)
            {
                try
                {
                    _connection.Open();
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
            return _connection;
        }
        public static void FecharConexao()
        {
            try
            {
                if (_connection != null && _connection.State == ConnectionState.Open)
                {
                    _connection.Close();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Erro ao fechar a conexão com o banco de dados.", ex);
            }
        }
    }
}

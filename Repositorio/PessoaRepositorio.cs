using CadastroImobiliaria.Database;
using CadastroImobiliaria.Models;
using Microsoft.Data.SqlClient;
using System.Data;

namespace CadastroImobiliaria.Repositorio
{
    public class PessoaRepositorio
    {
        public static DataTable BuscarTodasPessoas()
        {
            DataTable dataTable = new DataTable();
            string query = @"SELECT 
                                [Id], [Nome], [Email], [Tipo], [Documento], 
                                [CEP], [Estado], [Cidade], [Bairro], 
                                [Logradouro], [Numero], [DataCadastro]
                        FROM [Pessoa]";
            try
            {
                using (SqlConnection connection = Conexao.ObterConexao())
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.Fill(dataTable);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Falha ao buscar pessoas: {ex.Message}");
            }
            return dataTable;
        }

        public static DataTable BuscarPessoa(string pesquisaUsuario)
        {
            DataTable dataTable = new DataTable();
            string query = @"SELECT 
                                [Id], [Nome], [Email], [Tipo], [Documento], 
                                [CEP], [Estado], [Cidade], [Bairro], 
                                [Logradouro], [Numero], [DataCadastro]
                            FROM [Pessoa]
                            WHERE [Nome] LIKE @PesquisaUsuario OR [Documento] LIKE @PesquisaUsuario";
            try
            {
                using(SqlConnection connection = Conexao.ObterConexao())
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.SelectCommand.Parameters.Add(new SqlParameter("@PesquisaUsuario", $"%{pesquisaUsuario}%"));
                    adapter.Fill(dataTable);
                }
            }
            catch (Exception ex) 
            {
                throw new Exception($"Falha ao buscar pessoa: {ex.Message}");
            }
            return dataTable;
        }

        public static bool AdicionarPessoa(Pessoa pessoa)
        {
            string query = @"INSERT INTO [Pessoa]
                    ([Id], [Nome], [Email], [Tipo], [Documento], [Telefone], [CEP], [Estado], [Cidade], [Bairro], [Logradouro], [Numero], [DataCadastro])
                VALUES 
                    (@Id, @Nome, @Email, @Tipo, @Documento, @Telefone, @CEP, @Estado, @Cidade, @Bairro, @Logradouro, @Numero, @DataCadastro)";
            int linhasAfetadas;
            try
            {
                using (SqlConnection connection = Conexao.ObterConexao())
                {
                    using(SqlCommand comando = new SqlCommand(query, connection))
                    {
                        comando.Parameters.AddWithValue("@Id", pessoa.Id);
                        comando.Parameters.AddWithValue("@Nome", pessoa.Nome);
                        comando.Parameters.AddWithValue("@Email", pessoa.Email);
                        comando.Parameters.AddWithValue("@Tipo", pessoa.Tipo);
                        comando.Parameters.AddWithValue("@Documento", pessoa.Documento);
                        comando.Parameters.AddWithValue("@Telefone", pessoa.Telefone);
                        comando.Parameters.AddWithValue("@CEP", pessoa.CEP);
                        comando.Parameters.AddWithValue("@Estado", pessoa.Estado);
                        comando.Parameters.AddWithValue("@Cidade", pessoa.Cidade);
                        comando.Parameters.AddWithValue("@Bairro", pessoa.Bairro);
                        comando.Parameters.AddWithValue("@Logradouro", pessoa.Logradouro);
                        comando.Parameters.AddWithValue("@Numero", pessoa.Numero);
                        comando.Parameters.AddWithValue("@DataCadastro", pessoa.DataCadastro);
                        linhasAfetadas = comando.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Falha ao inserir pessoas: {ex.Message}");
            }
            return linhasAfetadas > 0 ? true : false;
        }
    }
}

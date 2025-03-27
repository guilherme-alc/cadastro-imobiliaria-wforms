using CadastroImobiliaria.Database;
using CadastroImobiliaria.Models;
using Microsoft.Data.SqlClient;

namespace CadastroImobiliaria.Repositorio
{
    public class PessoaRepository
    {
        public static List<Pessoa> BuscarTodasPessoas()
        {
            List<Pessoa> listaPessoas = new();
            string query = @"SELECT 
                                [Id], [Nome], [Email], [Tipo], [Documento], 
                                [Telefone], [CEP], [Estado], [Cidade], [Bairro], 
                                [Logradouro], [Numero], [DataCadastro]
                            FROM [Pessoa]
                            ORDER BY [DataCadastro] DESC";

            try
            {
                using (SqlConnection connection = Conexao.ObterConexao())
                {
                    using SqlCommand comando = new SqlCommand(query, connection);
                    using SqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        listaPessoas.Add(new Pessoa
                        {
                            Id = reader.GetGuid(0),
                            Nome = reader.GetString(1),
                            Email = reader.GetString(2),
                            Tipo = reader.GetString(3)[0],
                            Documento = reader.GetString(4),
                            Telefone = reader.GetString(5),
                            CEP = reader.GetString(6),
                            Estado = reader.GetString(7),
                            Cidade = reader.GetString(8),
                            Bairro = reader.GetString(9),
                            Logradouro = reader.GetString(10),
                            Numero = reader.GetString(11),
                            DataCadastro = reader.GetDateTime(12)
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Falha ao carregar os cadastros:\n{ex.Message}");
            }
            return listaPessoas;
        }

        public static List<Pessoa> PesquisaRegistros(string pesquisaUsuario)
        {

            List<Pessoa> registroEncontrados = new();
            string query = @"SELECT 
                                [Id], [Nome], [Email], [Tipo], [Documento], 
                                [Telefone], [CEP], [Estado], [Cidade], [Bairro], 
                                [Logradouro], [Numero], [DataCadastro]
                            FROM [Pessoa]
                            WHERE CONCAT([Nome], [Email], [Telefone], [Tipo], [Documento], [CEP], [Estado], [Cidade], [Bairro], [Logradouro], [Numero], [DataCadastro]) LIKE '%' + @pesquisa + '%'";
            try
            {
                using SqlConnection connection = Conexao.ObterConexao();
                using SqlCommand comando = new(query, connection);
                comando.Parameters.AddWithValue("@pesquisa", pesquisaUsuario);

                using SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    registroEncontrados.Add(new Pessoa
                    {
                        Id = reader.GetGuid(0),
                        Nome = reader.GetString(1),
                        Email = reader.GetString(2),
                        Tipo = reader.GetString(3)[0],
                        Documento = reader.GetString(4),
                        Telefone = reader.GetString(5),
                        CEP = reader.GetString(6),
                        Estado = reader.GetString(7),
                        Cidade = reader.GetString(8),
                        Bairro = reader.GetString(9),
                        Logradouro = reader.GetString(10),
                        Numero = reader.GetString(11),
                        DataCadastro = reader.GetDateTime(12)
                    });
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Falha ao buscar pessoa:\n{ex.Message}");
            }

            return registroEncontrados;
        }

        public static Pessoa BuscarPessoaPeloId(Guid id)
        {
            string query = @"SELECT [Id], [Nome], [Email], [Tipo], [Documento], 
                                [Telefone], [CEP], [Estado], [Cidade], [Bairro], 
                                [Logradouro], [Numero], [DataCadastro]
                            FROM [Pessoa]
                            WHERE [Id] = @Id";
            Pessoa pessoa = new Pessoa();
            try
            {
                using SqlConnection connection = Conexao.ObterConexao();
                using SqlCommand comando = new(query, connection);
                comando.Parameters.AddWithValue("@Id", id);
                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    if(reader.HasRows)
                    {
                        while(reader.Read())
                        {
                            pessoa.Id = reader.GetGuid(0);
                            pessoa.Nome = reader.GetString(1);
                            pessoa.Email = reader.GetString(2);
                            pessoa.Tipo = reader.GetString(3)[0];
                            pessoa.Documento = reader.GetString(4);
                            pessoa.Telefone = reader.GetString(5);
                            pessoa.CEP = reader.GetString(6);
                            pessoa.Estado = reader.GetString(7);
                            pessoa.Cidade = reader.GetString(8);
                            pessoa.Bairro = reader.GetString(9);
                            pessoa.Logradouro = reader.GetString(10);
                            pessoa.Numero = reader.GetString(11);
                            pessoa.DataCadastro = reader.GetDateTime(12);
                        }
                    } else
                    {
                        throw new Exception("Nenhum registro encontrado");
                    }
                }
                return pessoa;
            }
            catch (Exception ex)
            {
                throw new Exception($"Falha ao buscar pessoa:\n{ex.Message}");
            }
        }

        public static bool AdicionarPessoa(Pessoa pessoa)
        {
            string querySeExiste = "SELECT COUNT(*) FROM Pessoa WHERE Documento = @Documento";
            string query = @"INSERT INTO [Pessoa]
                    ([Id], [Nome], [Email], [Tipo], [Documento], [Telefone], [CEP], [Estado], [Cidade], [Bairro], [Logradouro], [Numero], [DataCadastro])
                VALUES 
                    (@Id, @Nome, @Email, @Tipo, @Documento, @Telefone, @CEP, @Estado, @Cidade, @Bairro, @Logradouro, @Numero, @DataCadastro)";

            int registroEncontrado;
            int linhasAfetadas;
           
            try
            {
                using (SqlConnection connection = Conexao.ObterConexao())
                {
                    using(SqlCommand SeExisteComando = new SqlCommand(querySeExiste, connection))
                    {
                        SeExisteComando.Parameters.AddWithValue("@Documento", pessoa.Documento);
                        registroEncontrado = (int) SeExisteComando.ExecuteScalar();
                    }

                    if (registroEncontrado > 0)
                    {
                        throw new Exception($"Já existe uma pessoa cadastrada com o documento {pessoa.Documento}");
                    }

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
                throw new Exception($"Falha ao inserir pessoa:\n{ex.Message}");
            }
            return linhasAfetadas > 0;
        }

        public static bool AlterarPessoa(PessoaDTO pessoaTemp)
        {
            var query = @"UPDATE 
	                        Pessoa 
                        SET [Nome] = @Nome, [Email] = @Email, [Tipo] = @Tipo, 
                            [Documento] = @Documento, [Telefone] = @Telefone, 
	                        [CEP] = @Cep, [Estado] = @Estado, [Cidade] = @Cidade, 
                            [Bairro] = @Bairro, [Logradouro] = @Logradouro, [Numero] = @Numero
                        WHERE [Id] = @Id;";

            int linhasAfetadas;

            try
            {
                using (SqlConnection connection = Conexao.ObterConexao())
                {
                    using(SqlCommand comando = new SqlCommand(query, connection))
                    {
                        comando.Parameters.AddWithValue("@Id", pessoaTemp.Id);
                        comando.Parameters.AddWithValue("@Nome", pessoaTemp.Nome);
                        comando.Parameters.AddWithValue("@Email", pessoaTemp.Email);
                        comando.Parameters.AddWithValue("@Tipo", pessoaTemp.Tipo);
                        comando.Parameters.AddWithValue("@Documento", pessoaTemp.Documento);
                        comando.Parameters.AddWithValue("@Telefone", pessoaTemp.Telefone);
                        comando.Parameters.AddWithValue("@CEP", pessoaTemp.CEP);
                        comando.Parameters.AddWithValue("@Estado", pessoaTemp.Estado);
                        comando.Parameters.AddWithValue("@Cidade", pessoaTemp.Cidade);
                        comando.Parameters.AddWithValue("@Bairro", pessoaTemp.Bairro);
                        comando.Parameters.AddWithValue("@Logradouro", pessoaTemp.Logradouro);
                        comando.Parameters.AddWithValue("@Numero", pessoaTemp.Numero);

                        linhasAfetadas = comando.ExecuteNonQuery();
                    }
                }
            } 
            catch (Exception ex)
            {
                throw new Exception($"Falha ao alterar pessoa:\n{ex.Message}");
            }
            return linhasAfetadas > 0;
        }

        public static bool ExcluirPessoa(Pessoa pessoa)
        {
            var query = @"DELETE FROM 
	                        Pessoa 
                        WHERE [Id] = @Id;";
            int linhasAfetadas;
            try
            {
                using (SqlConnection connection = Conexao.ObterConexao())
                {
                    using (SqlCommand comando = new SqlCommand(query, connection))
                    {
                        comando.Parameters.AddWithValue("@Id", pessoa.Id);
                        linhasAfetadas = comando.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Falha ao excluir pessoa:\n{ex.Message}");
            }
            return linhasAfetadas > 0;
        }
    }
}

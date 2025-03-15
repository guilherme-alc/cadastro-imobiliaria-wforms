using CadastroImobiliaria.Database;
using CadastroImobiliaria.Models;
using Microsoft.Data.SqlClient;
using System.Data;

namespace CadastroImobiliaria.Repositorio
{
    public class PessoaRepositorio
    {
        public static List<Pessoa> BuscarTodasPessoas()
        {
            List<Pessoa> listaPessoas = new List<Pessoa>();
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
                    SqlCommand comando = new SqlCommand(query, connection);

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Pessoa pessoa = new Pessoa
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
                            };
                            listaPessoas.Add(pessoa);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Falha ao buscar pessoas: {ex.Message}");
            }
            return listaPessoas;
        }

        public static List<Pessoa> BuscarPessoa(string pesquisaUsuario)
        {

            List<Pessoa> registroEncontrados = new List<Pessoa>();

            List<Pessoa> listaPessoas = BuscarTodasPessoas()
                .Where(p => p.Nome.Contains(pesquisaUsuario) || p.Documento.Contains(pesquisaUsuario))
                .ToList();

            if(listaPessoas == null)
                return new List<Pessoa>();

            foreach(var item in listaPessoas)
            {
                Pessoa pessoa = new Pessoa
                {
                    Id = item.Id,
                    Nome = item.Nome,
                    Email = item.Email,
                    Tipo = item.Tipo,
                    Documento = item.Documento,
                    Telefone = item.Telefone,
                    CEP = item.CEP,
                    Estado = item.Estado,
                    Cidade = item.Cidade,
                    Bairro = item.Bairro,
                    Logradouro = item.Logradouro,
                    Numero = item.Numero,
                    DataCadastro = item.DataCadastro,
                };
                registroEncontrados.Add(pessoa);
            }
            return registroEncontrados;
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

                    var existeDocumento = BuscarTodasPessoas().Where(p => p.Documento == pessoa.Documento).FirstOrDefault();

                    if (existeDocumento != null)
                    {
                        throw new Exception($"Já possui uma pessoa cadastrada com o documento {pessoa.Documento}");
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
                throw new Exception($"Falha ao inserir pessoa: {ex.Message}");
            }
            return linhasAfetadas > 0 ? true : false;
        }

        public static bool AlterarPessoa(Guid id, PessoaDTO pessoaTemp)
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
                Pessoa pessoa = BuscarTodasPessoas().Where(p => p.Id == id).FirstOrDefault();

                pessoa.Nome = pessoaTemp.Nome;
                pessoa.Email = pessoaTemp.Email;
                pessoa.Tipo = pessoaTemp.Tipo;
                pessoa.Documento = pessoaTemp.Documento;
                pessoa.Telefone = pessoaTemp.Telefone;
                pessoa.CEP = pessoaTemp.CEP;
                pessoa.Estado = pessoaTemp.Estado;
                pessoa.Cidade = pessoaTemp.Cidade;
                pessoa.Bairro = pessoaTemp.Bairro;
                pessoa.Logradouro = pessoaTemp.Logradouro;
                pessoa.Numero = pessoaTemp.Numero;

                using (SqlConnection connection = Conexao.ObterConexao())
                {
                    using(SqlCommand comando = new SqlCommand(query, connection))
                    {
                        comando.Parameters.AddWithValue("@Id", id);
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
                        linhasAfetadas = comando.ExecuteNonQuery();
                    }
                }
            } 
            catch (Exception ex)
            {
                throw new Exception($"Falha ao alterar pessoa: {ex.Message}");
            }
            return linhasAfetadas > 0 ? true : false;
        }

        public static bool ExcluirPessoa(Guid id)
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
                        comando.Parameters.AddWithValue("@Id", id);
                        linhasAfetadas = comando.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Falha ao alterar pessoa: {ex.Message}");
            }
            return linhasAfetadas > 0 ? true : false;
        }
    }
}

using CadastroImobiliaria.Models;
using CadastroImobiliaria.Repositorio;
using System.ComponentModel.DataAnnotations;

namespace CadastroImobiliaria.Negocio
{
    public static class PessoaService
    {
        private static List<string> ValidarInformacoes(PessoaDTO pessoaDTO)
        {
            var erros = new List<string>();

            var resultadosValidacao = new List<ValidationResult>();
            var contexto = new ValidationContext(pessoaDTO, null, null);

            var cadastroValido = Validator.TryValidateObject(pessoaDTO, contexto, resultadosValidacao, true);

            if (!cadastroValido)
            {
                foreach (var erro in resultadosValidacao)
                    erros.Add(erro.ErrorMessage);
            }

            if (pessoaDTO.Tipo == 'F')
            {
                var cpfValido = ValidarDocumento.ValidarCPF(pessoaDTO.Documento);
                if (!cpfValido)
                    erros.Add("CPF inválido");
            }
            else if (pessoaDTO.Tipo == 'J')
            {
                var cnpjValido = ValidarDocumento.ValidarCNPJ(pessoaDTO.Documento);
                if (!cnpjValido)
                    erros.Add("CNPJ inválido");
            }
            else
                erros.Add("O Tipo é obrigatório.");

            return erros;
        }
        public static List<string> SalvarPessoa(PessoaDTO pessoaDTO)
        {
            try
            {
                var erros = ValidarInformacoes(pessoaDTO);

                if (erros.Count == 0)
                {
                    var pessoa = new Pessoa
                    {
                        Id = Guid.NewGuid(),
                        Nome = pessoaDTO.Nome,
                        Email = pessoaDTO.Email,
                        Tipo = pessoaDTO.Tipo,
                        Documento = pessoaDTO.Documento,
                        Telefone = pessoaDTO.Telefone,
                        CEP = pessoaDTO.CEP.Replace("-", ""),
                        Estado = pessoaDTO.Estado,
                        Cidade = pessoaDTO.Cidade,
                        Bairro = pessoaDTO.Bairro,
                        Logradouro = pessoaDTO.Logradouro,
                        Numero = pessoaDTO.Numero,
                        DataCadastro = DateTime.Now
                    };

                    var salvaCadastro = PessoaRepository.AdicionarPessoa(pessoa);
                    if (!salvaCadastro)
                        erros.Add("Nenhum cadastro foi realizado.");
                }

                return erros;
            }
            catch (InvalidOperationException ex)
            {
                throw new InvalidOperationException("Não foi possível realizar o cadastro. Já existe uma pessoa cadastrada com esse documento.");
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível realizar o cadastro. Revise os dados e verifique se o banco está em execução.");
            }
        }

        public static List<string> AtualizarPessoa(PessoaDTO pessoaDTO)
        {
            try
            {
                var erros = ValidarInformacoes(pessoaDTO);

                if (erros.Count == 0)
                {
                    var pessoa = new Pessoa
                    {
                        Id = pessoaDTO.Id,
                        Nome = pessoaDTO.Nome,
                        Email = pessoaDTO.Email,
                        Tipo = pessoaDTO.Tipo,
                        Documento = pessoaDTO.Documento,
                        Telefone = pessoaDTO.Telefone,
                        CEP = pessoaDTO.CEP.Replace("-", ""),
                        Estado = pessoaDTO.Estado,
                        Cidade = pessoaDTO.Cidade,
                        Bairro = pessoaDTO.Bairro,
                        Logradouro = pessoaDTO.Logradouro,
                        Numero = pessoaDTO.Numero,
                        DataCadastro = DateTime.Now
                    };

                    var salvaCadastro = PessoaRepository.AtualizarPessoa(pessoa);
                    if (!salvaCadastro)
                        erros.Add("Nenhum cadastro foi atualizado.");
                }

                return erros;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível atualizar o cadastro. Revise os dados e verifique se o banco está em execução.");
            }
        }

        public static bool ExcluirPessoa(Guid guid)
        {
            try
            {
                var pessoa = PessoaRepository.BuscarPessoaPeloId(guid);
                var sucesso = PessoaRepository.ExcluirPessoa(pessoa);
                return sucesso;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível excluir o cadastro. Verifique se o banco de dados está em execução.");
            }
        }

        public static List<Pessoa> ObtemTodosRegistros()
        {
            try
            {
                var pessoas = PessoaRepository.BuscarTodasPessoas();
                return pessoas;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível carregar as pessoas cadastradas. Verifique se o servidor está em execução.");
            } 
        }

        public static List<Pessoa> ObtemRegistroPorPesquisa(string pesquisaUsuario)
        {
            try
            {
                pesquisaUsuario.Trim().ToUpper();
                if (!pesquisaUsuario.Contains("@"))
                {
                    pesquisaUsuario = pesquisaUsuario
                        .Replace(".", "")
                        .Replace("-", "");
                }
                return PessoaRepository.PesquisarRegistros(pesquisaUsuario);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível realizar a pesquisa. Verifique se o servidor está em execução.");
            }
        }
    }
}

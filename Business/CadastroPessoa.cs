using CadastroImobiliaria.Models;
using CadastroImobiliaria.Repositorio;
using System.ComponentModel.DataAnnotations;

namespace CadastroImobiliaria.Negocio
{
    public static class CadastroPessoa
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

        public static List<string> AtualizarPessoa(PessoaDTO pessoaDTO)
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

        public static bool ExcluirPessoa(Guid guid)
        {
            var pessoa = PessoaRepository.BuscarPessoaPeloId(guid);
            var sucesso = PessoaRepository.ExcluirPessoa(pessoa);
            return sucesso;
        }
    }
}

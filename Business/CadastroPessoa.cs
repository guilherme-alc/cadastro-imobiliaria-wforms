using CadastroImobiliaria.Models;
using CadastroImobiliaria.Repositorio;
using System.ComponentModel.DataAnnotations;

namespace CadastroImobiliaria.Negocio
{
    public static class CadastroPessoa
    {
        public static List<string> SalvarPessoa(PessoaDTO pessoaDto)
        {
            var erros = new List<string>();

            var resultadosValidacao = new List<ValidationResult>();
            var contexto = new ValidationContext(pessoaDto, null, null);

            var cadastroValido = Validator.TryValidateObject(pessoaDto, contexto, resultadosValidacao, true);

            if (!cadastroValido)
            {
                foreach (var erro in resultadosValidacao)
                {
                    erros.Add(erro.ErrorMessage);
                }
            }

            if (pessoaDto.Tipo == 'F')
            {
                var cpfValido = ValidaDocumento.ValidaCPF(pessoaDto.Documento);
                if (!cpfValido)
                {
                    erros.Add("CPF inválido");
                }
            } else if (pessoaDto.Tipo == 'J')
            {
                var cnpjValido = ValidaDocumento.ValidaCNPJ(pessoaDto.Documento);
                if (!cnpjValido)
                {
                    erros.Add("CNPJ inválido");
                }
            }
            else
            {
                erros.Add("O Tipo é obrigatório.");
            }

            if (erros.Count == 0)
            {
                var pessoa = new Pessoa
                {
                    Id = Guid.NewGuid(),
                    Nome = pessoaDto.Nome,
                    Email = pessoaDto.Email,
                    Tipo = pessoaDto.Tipo,
                    Documento = pessoaDto.Documento,
                    Telefone = pessoaDto.Telefone,
                    CEP = pessoaDto.CEP.Replace("-", ""),
                    Estado = pessoaDto.Estado,
                    Cidade = pessoaDto.Cidade,
                    Bairro = pessoaDto.Bairro,
                    Logradouro = pessoaDto.Logradouro,
                    Numero = pessoaDto.Numero,
                    DataCadastro = DateTime.Now
                };

                var salvaCadastro = PessoaRepository.AdicionarPessoa(pessoa);
                if (!salvaCadastro)
                    erros.Add("Nenhuma pessoa foi adicionada.");
            }

            return erros;
        }
    }
}

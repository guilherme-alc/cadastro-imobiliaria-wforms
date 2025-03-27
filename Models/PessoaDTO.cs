using System.ComponentModel.DataAnnotations;

namespace CadastroImobiliaria.Models
{
    public class PessoaDTO
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O Nome é obrigatório.")]
        [StringLength(180, MinimumLength = 3, ErrorMessage = "O nome deve ter entre 3 e 180 caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O E-mail é obrigatório.")]
        [EmailAddress(ErrorMessage = "O E-mail está inválido.")]
        public string Email { get; set; }

        public char Tipo { get; set; }

        [Required(ErrorMessage = "O Documento é obrigatório.")]
        public string Documento { get; set; }

        [Required(ErrorMessage = "O Telefone é obrigatório.")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "O CEP é obrigatório.")]
        [StringLength(8, MinimumLength = 8, ErrorMessage = "O CEP está incompleto.")]
        public string CEP { get; set; }

        [Required(ErrorMessage = "O Estado é obrigatório.")]
        public string Estado { get; set; }

        [Required(ErrorMessage = "A Cidade é obrigatória.")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "O Bairro é obrigatório.")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "O Logradouro é obrigatório.")]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "O Número é obrigatório.")]
        public string Numero { get; set; }
    }
}

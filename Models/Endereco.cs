using System.Text.Json.Serialization;

namespace CadastroImobiliaria.Models
{
    public class Endereco
    {
        [JsonPropertyName("cep")]
        public string CEP { get; set; }
        [JsonPropertyName("estado")]
        public string Estado { get; set; }
        [JsonPropertyName("localidade")]
        public string Cidade { get; set; }
        [JsonPropertyName("bairro")]
        public string Bairro { get; set; }
        [JsonPropertyName("logradouro")]
        public string Logradouro { get; set; }
        [JsonPropertyName("uf")]
        public string UF { get; set; }
        [JsonPropertyName("regiao")]
        public string Regiao { get; set; }
        [JsonPropertyName("ddd")]
        public string DDD { get; set; }
        [JsonPropertyName("erro")]
        public string Erro { get; set; }
    }
}

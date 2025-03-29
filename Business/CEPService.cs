using CadastroImobiliaria.Models;
using System.Text.Json;

namespace CadastroImobiliaria.Business
{
    public class CEPService
    {
        private static readonly HttpClient _client = new HttpClient();
        public async static Task<Endereco> BuscaEndereco(string cep)
        {
            if (string.IsNullOrWhiteSpace(cep) || cep.Length != 8)
                throw new ArgumentException("CEP inválido. Informe um CEP com 8 dígitos.");
            try
            {
                HttpResponseMessage response = await _client.GetAsync($"https://viacep.com.br/ws/{cep}/json/");
                response.EnsureSuccessStatusCode();

                string conteudo = await response.Content.ReadAsStringAsync();

                Endereco endereco = JsonSerializer.Deserialize<Endereco>(conteudo);

                if(endereco == null || !string.IsNullOrEmpty(endereco.Erro))
                    throw new ArgumentException("CEP não encontrado.");

                return endereco;    
            }
            catch (HttpRequestException)
            {
                throw new Exception("Erro ao buscar o CEP. Verifique sua conexão na internet.");
            }
            catch (ArgumentException ex)
            {
                throw new ArgumentException(ex.Message);
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro inesperado ao buscar o CEP.");
            }
        }
    }
}

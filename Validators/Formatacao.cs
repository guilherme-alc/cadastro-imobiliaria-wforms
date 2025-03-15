namespace CadastroImobiliaria.Validators
{
    public static class Formatacao
    {
        public static string formataDocumento(string documento)
        {
            string documentoFormatado = documento
                .Replace(".", "")
                .Replace(",", "")
                .Replace("-", "")
                .Replace("/", "")
                .Replace(" ", "");

            return documentoFormatado;
        }
        public static string formataCEP(string cep)
        {
            string cepFormatado = cep
                .Replace("-", "")
                .Replace(" ", "");

            return cepFormatado;
        }
    }
}

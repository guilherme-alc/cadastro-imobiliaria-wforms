namespace CadastroImobiliaria.Helpers
{
    public static class FormataHelper
    {
        public static string FormataDocumento(string documento)
        {
            string documentoFormatado = documento
                .Replace(".", "")
                .Replace(",", "")
                .Replace("-", "")
                .Replace("/", "")
                .Replace(" ", "");

            return documentoFormatado;
        }
        public static string FormataCEP(string cep)
        {
            string cepFormatado = cep
                .Replace("-", "")
                .Replace(" ", "");

            return cepFormatado;
        }
    }
}

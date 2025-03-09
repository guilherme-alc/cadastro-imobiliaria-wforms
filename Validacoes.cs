namespace CadastroImobiliaria
{
    public class Validacoes
    {
        public static void numeroInteiro(KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && e.KeyChar != (char) 8)
            {
                e.Handled = true;
            }
        }

        public static void CPF(string documento)
        {

        }

        public static void CNPJ(string documento)
        {

        }

        public static string validaCampoTexto(TextBox txt)
        {
            string erro;

            if (txt != null && string.IsNullOrWhiteSpace(txt.Text))
                erro = $"Preenchimento do campo obrigatório!";
            else
                erro = "";

            return erro;
        }
        public static string validaCampoTextoMascara(MaskedTextBox txt)
        {
            string erro;

            if (txt != null && string.IsNullOrWhiteSpace(txt.Text))
                erro = $"Preenchimento do campo obrigatório!";
            else if(!txt.MaskFull)
                erro = "Preenchimento incompleto!";
            else
                erro = "";

            return erro;
        }
    }
}

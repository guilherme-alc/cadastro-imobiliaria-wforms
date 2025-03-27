namespace CadastroImobiliaria.Helpers
{
    public class FormularioHelper
    {
        public static string CampoTexto(TextBox txt)
        {
            string erro;

            if (string.IsNullOrWhiteSpace(txt.Text))
                erro = $"Preenchimento do campo obrigatório!";
            else
                erro = "";

            return erro;
        }
        public static string CampoMascara(MaskedTextBox txt)
        {
            string erro;

            if (string.IsNullOrWhiteSpace(txt.Text))
                erro = $"Preenchimento do campo obrigatório!";
            else if (!txt.MaskFull)
                erro = "Preenchimento incompleto!";
            else
                erro = "";

            return erro;
        }
    }
}

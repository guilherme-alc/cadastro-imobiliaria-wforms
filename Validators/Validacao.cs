namespace CadastroImobiliaria.Validators
{
    public static class Validacao
    {
        public static void numeroInteiro(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
        public static bool CPF(string cpf)
        {
            cpf = cpf.Replace(",", "").Replace(".", "").Replace("-", "");

            // verifica se possui 11 digitos e se eles não são repetidos do primeiro caractere
            if (cpf.Length != 11 || cpf.All(c => c == cpf[0]))
                return false;

            int soma1 = 0;
            int peso1 = 10;
            for(int i = 0; i < 9; i++)
            {
                soma1 += int.Parse(cpf[i].ToString()) * peso1;
                peso1--;
            }

            int digito1 = 11 - (soma1 % 11);
            if (digito1 == 10 || digito1 == 11)
                digito1 = 0;

            int soma2 = 0;
            int peso2 = 11;
            for(int i = 0; i < 10; i++)
            {
                soma2 += int.Parse(cpf[i].ToString()) * peso2;
                peso2--;
            }

            int digito2 = 11 - (soma2 % 11);
            if (digito2 == 10 || digito2 == 11)
                digito2 = 0;

            // a conversão para string é necessária pois o char compara o valor número na tabela ASCII e não o caractere em específico

            var eValido = cpf[9].ToString() == digito1.ToString() && cpf[10].ToString() == digito2.ToString();
            return eValido;
        }

        public static bool CNPJ(string cnpj)
        {
            cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "");

            if (cnpj.Length != 14 || cnpj.All(c => c == cnpj[0]))
                return false;

            int soma1 = 0;
            int peso1 = 5;
            for (int i = 0; i < 12; i++)
            {
                soma1 += int.Parse(cnpj[i].ToString()) * peso1;
                peso1 = (peso1 == 2) ? 9 : peso1 - 1;
            }

            int digito1 = 11 - (soma1 % 11);
            if (digito1 == 10 || digito1 == 11)
                digito1 = 0;

            int soma2 = 0;
            int peso2 = 6;
            for (int i = 0; i < 13; i++)
            {
                soma2 += int.Parse(cnpj[i].ToString()) * peso2;
                peso2 = (peso2 == 2) ? 9 : peso2 - 1;

                int digito2 = 11 - (soma2 % 11);
                if (digito2 == 10 || digito2 == 11)
                    digito2 = 0;

                bool eValido = cnpj[12].ToString() == digito1.ToString() && cnpj[13].ToString() == digito2.ToString();

                return eValido;
            }
        }

        public static string CampoTexto(TextBox txt)
        {
            string erro;

            if (txt != null && string.IsNullOrWhiteSpace(txt.Text))
                erro = $"Preenchimento do campo obrigatório!";
            else
                erro = "";

            return erro;
        }
        public static string CampoTextoMascara(MaskedTextBox txt)
        {
            string erro;

            if (txt != null && string.IsNullOrWhiteSpace(txt.Text))
                erro = $"Preenchimento do campo obrigatório!";
            else if (!txt.MaskFull)
                erro = "Preenchimento incompleto!";
            else
                erro = "";

            return erro;
        }

        public static bool PreenchimentoCampo(TextBoxBase campo, string nomeCampo, ErrorProvider erro)
        {
            bool camposValidos = true;

            if (string.IsNullOrEmpty(campo.Text))
            {
                erro.SetError(campo, $"O campo {nomeCampo} é obrigatório.");
                camposValidos = false;
            }
            else
            {
                erro.SetError(campo, "");
            }

            return camposValidos;
        }
    }
}

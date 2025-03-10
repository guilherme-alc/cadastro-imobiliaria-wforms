using CadastroImobiliaria.Models;

namespace CadastroImobiliaria
{
    public partial class Cadastro : Form
    {
        private readonly Main _formPrincipal;
        public Cadastro(Main formPrincipal)
        {
            InitializeComponent();
            _formPrincipal = formPrincipal;
        }

        private void menuPrincipalToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            _formPrincipal.Show();
            this.Close();
        }

        private void textBox_Validated(object sender, EventArgs e)
        {
            var txt = (TextBox)sender;
            errorProvider1.SetError(txt, Validacoes.validaCampoTexto(txt));
        }

        private void maskedTextBox_Validated(object sender, EventArgs e)
        {
            var txt = (MaskedTextBox)sender;
            errorProvider1.SetError(txt, Validacoes.validaCampoTextoMascara(txt));
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacoes.numeroInteiro(e);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                bool camposPreenchidos = validarPreenchimento();
                if (!camposPreenchidos)
                {
                    MessageBox.Show("Preencha todos os campos obrigatórios.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var pessoa = new Pessoa
                {
                    Id = Guid.NewGuid(),
                    Nome = txtNome.Text.ToUpper().Trim(),
                    Email = txtEmail.Text.ToLower().Trim(),
                    Tipo = radFisica.Checked ? 'F' : 'J',
                    Documento = txtDocumento.Text
                    .Replace("-", "")
                    .Replace(".", "")
                    .Replace("/", "")
                    .Replace(" ", ""),
                    Telefone = mtxtTelefone.Text.Trim(),
                    CEP = mtxtCEP.Text.Trim(),
                    Estado = txtEstado.Text.Trim(),
                    Cidade = txtCidade.Text.Trim(),
                    Bairro = txtBairro.Text.Trim(),
                    Logradouro = txtLogradouro.Text.Trim(),
                    Numero = txtNumero.Text.Trim()
                };

                MessageBox.Show("Pessoa cadastrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Falha interna no servidor", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            _formPrincipal.Close();
        }

        private bool validarPreenchimento()
        {
            bool camposValidos = true;
            errorProvider1.Clear();

            if (string.IsNullOrEmpty(txtNome.Text))
            {
                errorProvider1.SetError(txtNome, "O campo Nome é obrigatório.");
                camposValidos = false;
            }

            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                errorProvider1.SetError(txtEmail, "O campo Email é obrigatório.");
                camposValidos = false;
            }

            if (!radFisica.Checked && !radJuridica.Checked)
            {
                camposValidos = false;
            }

            if (string.IsNullOrEmpty(txtDocumento.Text))
            {
                errorProvider1.SetError(txtDocumento, "O campo Documento é obrigatório.");
                camposValidos = false;
            }

            if (string.IsNullOrEmpty(mtxtCEP.Text))
            {
                errorProvider1.SetError(mtxtCEP, "O campo Nome é obrigatório.");
                camposValidos = false;
            }

            if (string.IsNullOrEmpty(txtEstado.Text))
            {
                errorProvider1.SetError(txtEstado, "O campo Estado é obrigatório.");
                camposValidos = false;
            }

            if (string.IsNullOrEmpty(txtCidade.Text))
            {
                errorProvider1.SetError(txtCidade, "O campo Cidade é obrigatório.");
                camposValidos = false;
            }

            if (string.IsNullOrEmpty(txtBairro.Text))
            {
                errorProvider1.SetError(txtBairro, "O campo Bairro é obrigatório.");
                camposValidos = false;
            }

            if (string.IsNullOrEmpty(txtLogradouro.Text))
            {
                errorProvider1.SetError(txtLogradouro, "O campo Logradouro é obrigatório.");
                camposValidos = false;
            }

            if (string.IsNullOrEmpty(txtNumero.Text))
            {
                errorProvider1.SetError(txtNumero, "O campo Número é obrigatório.");
                camposValidos = false;
            }

            return camposValidos;
        }
    }
}

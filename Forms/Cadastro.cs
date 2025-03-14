using CadastroImobiliaria.Models;
using CadastroImobiliaria.Repositorio;
using CadastroImobiliaria.Validators;

namespace CadastroImobiliaria
{
    public partial class Cadastro : Form
    {
        private readonly Principal _formPrincipal;
        public Cadastro(Principal formPrincipal)
        {
            InitializeComponent();
            _formPrincipal = formPrincipal;
        }

        private void textBox_Validated(object sender, EventArgs e)
        {
            var txt = (TextBox)sender;
            errorProvider1.SetError(txt, Validacao.CampoTexto(txt));
        }

        private void maskedTextBox_Validated(object sender, EventArgs e)
        {
            var txt = (MaskedTextBox)sender;
            errorProvider1.SetError(txt, Validacao.CampoTextoMascara(txt));
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                bool camposValidos;
                validarPreenchimento(out camposValidos);

                if (!camposValidos)
                {
                    MessageBox.Show("Preencha todos os campos obrigatórios.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (radFisica.Checked)
                {
                    if (!Validacao.CPF(mtxtDocumento.Text))
                    {
                        MessageBox.Show("CPF inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else if (radJuridica.Checked)
                {
                    if (!Validacao.CNPJ(mtxtDocumento.Text))
                    {
                        MessageBox.Show("CNPJ inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                if (!Validacao.Email(txtEmail.Text))
                {
                    MessageBox.Show("E-mail inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!Validacao.CEP(mtxtCEP.Text))
                {
                    MessageBox.Show("CEP inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var pessoa = new Pessoa
                {
                    Id = Guid.NewGuid(),
                    Nome = txtNome.Text.ToUpper().Trim(),
                    Email = txtEmail.Text.ToLower().Trim(),
                    Tipo = radFisica.Checked ? 'F' : 'J',
                    Documento = mtxtDocumento.Text
                        .Replace("-", "")
                        .Replace(",", "")
                        .Replace(".", "")
                        .Replace("/", "")
                        .Replace(" ", ""),
                    Telefone = mtxtTelefone.Text.Trim(),
                    CEP = mtxtCEP.Text.Trim().Replace("-", ""),
                    Estado = txtEstado.Text.Trim(),
                    Cidade = txtCidade.Text.Trim(),
                    Bairro = txtBairro.Text.Trim(),
                    Logradouro = txtLogradouro.Text.Trim(),
                    Numero = txtNumero.Text.Trim(),
                    DataCadastro = DateTime.Now
                };

                var sucesso = PessoaRepositorio.AdicionarPessoa(pessoa);

                if (!sucesso)
                {
                    MessageBox.Show("Nenhuma pessoa foi adicionada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show("Pessoa cadastrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Falha interna no servidor:\n {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool validarPreenchimento(out bool camposValidos)
        {
            errorProvider1.Clear();
            camposValidos = Validacao.PreenchimentoCampo(txtNome, lblNome.Text, errorProvider1) &&
                            Validacao.PreenchimentoCampo(mtxtTelefone, lblTelefone.Text, errorProvider1) &&
                            Validacao.PreenchimentoCampo(mtxtDocumento, lblDocumento.Text, errorProvider1) &&
                            Validacao.PreenchimentoCampo(txtEstado, lblEstado.Text, errorProvider1) &&
                            Validacao.PreenchimentoCampo(txtCidade, lblCidade.Text, errorProvider1) &&
                            Validacao.PreenchimentoCampo(txtBairro, lblBairro.Text, errorProvider1) &&
                            Validacao.PreenchimentoCampo(txtLogradouro, lblLogradouro.Text, errorProvider1) &&
                            Validacao.PreenchimentoCampo(txtNumero, lblNumero.Text, errorProvider1);

            return camposValidos;
        }

        private void radJuridica_CheckedChanged(object sender, EventArgs e)
        {
            mtxtDocumento.Text = "";
            mtxtDocumento.Mask = "00.000.000/0000-00";
        }

        private void radFisica_CheckedChanged(object sender, EventArgs e)
        {
            mtxtDocumento.Text = "";
            mtxtDocumento.Mask = "000.000.000-00";
        }

        private void menuPrincipalToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            _formPrincipal.Show();
            this.Close();
        }

        private void pessoasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form pessoas = new ListaPessoas(_formPrincipal);
            pessoas.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            _formPrincipal.Close();
        }

        private void btnLimparCampos_Click(object sender, EventArgs e)
        {
            txtNome.Text = string.Empty;
            txtEmail.Text = "";
            mtxtDocumento.Text = "";
            mtxtTelefone.Text = "";
            mtxtCEP.Text = "";
            txtEstado.Text = "";
            txtCidade.Text = "";
            txtBairro.Text = "";
            txtLogradouro.Text = "";
            txtNumero.Text = "";
            errorProvider1.Clear();
        }
    }
}

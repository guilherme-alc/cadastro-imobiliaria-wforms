using CadastroImobiliaria.Business;
using CadastroImobiliaria.Helpers;
using CadastroImobiliaria.Models;
using CadastroImobiliaria.Negocio;

namespace CadastroImobiliaria
{
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(TabulacaoEnter);
        }

        private void TabulacaoEnter(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
            }
        }

        private void CarregaFormularioCadastro(object sender, EventArgs e)
        {
            if (!radFisica.Checked && !radJuridica.Checked)
                mtxtDocumento.Enabled = false;
        }

        private void ValidaCamposTexto(object sender, EventArgs e)
        {
            var txt = (TextBox)sender;
            errorProvider.SetError(txt, FormularioHelper.CampoTexto(txt));
        }

        private void ValidaCamposMascara(object sender, EventArgs e)
        {
            var txt = (MaskedTextBox)sender;
            errorProvider.SetError(txt, FormularioHelper.CampoMascara(txt));
        }

        private void BotaoCadastrar(object sender, EventArgs e)
        {
            errorProvider.Clear();
            lblRadError.Visible = false;
            var tipo = 'N';
            if (radFisica.Checked)
                tipo = 'F';
            else if (radJuridica.Checked)
                tipo = 'J';
            try
            {
                var pessoaDto = new PessoaDTO
                {
                    Id = Guid.NewGuid(),
                    Nome = txtNome.Text.ToUpper().Trim(),
                    Email = txtEmail.Text.ToLower().Trim(),
                    Tipo = tipo,
                    Documento = FormataHelper.FormataDocumento(mtxtDocumento.Text),
                    Telefone = mtxtTelefone.Text.Trim(),
                    CEP = FormataHelper.FormataCEP(mtxtCEP.Text),
                    Estado = txtEstado.Text.Trim(),
                    Cidade = txtCidade.Text.Trim(),
                    Bairro = txtBairro.Text.Trim(),
                    Logradouro = txtLogradouro.Text.Trim(),
                    Numero = txtNumero.Text.Trim(),
                };

                var erros = PessoaService.SalvarPessoa(pessoaDto);

                if (erros.Any())
                {
                    foreach (var erro in erros)
                    {
                        if (erro.Contains("Nome"))
                            errorProvider.SetError(txtNome, erro);
                        else if (erro.Contains("E-mail"))
                            errorProvider.SetError(txtEmail, erro);
                        else if (erro.Contains("Tipo"))
                        {
                            lblRadError.Text = "Selecione uma opção.";
                            lblRadError.Visible = true;
                        }
                        else if (erro.Contains("Documento"))
                            errorProvider.SetError(mtxtDocumento, erro);
                        else if (erro.Contains("CPF"))
                            errorProvider.SetError(mtxtDocumento, erro);
                        else if (erro.Contains("CNPJ"))
                            errorProvider.SetError(mtxtDocumento, erro);
                        else if (erro.Contains("Telefone"))
                            errorProvider.SetError(mtxtTelefone, erro);
                        else if (erro.Contains("CEP"))
                            errorProvider.SetError(mtxtCEP, erro);
                        else if (erro.Contains("Estado"))
                            errorProvider.SetError(txtEstado, erro);
                        else if (erro.Contains("Cidade"))
                            errorProvider.SetError(txtCidade, erro);
                        else if (erro.Contains("Bairro"))
                            errorProvider.SetError(txtBairro, erro);
                        else if (erro.Contains("Logradouro"))
                            errorProvider.SetError(txtLogradouro, erro);
                        else if (erro.Contains("Número"))
                            errorProvider.SetError(txtNumero, erro);
                    }
                    MessageBox.Show("Não foi possível cadastrar pessoa. Verifique os dados preenchidos", "Informações inválidas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show("Pessoa cadastrada com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Erro ao cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void BuscaEndereco(object sender, EventArgs e)
        {
            try
            {
                string cep = FormataHelper.FormataCEP(mtxtCEP.Text);
                Endereco endereco = await CEPService.BuscaEndereco(cep);

                if (endereco == null)
                {
                    errorProvider.SetError(mtxtCEP, "CEP não encontrado.");
                    MessageBox.Show("Endereço não encontrado. Verifique o CEP informado.");
                    return;
                }

                txtEstado.Text = endereco.Estado;
                txtCidade.Text = endereco.Cidade;
                txtBairro.Text = endereco.Bairro;
                txtLogradouro.Text = endereco.Logradouro;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RadBtnJuridicaAlterado(object sender, EventArgs e)
        {
            lblRadError.Visible = false;
            mtxtDocumento.Enabled = true;
            mtxtDocumento.Text = "";
            mtxtDocumento.Mask = @"00\.000\.000/0000-00";
        }

        private void RadBtnFisicaAlterado(object sender, EventArgs e)
        {
            lblRadError.Visible = false;
            mtxtDocumento.Enabled = true;
            mtxtDocumento.Text = "";
            mtxtDocumento.Mask = @"000\.000\.000-00";
        }

        private void BotaoLimparCampos(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            lblRadError.Visible = false;
            txtNome.Text = string.Empty;
            txtEmail.Text = "";
            radFisica.Checked = false;
            radJuridica.Checked = false;
            mtxtDocumento.Text = "";
            mtxtTelefone.Text = "";
            mtxtCEP.Text = "";
            txtEstado.Text = "";
            txtCidade.Text = "";
            txtBairro.Text = "";
            txtLogradouro.Text = "";
            txtNumero.Text = "";
            errorProvider.Clear();
        }
    }
}

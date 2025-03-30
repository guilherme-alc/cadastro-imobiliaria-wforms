using CadastroImobiliaria.Business;
using CadastroImobiliaria.Helpers;
using CadastroImobiliaria.Models;
using CadastroImobiliaria.Negocio;

namespace CadastroImobiliaria
{
    public partial class FormRegistros : Form
    {
        public FormRegistros()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(TabulacaoEnter);
        }

        private void TabulacaoEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
            }
        }

        private void CarregaFormularioPessoas(object sender, EventArgs e)
        {
            Image iconLixeiraOriginal = Properties.Resources.lixeira_icon_removebg_preview;
            Image iconLixeiraRedimensionado = new Bitmap(iconLixeiraOriginal, new Size(20, 20));

            Image iconDisqueteOriginal = Properties.Resources.disquete_icon;
            Image iconDiqueteRedimensionado = new Bitmap(iconDisqueteOriginal, new Size(20, 20));
            btnExcluir.Image = iconLixeiraRedimensionado;
            btnSalvar.Image = iconDiqueteRedimensionado;
            try
            {
                dgvPessoas.DataSource = PessoaService.ObtemTodosRegistros();
                dgvPessoas.Columns["Id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Erro ao carregar registros", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void BotaoPesquisar(object sender, EventArgs e)
        {
            try
            {
                List<Pessoa> pessoas = PessoaService.ObtemRegistroPorPesquisa(txtPesquisa.Text);
                dgvPessoas.DataSource = pessoas;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Erro ao realizar pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void PreencheCampos(object sender, DataGridViewCellEventArgs e)
        {
            errorProvider.Clear();

            DataGridView dgv = (DataGridView)sender;
            DataGridViewRow row = dgv.Rows[e.RowIndex];
            var listaValores = row.Cells;
            lblGuid.Text = listaValores[0].Value.ToString();
            txtNome.Text = (string)listaValores[1].Value;
            txtEmail.Text = (string)listaValores[2].Value;
            var tipo = listaValores[3].Value.ToString()[0];
            if (tipo == 'F')
            {
                radFisica.Checked = true;
            }
            else
            {
                radJuridica.Checked = true;
            }
            mtxtDocumento.Text = (string)listaValores[4].Value;
            mtxtTelefone.Text = (string)listaValores[5].Value;
            mtxtCEP.Text = (string)listaValores[6].Value;
            txtEstado.Text = (string)listaValores[7].Value;
            txtCidade.Text = (string)listaValores[8].Value;
            txtBairro.Text = (string)listaValores[9].Value;
            txtLogradouro.Text = (string)listaValores[10].Value;
            txtNumero.Text = (string)listaValores[11].Value;
        }

        private void BotaoSalvar(object sender, EventArgs e)
        {
            errorProvider.Clear();
            try
            {
                PessoaDTO pessoaDto = new PessoaDTO
                {
                    Id = Guid.Parse(lblGuid.Text),
                    Nome = txtNome.Text.ToUpper(),
                    Email = txtEmail.Text,
                    Tipo = radFisica.Checked ? 'F' : 'J',
                    Documento = FormataHelper.FormataDocumento(mtxtDocumento.Text),
                    Telefone = mtxtTelefone.Text,
                    CEP = FormataHelper.FormataCEP(mtxtCEP.Text),
                    Estado = txtEstado.Text,
                    Cidade = txtCidade.Text,
                    Bairro = txtBairro.Text,
                    Logradouro = txtLogradouro.Text,
                    Numero = txtNumero.Text,
                };

                var erros = PessoaService.AtualizarPessoa(pessoaDto);

                if (erros.Any())
                {
                    foreach (var erro in erros)
                    {
                        if (erro.Contains("Nome"))
                            errorProvider.SetError(txtNome, erro);
                        else if (erro.Contains("E-mail"))
                            errorProvider.SetError(txtEmail, erro);
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
                    MessageBox.Show("Não foi possível salvar as informações. Verifique os dados preenchidos", "Informações inválidas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                MessageBox.Show("Cadastro alterado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
                dgvPessoas.DataSource = PessoaService.ObtemTodosRegistros();
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Não há pessoa para atualizar. Certifique-se de que um registro foi selecionado.", "Nenhum registro selecionado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Erro ao atualizar cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BotaoExcluir(object sender, EventArgs e)
        {
            try
            {
                Guid guid = Guid.Parse(lblGuid.Text);
                var sucesso = PessoaService.ExcluirPessoa(guid);

                if (!sucesso)
                {
                    MessageBox.Show("Nenhuma cadastro foi excluido.", "Erro ao excluir", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show("Cadastro excluido com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
                dgvPessoas.DataSource = PessoaService.ObtemTodosRegistros();
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Não há pessoa para excluir. Certifique-se de que um registro foi selecionado.", "Nenhum registro selecionado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void BotaoLimparCampos(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
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
            lblGuid.Text = "";
            errorProvider.Clear();
        }
    }
}

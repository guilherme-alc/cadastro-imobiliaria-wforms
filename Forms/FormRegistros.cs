using CadastroImobiliaria.Models;
using CadastroImobiliaria.Negocio;
using CadastroImobiliaria.Repositorio;
using CadastroImobiliaria.Helpers;

namespace CadastroImobiliaria
{
    public partial class FormRegistros : Form
    {
        public FormRegistros()
        {
            InitializeComponent();
        }

        private void CarregaFormularioPessoas(object sender, EventArgs e)
        {
            try
            {
                dgvPessoas.DataSource = PessoaRepository.BuscarTodasPessoas();
                dgvPessoas.Columns["Id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void BotaoPesquisar(object sender, EventArgs e)
        {
            try
            {
                string pesquisaUsuario = txtPesquisa.Text.Trim().ToUpper();
                if(!pesquisaUsuario.Contains("@"))
                {
                    pesquisaUsuario = pesquisaUsuario
                        .Replace(".", "")
                        .Replace("-", "");
                }              
 
                dgvPessoas.DataSource = PessoaRepository.PesquisaRegistros(pesquisaUsuario);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Falha interna no servidor\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void PreencheCampos(object sender, DataGridViewCellEventArgs e)
        {
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
            if (radFisica.Checked)
            {
                if (!ValidaDocumento.ValidaCPF(mtxtDocumento.Text))
                {
                    MessageBox.Show("CPF inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else if (radJuridica.Checked)
            {
                if (!ValidaDocumento.ValidaCNPJ(mtxtDocumento.Text))
                {
                    MessageBox.Show("CNPJ inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            try
            {
                PessoaDTO pessoaTemp = new PessoaDTO
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
                var sucesso = PessoaRepository.AlterarPessoa(pessoaTemp);

                if (!sucesso)
                {
                    MessageBox.Show("Nenhuma cadastro foi alterada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show("Cadastro alterado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
                dgvPessoas.DataSource = PessoaRepository.BuscarTodasPessoas();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Falha interna no servidor:\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BotaoExcluir(object sender, EventArgs e)
        {
            try
            {
                Guid guid = Guid.Parse(lblGuid.Text);
                var pessoa = PessoaRepository.BuscarPessoaPeloId(guid);
                var sucesso = PessoaRepository.ExcluirPessoa(pessoa);

                if (!sucesso)
                {
                    MessageBox.Show("Nenhuma cadastro foi excluido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show("Cadastro excluido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
                dgvPessoas.DataSource = PessoaRepository.BuscarTodasPessoas();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Falha interna no servidor:\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

using CadastroImobiliaria.Database;
using CadastroImobiliaria.Models;
using CadastroImobiliaria.Repositorio;
using CadastroImobiliaria.Validators;

namespace CadastroImobiliaria
{
    public partial class Pessoas : Form
    {
        private readonly Principal _formPrincipal;
        private readonly Cadastro _formCadastro;
        public Pessoas(Principal formPrincipal)
        {
            InitializeComponent();
            _formPrincipal = formPrincipal;
        }
        public Pessoas()
        {
            InitializeComponent();
        }

        private void ListaPessoas_Load(object sender, EventArgs e)
        {
            try
            {
                dgvPessoas.DataSource = PessoaRepositorio.BuscarTodasPessoas();
                dgvPessoas.Columns["Id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void menuPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _formPrincipal.Show();
            this.Close();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form cadastro = new Cadastro(_formPrincipal);
            cadastro.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Conexao.FecharConexao();
            _formPrincipal.Close();
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
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
 
                dgvPessoas.DataSource = PessoaRepositorio.PesquisaRegistros(pesquisaUsuario);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Falha interna no servidor\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void preencheCampos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
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
            try
            {
                PessoaDTO pessoaTemp = new PessoaDTO
                {
                    Id = Guid.Parse(lblGuid.Text),
                    Nome = txtNome.Text.ToUpper(),
                    Email = txtEmail.Text,
                    Tipo = radFisica.Checked ? 'F' : 'J',
                    Documento = Formatacao.formataDocumento(mtxtDocumento.Text),
                    Telefone = mtxtTelefone.Text,
                    CEP = Formatacao.formataCEP(mtxtCEP.Text),
                    Estado = txtEstado.Text,
                    Cidade = txtCidade.Text,
                    Bairro = txtBairro.Text,
                    Logradouro = txtLogradouro.Text,
                    Numero = txtNumero.Text,
                };
                var sucesso = PessoaRepositorio.AlterarPessoa(pessoaTemp);

                if (!sucesso)
                {
                    MessageBox.Show("Nenhuma cadastro foi alterada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show("Cadastro alterado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limparCampos();
                dgvPessoas.DataSource = PessoaRepositorio.BuscarTodasPessoas();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Falha interna no servidor:\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                Guid guid = Guid.Parse(lblGuid.Text);
                var pessoa = PessoaRepositorio.BuscarPessoaPeloId(guid);
                var sucesso = PessoaRepositorio.ExcluirPessoa(pessoa);

                if (!sucesso)
                {
                    MessageBox.Show("Nenhuma cadastro foi excluido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show("Cadastro excluido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limparCampos();
                dgvPessoas.DataSource = PessoaRepositorio.BuscarTodasPessoas();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Falha interna no servidor:\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimparCampos_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void limparCampos()
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
            errorProvider1.Clear();
        }
    }
}

using CadastroImobiliaria.Repositorio;

namespace CadastroImobiliaria
{
    public partial class ListaPessoas : Form
    {
        private readonly Principal _formPrincipal;
        private readonly Cadastro _formCadastro;
        public ListaPessoas(Principal formPrincipal)
        {
            InitializeComponent();
            _formPrincipal = formPrincipal;
        }
        public ListaPessoas()
        {
            InitializeComponent();
        }

        private void ListaPessoas_Load(object sender, EventArgs e)
        {
            try
            {
                dgvPessoas.DataSource = PessoaRepositorio.BuscarTodasPessoas();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Falha interna no servidor {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            try
            {
                string pesquisaUsuario = txtPesquisa.Text.Trim().ToUpper();
                string pesquisaFormatada = pesquisaUsuario
                    .Replace("-", "")
                    .Replace(".", "")
                    .Replace(",", "");
                dgvPessoas.DataSource = PessoaRepositorio.BuscarPessoa(pesquisaFormatada);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Falha interna no servidor {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            _formPrincipal.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

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
            errorProvider1.Clear();
        }
    }
}

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
    }
}

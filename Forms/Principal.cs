using CadastroImobiliaria.Database;
using Microsoft.Data.SqlClient;

namespace CadastroImobiliaria
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            try
            {
                using SqlConnection connection = Conexao.ObterConexao();
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Falha interna no servidor:\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Falha interna no servidor:\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form cadastro = new Cadastro(this);
            cadastro.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form listaPessoas = new Pessoas(this);
            listaPessoas.Show();
        }
    }
}

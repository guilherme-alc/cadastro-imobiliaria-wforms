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
            foreach (Control control in this.Controls)
            {
                if (control is MdiClient)
                {
                    control.BackColor = Color.WhiteSmoke;
                    break;
                }
            }
            try
            {
                SqlConnection connection = Conexao.ObterConexao();
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
            Conexao.FecharConexao();
            this.Close();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in MdiChildren)
            {
                if (form is Cadastro)
                {
                    form.Activate();
                    form.BringToFront();
                    picGroupLogo.SendToBack();
                    return;
                }
            }
            Form cadastro = new Cadastro(this);
            cadastro.MdiParent = this;
            cadastro.Show();
            cadastro.BringToFront();
            picGroupLogo.SendToBack();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in MdiChildren)
            {
                if (form is Pessoas)
                {
                    form.Activate();
                    form.BringToFront();
                    picGroupLogo.SendToBack();
                    return;
                }
            }
            Form pessoas = new Pessoas(this);
            pessoas.MdiParent = this;
            pessoas.Show();
            pessoas.BringToFront();
            picGroupLogo.SendToBack();
        }
    }
}

using CadastroImobiliaria.Database;
using Microsoft.Data.SqlClient;

namespace CadastroImobiliaria
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void CarregaFormularioPrincipal(object sender, EventArgs e)
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
                MessageBox.Show($"N�o foi poss�vel conectar ao servidor SQL. Qualquer adi��o ou altera��o de informa��es n�o ter� efeito.\n\nDescri��o: {ex.Message}", "Aten��o!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"N�o foi poss�vel conectar ao servidor SQL. Qualquer adi��o ou altera��o de informa��es n�o ter� efeito.\n\nDescri��o: {ex.Message}", "Aten��o!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void MenuItemSair(object sender, EventArgs e)
        {
            Conexao.FecharConexao();
            this.Close();
        }

        private void MenuItemCadastrar(object sender, EventArgs e)
        {
            foreach (Form form in MdiChildren)
            {
                if (form is FormCadastro)
                {
                    form.Activate();
                    form.BringToFront();
                    picGroupLogo.SendToBack();
                    return;
                }
            }
            Form cadastrar = new FormCadastro();
            cadastrar.MdiParent = this;
            cadastrar.Show();
            cadastrar.BringToFront();
            picGroupLogo.SendToBack();
        }

        private void MenuItemPessoas(object sender, EventArgs e)
        {
            foreach (Form form in MdiChildren)
            {
                if (form is FormRegistros)
                {
                    form.Activate();
                    form.BringToFront();
                    picGroupLogo.SendToBack();
                    return;
                }
            }
            Form registros = new FormRegistros();
            registros.MdiParent = this;
            registros.Show();
            registros.BringToFront();
            picGroupLogo.SendToBack();
        }
    }
}

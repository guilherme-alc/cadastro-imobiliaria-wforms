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
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
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

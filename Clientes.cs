namespace CadastroImobiliaria
{
    public partial class Clientes : Form
    {
        private readonly Main _formPrincipal;
        public Clientes(Main formPrincipal)
        {
            InitializeComponent();
            _formPrincipal = formPrincipal;
        }
        public Clientes()
        {
            InitializeComponent();
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
    }
}

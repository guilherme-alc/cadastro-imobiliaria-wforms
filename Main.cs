namespace CadastroImobiliaria
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
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
    }
}

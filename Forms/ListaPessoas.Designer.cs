namespace CadastroImobiliaria
{
    partial class ListaPessoas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaPessoas));
            menuStrip1 = new MenuStrip();
            menuPrincipalToolStripMenuItem = new ToolStripMenuItem();
            cadastroToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            dgvPessoas = new DataGridView();
            txtPesquisa = new TextBox();
            btnPesquisa = new Button();
            lblPesquisar = new Label();
            lblInstruPesquisa = new Label();
            btnSalvar = new Button();
            lblNome = new Label();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            lblEmail = new Label();
            lblDocumento = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            lblAlterarCadastro = new Label();
            lblCEP = new Label();
            mtxtCEP = new MaskedTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblLogradouro = new Label();
            lblNumero = new Label();
            mtxtDocumento = new MaskedTextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            btnExcluir = new Button();
            lblExcluir = new Label();
            lblTelefone = new Label();
            mtxtTelefone = new MaskedTextBox();
            btnLimparCampos = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPessoas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.SteelBlue;
            menuStrip1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuPrincipalToolStripMenuItem, cadastroToolStripMenuItem, sairToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(831, 25);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuPrincipalToolStripMenuItem
            // 
            menuPrincipalToolStripMenuItem.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            menuPrincipalToolStripMenuItem.ForeColor = SystemColors.Control;
            menuPrincipalToolStripMenuItem.Name = "menuPrincipalToolStripMenuItem";
            menuPrincipalToolStripMenuItem.Size = new Size(110, 21);
            menuPrincipalToolStripMenuItem.Text = "Menu Principal";
            menuPrincipalToolStripMenuItem.Click += menuPrincipalToolStripMenuItem_Click;
            // 
            // cadastroToolStripMenuItem
            // 
            cadastroToolStripMenuItem.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            cadastroToolStripMenuItem.ForeColor = SystemColors.Control;
            cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            cadastroToolStripMenuItem.Size = new Size(74, 21);
            cadastroToolStripMenuItem.Text = "Cadastro";
            cadastroToolStripMenuItem.Click += cadastroToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            sairToolStripMenuItem.ForeColor = SystemColors.Control;
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(42, 21);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // dgvPessoas
            // 
            dgvPessoas.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvPessoas.BackgroundColor = SystemColors.GradientActiveCaption;
            dgvPessoas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(155, 0, 70);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvPessoas.DefaultCellStyle = dataGridViewCellStyle1;
            dgvPessoas.Location = new Point(0, 123);
            dgvPessoas.Margin = new Padding(3, 2, 3, 2);
            dgvPessoas.MaximumSize = new Size(1239, 188);
            dgvPessoas.MinimumSize = new Size(796, 188);
            dgvPessoas.Name = "dgvPessoas";
            dgvPessoas.RowHeadersWidth = 51;
            dgvPessoas.Size = new Size(831, 188);
            dgvPessoas.TabIndex = 2;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Location = new Point(16, 91);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(243, 23);
            txtPesquisa.TabIndex = 0;
            // 
            // btnPesquisa
            // 
            btnPesquisa.BackColor = Color.FromArgb(155, 0, 70);
            btnPesquisa.FlatStyle = FlatStyle.Flat;
            btnPesquisa.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPesquisa.ForeColor = Color.White;
            btnPesquisa.Location = new Point(279, 87);
            btnPesquisa.Name = "btnPesquisa";
            btnPesquisa.Size = new Size(89, 31);
            btnPesquisa.TabIndex = 1;
            btnPesquisa.Text = "Pesquisar";
            btnPesquisa.UseVisualStyleBackColor = false;
            btnPesquisa.Click += btnPesquisa_Click;
            // 
            // lblPesquisar
            // 
            lblPesquisar.AutoSize = true;
            lblPesquisar.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPesquisar.ForeColor = Color.Black;
            lblPesquisar.Location = new Point(16, 37);
            lblPesquisar.Name = "lblPesquisar";
            lblPesquisar.Size = new Size(173, 25);
            lblPesquisar.TabIndex = 5;
            lblPesquisar.Text = "Pesquisar Cadastro";
            // 
            // lblInstruPesquisa
            // 
            lblInstruPesquisa.AutoSize = true;
            lblInstruPesquisa.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInstruPesquisa.ForeColor = SystemColors.ControlDarkDark;
            lblInstruPesquisa.Location = new Point(16, 73);
            lblInstruPesquisa.Name = "lblInstruPesquisa";
            lblInstruPesquisa.Size = new Size(228, 15);
            lblInstruPesquisa.TabIndex = 6;
            lblInstruPesquisa.Text = "Digite o nome ou documento (CPF/CNPJ)";
            // 
            // btnSalvar
            // 
            btnSalvar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalvar.BackColor = Color.FromArgb(155, 0, 70);
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Location = new Point(717, 554);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(102, 40);
            btnSalvar.TabIndex = 14;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblNome.Location = new Point(14, 354);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 8;
            lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(66, 350);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(180, 23);
            txtNome.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(66, 393);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(180, 23);
            txtEmail.TabIndex = 3;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblEmail.Location = new Point(14, 397);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(41, 15);
            lblEmail.TabIndex = 8;
            lblEmail.Text = "E-mail";
            // 
            // lblDocumento
            // 
            lblDocumento.AutoSize = true;
            lblDocumento.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblDocumento.Location = new Point(14, 476);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(71, 15);
            lblDocumento.TabIndex = 8;
            lblDocumento.Text = "Documento";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            radioButton1.Location = new Point(14, 434);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(93, 19);
            radioButton1.TabIndex = 4;
            radioButton1.TabStop = true;
            radioButton1.Text = "Pessoa Física";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            radioButton2.Location = new Point(141, 434);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(105, 19);
            radioButton2.TabIndex = 5;
            radioButton2.TabStop = true;
            radioButton2.Text = "Pessoa Jurídica";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // lblAlterarCadastro
            // 
            lblAlterarCadastro.AutoSize = true;
            lblAlterarCadastro.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAlterarCadastro.ForeColor = SystemColors.ControlText;
            lblAlterarCadastro.Location = new Point(14, 322);
            lblAlterarCadastro.Name = "lblAlterarCadastro";
            lblAlterarCadastro.Size = new Size(133, 21);
            lblAlterarCadastro.TabIndex = 13;
            lblAlterarCadastro.Text = "Alterar Cadastro";
            // 
            // lblCEP
            // 
            lblCEP.AutoSize = true;
            lblCEP.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblCEP.Location = new Point(298, 354);
            lblCEP.Name = "lblCEP";
            lblCEP.Size = new Size(27, 15);
            lblCEP.TabIndex = 8;
            lblCEP.Text = "CEP";
            // 
            // mtxtCEP
            // 
            mtxtCEP.Location = new Point(342, 350);
            mtxtCEP.Mask = "000000-000";
            mtxtCEP.Name = "mtxtCEP";
            mtxtCEP.Size = new Size(152, 23);
            mtxtCEP.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label1.Location = new Point(506, 354);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 8;
            label1.Text = "Estado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.Location = new Point(298, 397);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 8;
            label2.Text = "Cidade";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.Location = new Point(298, 436);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 8;
            label3.Text = "Bairro";
            // 
            // lblLogradouro
            // 
            lblLogradouro.AutoSize = true;
            lblLogradouro.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblLogradouro.Location = new Point(298, 476);
            lblLogradouro.Name = "lblLogradouro";
            lblLogradouro.Size = new Size(69, 15);
            lblLogradouro.TabIndex = 8;
            lblLogradouro.Text = "Logradouro";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblNumero.Location = new Point(506, 476);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(51, 15);
            lblNumero.TabIndex = 8;
            lblNumero.Text = "Número";
            // 
            // mtxtDocumento
            // 
            mtxtDocumento.Location = new Point(97, 472);
            mtxtDocumento.Mask = "000.000.000-00";
            mtxtDocumento.Name = "mtxtDocumento";
            mtxtDocumento.Size = new Size(149, 23);
            mtxtDocumento.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(342, 393);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(152, 23);
            textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(371, 472);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(123, 23);
            textBox2.TabIndex = 12;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(563, 472);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(80, 23);
            textBox3.TabIndex = 13;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(342, 432);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(152, 23);
            textBox4.TabIndex = 11;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(563, 350);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(80, 23);
            textBox5.TabIndex = 9;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // btnExcluir
            // 
            btnExcluir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExcluir.BackColor = SystemColors.ControlLight;
            btnExcluir.BackgroundImage = (Image)resources.GetObject("btnExcluir.BackgroundImage");
            btnExcluir.BackgroundImageLayout = ImageLayout.Stretch;
            btnExcluir.FlatStyle = FlatStyle.Flat;
            btnExcluir.ForeColor = SystemColors.ControlLight;
            btnExcluir.Image = (Image)resources.GetObject("btnExcluir.Image");
            btnExcluir.ImageAlign = ContentAlignment.TopCenter;
            btnExcluir.Location = new Point(777, 342);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(41, 36);
            btnExcluir.TabIndex = 15;
            btnExcluir.UseVisualStyleBackColor = false;
            // 
            // lblExcluir
            // 
            lblExcluir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblExcluir.AutoSize = true;
            lblExcluir.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExcluir.ForeColor = SystemColors.ControlDarkDark;
            lblExcluir.Location = new Point(727, 325);
            lblExcluir.Name = "lblExcluir";
            lblExcluir.Size = new Size(91, 15);
            lblExcluir.TabIndex = 19;
            lblExcluir.Text = "Excluir Cadastro";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblTelefone.Location = new Point(14, 519);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(52, 15);
            lblTelefone.TabIndex = 8;
            lblTelefone.Text = "Telefone";
            // 
            // mtxtTelefone
            // 
            mtxtTelefone.Location = new Point(97, 515);
            mtxtTelefone.Mask = "(00) 00000-0000";
            mtxtTelefone.Name = "mtxtTelefone";
            mtxtTelefone.Size = new Size(149, 23);
            mtxtTelefone.TabIndex = 7;
            // 
            // btnLimparCampos
            // 
            btnLimparCampos.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLimparCampos.BackColor = Color.FromArgb(160, 0, 0);
            btnLimparCampos.FlatStyle = FlatStyle.Flat;
            btnLimparCampos.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnLimparCampos.ForeColor = SystemColors.MenuBar;
            btnLimparCampos.ImeMode = ImeMode.NoControl;
            btnLimparCampos.Location = new Point(737, 35);
            btnLimparCampos.Margin = new Padding(3, 2, 3, 2);
            btnLimparCampos.Name = "btnLimparCampos";
            btnLimparCampos.Size = new Size(82, 28);
            btnLimparCampos.TabIndex = 16;
            btnLimparCampos.Text = "Limpar";
            btnLimparCampos.UseVisualStyleBackColor = false;
            // 
            // ListaPessoas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(831, 606);
            Controls.Add(btnLimparCampos);
            Controls.Add(lblExcluir);
            Controls.Add(btnExcluir);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(mtxtTelefone);
            Controls.Add(mtxtDocumento);
            Controls.Add(mtxtCEP);
            Controls.Add(lblAlterarCadastro);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(lblTelefone);
            Controls.Add(txtEmail);
            Controls.Add(lblDocumento);
            Controls.Add(lblEmail);
            Controls.Add(lblNumero);
            Controls.Add(lblLogradouro);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblCEP);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Controls.Add(btnSalvar);
            Controls.Add(lblInstruPesquisa);
            Controls.Add(lblPesquisar);
            Controls.Add(btnPesquisa);
            Controls.Add(txtPesquisa);
            Controls.Add(dgvPessoas);
            Controls.Add(menuStrip1);
            ForeColor = SystemColors.ControlText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            MaximumSize = new Size(1255, 700);
            MinimumSize = new Size(812, 610);
            Name = "ListaPessoas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pessoas";
            Load += ListaPessoas_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPessoas).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuPrincipalToolStripMenuItem;
        private ToolStripMenuItem cadastroToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private DataGridView dgvPessoas;
        private TextBox txtPesquisa;
        private Button btnPesquisa;
        private Label lblPesquisar;
        private Label lblInstruPesquisa;
        private Button btnSalvar;
        private Label lblNome;
        private TextBox txtNome;
        private TextBox txtEmail;
        private Label lblEmail;
        private Label lblDocumento;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label lblAlterarCadastro;
        private Label lblCEP;
        private MaskedTextBox mtxtCEP;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblLogradouro;
        private Label lblNumero;
        private MaskedTextBox mtxtDocumento;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private ErrorProvider errorProvider1;
        private Button btnExcluir;
        private Label lblExcluir;
        private MaskedTextBox mtxtTelefone;
        private Label lblTelefone;
        private Button btnLimparCampos;
    }
}
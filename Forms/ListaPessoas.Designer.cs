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
            pessoaBindingSource = new BindingSource(components);
            txtEmail = new TextBox();
            lblEmail = new Label();
            lblDocumento = new Label();
            radFisica = new RadioButton();
            radJuridica = new RadioButton();
            lblCEP = new Label();
            mtxtCEP = new MaskedTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblLogradouro = new Label();
            lblNumero = new Label();
            mtxtDocumento = new MaskedTextBox();
            txtCidade = new TextBox();
            txtLogradouro = new TextBox();
            txtNumero = new TextBox();
            txtBairro = new TextBox();
            txtEstado = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            btnExcluir = new Button();
            lblExcluir = new Label();
            lblTelefone = new Label();
            mtxtTelefone = new MaskedTextBox();
            btnLimparCampos = new Button();
            lblAlterarCadastro = new Label();
            lblTituloGuid = new Label();
            lblGuid = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPessoas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pessoaBindingSource).BeginInit();
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
            dgvPessoas.CellContentDoubleClick += preencheCampos_CellContentDoubleClick;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Location = new Point(16, 91);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(325, 23);
            txtPesquisa.TabIndex = 0;
            // 
            // btnPesquisa
            // 
            btnPesquisa.BackColor = Color.FromArgb(155, 0, 70);
            btnPesquisa.FlatStyle = FlatStyle.Flat;
            btnPesquisa.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPesquisa.ForeColor = Color.White;
            btnPesquisa.Location = new Point(359, 87);
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
            btnSalvar.Location = new Point(717, 557);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(102, 40);
            btnSalvar.TabIndex = 14;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblNome.Location = new Point(14, 361);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 8;
            lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.DataBindings.Add(new Binding("Text", pessoaBindingSource, "Nome", true));
            txtNome.Location = new Point(66, 357);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(180, 23);
            txtNome.TabIndex = 2;
            // 
            // pessoaBindingSource
            // 
            pessoaBindingSource.DataSource = typeof(Models.Pessoa);
            // 
            // txtEmail
            // 
            txtEmail.DataBindings.Add(new Binding("Text", pessoaBindingSource, "Email", true));
            txtEmail.Location = new Point(66, 400);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(180, 23);
            txtEmail.TabIndex = 3;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblEmail.Location = new Point(14, 404);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(41, 15);
            lblEmail.TabIndex = 8;
            lblEmail.Text = "E-mail";
            // 
            // lblDocumento
            // 
            lblDocumento.AutoSize = true;
            lblDocumento.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblDocumento.Location = new Point(14, 483);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(71, 15);
            lblDocumento.TabIndex = 8;
            lblDocumento.Text = "Documento";
            // 
            // radFisica
            // 
            radFisica.AutoSize = true;
            radFisica.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            radFisica.Location = new Point(14, 441);
            radFisica.Name = "radFisica";
            radFisica.Size = new Size(93, 19);
            radFisica.TabIndex = 4;
            radFisica.TabStop = true;
            radFisica.Text = "Pessoa Física";
            radFisica.UseVisualStyleBackColor = true;
            // 
            // radJuridica
            // 
            radJuridica.AutoSize = true;
            radJuridica.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            radJuridica.Location = new Point(141, 441);
            radJuridica.Name = "radJuridica";
            radJuridica.Size = new Size(105, 19);
            radJuridica.TabIndex = 5;
            radJuridica.TabStop = true;
            radJuridica.Text = "Pessoa Jurídica";
            radJuridica.UseVisualStyleBackColor = true;
            // 
            // lblCEP
            // 
            lblCEP.AutoSize = true;
            lblCEP.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblCEP.Location = new Point(298, 361);
            lblCEP.Name = "lblCEP";
            lblCEP.Size = new Size(27, 15);
            lblCEP.TabIndex = 8;
            lblCEP.Text = "CEP";
            // 
            // mtxtCEP
            // 
            mtxtCEP.DataBindings.Add(new Binding("Text", pessoaBindingSource, "CEP", true));
            mtxtCEP.Location = new Point(342, 357);
            mtxtCEP.Mask = "00000-000";
            mtxtCEP.Name = "mtxtCEP";
            mtxtCEP.Size = new Size(152, 23);
            mtxtCEP.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label1.Location = new Point(506, 361);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 8;
            label1.Text = "Estado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.Location = new Point(298, 404);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 8;
            label2.Text = "Cidade";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.Location = new Point(298, 443);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 8;
            label3.Text = "Bairro";
            // 
            // lblLogradouro
            // 
            lblLogradouro.AutoSize = true;
            lblLogradouro.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblLogradouro.Location = new Point(298, 483);
            lblLogradouro.Name = "lblLogradouro";
            lblLogradouro.Size = new Size(69, 15);
            lblLogradouro.TabIndex = 8;
            lblLogradouro.Text = "Logradouro";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblNumero.Location = new Point(506, 483);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(51, 15);
            lblNumero.TabIndex = 8;
            lblNumero.Text = "Número";
            // 
            // mtxtDocumento
            // 
            mtxtDocumento.DataBindings.Add(new Binding("Text", pessoaBindingSource, "Documento", true));
            mtxtDocumento.Location = new Point(97, 479);
            mtxtDocumento.Name = "mtxtDocumento";
            mtxtDocumento.Size = new Size(149, 23);
            mtxtDocumento.TabIndex = 6;
            // 
            // txtCidade
            // 
            txtCidade.DataBindings.Add(new Binding("Text", pessoaBindingSource, "Cidade", true));
            txtCidade.Location = new Point(342, 400);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(152, 23);
            txtCidade.TabIndex = 10;
            // 
            // txtLogradouro
            // 
            txtLogradouro.DataBindings.Add(new Binding("Text", pessoaBindingSource, "Logradouro", true));
            txtLogradouro.Location = new Point(371, 479);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(123, 23);
            txtLogradouro.TabIndex = 12;
            // 
            // txtNumero
            // 
            txtNumero.DataBindings.Add(new Binding("Text", pessoaBindingSource, "Numero", true));
            txtNumero.Location = new Point(563, 479);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(80, 23);
            txtNumero.TabIndex = 13;
            // 
            // txtBairro
            // 
            txtBairro.DataBindings.Add(new Binding("Text", pessoaBindingSource, "Bairro", true));
            txtBairro.Location = new Point(342, 439);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(152, 23);
            txtBairro.TabIndex = 11;
            // 
            // txtEstado
            // 
            txtEstado.DataBindings.Add(new Binding("Text", pessoaBindingSource, "Estado", true));
            txtEstado.Location = new Point(563, 357);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(80, 23);
            txtEstado.TabIndex = 9;
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
            btnExcluir.Location = new Point(777, 347);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(41, 36);
            btnExcluir.TabIndex = 15;
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // lblExcluir
            // 
            lblExcluir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblExcluir.AutoSize = true;
            lblExcluir.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExcluir.ForeColor = SystemColors.ControlDarkDark;
            lblExcluir.Location = new Point(727, 329);
            lblExcluir.Name = "lblExcluir";
            lblExcluir.Size = new Size(91, 15);
            lblExcluir.TabIndex = 19;
            lblExcluir.Text = "Excluir Cadastro";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblTelefone.Location = new Point(14, 526);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(52, 15);
            lblTelefone.TabIndex = 8;
            lblTelefone.Text = "Telefone";
            // 
            // mtxtTelefone
            // 
            mtxtTelefone.DataBindings.Add(new Binding("Text", pessoaBindingSource, "Telefone", true));
            mtxtTelefone.Location = new Point(97, 522);
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
            btnLimparCampos.Click += btnLimparCampos_Click;
            // 
            // lblAlterarCadastro
            // 
            lblAlterarCadastro.AutoSize = true;
            lblAlterarCadastro.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAlterarCadastro.ForeColor = SystemColors.ControlText;
            lblAlterarCadastro.Location = new Point(14, 326);
            lblAlterarCadastro.Name = "lblAlterarCadastro";
            lblAlterarCadastro.Size = new Size(133, 21);
            lblAlterarCadastro.TabIndex = 13;
            lblAlterarCadastro.Text = "Alterar Cadastro";
            // 
            // lblTituloGuid
            // 
            lblTituloGuid.Anchor = AnchorStyles.Left;
            lblTituloGuid.AutoSize = true;
            lblTituloGuid.ForeColor = SystemColors.ControlDarkDark;
            lblTituloGuid.Location = new Point(14, 557);
            lblTituloGuid.Name = "lblTituloGuid";
            lblTituloGuid.Size = new Size(35, 15);
            lblTituloGuid.TabIndex = 20;
            lblTituloGuid.Text = "Guid:";
            // 
            // lblGuid
            // 
            lblGuid.AutoSize = true;
            lblGuid.ForeColor = SystemColors.ControlDarkDark;
            lblGuid.Location = new Point(58, 557);
            lblGuid.Name = "lblGuid";
            lblGuid.Size = new Size(0, 15);
            lblGuid.TabIndex = 21;
            // 
            // ListaPessoas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(831, 606);
            Controls.Add(lblGuid);
            Controls.Add(lblTituloGuid);
            Controls.Add(btnLimparCampos);
            Controls.Add(lblExcluir);
            Controls.Add(btnExcluir);
            Controls.Add(txtEstado);
            Controls.Add(txtBairro);
            Controls.Add(txtNumero);
            Controls.Add(txtLogradouro);
            Controls.Add(txtCidade);
            Controls.Add(mtxtTelefone);
            Controls.Add(mtxtDocumento);
            Controls.Add(mtxtCEP);
            Controls.Add(lblAlterarCadastro);
            Controls.Add(radJuridica);
            Controls.Add(radFisica);
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
            ((System.ComponentModel.ISupportInitialize)pessoaBindingSource).EndInit();
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
        private RadioButton radFisica;
        private RadioButton radJuridica;
        private Label lblCEP;
        private MaskedTextBox mtxtCEP;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblLogradouro;
        private Label lblNumero;
        private MaskedTextBox mtxtDocumento;
        private TextBox txtCidade;
        private TextBox txtLogradouro;
        private TextBox txtNumero;
        private TextBox txtBairro;
        private TextBox txtEstado;
        private ErrorProvider errorProvider1;
        private Button btnExcluir;
        private Label lblExcluir;
        private MaskedTextBox mtxtTelefone;
        private Label lblTelefone;
        private Button btnLimparCampos;
        private Label lblAlterarCadastro;
        private BindingSource pessoaBindingSource;
        private Label lblTituloGuid;
        private Label lblGuid;
    }
}
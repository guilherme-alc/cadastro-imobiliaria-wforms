namespace CadastroImobiliaria
{
    partial class FormRegistros
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistros));
            dgvPessoas = new DataGridView();
            txtPesquisa = new TextBox();
            btnPesquisa = new Button();
            lblPesquisar = new Label();
            lblInstrucaoPesquisa = new Label();
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
            lblEstado = new Label();
            lblCidade = new Label();
            lblBairro = new Label();
            lblLogradouro = new Label();
            lblNumero = new Label();
            mtxtDocumento = new MaskedTextBox();
            txtCidade = new TextBox();
            txtLogradouro = new TextBox();
            txtNumero = new TextBox();
            txtBairro = new TextBox();
            txtEstado = new TextBox();
            errorProvider = new ErrorProvider(components);
            btnExcluir = new Button();
            lblExcluir = new Label();
            lblTelefone = new Label();
            mtxtTelefone = new MaskedTextBox();
            btnLimparCampos = new Button();
            lblAlterarCadastro = new Label();
            lblTituloGuid = new Label();
            lblGuid = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPessoas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pessoaBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // dgvPessoas
            // 
            dgvPessoas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPessoas.BackgroundColor = SystemColors.GradientActiveCaption;
            dgvPessoas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(155, 0, 70);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvPessoas.DefaultCellStyle = dataGridViewCellStyle2;
            dgvPessoas.Location = new Point(0, 95);
            dgvPessoas.Margin = new Padding(3, 2, 3, 2);
            dgvPessoas.MaximumSize = new Size(1239, 188);
            dgvPessoas.MinimumSize = new Size(796, 200);
            dgvPessoas.Name = "dgvPessoas";
            dgvPessoas.RowHeadersWidth = 51;
            dgvPessoas.Size = new Size(831, 200);
            dgvPessoas.TabIndex = 19;
            dgvPessoas.CellContentDoubleClick += PreencheCampos;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Location = new Point(12, 63);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(325, 23);
            txtPesquisa.TabIndex = 0;
            txtPesquisa.Enter += BotaoPesquisar;
            // 
            // btnPesquisa
            // 
            btnPesquisa.BackColor = Color.FromArgb(155, 0, 70);
            btnPesquisa.FlatStyle = FlatStyle.Flat;
            btnPesquisa.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPesquisa.ForeColor = Color.White;
            btnPesquisa.Location = new Point(355, 59);
            btnPesquisa.Name = "btnPesquisa";
            btnPesquisa.Size = new Size(89, 31);
            btnPesquisa.TabIndex = 1;
            btnPesquisa.Text = "Pesquisar";
            btnPesquisa.UseVisualStyleBackColor = false;
            btnPesquisa.Click += BotaoPesquisar;
            // 
            // lblPesquisar
            // 
            lblPesquisar.AutoSize = true;
            lblPesquisar.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPesquisar.ForeColor = Color.Black;
            lblPesquisar.Location = new Point(12, 9);
            lblPesquisar.Name = "lblPesquisar";
            lblPesquisar.Size = new Size(173, 25);
            lblPesquisar.TabIndex = 21;
            lblPesquisar.Text = "Pesquisar Cadastro";
            // 
            // lblInstrucaoPesquisa
            // 
            lblInstrucaoPesquisa.AutoSize = true;
            lblInstrucaoPesquisa.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInstrucaoPesquisa.ForeColor = SystemColors.ControlDarkDark;
            lblInstrucaoPesquisa.Location = new Point(12, 45);
            lblInstrucaoPesquisa.Name = "lblInstrucaoPesquisa";
            lblInstrucaoPesquisa.Size = new Size(228, 15);
            lblInstrucaoPesquisa.TabIndex = 22;
            lblInstrucaoPesquisa.Text = "Digite o nome ou documento (CPF/CNPJ)";
            // 
            // btnSalvar
            // 
            btnSalvar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalvar.BackColor = Color.FromArgb(155, 0, 70);
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Location = new Point(714, 544);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(102, 40);
            btnSalvar.TabIndex = 14;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += BotaoSalvar;
            // 
            // lblNome
            // 
            lblNome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblNome.Location = new Point(12, 348);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 24;
            lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtNome.DataBindings.Add(new Binding("Text", pessoaBindingSource, "Nome", true));
            txtNome.Location = new Point(64, 344);
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
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtEmail.DataBindings.Add(new Binding("Text", pessoaBindingSource, "Email", true));
            txtEmail.Location = new Point(64, 387);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(180, 23);
            txtEmail.TabIndex = 3;
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblEmail.Location = new Point(12, 391);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(41, 15);
            lblEmail.TabIndex = 25;
            lblEmail.Text = "E-mail";
            // 
            // lblDocumento
            // 
            lblDocumento.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblDocumento.AutoSize = true;
            lblDocumento.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblDocumento.Location = new Point(12, 470);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(71, 15);
            lblDocumento.TabIndex = 26;
            lblDocumento.Text = "Documento";
            // 
            // radFisica
            // 
            radFisica.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            radFisica.AutoSize = true;
            radFisica.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            radFisica.Location = new Point(12, 428);
            radFisica.Name = "radFisica";
            radFisica.Size = new Size(93, 19);
            radFisica.TabIndex = 4;
            radFisica.TabStop = true;
            radFisica.Text = "Pessoa Física";
            radFisica.UseVisualStyleBackColor = true;
            // 
            // radJuridica
            // 
            radJuridica.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            radJuridica.AutoSize = true;
            radJuridica.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            radJuridica.Location = new Point(139, 428);
            radJuridica.Name = "radJuridica";
            radJuridica.Size = new Size(105, 19);
            radJuridica.TabIndex = 5;
            radJuridica.TabStop = true;
            radJuridica.Text = "Pessoa Jurídica";
            radJuridica.UseVisualStyleBackColor = true;
            // 
            // lblCEP
            // 
            lblCEP.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblCEP.AutoSize = true;
            lblCEP.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblCEP.Location = new Point(296, 348);
            lblCEP.Name = "lblCEP";
            lblCEP.Size = new Size(27, 15);
            lblCEP.TabIndex = 30;
            lblCEP.Text = "CEP";
            // 
            // mtxtCEP
            // 
            mtxtCEP.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            mtxtCEP.DataBindings.Add(new Binding("Text", pessoaBindingSource, "CEP", true));
            mtxtCEP.Location = new Point(340, 344);
            mtxtCEP.Mask = "00000-000";
            mtxtCEP.Name = "mtxtCEP";
            mtxtCEP.Size = new Size(152, 23);
            mtxtCEP.TabIndex = 8;
            // 
            // lblEstado
            // 
            lblEstado.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblEstado.Location = new Point(504, 348);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(42, 15);
            lblEstado.TabIndex = 34;
            lblEstado.Text = "Estado";
            // 
            // lblCidade
            // 
            lblCidade.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblCidade.AutoSize = true;
            lblCidade.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblCidade.Location = new Point(296, 391);
            lblCidade.Name = "lblCidade";
            lblCidade.Size = new Size(43, 15);
            lblCidade.TabIndex = 31;
            lblCidade.Text = "Cidade";
            // 
            // lblBairro
            // 
            lblBairro.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblBairro.AutoSize = true;
            lblBairro.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblBairro.Location = new Point(296, 430);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(38, 15);
            lblBairro.TabIndex = 32;
            lblBairro.Text = "Bairro";
            // 
            // lblLogradouro
            // 
            lblLogradouro.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblLogradouro.AutoSize = true;
            lblLogradouro.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblLogradouro.Location = new Point(296, 470);
            lblLogradouro.Name = "lblLogradouro";
            lblLogradouro.Size = new Size(69, 15);
            lblLogradouro.TabIndex = 33;
            lblLogradouro.Text = "Logradouro";
            // 
            // lblNumero
            // 
            lblNumero.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblNumero.AutoSize = true;
            lblNumero.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblNumero.Location = new Point(583, 470);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(51, 15);
            lblNumero.TabIndex = 0;
            lblNumero.Text = "Número";
            // 
            // mtxtDocumento
            // 
            mtxtDocumento.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            mtxtDocumento.DataBindings.Add(new Binding("Text", pessoaBindingSource, "Documento", true));
            mtxtDocumento.Location = new Point(95, 466);
            mtxtDocumento.Name = "mtxtDocumento";
            mtxtDocumento.Size = new Size(149, 23);
            mtxtDocumento.TabIndex = 6;
            // 
            // txtCidade
            // 
            txtCidade.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtCidade.DataBindings.Add(new Binding("Text", pessoaBindingSource, "Cidade", true));
            txtCidade.Location = new Point(340, 387);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(152, 23);
            txtCidade.TabIndex = 10;
            // 
            // txtLogradouro
            // 
            txtLogradouro.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtLogradouro.DataBindings.Add(new Binding("Text", pessoaBindingSource, "Logradouro", true));
            txtLogradouro.Location = new Point(369, 466);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(208, 23);
            txtLogradouro.TabIndex = 12;
            // 
            // txtNumero
            // 
            txtNumero.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtNumero.DataBindings.Add(new Binding("Text", pessoaBindingSource, "Numero", true));
            txtNumero.Location = new Point(640, 466);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(64, 23);
            txtNumero.TabIndex = 13;
            // 
            // txtBairro
            // 
            txtBairro.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtBairro.DataBindings.Add(new Binding("Text", pessoaBindingSource, "Bairro", true));
            txtBairro.Location = new Point(340, 426);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(152, 23);
            txtBairro.TabIndex = 11;
            // 
            // txtEstado
            // 
            txtEstado.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtEstado.DataBindings.Add(new Binding("Text", pessoaBindingSource, "Estado", true));
            txtEstado.Location = new Point(552, 344);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(152, 23);
            txtEstado.TabIndex = 9;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // btnExcluir
            // 
            btnExcluir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExcluir.BackColor = SystemColors.ControlLight;
            btnExcluir.BackgroundImage = (Image)resources.GetObject("btnExcluir.BackgroundImage");
            btnExcluir.BackgroundImageLayout = ImageLayout.Zoom;
            btnExcluir.FlatStyle = FlatStyle.Flat;
            btnExcluir.ForeColor = SystemColors.ControlLight;
            btnExcluir.Image = (Image)resources.GetObject("btnExcluir.Image");
            btnExcluir.ImageAlign = ContentAlignment.TopCenter;
            btnExcluir.Location = new Point(775, 334);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(41, 36);
            btnExcluir.TabIndex = 16;
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += BotaoExcluir;
            // 
            // lblExcluir
            // 
            lblExcluir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblExcluir.AutoSize = true;
            lblExcluir.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExcluir.ForeColor = SystemColors.ControlDarkDark;
            lblExcluir.Location = new Point(725, 316);
            lblExcluir.Name = "lblExcluir";
            lblExcluir.Size = new Size(91, 15);
            lblExcluir.TabIndex = 1;
            lblExcluir.Text = "Excluir Cadastro";
            // 
            // lblTelefone
            // 
            lblTelefone.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblTelefone.AutoSize = true;
            lblTelefone.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblTelefone.Location = new Point(12, 513);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(52, 15);
            lblTelefone.TabIndex = 27;
            lblTelefone.Text = "Telefone";
            // 
            // mtxtTelefone
            // 
            mtxtTelefone.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            mtxtTelefone.DataBindings.Add(new Binding("Text", pessoaBindingSource, "Telefone", true));
            mtxtTelefone.Location = new Point(95, 509);
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
            btnLimparCampos.Location = new Point(733, 7);
            btnLimparCampos.Margin = new Padding(3, 2, 3, 2);
            btnLimparCampos.Name = "btnLimparCampos";
            btnLimparCampos.Size = new Size(82, 28);
            btnLimparCampos.TabIndex = 15;
            btnLimparCampos.Text = "Limpar";
            btnLimparCampos.UseVisualStyleBackColor = false;
            btnLimparCampos.Click += BotaoLimparCampos;
            // 
            // lblAlterarCadastro
            // 
            lblAlterarCadastro.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblAlterarCadastro.AutoSize = true;
            lblAlterarCadastro.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAlterarCadastro.ForeColor = SystemColors.ControlText;
            lblAlterarCadastro.Location = new Point(12, 313);
            lblAlterarCadastro.Name = "lblAlterarCadastro";
            lblAlterarCadastro.Size = new Size(133, 21);
            lblAlterarCadastro.TabIndex = 23;
            lblAlterarCadastro.Text = "Alterar Cadastro";
            // 
            // lblTituloGuid
            // 
            lblTituloGuid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblTituloGuid.AutoSize = true;
            lblTituloGuid.ForeColor = SystemColors.ControlDarkDark;
            lblTituloGuid.Location = new Point(12, 544);
            lblTituloGuid.Name = "lblTituloGuid";
            lblTituloGuid.Size = new Size(35, 15);
            lblTituloGuid.TabIndex = 28;
            lblTituloGuid.Text = "Guid:";
            // 
            // lblGuid
            // 
            lblGuid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblGuid.AutoSize = true;
            lblGuid.ForeColor = SystemColors.ControlDarkDark;
            lblGuid.Location = new Point(56, 544);
            lblGuid.Name = "lblGuid";
            lblGuid.Size = new Size(0, 15);
            lblGuid.TabIndex = 29;
            // 
            // Registros
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
            Controls.Add(lblBairro);
            Controls.Add(lblCidade);
            Controls.Add(lblEstado);
            Controls.Add(lblCEP);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Controls.Add(btnSalvar);
            Controls.Add(lblInstrucaoPesquisa);
            Controls.Add(lblPesquisar);
            Controls.Add(btnPesquisa);
            Controls.Add(txtPesquisa);
            Controls.Add(dgvPessoas);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MaximumSize = new Size(1255, 700);
            MinimumSize = new Size(812, 620);
            Name = "Registros";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registros";
            Load += CarregaFormularioPessoas;
            ((System.ComponentModel.ISupportInitialize)dgvPessoas).EndInit();
            ((System.ComponentModel.ISupportInitialize)pessoaBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvPessoas;
        private TextBox txtPesquisa;
        private Button btnPesquisa;
        private Label lblPesquisar;
        private Label lblInstrucaoPesquisa;
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
        private Label lblEstado;
        private Label lblCidade;
        private Label lblBairro;
        private Label lblLogradouro;
        private Label lblNumero;
        private MaskedTextBox mtxtDocumento;
        private TextBox txtCidade;
        private TextBox txtLogradouro;
        private TextBox txtNumero;
        private TextBox txtBairro;
        private TextBox txtEstado;
        private ErrorProvider errorProvider;
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
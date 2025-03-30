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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
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
            lblTelefone = new Label();
            mtxtTelefone = new MaskedTextBox();
            btnLimparCampos = new Button();
            lblTituloGuid = new Label();
            lblGuid = new Label();
            groupBox1 = new GroupBox();
            lblAlterarCadastro = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPessoas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pessoaBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvPessoas
            // 
            dgvPessoas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            dgvPessoas.Location = new Point(0, 127);
            dgvPessoas.MaximumSize = new Size(1416, 251);
            dgvPessoas.MinimumSize = new Size(910, 267);
            dgvPessoas.Name = "dgvPessoas";
            dgvPessoas.RowHeadersWidth = 51;
            dgvPessoas.Size = new Size(910, 267);
            dgvPessoas.TabIndex = 19;
            dgvPessoas.CellContentDoubleClick += PreencheCampos;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Location = new Point(14, 84);
            txtPesquisa.Margin = new Padding(3, 4, 3, 4);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(371, 27);
            txtPesquisa.TabIndex = 0;
            // 
            // btnPesquisa
            // 
            btnPesquisa.BackColor = Color.FromArgb(155, 0, 70);
            btnPesquisa.FlatStyle = FlatStyle.Flat;
            btnPesquisa.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPesquisa.ForeColor = Color.White;
            btnPesquisa.Location = new Point(406, 79);
            btnPesquisa.Margin = new Padding(3, 4, 3, 4);
            btnPesquisa.Name = "btnPesquisa";
            btnPesquisa.Size = new Size(102, 41);
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
            lblPesquisar.Location = new Point(14, 12);
            lblPesquisar.Name = "lblPesquisar";
            lblPesquisar.Size = new Size(220, 32);
            lblPesquisar.TabIndex = 21;
            lblPesquisar.Text = "Pesquisar Cadastro";
            // 
            // lblInstrucaoPesquisa
            // 
            lblInstrucaoPesquisa.AutoSize = true;
            lblInstrucaoPesquisa.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInstrucaoPesquisa.ForeColor = SystemColors.ControlDarkDark;
            lblInstrucaoPesquisa.Location = new Point(14, 60);
            lblInstrucaoPesquisa.Name = "lblInstrucaoPesquisa";
            lblInstrucaoPesquisa.Size = new Size(291, 20);
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
            btnSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalvar.Location = new Point(711, 343);
            btnSalvar.Margin = new Padding(3, 4, 3, 4);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(90, 53);
            btnSalvar.TabIndex = 14;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextAlign = ContentAlignment.MiddleRight;
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += BotaoSalvar;
            // 
            // lblNome
            // 
            lblNome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblNome.Location = new Point(7, 72);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(51, 20);
            lblNome.TabIndex = 24;
            lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtNome.DataBindings.Add(new Binding("Text", pessoaBindingSource, "Nome", true));
            txtNome.Location = new Point(66, 67);
            txtNome.Margin = new Padding(3, 4, 3, 4);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(205, 27);
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
            txtEmail.Location = new Point(66, 124);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(205, 27);
            txtEmail.TabIndex = 3;
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblEmail.Location = new Point(7, 129);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(52, 20);
            lblEmail.TabIndex = 25;
            lblEmail.Text = "E-mail";
            // 
            // lblDocumento
            // 
            lblDocumento.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblDocumento.AutoSize = true;
            lblDocumento.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblDocumento.Location = new Point(7, 235);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(89, 20);
            lblDocumento.TabIndex = 26;
            lblDocumento.Text = "Documento";
            // 
            // radFisica
            // 
            radFisica.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            radFisica.AutoSize = true;
            radFisica.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            radFisica.Location = new Point(7, 179);
            radFisica.Margin = new Padding(3, 4, 3, 4);
            radFisica.Name = "radFisica";
            radFisica.Size = new Size(116, 24);
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
            radJuridica.Location = new Point(152, 179);
            radJuridica.Margin = new Padding(3, 4, 3, 4);
            radJuridica.Name = "radJuridica";
            radJuridica.Size = new Size(132, 24);
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
            lblCEP.Location = new Point(7, 339);
            lblCEP.Name = "lblCEP";
            lblCEP.Size = new Size(35, 20);
            lblCEP.TabIndex = 30;
            lblCEP.Text = "CEP";
            // 
            // mtxtCEP
            // 
            mtxtCEP.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            mtxtCEP.DataBindings.Add(new Binding("Text", pessoaBindingSource, "CEP", true));
            mtxtCEP.Location = new Point(102, 335);
            mtxtCEP.Margin = new Padding(3, 4, 3, 4);
            mtxtCEP.Mask = "00000-000";
            mtxtCEP.Name = "mtxtCEP";
            mtxtCEP.Size = new Size(170, 27);
            mtxtCEP.TabIndex = 8;
            mtxtCEP.Leave += BuscaEndereco;
            // 
            // lblEstado
            // 
            lblEstado.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblEstado.Location = new Point(333, 72);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(54, 20);
            lblEstado.TabIndex = 34;
            lblEstado.Text = "Estado";
            // 
            // lblCidade
            // 
            lblCidade.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblCidade.AutoSize = true;
            lblCidade.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblCidade.Location = new Point(333, 124);
            lblCidade.Name = "lblCidade";
            lblCidade.Size = new Size(56, 20);
            lblCidade.TabIndex = 31;
            lblCidade.Text = "Cidade";
            // 
            // lblBairro
            // 
            lblBairro.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblBairro.AutoSize = true;
            lblBairro.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblBairro.Location = new Point(333, 176);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(51, 20);
            lblBairro.TabIndex = 32;
            lblBairro.Text = "Bairro";
            // 
            // lblLogradouro
            // 
            lblLogradouro.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblLogradouro.AutoSize = true;
            lblLogradouro.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblLogradouro.Location = new Point(333, 229);
            lblLogradouro.Name = "lblLogradouro";
            lblLogradouro.Size = new Size(90, 20);
            lblLogradouro.TabIndex = 33;
            lblLogradouro.Text = "Logradouro";
            // 
            // lblNumero
            // 
            lblNumero.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblNumero.AutoSize = true;
            lblNumero.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblNumero.Location = new Point(695, 229);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(66, 20);
            lblNumero.TabIndex = 0;
            lblNumero.Text = "Número";
            // 
            // mtxtDocumento
            // 
            mtxtDocumento.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            mtxtDocumento.DataBindings.Add(new Binding("Text", pessoaBindingSource, "Documento", true));
            mtxtDocumento.Location = new Point(102, 229);
            mtxtDocumento.Margin = new Padding(3, 4, 3, 4);
            mtxtDocumento.Name = "mtxtDocumento";
            mtxtDocumento.Size = new Size(170, 27);
            mtxtDocumento.TabIndex = 6;
            // 
            // txtCidade
            // 
            txtCidade.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtCidade.DataBindings.Add(new Binding("Text", pessoaBindingSource, "Cidade", true));
            txtCidade.Location = new Point(387, 119);
            txtCidade.Margin = new Padding(3, 4, 3, 4);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(173, 27);
            txtCidade.TabIndex = 10;
            // 
            // txtLogradouro
            // 
            txtLogradouro.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtLogradouro.DataBindings.Add(new Binding("Text", pessoaBindingSource, "Logradouro", true));
            txtLogradouro.Location = new Point(418, 224);
            txtLogradouro.Margin = new Padding(3, 4, 3, 4);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(237, 27);
            txtLogradouro.TabIndex = 12;
            // 
            // txtNumero
            // 
            txtNumero.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtNumero.DataBindings.Add(new Binding("Text", pessoaBindingSource, "Numero", true));
            txtNumero.Location = new Point(760, 224);
            txtNumero.Margin = new Padding(3, 4, 3, 4);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(73, 27);
            txtNumero.TabIndex = 13;
            // 
            // txtBairro
            // 
            txtBairro.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtBairro.DataBindings.Add(new Binding("Text", pessoaBindingSource, "Bairro", true));
            txtBairro.Location = new Point(387, 171);
            txtBairro.Margin = new Padding(3, 4, 3, 4);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(173, 27);
            txtBairro.TabIndex = 11;
            // 
            // txtEstado
            // 
            txtEstado.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtEstado.DataBindings.Add(new Binding("Text", pessoaBindingSource, "Estado", true));
            txtEstado.Location = new Point(387, 67);
            txtEstado.Margin = new Padding(3, 4, 3, 4);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(173, 27);
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
            btnExcluir.BackgroundImageLayout = ImageLayout.Zoom;
            btnExcluir.FlatStyle = FlatStyle.Popup;
            btnExcluir.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExcluir.ForeColor = SystemColors.ActiveCaptionText;
            btnExcluir.ImageAlign = ContentAlignment.MiddleLeft;
            btnExcluir.Location = new Point(825, 343);
            btnExcluir.Margin = new Padding(3, 4, 3, 4);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(90, 53);
            btnExcluir.TabIndex = 15;
            btnExcluir.Text = "Excluir";
            btnExcluir.TextAlign = ContentAlignment.MiddleRight;
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += BotaoExcluir;
            // 
            // lblTelefone
            // 
            lblTelefone.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblTelefone.AutoSize = true;
            lblTelefone.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblTelefone.Location = new Point(7, 287);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(67, 20);
            lblTelefone.TabIndex = 27;
            lblTelefone.Text = "Telefone";
            // 
            // mtxtTelefone
            // 
            mtxtTelefone.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            mtxtTelefone.DataBindings.Add(new Binding("Text", pessoaBindingSource, "Telefone", true));
            mtxtTelefone.Location = new Point(102, 281);
            mtxtTelefone.Margin = new Padding(3, 4, 3, 4);
            mtxtTelefone.Mask = "(00) 00000-0000";
            mtxtTelefone.Name = "mtxtTelefone";
            mtxtTelefone.Size = new Size(170, 27);
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
            btnLimparCampos.Location = new Point(842, 15);
            btnLimparCampos.Name = "btnLimparCampos";
            btnLimparCampos.Size = new Size(94, 37);
            btnLimparCampos.TabIndex = 16;
            btnLimparCampos.Text = "Limpar";
            btnLimparCampos.UseVisualStyleBackColor = false;
            btnLimparCampos.Click += BotaoLimparCampos;
            // 
            // lblTituloGuid
            // 
            lblTituloGuid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblTituloGuid.AutoSize = true;
            lblTituloGuid.ForeColor = SystemColors.ControlDarkDark;
            lblTituloGuid.Location = new Point(7, 376);
            lblTituloGuid.Name = "lblTituloGuid";
            lblTituloGuid.Size = new Size(43, 20);
            lblTituloGuid.TabIndex = 28;
            lblTituloGuid.Text = "Guid:";
            // 
            // lblGuid
            // 
            lblGuid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblGuid.AutoSize = true;
            lblGuid.ForeColor = SystemColors.ControlDarkDark;
            lblGuid.Location = new Point(66, 376);
            lblGuid.Name = "lblGuid";
            lblGuid.Size = new Size(0, 20);
            lblGuid.TabIndex = 29;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblAlterarCadastro);
            groupBox1.Controls.Add(lblGuid);
            groupBox1.Controls.Add(btnSalvar);
            groupBox1.Controls.Add(lblNome);
            groupBox1.Controls.Add(lblTituloGuid);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Controls.Add(lblCEP);
            groupBox1.Controls.Add(btnExcluir);
            groupBox1.Controls.Add(lblEstado);
            groupBox1.Controls.Add(txtEstado);
            groupBox1.Controls.Add(lblCidade);
            groupBox1.Controls.Add(txtBairro);
            groupBox1.Controls.Add(lblBairro);
            groupBox1.Controls.Add(txtNumero);
            groupBox1.Controls.Add(lblLogradouro);
            groupBox1.Controls.Add(txtLogradouro);
            groupBox1.Controls.Add(lblNumero);
            groupBox1.Controls.Add(txtCidade);
            groupBox1.Controls.Add(lblEmail);
            groupBox1.Controls.Add(mtxtTelefone);
            groupBox1.Controls.Add(lblDocumento);
            groupBox1.Controls.Add(mtxtDocumento);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(mtxtCEP);
            groupBox1.Controls.Add(lblTelefone);
            groupBox1.Controls.Add(radFisica);
            groupBox1.Controls.Add(radJuridica);
            groupBox1.Location = new Point(14, 400);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(922, 404);
            groupBox1.TabIndex = 35;
            groupBox1.TabStop = false;
            // 
            // lblAlterarCadastro
            // 
            lblAlterarCadastro.AutoSize = true;
            lblAlterarCadastro.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAlterarCadastro.Location = new Point(7, 25);
            lblAlterarCadastro.Name = "lblAlterarCadastro";
            lblAlterarCadastro.Size = new Size(167, 28);
            lblAlterarCadastro.TabIndex = 35;
            lblAlterarCadastro.Text = "Alterar Cadastro";
            // 
            // FormRegistros
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(950, 808);
            Controls.Add(groupBox1);
            Controls.Add(btnLimparCampos);
            Controls.Add(lblInstrucaoPesquisa);
            Controls.Add(lblPesquisar);
            Controls.Add(btnPesquisa);
            Controls.Add(txtPesquisa);
            Controls.Add(dgvPessoas);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1432, 918);
            MinimumSize = new Size(925, 811);
            Name = "FormRegistros";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registros";
            Load += CarregaFormularioPessoas;
            ((System.ComponentModel.ISupportInitialize)dgvPessoas).EndInit();
            ((System.ComponentModel.ISupportInitialize)pessoaBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private MaskedTextBox mtxtTelefone;
        private Label lblTelefone;
        private Button btnLimparCampos;
        private BindingSource pessoaBindingSource;
        private Label lblTituloGuid;
        private Label lblGuid;
        private GroupBox groupBox1;
        private Label lblAlterarCadastro;
    }
}
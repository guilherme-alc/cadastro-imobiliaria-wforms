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
            dgvPessoas.Location = new Point(0, 95);
            dgvPessoas.Margin = new Padding(3, 2, 3, 2);
            dgvPessoas.MaximumSize = new Size(1239, 188);
            dgvPessoas.MinimumSize = new Size(796, 200);
            dgvPessoas.Name = "dgvPessoas";
            dgvPessoas.RowHeadersWidth = 51;
            dgvPessoas.Size = new Size(865, 200);
            dgvPessoas.TabIndex = 19;
            dgvPessoas.CellContentDoubleClick += PreencheCampos;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Location = new Point(12, 63);
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
            btnSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalvar.Location = new Point(622, 257);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(79, 40);
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
            lblNome.Location = new Point(6, 54);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 24;
            lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtNome.DataBindings.Add(new Binding("Text", pessoaBindingSource, "Nome", true));
            txtNome.Location = new Point(58, 50);
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
            txtEmail.Location = new Point(58, 93);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(180, 23);
            txtEmail.TabIndex = 3;
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblEmail.Location = new Point(6, 97);
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
            lblDocumento.Location = new Point(6, 176);
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
            radFisica.Location = new Point(6, 134);
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
            radJuridica.Location = new Point(133, 134);
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
            lblCEP.Location = new Point(6, 254);
            lblCEP.Name = "lblCEP";
            lblCEP.Size = new Size(27, 15);
            lblCEP.TabIndex = 30;
            lblCEP.Text = "CEP";
            // 
            // mtxtCEP
            // 
            mtxtCEP.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            mtxtCEP.DataBindings.Add(new Binding("Text", pessoaBindingSource, "CEP", true));
            mtxtCEP.Location = new Point(89, 251);
            mtxtCEP.Mask = "00000-000";
            mtxtCEP.Name = "mtxtCEP";
            mtxtCEP.Size = new Size(149, 23);
            mtxtCEP.TabIndex = 8;
            // 
            // lblEstado
            // 
            lblEstado.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblEstado.Location = new Point(291, 54);
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
            lblCidade.Location = new Point(291, 93);
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
            lblBairro.Location = new Point(291, 132);
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
            lblLogradouro.Location = new Point(291, 172);
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
            lblNumero.Location = new Point(608, 172);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(51, 15);
            lblNumero.TabIndex = 0;
            lblNumero.Text = "Número";
            // 
            // mtxtDocumento
            // 
            mtxtDocumento.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            mtxtDocumento.DataBindings.Add(new Binding("Text", pessoaBindingSource, "Documento", true));
            mtxtDocumento.Location = new Point(89, 172);
            mtxtDocumento.Name = "mtxtDocumento";
            mtxtDocumento.Size = new Size(149, 23);
            mtxtDocumento.TabIndex = 6;
            // 
            // txtCidade
            // 
            txtCidade.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtCidade.DataBindings.Add(new Binding("Text", pessoaBindingSource, "Cidade", true));
            txtCidade.Location = new Point(339, 89);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(152, 23);
            txtCidade.TabIndex = 10;
            // 
            // txtLogradouro
            // 
            txtLogradouro.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtLogradouro.DataBindings.Add(new Binding("Text", pessoaBindingSource, "Logradouro", true));
            txtLogradouro.Location = new Point(366, 168);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(208, 23);
            txtLogradouro.TabIndex = 12;
            // 
            // txtNumero
            // 
            txtNumero.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtNumero.DataBindings.Add(new Binding("Text", pessoaBindingSource, "Numero", true));
            txtNumero.Location = new Point(665, 168);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(64, 23);
            txtNumero.TabIndex = 13;
            // 
            // txtBairro
            // 
            txtBairro.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtBairro.DataBindings.Add(new Binding("Text", pessoaBindingSource, "Bairro", true));
            txtBairro.Location = new Point(339, 128);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(152, 23);
            txtBairro.TabIndex = 11;
            // 
            // txtEstado
            // 
            txtEstado.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtEstado.DataBindings.Add(new Binding("Text", pessoaBindingSource, "Estado", true));
            txtEstado.Location = new Point(339, 50);
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
            btnExcluir.BackgroundImageLayout = ImageLayout.Zoom;
            btnExcluir.FlatStyle = FlatStyle.Popup;
            btnExcluir.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExcluir.ForeColor = SystemColors.ActiveCaptionText;
            btnExcluir.ImageAlign = ContentAlignment.MiddleLeft;
            btnExcluir.Location = new Point(722, 257);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(79, 40);
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
            lblTelefone.Location = new Point(6, 215);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(52, 15);
            lblTelefone.TabIndex = 27;
            lblTelefone.Text = "Telefone";
            // 
            // mtxtTelefone
            // 
            mtxtTelefone.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            mtxtTelefone.DataBindings.Add(new Binding("Text", pessoaBindingSource, "Telefone", true));
            mtxtTelefone.Location = new Point(89, 211);
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
            btnLimparCampos.Location = new Point(737, 11);
            btnLimparCampos.Margin = new Padding(3, 2, 3, 2);
            btnLimparCampos.Name = "btnLimparCampos";
            btnLimparCampos.Size = new Size(82, 28);
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
            lblTituloGuid.Location = new Point(6, 282);
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
            lblGuid.Location = new Point(58, 282);
            lblGuid.Name = "lblGuid";
            lblGuid.Size = new Size(0, 15);
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
            groupBox1.Location = new Point(12, 300);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(807, 303);
            groupBox1.TabIndex = 35;
            groupBox1.TabStop = false;
            // 
            // lblAlterarCadastro
            // 
            lblAlterarCadastro.AutoSize = true;
            lblAlterarCadastro.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAlterarCadastro.Location = new Point(6, 19);
            lblAlterarCadastro.Name = "lblAlterarCadastro";
            lblAlterarCadastro.Size = new Size(133, 21);
            lblAlterarCadastro.TabIndex = 35;
            lblAlterarCadastro.Text = "Alterar Cadastro";
            // 
            // FormRegistros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(831, 606);
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
            Margin = new Padding(3, 2, 3, 2);
            MaximumSize = new Size(1255, 700);
            MinimumSize = new Size(812, 620);
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
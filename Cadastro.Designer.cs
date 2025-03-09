namespace CadastroImobiliaria
{
    partial class Cadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro));
            lblNome = new Label();
            txtNome = new TextBox();
            lblCEP = new Label();
            radFisica = new RadioButton();
            radJuridica = new RadioButton();
            lblDocumento = new Label();
            txtDocumento = new TextBox();
            lblEmail = new Label();
            lblTelefone = new Label();
            txtEmail = new TextBox();
            btnCadastrar = new Button();
            btnLimparCampos = new Button();
            pnlConteudo = new Panel();
            txtBairro = new TextBox();
            txtCidade = new TextBox();
            txtEstado = new TextBox();
            lblBairro = new Label();
            lblCidade = new Label();
            lblEstado = new Label();
            lblNumero = new Label();
            txtNumero = new TextBox();
            txtLogradouro = new TextBox();
            label1 = new Label();
            mtxtCEP = new MaskedTextBox();
            lblTitulo = new Label();
            mtxtTelefone = new MaskedTextBox();
            menuStrip1 = new MenuStrip();
            panel1 = new Panel();
            menuStrip = new MenuStrip();
            menuPrincipalToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            errorProvider1 = new ErrorProvider(components);
            pnlConteudo.SuspendLayout();
            panel1.SuspendLayout();
            menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 10.8F);
            lblNome.Location = new Point(38, 96);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(61, 25);
            lblNome.TabIndex = 2132321;
            lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNome.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.Location = new Point(38, 124);
            txtNome.MaxLength = 100;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(388, 30);
            txtNome.TabIndex = 0;
            txtNome.Validated += textBox_Validated;
            // 
            // lblCEP
            // 
            lblCEP.AutoSize = true;
            lblCEP.Font = new Font("Segoe UI", 10.8F);
            lblCEP.Location = new Point(38, 443);
            lblCEP.Name = "lblCEP";
            lblCEP.Size = new Size(42, 25);
            lblCEP.TabIndex = 4213132;
            lblCEP.Text = "CEP";
            // 
            // radFisica
            // 
            radFisica.AutoSize = true;
            radFisica.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radFisica.Location = new Point(38, 248);
            radFisica.Name = "radFisica";
            radFisica.Size = new Size(127, 27);
            radFisica.TabIndex = 2;
            radFisica.TabStop = true;
            radFisica.Text = "Pessoa Física";
            radFisica.UseVisualStyleBackColor = true;
            // 
            // radJuridica
            // 
            radJuridica.AutoSize = true;
            radJuridica.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radJuridica.Location = new Point(185, 248);
            radJuridica.Name = "radJuridica";
            radJuridica.Size = new Size(144, 27);
            radJuridica.TabIndex = 3;
            radJuridica.TabStop = true;
            radJuridica.Text = "Pessoa Jurídica";
            radJuridica.UseVisualStyleBackColor = true;
            // 
            // lblDocumento
            // 
            lblDocumento.AutoSize = true;
            lblDocumento.Font = new Font("Segoe UI", 10.8F);
            lblDocumento.Location = new Point(38, 278);
            lblDocumento.Margin = new Padding(0, 0, 3, 0);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(106, 25);
            lblDocumento.TabIndex = 83213;
            lblDocumento.Text = "Documento";
            // 
            // txtDocumento
            // 
            txtDocumento.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDocumento.Location = new Point(38, 306);
            txtDocumento.MaxLength = 18;
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(196, 30);
            txtDocumento.TabIndex = 4;
            txtDocumento.KeyPress += txtNumero_KeyPress;
            txtDocumento.Validated += textBox_Validated;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10.8F);
            lblEmail.Location = new Point(38, 167);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(61, 25);
            lblEmail.TabIndex = 932131;
            lblEmail.Text = "E-mail";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Font = new Font("Segoe UI", 10.8F);
            lblTelefone.Location = new Point(38, 356);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(77, 25);
            lblTelefone.TabIndex = 13132;
            lblTelefone.Text = "Telefone";
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(38, 195);
            txtEmail.MaxLength = 254;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(388, 30);
            txtEmail.TabIndex = 1;
            txtEmail.Validated += textBox_Validated;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Anchor = AnchorStyles.Bottom;
            btnCadastrar.BackColor = Color.RoyalBlue;
            btnCadastrar.FlatStyle = FlatStyle.Flat;
            btnCadastrar.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrar.ForeColor = Color.White;
            btnCadastrar.Location = new Point(372, 573);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(165, 61);
            btnCadastrar.TabIndex = 12;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnLimparCampos
            // 
            btnLimparCampos.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLimparCampos.Location = new Point(802, 44);
            btnLimparCampos.Name = "btnLimparCampos";
            btnLimparCampos.Size = new Size(94, 31);
            btnLimparCampos.TabIndex = 13;
            btnLimparCampos.Text = "Limpar";
            btnLimparCampos.UseVisualStyleBackColor = true;
            // 
            // pnlConteudo
            // 
            pnlConteudo.Controls.Add(txtBairro);
            pnlConteudo.Controls.Add(txtCidade);
            pnlConteudo.Controls.Add(txtEstado);
            pnlConteudo.Controls.Add(lblBairro);
            pnlConteudo.Controls.Add(lblCidade);
            pnlConteudo.Controls.Add(lblEstado);
            pnlConteudo.Controls.Add(lblNumero);
            pnlConteudo.Controls.Add(txtNumero);
            pnlConteudo.Controls.Add(txtLogradouro);
            pnlConteudo.Controls.Add(label1);
            pnlConteudo.Controls.Add(mtxtCEP);
            pnlConteudo.Controls.Add(lblTitulo);
            pnlConteudo.Controls.Add(mtxtTelefone);
            pnlConteudo.Controls.Add(btnLimparCampos);
            pnlConteudo.Controls.Add(btnCadastrar);
            pnlConteudo.Controls.Add(lblNome);
            pnlConteudo.Controls.Add(txtEmail);
            pnlConteudo.Controls.Add(txtNome);
            pnlConteudo.Controls.Add(lblTelefone);
            pnlConteudo.Controls.Add(lblCEP);
            pnlConteudo.Controls.Add(lblEmail);
            pnlConteudo.Controls.Add(txtDocumento);
            pnlConteudo.Controls.Add(radFisica);
            pnlConteudo.Controls.Add(lblDocumento);
            pnlConteudo.Controls.Add(radJuridica);
            pnlConteudo.Controls.Add(menuStrip1);
            pnlConteudo.Dock = DockStyle.Fill;
            pnlConteudo.Location = new Point(0, 0);
            pnlConteudo.Name = "pnlConteudo";
            pnlConteudo.Size = new Size(908, 646);
            pnlConteudo.TabIndex = 4213134;
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(747, 444);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(125, 27);
            txtBairro.TabIndex = 9;
            txtBairro.Validated += textBox_Validated;
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(522, 444);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(125, 27);
            txtCidade.TabIndex = 8;
            txtCidade.Validated += textBox_Validated;
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(288, 444);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(125, 27);
            txtEstado.TabIndex = 7;
            txtEstado.Validated += textBox_Validated;
            // 
            // lblBairro
            // 
            lblBairro.AutoSize = true;
            lblBairro.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBairro.Location = new Point(668, 442);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(58, 25);
            lblBairro.TabIndex = 4213143;
            lblBairro.Text = "Bairro";
            // 
            // lblCidade
            // 
            lblCidade.AutoSize = true;
            lblCidade.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCidade.Location = new Point(434, 442);
            lblCidade.Name = "lblCidade";
            lblCidade.Size = new Size(67, 25);
            lblCidade.TabIndex = 4213142;
            lblCidade.Text = "Cidade";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEstado.Location = new Point(201, 443);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(66, 25);
            lblEstado.TabIndex = 4213141;
            lblEstado.Text = "Estado";
            // 
            // lblNumero
            // 
            lblNumero.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblNumero.AutoSize = true;
            lblNumero.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumero.Location = new Point(468, 497);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(73, 23);
            lblNumero.TabIndex = 4213140;
            lblNumero.Text = "Número";
            // 
            // txtNumero
            // 
            txtNumero.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtNumero.Location = new Point(468, 523);
            txtNumero.MaxLength = 10;
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(87, 27);
            txtNumero.TabIndex = 11;
            txtNumero.Validated += textBox_Validated;
            // 
            // txtLogradouro
            // 
            txtLogradouro.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtLogradouro.Location = new Point(38, 523);
            txtLogradouro.MaxLength = 100;
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(388, 27);
            txtLogradouro.TabIndex = 10;
            txtLogradouro.Validated += textBox_Validated;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(38, 495);
            label1.Name = "label1";
            label1.Size = new Size(106, 25);
            label1.TabIndex = 4213137;
            label1.Text = "Logradouro";
            // 
            // mtxtCEP
            // 
            mtxtCEP.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mtxtCEP.Location = new Point(101, 442);
            mtxtCEP.Mask = "00000-000";
            mtxtCEP.Name = "mtxtCEP";
            mtxtCEP.Size = new Size(79, 30);
            mtxtCEP.TabIndex = 6;
            mtxtCEP.TextAlign = HorizontalAlignment.Center;
            mtxtCEP.KeyPress += txtNumero_KeyPress;
            mtxtCEP.Validated += maskedTextBox_Validated;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(38, 44);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(235, 35);
            lblTitulo.TabIndex = 4213135;
            lblTitulo.Text = "Cadastro de Pessoa";
            // 
            // mtxtTelefone
            // 
            mtxtTelefone.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mtxtTelefone.Location = new Point(38, 384);
            mtxtTelefone.Mask = "(00) 00000-0000";
            mtxtTelefone.Name = "mtxtTelefone";
            mtxtTelefone.Size = new Size(129, 30);
            mtxtTelefone.TabIndex = 5;
            mtxtTelefone.TextAlign = HorizontalAlignment.Center;
            mtxtTelefone.KeyPress += txtNumero_KeyPress;
            mtxtTelefone.Validated += maskedTextBox_Validated;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(908, 24);
            menuStrip1.TabIndex = 4213144;
            menuStrip1.Text = "menuStrip1";
            // 
            // panel1
            // 
            panel1.Controls.Add(menuStrip);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(908, 31);
            panel1.TabIndex = 4213135;
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { menuPrincipalToolStripMenuItem, sairToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(908, 28);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip1";
            // 
            // menuPrincipalToolStripMenuItem
            // 
            menuPrincipalToolStripMenuItem.Name = "menuPrincipalToolStripMenuItem";
            menuPrincipalToolStripMenuItem.Size = new Size(121, 24);
            menuPrincipalToolStripMenuItem.Text = "Menu Principal";
            menuPrincipalToolStripMenuItem.Click += menuPrincipalToolStripMenuItem_Click_1;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(48, 24);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(908, 646);
            Controls.Add(panel1);
            Controls.Add(pnlConteudo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip;
            MaximumSize = new Size(1432, 800);
            MinimumSize = new Size(926, 693);
            Name = "Cadastro";
            Text = "Cadastro";
            pnlConteudo.ResumeLayout(false);
            pnlConteudo.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label lblNome;
        private TextBox txtNome;
        private Label lblCEP;
        private RadioButton radFisica;
        private RadioButton radJuridica;
        private Label lblDocumento;
        private TextBox txtDocumento;
        private Label lblEmail;
        private Label lblTelefone;
        private TextBox txtEmail;
        private TextBox txtTelefone;
        private Button btnCadastrar;
        private Button btnLimparCampos;
        private Panel pnlConteudo;
        private Panel panel1;
        private MaskedTextBox mtxtTelefone;
        private Label lblTitulo;
        private Label label1;
        private MaskedTextBox mtxtCEP;
        private Label lblNumero;
        private TextBox txtNumero;
        private TextBox txtLogradouro;
        private TextBox txtBairro;
        private TextBox txtCidade;
        private TextBox txtEstado;
        private Label lblBairro;
        private Label lblCidade;
        private Label lblEstado;
        private MenuStrip menuStrip;
        private ToolStripMenuItem menuPrincipalToolStripMenuItem;
        private ErrorProvider errorProvider1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem sairToolStripMenuItem;
    }
}
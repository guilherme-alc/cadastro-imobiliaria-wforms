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
            lblEmail = new Label();
            lblTelefone = new Label();
            txtEmail = new TextBox();
            btnCadastrar = new Button();
            btnLimparCampos = new Button();
            pnlConteudo = new Panel();
            pictureBox1 = new PictureBox();
            mtxtDocumento = new MaskedTextBox();
            txtBairro = new TextBox();
            txtCidade = new TextBox();
            txtEstado = new TextBox();
            lblBairro = new Label();
            lblCidade = new Label();
            lblEstado = new Label();
            lblNumero = new Label();
            txtNumero = new TextBox();
            txtLogradouro = new TextBox();
            lblLogradouro = new Label();
            mtxtCEP = new MaskedTextBox();
            lblTitulo = new Label();
            mtxtTelefone = new MaskedTextBox();
            menuStrip1 = new MenuStrip();
            panel1 = new Panel();
            menuStrip = new MenuStrip();
            menuPrincipalToolStripMenuItem = new ToolStripMenuItem();
            pessoasToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            errorProvider1 = new ErrorProvider(components);
            pnlConteudo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblNome
            // 
            resources.ApplyResources(lblNome, "lblNome");
            errorProvider1.SetError(lblNome, resources.GetString("lblNome.Error"));
            errorProvider1.SetIconAlignment(lblNome, (ErrorIconAlignment)resources.GetObject("lblNome.IconAlignment"));
            errorProvider1.SetIconPadding(lblNome, (int)resources.GetObject("lblNome.IconPadding"));
            lblNome.Name = "lblNome";
            // 
            // txtNome
            // 
            resources.ApplyResources(txtNome, "txtNome");
            txtNome.BackColor = SystemColors.HighlightText;
            errorProvider1.SetError(txtNome, resources.GetString("txtNome.Error"));
            errorProvider1.SetIconAlignment(txtNome, (ErrorIconAlignment)resources.GetObject("txtNome.IconAlignment"));
            errorProvider1.SetIconPadding(txtNome, (int)resources.GetObject("txtNome.IconPadding"));
            txtNome.Name = "txtNome";
            txtNome.Validated += textBox_Validated;
            // 
            // lblCEP
            // 
            resources.ApplyResources(lblCEP, "lblCEP");
            errorProvider1.SetError(lblCEP, resources.GetString("lblCEP.Error"));
            errorProvider1.SetIconAlignment(lblCEP, (ErrorIconAlignment)resources.GetObject("lblCEP.IconAlignment"));
            errorProvider1.SetIconPadding(lblCEP, (int)resources.GetObject("lblCEP.IconPadding"));
            lblCEP.Name = "lblCEP";
            // 
            // radFisica
            // 
            resources.ApplyResources(radFisica, "radFisica");
            radFisica.Checked = true;
            errorProvider1.SetError(radFisica, resources.GetString("radFisica.Error"));
            errorProvider1.SetIconAlignment(radFisica, (ErrorIconAlignment)resources.GetObject("radFisica.IconAlignment"));
            errorProvider1.SetIconPadding(radFisica, (int)resources.GetObject("radFisica.IconPadding"));
            radFisica.Name = "radFisica";
            radFisica.TabStop = true;
            radFisica.UseVisualStyleBackColor = true;
            radFisica.CheckedChanged += radFisica_CheckedChanged;
            // 
            // radJuridica
            // 
            resources.ApplyResources(radJuridica, "radJuridica");
            errorProvider1.SetError(radJuridica, resources.GetString("radJuridica.Error"));
            errorProvider1.SetIconAlignment(radJuridica, (ErrorIconAlignment)resources.GetObject("radJuridica.IconAlignment"));
            errorProvider1.SetIconPadding(radJuridica, (int)resources.GetObject("radJuridica.IconPadding"));
            radJuridica.Name = "radJuridica";
            radJuridica.UseVisualStyleBackColor = true;
            radJuridica.CheckedChanged += radJuridica_CheckedChanged;
            // 
            // lblDocumento
            // 
            resources.ApplyResources(lblDocumento, "lblDocumento");
            errorProvider1.SetError(lblDocumento, resources.GetString("lblDocumento.Error"));
            errorProvider1.SetIconAlignment(lblDocumento, (ErrorIconAlignment)resources.GetObject("lblDocumento.IconAlignment"));
            errorProvider1.SetIconPadding(lblDocumento, (int)resources.GetObject("lblDocumento.IconPadding"));
            lblDocumento.Name = "lblDocumento";
            // 
            // lblEmail
            // 
            resources.ApplyResources(lblEmail, "lblEmail");
            errorProvider1.SetError(lblEmail, resources.GetString("lblEmail.Error"));
            errorProvider1.SetIconAlignment(lblEmail, (ErrorIconAlignment)resources.GetObject("lblEmail.IconAlignment"));
            errorProvider1.SetIconPadding(lblEmail, (int)resources.GetObject("lblEmail.IconPadding"));
            lblEmail.Name = "lblEmail";
            // 
            // lblTelefone
            // 
            resources.ApplyResources(lblTelefone, "lblTelefone");
            errorProvider1.SetError(lblTelefone, resources.GetString("lblTelefone.Error"));
            errorProvider1.SetIconAlignment(lblTelefone, (ErrorIconAlignment)resources.GetObject("lblTelefone.IconAlignment"));
            errorProvider1.SetIconPadding(lblTelefone, (int)resources.GetObject("lblTelefone.IconPadding"));
            lblTelefone.Name = "lblTelefone";
            // 
            // txtEmail
            // 
            resources.ApplyResources(txtEmail, "txtEmail");
            errorProvider1.SetError(txtEmail, resources.GetString("txtEmail.Error"));
            errorProvider1.SetIconAlignment(txtEmail, (ErrorIconAlignment)resources.GetObject("txtEmail.IconAlignment"));
            errorProvider1.SetIconPadding(txtEmail, (int)resources.GetObject("txtEmail.IconPadding"));
            txtEmail.Name = "txtEmail";
            txtEmail.Validated += textBox_Validated;
            // 
            // btnCadastrar
            // 
            resources.ApplyResources(btnCadastrar, "btnCadastrar");
            btnCadastrar.BackColor = Color.SteelBlue;
            errorProvider1.SetError(btnCadastrar, resources.GetString("btnCadastrar.Error"));
            btnCadastrar.ForeColor = Color.White;
            errorProvider1.SetIconAlignment(btnCadastrar, (ErrorIconAlignment)resources.GetObject("btnCadastrar.IconAlignment"));
            errorProvider1.SetIconPadding(btnCadastrar, (int)resources.GetObject("btnCadastrar.IconPadding"));
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnLimparCampos
            // 
            resources.ApplyResources(btnLimparCampos, "btnLimparCampos");
            btnLimparCampos.BackColor = Color.FromArgb(160, 0, 0);
            errorProvider1.SetError(btnLimparCampos, resources.GetString("btnLimparCampos.Error"));
            btnLimparCampos.ForeColor = SystemColors.MenuBar;
            errorProvider1.SetIconAlignment(btnLimparCampos, (ErrorIconAlignment)resources.GetObject("btnLimparCampos.IconAlignment"));
            errorProvider1.SetIconPadding(btnLimparCampos, (int)resources.GetObject("btnLimparCampos.IconPadding"));
            btnLimparCampos.Name = "btnLimparCampos";
            btnLimparCampos.UseVisualStyleBackColor = false;
            // 
            // pnlConteudo
            // 
            resources.ApplyResources(pnlConteudo, "pnlConteudo");
            pnlConteudo.BackColor = SystemColors.ControlLight;
            pnlConteudo.Controls.Add(pictureBox1);
            pnlConteudo.Controls.Add(mtxtDocumento);
            pnlConteudo.Controls.Add(txtBairro);
            pnlConteudo.Controls.Add(txtCidade);
            pnlConteudo.Controls.Add(txtEstado);
            pnlConteudo.Controls.Add(lblBairro);
            pnlConteudo.Controls.Add(lblCidade);
            pnlConteudo.Controls.Add(lblEstado);
            pnlConteudo.Controls.Add(lblNumero);
            pnlConteudo.Controls.Add(txtNumero);
            pnlConteudo.Controls.Add(txtLogradouro);
            pnlConteudo.Controls.Add(lblLogradouro);
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
            pnlConteudo.Controls.Add(radFisica);
            pnlConteudo.Controls.Add(lblDocumento);
            pnlConteudo.Controls.Add(radJuridica);
            pnlConteudo.Controls.Add(menuStrip1);
            errorProvider1.SetError(pnlConteudo, resources.GetString("pnlConteudo.Error"));
            errorProvider1.SetIconAlignment(pnlConteudo, (ErrorIconAlignment)resources.GetObject("pnlConteudo.IconAlignment"));
            errorProvider1.SetIconPadding(pnlConteudo, (int)resources.GetObject("pnlConteudo.IconPadding"));
            pnlConteudo.Name = "pnlConteudo";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            errorProvider1.SetError(pictureBox1, resources.GetString("pictureBox1.Error"));
            errorProvider1.SetIconAlignment(pictureBox1, (ErrorIconAlignment)resources.GetObject("pictureBox1.IconAlignment"));
            errorProvider1.SetIconPadding(pictureBox1, (int)resources.GetObject("pictureBox1.IconPadding"));
            pictureBox1.Image = Properties.Resources.group_banner;
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // mtxtDocumento
            // 
            resources.ApplyResources(mtxtDocumento, "mtxtDocumento");
            errorProvider1.SetError(mtxtDocumento, resources.GetString("mtxtDocumento.Error"));
            errorProvider1.SetIconAlignment(mtxtDocumento, (ErrorIconAlignment)resources.GetObject("mtxtDocumento.IconAlignment"));
            errorProvider1.SetIconPadding(mtxtDocumento, (int)resources.GetObject("mtxtDocumento.IconPadding"));
            mtxtDocumento.Name = "mtxtDocumento";
            mtxtDocumento.Validated += maskedTextBox_Validated;
            // 
            // txtBairro
            // 
            resources.ApplyResources(txtBairro, "txtBairro");
            errorProvider1.SetError(txtBairro, resources.GetString("txtBairro.Error"));
            errorProvider1.SetIconAlignment(txtBairro, (ErrorIconAlignment)resources.GetObject("txtBairro.IconAlignment"));
            errorProvider1.SetIconPadding(txtBairro, (int)resources.GetObject("txtBairro.IconPadding"));
            txtBairro.Name = "txtBairro";
            txtBairro.Validated += textBox_Validated;
            // 
            // txtCidade
            // 
            resources.ApplyResources(txtCidade, "txtCidade");
            errorProvider1.SetError(txtCidade, resources.GetString("txtCidade.Error"));
            errorProvider1.SetIconAlignment(txtCidade, (ErrorIconAlignment)resources.GetObject("txtCidade.IconAlignment"));
            errorProvider1.SetIconPadding(txtCidade, (int)resources.GetObject("txtCidade.IconPadding"));
            txtCidade.Name = "txtCidade";
            txtCidade.Validated += textBox_Validated;
            // 
            // txtEstado
            // 
            resources.ApplyResources(txtEstado, "txtEstado");
            errorProvider1.SetError(txtEstado, resources.GetString("txtEstado.Error"));
            errorProvider1.SetIconAlignment(txtEstado, (ErrorIconAlignment)resources.GetObject("txtEstado.IconAlignment"));
            errorProvider1.SetIconPadding(txtEstado, (int)resources.GetObject("txtEstado.IconPadding"));
            txtEstado.Name = "txtEstado";
            txtEstado.Validated += textBox_Validated;
            // 
            // lblBairro
            // 
            resources.ApplyResources(lblBairro, "lblBairro");
            errorProvider1.SetError(lblBairro, resources.GetString("lblBairro.Error"));
            errorProvider1.SetIconAlignment(lblBairro, (ErrorIconAlignment)resources.GetObject("lblBairro.IconAlignment"));
            errorProvider1.SetIconPadding(lblBairro, (int)resources.GetObject("lblBairro.IconPadding"));
            lblBairro.Name = "lblBairro";
            // 
            // lblCidade
            // 
            resources.ApplyResources(lblCidade, "lblCidade");
            errorProvider1.SetError(lblCidade, resources.GetString("lblCidade.Error"));
            errorProvider1.SetIconAlignment(lblCidade, (ErrorIconAlignment)resources.GetObject("lblCidade.IconAlignment"));
            errorProvider1.SetIconPadding(lblCidade, (int)resources.GetObject("lblCidade.IconPadding"));
            lblCidade.Name = "lblCidade";
            // 
            // lblEstado
            // 
            resources.ApplyResources(lblEstado, "lblEstado");
            errorProvider1.SetError(lblEstado, resources.GetString("lblEstado.Error"));
            errorProvider1.SetIconAlignment(lblEstado, (ErrorIconAlignment)resources.GetObject("lblEstado.IconAlignment"));
            errorProvider1.SetIconPadding(lblEstado, (int)resources.GetObject("lblEstado.IconPadding"));
            lblEstado.Name = "lblEstado";
            // 
            // lblNumero
            // 
            resources.ApplyResources(lblNumero, "lblNumero");
            errorProvider1.SetError(lblNumero, resources.GetString("lblNumero.Error"));
            errorProvider1.SetIconAlignment(lblNumero, (ErrorIconAlignment)resources.GetObject("lblNumero.IconAlignment"));
            errorProvider1.SetIconPadding(lblNumero, (int)resources.GetObject("lblNumero.IconPadding"));
            lblNumero.Name = "lblNumero";
            // 
            // txtNumero
            // 
            resources.ApplyResources(txtNumero, "txtNumero");
            errorProvider1.SetError(txtNumero, resources.GetString("txtNumero.Error"));
            errorProvider1.SetIconAlignment(txtNumero, (ErrorIconAlignment)resources.GetObject("txtNumero.IconAlignment"));
            errorProvider1.SetIconPadding(txtNumero, (int)resources.GetObject("txtNumero.IconPadding"));
            txtNumero.Name = "txtNumero";
            txtNumero.Validated += textBox_Validated;
            // 
            // txtLogradouro
            // 
            resources.ApplyResources(txtLogradouro, "txtLogradouro");
            errorProvider1.SetError(txtLogradouro, resources.GetString("txtLogradouro.Error"));
            errorProvider1.SetIconAlignment(txtLogradouro, (ErrorIconAlignment)resources.GetObject("txtLogradouro.IconAlignment"));
            errorProvider1.SetIconPadding(txtLogradouro, (int)resources.GetObject("txtLogradouro.IconPadding"));
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Validated += textBox_Validated;
            // 
            // lblLogradouro
            // 
            resources.ApplyResources(lblLogradouro, "lblLogradouro");
            errorProvider1.SetError(lblLogradouro, resources.GetString("lblLogradouro.Error"));
            errorProvider1.SetIconAlignment(lblLogradouro, (ErrorIconAlignment)resources.GetObject("lblLogradouro.IconAlignment"));
            errorProvider1.SetIconPadding(lblLogradouro, (int)resources.GetObject("lblLogradouro.IconPadding"));
            lblLogradouro.Name = "lblLogradouro";
            // 
            // mtxtCEP
            // 
            resources.ApplyResources(mtxtCEP, "mtxtCEP");
            errorProvider1.SetError(mtxtCEP, resources.GetString("mtxtCEP.Error"));
            errorProvider1.SetIconAlignment(mtxtCEP, (ErrorIconAlignment)resources.GetObject("mtxtCEP.IconAlignment"));
            errorProvider1.SetIconPadding(mtxtCEP, (int)resources.GetObject("mtxtCEP.IconPadding"));
            mtxtCEP.Name = "mtxtCEP";
            mtxtCEP.Validated += maskedTextBox_Validated;
            // 
            // lblTitulo
            // 
            resources.ApplyResources(lblTitulo, "lblTitulo");
            errorProvider1.SetError(lblTitulo, resources.GetString("lblTitulo.Error"));
            lblTitulo.ForeColor = Color.Black;
            errorProvider1.SetIconAlignment(lblTitulo, (ErrorIconAlignment)resources.GetObject("lblTitulo.IconAlignment"));
            errorProvider1.SetIconPadding(lblTitulo, (int)resources.GetObject("lblTitulo.IconPadding"));
            lblTitulo.Name = "lblTitulo";
            // 
            // mtxtTelefone
            // 
            resources.ApplyResources(mtxtTelefone, "mtxtTelefone");
            errorProvider1.SetError(mtxtTelefone, resources.GetString("mtxtTelefone.Error"));
            errorProvider1.SetIconAlignment(mtxtTelefone, (ErrorIconAlignment)resources.GetObject("mtxtTelefone.IconAlignment"));
            errorProvider1.SetIconPadding(mtxtTelefone, (int)resources.GetObject("mtxtTelefone.IconPadding"));
            mtxtTelefone.Name = "mtxtTelefone";
            mtxtTelefone.Validated += maskedTextBox_Validated;
            // 
            // menuStrip1
            // 
            resources.ApplyResources(menuStrip1, "menuStrip1");
            errorProvider1.SetError(menuStrip1, resources.GetString("menuStrip1.Error"));
            errorProvider1.SetIconAlignment(menuStrip1, (ErrorIconAlignment)resources.GetObject("menuStrip1.IconAlignment"));
            errorProvider1.SetIconPadding(menuStrip1, (int)resources.GetObject("menuStrip1.IconPadding"));
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Name = "menuStrip1";
            // 
            // panel1
            // 
            resources.ApplyResources(panel1, "panel1");
            panel1.Controls.Add(menuStrip);
            errorProvider1.SetError(panel1, resources.GetString("panel1.Error"));
            errorProvider1.SetIconAlignment(panel1, (ErrorIconAlignment)resources.GetObject("panel1.IconAlignment"));
            errorProvider1.SetIconPadding(panel1, (int)resources.GetObject("panel1.IconPadding"));
            panel1.Name = "panel1";
            // 
            // menuStrip
            // 
            resources.ApplyResources(menuStrip, "menuStrip");
            menuStrip.BackColor = Color.SteelBlue;
            errorProvider1.SetError(menuStrip, resources.GetString("menuStrip.Error"));
            errorProvider1.SetIconAlignment(menuStrip, (ErrorIconAlignment)resources.GetObject("menuStrip.IconAlignment"));
            errorProvider1.SetIconPadding(menuStrip, (int)resources.GetObject("menuStrip.IconPadding"));
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { menuPrincipalToolStripMenuItem, pessoasToolStripMenuItem, sairToolStripMenuItem });
            menuStrip.Name = "menuStrip";
            // 
            // menuPrincipalToolStripMenuItem
            // 
            resources.ApplyResources(menuPrincipalToolStripMenuItem, "menuPrincipalToolStripMenuItem");
            menuPrincipalToolStripMenuItem.Name = "menuPrincipalToolStripMenuItem";
            menuPrincipalToolStripMenuItem.Click += menuPrincipalToolStripMenuItem_Click_1;
            // 
            // pessoasToolStripMenuItem
            // 
            resources.ApplyResources(pessoasToolStripMenuItem, "pessoasToolStripMenuItem");
            pessoasToolStripMenuItem.Name = "pessoasToolStripMenuItem";
            pessoasToolStripMenuItem.Click += pessoasToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem
            // 
            resources.ApplyResources(sairToolStripMenuItem, "sairToolStripMenuItem");
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            resources.ApplyResources(errorProvider1, "errorProvider1");
            // 
            // Cadastro
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(pnlConteudo);
            MainMenuStrip = menuStrip;
            Name = "Cadastro";
            pnlConteudo.ResumeLayout(false);
            pnlConteudo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Label lblLogradouro;
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
        private MaskedTextBox mtxtDocumento;
        private ToolStripMenuItem pessoasToolStripMenuItem;
        private PictureBox pictureBox1;
    }
}
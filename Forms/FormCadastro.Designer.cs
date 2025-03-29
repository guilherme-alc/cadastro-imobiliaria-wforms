namespace CadastroImobiliaria
{
    partial class FormCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastro));
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
            grupoEndereco = new GroupBox();
            mtxtCEP = new MaskedTextBox();
            txtBairro = new TextBox();
            lblLogradouro = new Label();
            txtCidade = new TextBox();
            txtLogradouro = new TextBox();
            txtEstado = new TextBox();
            txtNumero = new TextBox();
            lblBairro = new Label();
            lblNumero = new Label();
            lblCidade = new Label();
            lblEstado = new Label();
            grupoDadosPessoais = new GroupBox();
            lblRadError = new Label();
            mtxtDocumento = new MaskedTextBox();
            mtxtTelefone = new MaskedTextBox();
            lblTitulo = new Label();
            errorProvider = new ErrorProvider(components);
            pnlConteudo.SuspendLayout();
            grupoEndereco.SuspendLayout();
            grupoDadosPessoais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // lblNome
            // 
            resources.ApplyResources(lblNome, "lblNome");
            errorProvider.SetError(lblNome, resources.GetString("lblNome.Error"));
            errorProvider.SetIconAlignment(lblNome, (ErrorIconAlignment)resources.GetObject("lblNome.IconAlignment"));
            errorProvider.SetIconPadding(lblNome, (int)resources.GetObject("lblNome.IconPadding"));
            lblNome.Name = "lblNome";
            // 
            // txtNome
            // 
            resources.ApplyResources(txtNome, "txtNome");
            txtNome.BackColor = SystemColors.HighlightText;
            errorProvider.SetError(txtNome, resources.GetString("txtNome.Error"));
            errorProvider.SetIconAlignment(txtNome, (ErrorIconAlignment)resources.GetObject("txtNome.IconAlignment"));
            errorProvider.SetIconPadding(txtNome, (int)resources.GetObject("txtNome.IconPadding"));
            txtNome.Name = "txtNome";
            txtNome.Validated += ValidaCamposTexto;
            // 
            // lblCEP
            // 
            resources.ApplyResources(lblCEP, "lblCEP");
            errorProvider.SetError(lblCEP, resources.GetString("lblCEP.Error"));
            errorProvider.SetIconAlignment(lblCEP, (ErrorIconAlignment)resources.GetObject("lblCEP.IconAlignment"));
            errorProvider.SetIconPadding(lblCEP, (int)resources.GetObject("lblCEP.IconPadding"));
            lblCEP.Name = "lblCEP";
            // 
            // radFisica
            // 
            resources.ApplyResources(radFisica, "radFisica");
            errorProvider.SetError(radFisica, resources.GetString("radFisica.Error"));
            errorProvider.SetIconAlignment(radFisica, (ErrorIconAlignment)resources.GetObject("radFisica.IconAlignment"));
            errorProvider.SetIconPadding(radFisica, (int)resources.GetObject("radFisica.IconPadding"));
            radFisica.Name = "radFisica";
            radFisica.UseVisualStyleBackColor = true;
            radFisica.CheckedChanged += RadBtnFisicaAlterado;
            // 
            // radJuridica
            // 
            resources.ApplyResources(radJuridica, "radJuridica");
            errorProvider.SetError(radJuridica, resources.GetString("radJuridica.Error"));
            errorProvider.SetIconAlignment(radJuridica, (ErrorIconAlignment)resources.GetObject("radJuridica.IconAlignment"));
            errorProvider.SetIconPadding(radJuridica, (int)resources.GetObject("radJuridica.IconPadding"));
            radJuridica.Name = "radJuridica";
            radJuridica.UseVisualStyleBackColor = true;
            radJuridica.CheckedChanged += RadBtnJuridicaAlterado;
            // 
            // lblDocumento
            // 
            resources.ApplyResources(lblDocumento, "lblDocumento");
            errorProvider.SetError(lblDocumento, resources.GetString("lblDocumento.Error"));
            errorProvider.SetIconAlignment(lblDocumento, (ErrorIconAlignment)resources.GetObject("lblDocumento.IconAlignment"));
            errorProvider.SetIconPadding(lblDocumento, (int)resources.GetObject("lblDocumento.IconPadding"));
            lblDocumento.Name = "lblDocumento";
            // 
            // lblEmail
            // 
            resources.ApplyResources(lblEmail, "lblEmail");
            errorProvider.SetError(lblEmail, resources.GetString("lblEmail.Error"));
            errorProvider.SetIconAlignment(lblEmail, (ErrorIconAlignment)resources.GetObject("lblEmail.IconAlignment"));
            errorProvider.SetIconPadding(lblEmail, (int)resources.GetObject("lblEmail.IconPadding"));
            lblEmail.Name = "lblEmail";
            // 
            // lblTelefone
            // 
            resources.ApplyResources(lblTelefone, "lblTelefone");
            errorProvider.SetError(lblTelefone, resources.GetString("lblTelefone.Error"));
            errorProvider.SetIconAlignment(lblTelefone, (ErrorIconAlignment)resources.GetObject("lblTelefone.IconAlignment"));
            errorProvider.SetIconPadding(lblTelefone, (int)resources.GetObject("lblTelefone.IconPadding"));
            lblTelefone.Name = "lblTelefone";
            // 
            // txtEmail
            // 
            resources.ApplyResources(txtEmail, "txtEmail");
            errorProvider.SetError(txtEmail, resources.GetString("txtEmail.Error"));
            errorProvider.SetIconAlignment(txtEmail, (ErrorIconAlignment)resources.GetObject("txtEmail.IconAlignment"));
            errorProvider.SetIconPadding(txtEmail, (int)resources.GetObject("txtEmail.IconPadding"));
            txtEmail.Name = "txtEmail";
            txtEmail.Validated += ValidaCamposTexto;
            // 
            // btnCadastrar
            // 
            resources.ApplyResources(btnCadastrar, "btnCadastrar");
            btnCadastrar.BackColor = Color.FromArgb(155, 0, 70);
            errorProvider.SetError(btnCadastrar, resources.GetString("btnCadastrar.Error"));
            btnCadastrar.ForeColor = Color.White;
            errorProvider.SetIconAlignment(btnCadastrar, (ErrorIconAlignment)resources.GetObject("btnCadastrar.IconAlignment"));
            errorProvider.SetIconPadding(btnCadastrar, (int)resources.GetObject("btnCadastrar.IconPadding"));
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += BotaoCadastrar;
            // 
            // btnLimparCampos
            // 
            resources.ApplyResources(btnLimparCampos, "btnLimparCampos");
            btnLimparCampos.BackColor = Color.FromArgb(160, 0, 0);
            errorProvider.SetError(btnLimparCampos, resources.GetString("btnLimparCampos.Error"));
            btnLimparCampos.ForeColor = SystemColors.MenuBar;
            errorProvider.SetIconAlignment(btnLimparCampos, (ErrorIconAlignment)resources.GetObject("btnLimparCampos.IconAlignment"));
            errorProvider.SetIconPadding(btnLimparCampos, (int)resources.GetObject("btnLimparCampos.IconPadding"));
            btnLimparCampos.Name = "btnLimparCampos";
            btnLimparCampos.UseVisualStyleBackColor = false;
            btnLimparCampos.Click += BotaoLimparCampos;
            // 
            // pnlConteudo
            // 
            resources.ApplyResources(pnlConteudo, "pnlConteudo");
            pnlConteudo.BackColor = SystemColors.ControlLight;
            pnlConteudo.Controls.Add(grupoEndereco);
            pnlConteudo.Controls.Add(grupoDadosPessoais);
            pnlConteudo.Controls.Add(lblTitulo);
            pnlConteudo.Controls.Add(btnLimparCampos);
            pnlConteudo.Controls.Add(btnCadastrar);
            errorProvider.SetError(pnlConteudo, resources.GetString("pnlConteudo.Error"));
            errorProvider.SetIconAlignment(pnlConteudo, (ErrorIconAlignment)resources.GetObject("pnlConteudo.IconAlignment"));
            errorProvider.SetIconPadding(pnlConteudo, (int)resources.GetObject("pnlConteudo.IconPadding"));
            pnlConteudo.Name = "pnlConteudo";
            // 
            // grupoEndereco
            // 
            resources.ApplyResources(grupoEndereco, "grupoEndereco");
            grupoEndereco.Controls.Add(lblCEP);
            grupoEndereco.Controls.Add(mtxtCEP);
            grupoEndereco.Controls.Add(txtBairro);
            grupoEndereco.Controls.Add(lblLogradouro);
            grupoEndereco.Controls.Add(txtCidade);
            grupoEndereco.Controls.Add(txtLogradouro);
            grupoEndereco.Controls.Add(txtEstado);
            grupoEndereco.Controls.Add(txtNumero);
            grupoEndereco.Controls.Add(lblBairro);
            grupoEndereco.Controls.Add(lblNumero);
            grupoEndereco.Controls.Add(lblCidade);
            grupoEndereco.Controls.Add(lblEstado);
            errorProvider.SetError(grupoEndereco, resources.GetString("grupoEndereco.Error"));
            errorProvider.SetIconAlignment(grupoEndereco, (ErrorIconAlignment)resources.GetObject("grupoEndereco.IconAlignment"));
            errorProvider.SetIconPadding(grupoEndereco, (int)resources.GetObject("grupoEndereco.IconPadding"));
            grupoEndereco.Name = "grupoEndereco";
            grupoEndereco.TabStop = false;
            // 
            // mtxtCEP
            // 
            resources.ApplyResources(mtxtCEP, "mtxtCEP");
            errorProvider.SetError(mtxtCEP, resources.GetString("mtxtCEP.Error"));
            errorProvider.SetIconAlignment(mtxtCEP, (ErrorIconAlignment)resources.GetObject("mtxtCEP.IconAlignment"));
            errorProvider.SetIconPadding(mtxtCEP, (int)resources.GetObject("mtxtCEP.IconPadding"));
            mtxtCEP.Name = "mtxtCEP";
            mtxtCEP.Leave += BuscaEndereco;
            mtxtCEP.Validated += ValidaCamposMascara;
            // 
            // txtBairro
            // 
            resources.ApplyResources(txtBairro, "txtBairro");
            errorProvider.SetError(txtBairro, resources.GetString("txtBairro.Error"));
            errorProvider.SetIconAlignment(txtBairro, (ErrorIconAlignment)resources.GetObject("txtBairro.IconAlignment"));
            errorProvider.SetIconPadding(txtBairro, (int)resources.GetObject("txtBairro.IconPadding"));
            txtBairro.Name = "txtBairro";
            txtBairro.Validated += ValidaCamposTexto;
            // 
            // lblLogradouro
            // 
            resources.ApplyResources(lblLogradouro, "lblLogradouro");
            errorProvider.SetError(lblLogradouro, resources.GetString("lblLogradouro.Error"));
            errorProvider.SetIconAlignment(lblLogradouro, (ErrorIconAlignment)resources.GetObject("lblLogradouro.IconAlignment"));
            errorProvider.SetIconPadding(lblLogradouro, (int)resources.GetObject("lblLogradouro.IconPadding"));
            lblLogradouro.Name = "lblLogradouro";
            // 
            // txtCidade
            // 
            resources.ApplyResources(txtCidade, "txtCidade");
            errorProvider.SetError(txtCidade, resources.GetString("txtCidade.Error"));
            errorProvider.SetIconAlignment(txtCidade, (ErrorIconAlignment)resources.GetObject("txtCidade.IconAlignment"));
            errorProvider.SetIconPadding(txtCidade, (int)resources.GetObject("txtCidade.IconPadding"));
            txtCidade.Name = "txtCidade";
            txtCidade.Validated += ValidaCamposTexto;
            // 
            // txtLogradouro
            // 
            resources.ApplyResources(txtLogradouro, "txtLogradouro");
            errorProvider.SetError(txtLogradouro, resources.GetString("txtLogradouro.Error"));
            errorProvider.SetIconAlignment(txtLogradouro, (ErrorIconAlignment)resources.GetObject("txtLogradouro.IconAlignment"));
            errorProvider.SetIconPadding(txtLogradouro, (int)resources.GetObject("txtLogradouro.IconPadding"));
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Validated += ValidaCamposTexto;
            // 
            // txtEstado
            // 
            resources.ApplyResources(txtEstado, "txtEstado");
            errorProvider.SetError(txtEstado, resources.GetString("txtEstado.Error"));
            errorProvider.SetIconAlignment(txtEstado, (ErrorIconAlignment)resources.GetObject("txtEstado.IconAlignment"));
            errorProvider.SetIconPadding(txtEstado, (int)resources.GetObject("txtEstado.IconPadding"));
            txtEstado.Name = "txtEstado";
            txtEstado.Validated += ValidaCamposTexto;
            // 
            // txtNumero
            // 
            resources.ApplyResources(txtNumero, "txtNumero");
            errorProvider.SetError(txtNumero, resources.GetString("txtNumero.Error"));
            errorProvider.SetIconAlignment(txtNumero, (ErrorIconAlignment)resources.GetObject("txtNumero.IconAlignment"));
            errorProvider.SetIconPadding(txtNumero, (int)resources.GetObject("txtNumero.IconPadding"));
            txtNumero.Name = "txtNumero";
            txtNumero.Validated += ValidaCamposTexto;
            // 
            // lblBairro
            // 
            resources.ApplyResources(lblBairro, "lblBairro");
            errorProvider.SetError(lblBairro, resources.GetString("lblBairro.Error"));
            errorProvider.SetIconAlignment(lblBairro, (ErrorIconAlignment)resources.GetObject("lblBairro.IconAlignment"));
            errorProvider.SetIconPadding(lblBairro, (int)resources.GetObject("lblBairro.IconPadding"));
            lblBairro.Name = "lblBairro";
            // 
            // lblNumero
            // 
            resources.ApplyResources(lblNumero, "lblNumero");
            errorProvider.SetError(lblNumero, resources.GetString("lblNumero.Error"));
            errorProvider.SetIconAlignment(lblNumero, (ErrorIconAlignment)resources.GetObject("lblNumero.IconAlignment"));
            errorProvider.SetIconPadding(lblNumero, (int)resources.GetObject("lblNumero.IconPadding"));
            lblNumero.Name = "lblNumero";
            // 
            // lblCidade
            // 
            resources.ApplyResources(lblCidade, "lblCidade");
            errorProvider.SetError(lblCidade, resources.GetString("lblCidade.Error"));
            errorProvider.SetIconAlignment(lblCidade, (ErrorIconAlignment)resources.GetObject("lblCidade.IconAlignment"));
            errorProvider.SetIconPadding(lblCidade, (int)resources.GetObject("lblCidade.IconPadding"));
            lblCidade.Name = "lblCidade";
            // 
            // lblEstado
            // 
            resources.ApplyResources(lblEstado, "lblEstado");
            errorProvider.SetError(lblEstado, resources.GetString("lblEstado.Error"));
            errorProvider.SetIconAlignment(lblEstado, (ErrorIconAlignment)resources.GetObject("lblEstado.IconAlignment"));
            errorProvider.SetIconPadding(lblEstado, (int)resources.GetObject("lblEstado.IconPadding"));
            lblEstado.Name = "lblEstado";
            // 
            // grupoDadosPessoais
            // 
            resources.ApplyResources(grupoDadosPessoais, "grupoDadosPessoais");
            grupoDadosPessoais.Controls.Add(lblNome);
            grupoDadosPessoais.Controls.Add(lblRadError);
            grupoDadosPessoais.Controls.Add(radJuridica);
            grupoDadosPessoais.Controls.Add(mtxtDocumento);
            grupoDadosPessoais.Controls.Add(lblDocumento);
            grupoDadosPessoais.Controls.Add(radFisica);
            grupoDadosPessoais.Controls.Add(lblEmail);
            grupoDadosPessoais.Controls.Add(lblTelefone);
            grupoDadosPessoais.Controls.Add(txtNome);
            grupoDadosPessoais.Controls.Add(txtEmail);
            grupoDadosPessoais.Controls.Add(mtxtTelefone);
            errorProvider.SetError(grupoDadosPessoais, resources.GetString("grupoDadosPessoais.Error"));
            errorProvider.SetIconAlignment(grupoDadosPessoais, (ErrorIconAlignment)resources.GetObject("grupoDadosPessoais.IconAlignment"));
            errorProvider.SetIconPadding(grupoDadosPessoais, (int)resources.GetObject("grupoDadosPessoais.IconPadding"));
            grupoDadosPessoais.Name = "grupoDadosPessoais";
            grupoDadosPessoais.TabStop = false;
            // 
            // lblRadError
            // 
            resources.ApplyResources(lblRadError, "lblRadError");
            errorProvider.SetError(lblRadError, resources.GetString("lblRadError.Error"));
            lblRadError.ForeColor = Color.Red;
            errorProvider.SetIconAlignment(lblRadError, (ErrorIconAlignment)resources.GetObject("lblRadError.IconAlignment"));
            errorProvider.SetIconPadding(lblRadError, (int)resources.GetObject("lblRadError.IconPadding"));
            lblRadError.Name = "lblRadError";
            // 
            // mtxtDocumento
            // 
            resources.ApplyResources(mtxtDocumento, "mtxtDocumento");
            errorProvider.SetError(mtxtDocumento, resources.GetString("mtxtDocumento.Error"));
            errorProvider.SetIconAlignment(mtxtDocumento, (ErrorIconAlignment)resources.GetObject("mtxtDocumento.IconAlignment"));
            errorProvider.SetIconPadding(mtxtDocumento, (int)resources.GetObject("mtxtDocumento.IconPadding"));
            mtxtDocumento.Name = "mtxtDocumento";
            mtxtDocumento.Validated += ValidaCamposMascara;
            // 
            // mtxtTelefone
            // 
            resources.ApplyResources(mtxtTelefone, "mtxtTelefone");
            errorProvider.SetError(mtxtTelefone, resources.GetString("mtxtTelefone.Error"));
            errorProvider.SetIconAlignment(mtxtTelefone, (ErrorIconAlignment)resources.GetObject("mtxtTelefone.IconAlignment"));
            errorProvider.SetIconPadding(mtxtTelefone, (int)resources.GetObject("mtxtTelefone.IconPadding"));
            mtxtTelefone.Name = "mtxtTelefone";
            mtxtTelefone.Validated += ValidaCamposMascara;
            // 
            // lblTitulo
            // 
            resources.ApplyResources(lblTitulo, "lblTitulo");
            errorProvider.SetError(lblTitulo, resources.GetString("lblTitulo.Error"));
            lblTitulo.ForeColor = Color.Black;
            errorProvider.SetIconAlignment(lblTitulo, (ErrorIconAlignment)resources.GetObject("lblTitulo.IconAlignment"));
            errorProvider.SetIconPadding(lblTitulo, (int)resources.GetObject("lblTitulo.IconPadding"));
            lblTitulo.Name = "lblTitulo";
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            resources.ApplyResources(errorProvider, "errorProvider");
            // 
            // FormCadastro
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlConteudo);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "FormCadastro";
            Load += CarregaFormularioCadastro;
            pnlConteudo.ResumeLayout(false);
            pnlConteudo.PerformLayout();
            grupoEndereco.ResumeLayout(false);
            grupoEndereco.PerformLayout();
            grupoDadosPessoais.ResumeLayout(false);
            grupoDadosPessoais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
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
        private ErrorProvider errorProvider;
        private MaskedTextBox mtxtDocumento;
        private Label lblRadError;
        private GroupBox grupoEndereco;
        private GroupBox grupoDadosPessoais;
    }
}
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
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPessoas).BeginInit();
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
            menuStrip1.Size = new Size(796, 25);
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
            dgvPessoas.BackgroundColor = SystemColors.GradientActiveCaption;
            dgvPessoas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPessoas.Location = new Point(0, 123);
            dgvPessoas.Margin = new Padding(3, 2, 3, 2);
            dgvPessoas.Name = "dgvPessoas";
            dgvPessoas.RowHeadersWidth = 51;
            dgvPessoas.Size = new Size(796, 186);
            dgvPessoas.TabIndex = 2;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Location = new Point(16, 91);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(243, 23);
            txtPesquisa.TabIndex = 3;
            // 
            // btnPesquisa
            // 
            btnPesquisa.BackColor = Color.FromArgb(155, 0, 70);
            btnPesquisa.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPesquisa.ForeColor = Color.White;
            btnPesquisa.Location = new Point(279, 87);
            btnPesquisa.Name = "btnPesquisa";
            btnPesquisa.Size = new Size(89, 31);
            btnPesquisa.TabIndex = 4;
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
            btnSalvar.BackColor = Color.FromArgb(155, 0, 70);
            btnSalvar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Location = new Point(682, 453);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(102, 40);
            btnSalvar.TabIndex = 7;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            // 
            // ListaPessoas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(796, 505);
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
            MaximumSize = new Size(1255, 610);
            MinimumSize = new Size(812, 544);
            Name = "ListaPessoas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pessoas";
            Load += ListaPessoas_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPessoas).EndInit();
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
    }
}
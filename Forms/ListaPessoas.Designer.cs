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
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPessoas).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(155, 0, 70);
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
            dgvPessoas.Location = new Point(0, 57);
            dgvPessoas.Margin = new Padding(3, 2, 3, 2);
            dgvPessoas.Name = "dgvPessoas";
            dgvPessoas.RowHeadersWidth = 51;
            dgvPessoas.Size = new Size(796, 141);
            dgvPessoas.TabIndex = 2;
            // 
            // ListaPessoas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(796, 505);
            Controls.Add(dgvPessoas);
            Controls.Add(menuStrip1);
            ForeColor = SystemColors.Control;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
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
    }
}
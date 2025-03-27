namespace CadastroImobiliaria
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            menuHeader = new MenuStrip();
            cadastrarMenuItem = new ToolStripMenuItem();
            registrosMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            picGroupLogo = new PictureBox();
            menuHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picGroupLogo).BeginInit();
            SuspendLayout();
            // 
            // menuHeader
            // 
            resources.ApplyResources(menuHeader, "menuHeader");
            menuHeader.BackColor = Color.SteelBlue;
            menuHeader.ImageScalingSize = new Size(20, 20);
            menuHeader.Items.AddRange(new ToolStripItem[] { cadastrarMenuItem, registrosMenuItem, sairToolStripMenuItem });
            menuHeader.Name = "menuHeader";
            // 
            // cadastrarMenuItem
            // 
            resources.ApplyResources(cadastrarMenuItem, "cadastrarMenuItem");
            cadastrarMenuItem.ForeColor = SystemColors.Control;
            cadastrarMenuItem.Name = "cadastrarMenuItem";
            cadastrarMenuItem.Click += MenuItemCadastrar;
            // 
            // registrosMenuItem
            // 
            resources.ApplyResources(registrosMenuItem, "registrosMenuItem");
            registrosMenuItem.ForeColor = SystemColors.Control;
            registrosMenuItem.Name = "registrosMenuItem";
            registrosMenuItem.Click += MenuItemPessoas;
            // 
            // sairToolStripMenuItem
            // 
            resources.ApplyResources(sairToolStripMenuItem, "sairToolStripMenuItem");
            sairToolStripMenuItem.ForeColor = SystemColors.Control;
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Click += MenuItemSair;
            // 
            // picGroupLogo
            // 
            resources.ApplyResources(picGroupLogo, "picGroupLogo");
            picGroupLogo.BackColor = Color.WhiteSmoke;
            picGroupLogo.Image = Properties.Resources.group_banner;
            picGroupLogo.Name = "picGroupLogo";
            picGroupLogo.TabStop = false;
            // 
            // Principal
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            Controls.Add(picGroupLogo);
            Controls.Add(menuHeader);
            IsMdiContainer = true;
            MainMenuStrip = menuHeader;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Principal";
            WindowState = FormWindowState.Maximized;
            Load += CarregaFormularioPrincipal;
            menuHeader.ResumeLayout(false);
            menuHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picGroupLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuHeader;
        private ToolStripMenuItem cadastrarMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem registrosMenuItem;
        private PictureBox picGroupLogo;
    }
}

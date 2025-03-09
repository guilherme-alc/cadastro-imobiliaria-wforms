namespace CadastroImobiliaria
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            menuHeader = new MenuStrip();
            cadastroToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            picGroupLogo = new PictureBox();
            menuHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picGroupLogo).BeginInit();
            SuspendLayout();
            // 
            // menuHeader
            // 
            resources.ApplyResources(menuHeader, "menuHeader");
            menuHeader.ImageScalingSize = new Size(20, 20);
            menuHeader.Items.AddRange(new ToolStripItem[] { cadastroToolStripMenuItem, clientesToolStripMenuItem, sairToolStripMenuItem });
            menuHeader.Name = "menuHeader";
            // 
            // cadastroToolStripMenuItem
            // 
            resources.ApplyResources(cadastroToolStripMenuItem, "cadastroToolStripMenuItem");
            cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            cadastroToolStripMenuItem.Click += cadastroToolStripMenuItem_Click;
            // 
            // clientesToolStripMenuItem
            // 
            resources.ApplyResources(clientesToolStripMenuItem, "clientesToolStripMenuItem");
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Click += clientesToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem
            // 
            resources.ApplyResources(sairToolStripMenuItem, "sairToolStripMenuItem");
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // picGroupLogo
            // 
            resources.ApplyResources(picGroupLogo, "picGroupLogo");
            picGroupLogo.Image = Properties.Resources.group_banner;
            picGroupLogo.Name = "picGroupLogo";
            picGroupLogo.TabStop = false;
            // 
            // Main
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(picGroupLogo);
            Controls.Add(menuHeader);
            MainMenuStrip = menuHeader;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Main";
            menuHeader.ResumeLayout(false);
            menuHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picGroupLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuHeader;
        private ToolStripMenuItem cadastroToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private PictureBox picGroupLogo;
        private ToolStripMenuItem clientesToolStripMenuItem;
    }
}

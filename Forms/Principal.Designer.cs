namespace CadastroImobiliaria
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
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
            menuHeader.BackColor = Color.SteelBlue;
            menuHeader.ImageScalingSize = new Size(20, 20);
            menuHeader.Items.AddRange(new ToolStripItem[] { cadastroToolStripMenuItem, clientesToolStripMenuItem, sairToolStripMenuItem });
            menuHeader.Name = "menuHeader";
            // 
            // cadastroToolStripMenuItem
            // 
            resources.ApplyResources(cadastroToolStripMenuItem, "cadastroToolStripMenuItem");
            cadastroToolStripMenuItem.ForeColor = SystemColors.Control;
            cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            cadastroToolStripMenuItem.Click += cadastroToolStripMenuItem_Click;
            // 
            // clientesToolStripMenuItem
            // 
            resources.ApplyResources(clientesToolStripMenuItem, "clientesToolStripMenuItem");
            clientesToolStripMenuItem.ForeColor = SystemColors.Control;
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Click += clientesToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem
            // 
            resources.ApplyResources(sairToolStripMenuItem, "sairToolStripMenuItem");
            sairToolStripMenuItem.ForeColor = SystemColors.Control;
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
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
<<<<<<< HEAD
            WindowState = FormWindowState.Maximized;
=======
>>>>>>> 5f40194bd8953c45031995c57c3232f256bfec29
            Load += Principal_Load;
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
        private ToolStripMenuItem clientesToolStripMenuItem;
        private PictureBox picGroupLogo;
    }
}

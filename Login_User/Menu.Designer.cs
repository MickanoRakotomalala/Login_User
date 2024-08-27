namespace Login_User
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.Navbar = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Name_User = new System.Windows.Forms.ToolStripMenuItem();
            this.Session_Name = new System.Windows.Forms.ToolStripMenuItem();
            this.Logout = new System.Windows.Forms.ToolStripMenuItem();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.factureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Sidebar = new System.Windows.Forms.Panel();
            this.slogan = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.mdiPanelChild = new System.Windows.Forms.Panel();
            this.factureToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.factureProformaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.journalDeVenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeFactureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificationDePrixToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.etatDeStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entréeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Navbar.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.Sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Navbar
            // 
            this.Navbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(140)))), ((int)(((byte)(172)))));
            this.Navbar.Controls.Add(this.menuStrip1);
            this.Navbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Navbar.Location = new System.Drawing.Point(200, 0);
            this.Navbar.Name = "Navbar";
            this.Navbar.Size = new System.Drawing.Size(600, 43);
            this.Navbar.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Name_User,
            this.fichierToolStripMenuItem,
            this.factureToolStripMenuItem,
            this.stockToolStripMenuItem,
            this.paramToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(600, 43);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "OptionNavbar";
            // 
            // Name_User
            // 
            this.Name_User.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Name_User.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Session_Name,
            this.Logout});
            this.Name_User.ForeColor = System.Drawing.Color.White;
            this.Name_User.Name = "Name_User";
            this.Name_User.Size = new System.Drawing.Size(79, 39);
            this.Name_User.Text = "Name_User";
            // 
            // Session_Name
            // 
            this.Session_Name.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Session_Name.ForeColor = System.Drawing.Color.Black;
            this.Session_Name.Name = "Session_Name";
            this.Session_Name.Size = new System.Drawing.Size(160, 22);
            this.Session_Name.Text = "Session_Name";
            this.Session_Name.Click += new System.EventHandler(this.Session_Name_Click);
            // 
            // Logout
            // 
            this.Logout.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Logout.Image = global::Login_User.Properties.Resources.LogoutBlack;
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(160, 22);
            this.Logout.Text = "Déconnexion";
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 39);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // factureToolStripMenuItem
            // 
            this.factureToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.factureToolStripMenuItem1,
            this.factureProformaToolStripMenuItem,
            this.journalDeVenteToolStripMenuItem,
            this.listeFactureToolStripMenuItem});
            this.factureToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.factureToolStripMenuItem.Name = "factureToolStripMenuItem";
            this.factureToolStripMenuItem.Size = new System.Drawing.Size(79, 39);
            this.factureToolStripMenuItem.Text = "Facturation";
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.etatDeStockToolStripMenuItem,
            this.entréeToolStripMenuItem,
            this.sortieToolStripMenuItem});
            this.stockToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(48, 39);
            this.stockToolStripMenuItem.Text = "Stock";
            // 
            // paramToolStripMenuItem
            // 
            this.paramToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificationDePrixToolStripMenuItem});
            this.paramToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.paramToolStripMenuItem.Name = "paramToolStripMenuItem";
            this.paramToolStripMenuItem.Size = new System.Drawing.Size(73, 39);
            this.paramToolStripMenuItem.Text = "Paramètre";
            // 
            // Sidebar
            // 
            this.Sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(140)))), ((int)(((byte)(172)))));
            this.Sidebar.Controls.Add(this.slogan);
            this.Sidebar.Controls.Add(this.pictureBox1);
            this.Sidebar.Controls.Add(this.btnDashboard);
            this.Sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.Sidebar.Location = new System.Drawing.Point(0, 0);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Size = new System.Drawing.Size(200, 450);
            this.Sidebar.TabIndex = 1;
            // 
            // slogan
            // 
            this.slogan.Font = new System.Drawing.Font("Calisto MT", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slogan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.slogan.Location = new System.Drawing.Point(12, 108);
            this.slogan.Name = "slogan";
            this.slogan.Size = new System.Drawing.Size(170, 23);
            this.slogan.TabIndex = 2;
            this.slogan.Text = "Shop Mada";
            this.slogan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(42, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(140)))), ((int)(((byte)(172)))));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Image = global::Login_User.Properties.Resources.Dashboard;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(12, 150);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(162, 41);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Tableau de bord";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // mdiPanelChild
            // 
            this.mdiPanelChild.BackColor = System.Drawing.Color.White;
            this.mdiPanelChild.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mdiPanelChild.Location = new System.Drawing.Point(200, 43);
            this.mdiPanelChild.Name = "mdiPanelChild";
            this.mdiPanelChild.Size = new System.Drawing.Size(600, 407);
            this.mdiPanelChild.TabIndex = 2;
            // 
            // factureToolStripMenuItem1
            // 
            this.factureToolStripMenuItem1.Name = "factureToolStripMenuItem1";
            this.factureToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.factureToolStripMenuItem1.Text = "Facture";
            // 
            // factureProformaToolStripMenuItem
            // 
            this.factureProformaToolStripMenuItem.Name = "factureProformaToolStripMenuItem";
            this.factureProformaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.factureProformaToolStripMenuItem.Text = "Facture Proforma";
            // 
            // journalDeVenteToolStripMenuItem
            // 
            this.journalDeVenteToolStripMenuItem.Name = "journalDeVenteToolStripMenuItem";
            this.journalDeVenteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.journalDeVenteToolStripMenuItem.Text = "Journal de Vente";
            // 
            // listeFactureToolStripMenuItem
            // 
            this.listeFactureToolStripMenuItem.Name = "listeFactureToolStripMenuItem";
            this.listeFactureToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listeFactureToolStripMenuItem.Text = "Liste Facture";
            // 
            // modificationDePrixToolStripMenuItem
            // 
            this.modificationDePrixToolStripMenuItem.Name = "modificationDePrixToolStripMenuItem";
            this.modificationDePrixToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.modificationDePrixToolStripMenuItem.Text = "Modification de prix";
            // 
            // etatDeStockToolStripMenuItem
            // 
            this.etatDeStockToolStripMenuItem.Name = "etatDeStockToolStripMenuItem";
            this.etatDeStockToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.etatDeStockToolStripMenuItem.Text = "Etat de Stock";
            // 
            // entréeToolStripMenuItem
            // 
            this.entréeToolStripMenuItem.Name = "entréeToolStripMenuItem";
            this.entréeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.entréeToolStripMenuItem.Text = "Entrée";
            // 
            // sortieToolStripMenuItem
            // 
            this.sortieToolStripMenuItem.Name = "sortieToolStripMenuItem";
            this.sortieToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sortieToolStripMenuItem.Text = "Sortie";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mdiPanelChild);
            this.Controls.Add(this.Navbar);
            this.Controls.Add(this.Sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Menu_Load);
            this.Navbar.ResumeLayout(false);
            this.Navbar.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Sidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Navbar;
        private System.Windows.Forms.Panel Sidebar;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel mdiPanelChild;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Name_User;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Session_Name;
        private System.Windows.Forms.ToolStripMenuItem Logout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem factureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paramToolStripMenuItem;
        private System.Windows.Forms.Label slogan;
        private System.Windows.Forms.ToolStripMenuItem factureToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem factureProformaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem journalDeVenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeFactureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem etatDeStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificationDePrixToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entréeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortieToolStripMenuItem;
    }
}
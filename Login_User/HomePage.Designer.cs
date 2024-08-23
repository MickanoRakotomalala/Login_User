namespace Login_User
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Session_Name = new System.Windows.Forms.ToolStripMenuItem();
            this.Logout = new System.Windows.Forms.ToolStripMenuItem();
            this.File = new System.Windows.Forms.ToolStripMenuItem();
            this.tESTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Facturation = new System.Windows.Forms.ToolStripMenuItem();
            this.tESTToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.journalDeVenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.journalDeVenteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listeFactureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Stock = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.Settings = new System.Windows.Forms.ToolStripMenuItem();
            this.prixToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DashMenu = new System.Windows.Forms.MenuStrip();
            this.Dashboard = new System.Windows.Forms.ToolStripMenuItem();
            this.LogoShop = new System.Windows.Forms.PictureBox();
            this.MenuStrip.SuspendLayout();
            this.DashMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoShop)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.AutoSize = false;
            this.MenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(140)))), ((int)(((byte)(172)))));
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu,
            this.File,
            this.Facturation,
            this.Stock,
            this.Settings});
            this.MenuStrip.Location = new System.Drawing.Point(131, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.MenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.MenuStrip.Size = new System.Drawing.Size(754, 50);
            this.MenuStrip.TabIndex = 11;
            this.MenuStrip.Text = "Menu";
            // 
            // Menu
            // 
            this.Menu.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Session_Name,
            this.Logout});
            this.Menu.Font = new System.Drawing.Font("Calisto MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu.ForeColor = System.Drawing.Color.White;
            this.Menu.Image = global::Login_User.Properties.Resources.Menu_White;
            this.Menu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Menu.ImageTransparentColor = System.Drawing.SystemColors.Control;
            this.Menu.Name = "Menu";
            this.Menu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Menu.Size = new System.Drawing.Size(95, 46);
            this.Menu.Text = "Name_user";
            this.Menu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Menu.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Menu.DropDownClosed += new System.EventHandler(this.Menu_DropDownClosed);
            this.Menu.DropDownOpened += new System.EventHandler(this.Menu_DropDownOpened);
            // 
            // Session_Name
            // 
            this.Session_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(140)))), ((int)(((byte)(172)))));
            this.Session_Name.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Session_Name.ForeColor = System.Drawing.SystemColors.Control;
            this.Session_Name.Image = global::Login_User.Properties.Resources.User;
            this.Session_Name.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Session_Name.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(140)))), ((int)(((byte)(172)))));
            this.Session_Name.Name = "Session_Name";
            this.Session_Name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Session_Name.Size = new System.Drawing.Size(151, 24);
            this.Session_Name.Text = "Session_Name";
            this.Session_Name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Session_Name.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Session_Name.Click += new System.EventHandler(this.Session_Name_Click);
            // 
            // Logout
            // 
            this.Logout.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Logout.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout.ForeColor = System.Drawing.SystemColors.Control;
            this.Logout.Image = global::Login_User.Properties.Resources.logout;
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(151, 24);
            this.Logout.Text = "Logout";
            this.Logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Logout.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // File
            // 
            this.File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tESTToolStripMenuItem});
            this.File.ForeColor = System.Drawing.Color.White;
            this.File.Margin = new System.Windows.Forms.Padding(15, 8, 0, 0);
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(54, 38);
            this.File.Text = "Fichier";
            this.File.DropDownClosed += new System.EventHandler(this.File_DropDownClosed);
            this.File.DropDownOpened += new System.EventHandler(this.File_DropDownOpened);
            // 
            // tESTToolStripMenuItem
            // 
            this.tESTToolStripMenuItem.Name = "tESTToolStripMenuItem";
            this.tESTToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.tESTToolStripMenuItem.Text = "TEST";
            // 
            // Facturation
            // 
            this.Facturation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(140)))), ((int)(((byte)(172)))));
            this.Facturation.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tESTToolStripMenuItem1,
            this.journalDeVenteToolStripMenuItem,
            this.journalDeVenteToolStripMenuItem1,
            this.listeFactureToolStripMenuItem});
            this.Facturation.ForeColor = System.Drawing.Color.White;
            this.Facturation.Margin = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.Facturation.Name = "Facturation";
            this.Facturation.Size = new System.Drawing.Size(79, 38);
            this.Facturation.Text = "Facturation";
            this.Facturation.DropDownClosed += new System.EventHandler(this.Facturation_DropDownClosed);
            this.Facturation.DropDownOpened += new System.EventHandler(this.Facturation_DropDownOpened);
            // 
            // tESTToolStripMenuItem1
            // 
            this.tESTToolStripMenuItem1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tESTToolStripMenuItem1.Name = "tESTToolStripMenuItem1";
            this.tESTToolStripMenuItem1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tESTToolStripMenuItem1.Size = new System.Drawing.Size(166, 22);
            this.tESTToolStripMenuItem1.Text = "Facture";
            this.tESTToolStripMenuItem1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tESTToolStripMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // journalDeVenteToolStripMenuItem
            // 
            this.journalDeVenteToolStripMenuItem.Name = "journalDeVenteToolStripMenuItem";
            this.journalDeVenteToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.journalDeVenteToolStripMenuItem.Text = "Facture Proforma";
            // 
            // journalDeVenteToolStripMenuItem1
            // 
            this.journalDeVenteToolStripMenuItem1.Name = "journalDeVenteToolStripMenuItem1";
            this.journalDeVenteToolStripMenuItem1.Size = new System.Drawing.Size(166, 22);
            this.journalDeVenteToolStripMenuItem1.Text = "Journal de Vente";
            // 
            // listeFactureToolStripMenuItem
            // 
            this.listeFactureToolStripMenuItem.Name = "listeFactureToolStripMenuItem";
            this.listeFactureToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.listeFactureToolStripMenuItem.Text = "Liste Facture";
            // 
            // Stock
            // 
            this.Stock.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem2});
            this.Stock.ForeColor = System.Drawing.Color.White;
            this.Stock.Margin = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.Stock.Name = "Stock";
            this.Stock.Size = new System.Drawing.Size(48, 38);
            this.Stock.Text = "Stock";
            this.Stock.DropDownClosed += new System.EventHandler(this.Stock_DropDownClosed);
            this.Stock.DropDownOpened += new System.EventHandler(this.Stock_DropDownOpened);
            // 
            // testToolStripMenuItem2
            // 
            this.testToolStripMenuItem2.Name = "testToolStripMenuItem2";
            this.testToolStripMenuItem2.Size = new System.Drawing.Size(94, 22);
            this.testToolStripMenuItem2.Text = "Test";
            // 
            // Settings
            // 
            this.Settings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prixToolStripMenuItem});
            this.Settings.ForeColor = System.Drawing.Color.White;
            this.Settings.Margin = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(78, 38);
            this.Settings.Text = "Paramètres";
            this.Settings.DropDownClosed += new System.EventHandler(this.Settings_DropDownClosed);
            this.Settings.DropDownOpened += new System.EventHandler(this.Settings_DropDownOpened);
            // 
            // prixToolStripMenuItem
            // 
            this.prixToolStripMenuItem.Name = "prixToolStripMenuItem";
            this.prixToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.prixToolStripMenuItem.Text = "Prix";
            // 
            // DashMenu
            // 
            this.DashMenu.AutoSize = false;
            this.DashMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(140)))), ((int)(((byte)(172)))));
            this.DashMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.DashMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Dashboard});
            this.DashMenu.Location = new System.Drawing.Point(0, 0);
            this.DashMenu.Name = "DashMenu";
            this.DashMenu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.DashMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.DashMenu.Size = new System.Drawing.Size(131, 501);
            this.DashMenu.TabIndex = 14;
            this.DashMenu.Text = "DashMenu";
            // 
            // Dashboard
            // 
            this.Dashboard.ForeColor = System.Drawing.Color.White;
            this.Dashboard.Image = ((System.Drawing.Image)(resources.GetObject("Dashboard.Image")));
            this.Dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Dashboard.Margin = new System.Windows.Forms.Padding(0, 120, 0, 0);
            this.Dashboard.Name = "Dashboard";
            this.Dashboard.Size = new System.Drawing.Size(126, 20);
            this.Dashboard.Text = "Tableau de bord";
            this.Dashboard.Click += new System.EventHandler(this.Dashboard_Click);
            // 
            // LogoShop
            // 
            this.LogoShop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(140)))), ((int)(((byte)(172)))));
            this.LogoShop.Image = global::Login_User.Properties.Resources.LogoShop;
            this.LogoShop.Location = new System.Drawing.Point(20, 5);
            this.LogoShop.Name = "LogoShop";
            this.LogoShop.Size = new System.Drawing.Size(90, 82);
            this.LogoShop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoShop.TabIndex = 16;
            this.LogoShop.TabStop = false;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 501);
            this.Controls.Add(this.LogoShop);
            this.Controls.Add(this.MenuStrip);
            this.Controls.Add(this.DashMenu);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(140)))), ((int)(((byte)(172)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.DashMenu.ResumeLayout(false);
            this.DashMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoShop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.MenuStrip MenuStrip;
        public System.Windows.Forms.ToolStripMenuItem Session_Name;
        private System.Windows.Forms.ToolStripMenuItem Logout;
        private new System.Windows.Forms.ToolStripMenuItem  Menu;
        private System.Windows.Forms.ToolStripMenuItem File;
        private System.Windows.Forms.ToolStripMenuItem tESTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Facturation;
        private System.Windows.Forms.ToolStripMenuItem tESTToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem Stock;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem Settings;
        private System.Windows.Forms.ToolStripMenuItem prixToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem journalDeVenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem journalDeVenteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listeFactureToolStripMenuItem;
        private System.Windows.Forms.MenuStrip DashMenu;
        private System.Windows.Forms.PictureBox LogoShop;
        private System.Windows.Forms.ToolStripMenuItem Dashboard;
    }
}
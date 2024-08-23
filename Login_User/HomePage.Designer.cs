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
            this.Fichier = new System.Windows.Forms.ToolStripMenuItem();
            this.tESTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Facturation = new System.Windows.Forms.ToolStripMenuItem();
            this.tESTToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Stock = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.Paramètres = new System.Windows.Forms.ToolStripMenuItem();
            this.prixToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.journalDeVenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.AutoSize = false;
            this.MenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(140)))), ((int)(((byte)(172)))));
            this.MenuStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu,
            this.Fichier,
            this.Facturation,
            this.Stock,
            this.Paramètres});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.MenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.MenuStrip.Size = new System.Drawing.Size(885, 36);
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
            this.Menu.Size = new System.Drawing.Size(95, 32);
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
            // Fichier
            // 
            this.Fichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tESTToolStripMenuItem});
            this.Fichier.ForeColor = System.Drawing.Color.White;
            this.Fichier.Name = "Fichier";
            this.Fichier.Size = new System.Drawing.Size(54, 32);
            this.Fichier.Text = "Fichier";
            this.Fichier.DropDownClosed += new System.EventHandler(this.Fichier_DropDownClosed);
            this.Fichier.DropDownOpened += new System.EventHandler(this.Fichier_DropDownOpened);
            // 
            // tESTToolStripMenuItem
            // 
            this.tESTToolStripMenuItem.Name = "tESTToolStripMenuItem";
            this.tESTToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tESTToolStripMenuItem.Text = "TEST";
            // 
            // Facturation
            // 
            this.Facturation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(140)))), ((int)(((byte)(172)))));
            this.Facturation.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tESTToolStripMenuItem1,
            this.journalDeVenteToolStripMenuItem});
            this.Facturation.ForeColor = System.Drawing.Color.White;
            this.Facturation.Name = "Facturation";
            this.Facturation.Size = new System.Drawing.Size(79, 32);
            this.Facturation.Text = "Facturation";
            this.Facturation.DropDownClosed += new System.EventHandler(this.Facturation_DropDownClosed);
            this.Facturation.DropDownOpened += new System.EventHandler(this.Facturation_DropDownOpened);
            // 
            // tESTToolStripMenuItem1
            // 
            this.tESTToolStripMenuItem1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tESTToolStripMenuItem1.Name = "tESTToolStripMenuItem1";
            this.tESTToolStripMenuItem1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tESTToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.tESTToolStripMenuItem1.Text = "Facture Proforma";
            this.tESTToolStripMenuItem1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tESTToolStripMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // Stock
            // 
            this.Stock.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem2});
            this.Stock.ForeColor = System.Drawing.Color.White;
            this.Stock.Name = "Stock";
            this.Stock.Size = new System.Drawing.Size(48, 32);
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
            // Paramètres
            // 
            this.Paramètres.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prixToolStripMenuItem});
            this.Paramètres.ForeColor = System.Drawing.Color.White;
            this.Paramètres.Name = "Paramètres";
            this.Paramètres.Size = new System.Drawing.Size(78, 32);
            this.Paramètres.Text = "Paramètres";
            this.Paramètres.DropDownClosed += new System.EventHandler(this.Paramètres_DropDownClosed);
            this.Paramètres.DropDownOpened += new System.EventHandler(this.Paramètres_DropDownOpened);
            // 
            // prixToolStripMenuItem
            // 
            this.prixToolStripMenuItem.Name = "prixToolStripMenuItem";
            this.prixToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.prixToolStripMenuItem.Text = "Prix";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(140)))), ((int)(((byte)(172)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 501);
            this.panel1.TabIndex = 12;
            // 
            // journalDeVenteToolStripMenuItem
            // 
            this.journalDeVenteToolStripMenuItem.Name = "journalDeVenteToolStripMenuItem";
            this.journalDeVenteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.journalDeVenteToolStripMenuItem.Text = "Journal de Vente";
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 501);
            this.Controls.Add(this.MenuStrip);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(140)))), ((int)(((byte)(172)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomePage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.ToolStripMenuItem Session_Name;
        private System.Windows.Forms.ToolStripMenuItem Logout;
        private new System.Windows.Forms.ToolStripMenuItem  Menu;
        private System.Windows.Forms.ToolStripMenuItem Fichier;
        private System.Windows.Forms.ToolStripMenuItem tESTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Facturation;
        private System.Windows.Forms.ToolStripMenuItem tESTToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem Stock;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem Paramètres;
        private System.Windows.Forms.ToolStripMenuItem prixToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem journalDeVenteToolStripMenuItem;
    }
}
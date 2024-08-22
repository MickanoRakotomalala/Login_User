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
            this.Dashboard = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.Dashboard});
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
            this.Menu.ForeColor = System.Drawing.SystemColors.Control;
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
            this.Session_Name.Size = new System.Drawing.Size(180, 24);
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
            this.Logout.Size = new System.Drawing.Size(180, 24);
            this.Logout.Text = "Logout";
            this.Logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Logout.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // Dashboard
            // 
            this.Dashboard.Name = "Dashboard";
            this.Dashboard.Size = new System.Drawing.Size(76, 32);
            this.Dashboard.Text = "Dashboard";
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
        private System.Windows.Forms.ToolStripMenuItem Dashboard;
    }
}
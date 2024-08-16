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
            this.SessionName = new System.Windows.Forms.Label();
            this.BtnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Session_Name = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // SessionName
            // 
            this.SessionName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SessionName.AutoSize = true;
            this.SessionName.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SessionName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SessionName.Location = new System.Drawing.Point(4, 39);
            this.SessionName.Name = "SessionName";
            this.SessionName.Size = new System.Drawing.Size(162, 28);
            this.SessionName.TabIndex = 0;
            this.SessionName.Text = "Session Name";
            this.SessionName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnLogout
            // 
            this.BtnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnLogout.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BtnLogout.BorderRadius = 5;
            this.BtnLogout.CheckedState.Parent = this.BtnLogout;
            this.BtnLogout.CustomImages.Parent = this.BtnLogout;
            this.BtnLogout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(140)))), ((int)(((byte)(172)))));
            this.BtnLogout.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogout.ForeColor = System.Drawing.Color.White;
            this.BtnLogout.HoverState.Parent = this.BtnLogout;
            this.BtnLogout.Image = global::Login_User.Properties.Resources.logout;
            this.BtnLogout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BtnLogout.Location = new System.Drawing.Point(67, 3);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.ShadowDecoration.Parent = this.BtnLogout;
            this.BtnLogout.Size = new System.Drawing.Size(99, 24);
            this.BtnLogout.TabIndex = 9;
            this.BtnLogout.Text = "Logout";
            this.BtnLogout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.BtnLogout, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.SessionName, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(711, 65);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(169, 67);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.MenuStrip.Size = new System.Drawing.Size(885, 40);
            this.MenuStrip.TabIndex = 11;
            this.MenuStrip.Text = "Menu";
            // 
            // Menu
            // 
            this.Menu.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Menu.AutoSize = false;
            this.Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Session_Name,
            this.toolStripMenuItem3});
            this.Menu.Image = global::Login_User.Properties.Resources.Menu;
            this.Menu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Menu.Name = "Menu";
            this.Menu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Menu.Size = new System.Drawing.Size(122, 36);
            this.Menu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Session_Name
            // 
            this.Session_Name.Image = global::Login_User.Properties.Resources.User;
            this.Session_Name.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Session_Name.Name = "Session_Name";
            this.Session_Name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Session_Name.Size = new System.Drawing.Size(180, 22);
            this.Session_Name.Text = "Session_Name";
            this.Session_Name.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem3.Text = "Logout";
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 501);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.MenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomePage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SessionName;
        private Guna.UI2.WinForms.Guna2Button BtnLogout;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.MenuStrip MenuStrip;
        public System.Windows.Forms.ToolStripMenuItem Menu;
        public System.Windows.Forms.ToolStripMenuItem Session_Name;
        public System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
    }
}
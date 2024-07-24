﻿namespace Login_User
{
    partial class Login
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.BtnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.ManageUser = new System.Windows.Forms.LinkLabel();
            this.Register = new System.Windows.Forms.LinkLabel();
            this.TypeUser = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.NameLogin = new System.Windows.Forms.Label();
            this.UserProfil = new Guna.UI2.WinForms.Guna2PictureBox();
            this.ShowPw = new Guna.UI2.WinForms.Guna2Button();
            this.HidePassword = new Guna.UI2.WinForms.Guna2Button();
            this.Password = new Guna.UI2.WinForms.Guna2TextBox();
            this.UserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.BtnExit = new Guna.UI2.WinForms.Guna2Button();
            this.ForgotPassword = new System.Windows.Forms.LinkLabel();
            this.Error = new System.Windows.Forms.Label();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserProfil)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnLogin
            // 
            this.BtnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnLogin.BackColor = System.Drawing.Color.Transparent;
            this.BtnLogin.BorderRadius = 10;
            this.BtnLogin.CheckedState.Parent = this.BtnLogin;
            this.BtnLogin.CustomImages.Parent = this.BtnLogin;
            this.BtnLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(140)))), ((int)(((byte)(172)))));
            this.BtnLogin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.ForeColor = System.Drawing.Color.White;
            this.BtnLogin.HoverState.Parent = this.BtnLogin;
            this.BtnLogin.Location = new System.Drawing.Point(348, 232);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.ShadowDecoration.Parent = this.BtnLogin;
            this.BtnLogin.Size = new System.Drawing.Size(155, 30);
            this.BtnLogin.TabIndex = 4;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // ManageUser
            // 
            this.ManageUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ManageUser.AutoSize = true;
            this.ManageUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageUser.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.ManageUser.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ManageUser.Location = new System.Drawing.Point(375, 305);
            this.ManageUser.Name = "ManageUser";
            this.ManageUser.Size = new System.Drawing.Size(77, 13);
            this.ManageUser.TabIndex = 5;
            this.ManageUser.TabStop = true;
            this.ManageUser.Text = "Manage User !";
            this.ManageUser.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ManageUser_LinkClicked);
            // 
            // Register
            // 
            this.Register.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Register.AutoSize = true;
            this.Register.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.Register.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Register.Location = new System.Drawing.Point(458, 275);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(96, 13);
            this.Register.TabIndex = 6;
            this.Register.TabStop = true;
            this.Register.Text = "Register Here ?";
            this.Register.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Register_LinkClicked);
            // 
            // TypeUser
            // 
            this.TypeUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TypeUser.BackColor = System.Drawing.Color.Transparent;
            this.TypeUser.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(140)))), ((int)(((byte)(172)))));
            this.TypeUser.Location = new System.Drawing.Point(388, 54);
            this.TypeUser.Name = "TypeUser";
            this.TypeUser.Size = new System.Drawing.Size(74, 30);
            this.TypeUser.TabIndex = 10;
            this.TypeUser.Text = "Sign in";
            this.TypeUser.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.TypeUser.Click += new System.EventHandler(this.TypeUser_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(140)))), ((int)(((byte)(172)))));
            this.guna2Panel2.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.guna2Panel2.Controls.Add(this.NameLogin);
            this.guna2Panel2.Controls.Add(this.UserProfil);
            this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(140)))), ((int)(((byte)(172)))));
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(264, 352);
            this.guna2Panel2.TabIndex = 1;
            // 
            // NameLogin
            // 
            this.NameLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameLogin.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLogin.ForeColor = System.Drawing.Color.White;
            this.NameLogin.Location = new System.Drawing.Point(0, 257);
            this.NameLogin.Name = "NameLogin";
            this.NameLogin.Size = new System.Drawing.Size(261, 86);
            this.NameLogin.TabIndex = 1;
            this.NameLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NameLogin.UseCompatibleTextRendering = true;
            // 
            // UserProfil
            // 
            this.UserProfil.BackColor = System.Drawing.Color.Transparent;
            this.UserProfil.Image = global::Login_User.Properties.Resources.personne;
            this.UserProfil.Location = new System.Drawing.Point(20, 33);
            this.UserProfil.Name = "UserProfil";
            this.UserProfil.ShadowDecoration.Parent = this.UserProfil;
            this.UserProfil.Size = new System.Drawing.Size(222, 218);
            this.UserProfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UserProfil.TabIndex = 0;
            this.UserProfil.TabStop = false;
            // 
            // ShowPw
            // 
            this.ShowPw.BackColor = System.Drawing.SystemColors.Control;
            this.ShowPw.BorderRadius = 5;
            this.ShowPw.CheckedState.Parent = this.ShowPw;
            this.ShowPw.CustomImages.Parent = this.ShowPw;
            this.ShowPw.FillColor = System.Drawing.Color.Transparent;
            this.ShowPw.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowPw.ForeColor = System.Drawing.SystemColors.Control;
            this.ShowPw.HoverState.Parent = this.ShowPw;
            this.ShowPw.Image = global::Login_User.Properties.Resources.Show_password;
            this.ShowPw.Location = new System.Drawing.Point(515, 180);
            this.ShowPw.Name = "ShowPw";
            this.ShowPw.PressedColor = System.Drawing.Color.Transparent;
            this.ShowPw.ShadowDecoration.Parent = this.ShowPw;
            this.ShowPw.Size = new System.Drawing.Size(30, 19);
            this.ShowPw.TabIndex = 12;
            this.ShowPw.Click += new System.EventHandler(this.ShowPw_Click);
            // 
            // HidePassword
            // 
            this.HidePassword.BackColor = System.Drawing.SystemColors.Control;
            this.HidePassword.BorderRadius = 5;
            this.HidePassword.CheckedState.Parent = this.HidePassword;
            this.HidePassword.CustomImages.Parent = this.HidePassword;
            this.HidePassword.FillColor = System.Drawing.Color.Transparent;
            this.HidePassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HidePassword.ForeColor = System.Drawing.SystemColors.Control;
            this.HidePassword.HoverState.Parent = this.HidePassword;
            this.HidePassword.Image = global::Login_User.Properties.Resources.Hidden_password;
            this.HidePassword.Location = new System.Drawing.Point(514, 180);
            this.HidePassword.Name = "HidePassword";
            this.HidePassword.PressedColor = System.Drawing.Color.Transparent;
            this.HidePassword.ShadowDecoration.Parent = this.HidePassword;
            this.HidePassword.Size = new System.Drawing.Size(30, 19);
            this.HidePassword.TabIndex = 11;
            this.HidePassword.Click += new System.EventHandler(this.HidePassword_Click);
            // 
            // Password
            // 
            this.Password.AcceptsTab = true;
            this.Password.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Password.BorderRadius = 5;
            this.Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Password.DefaultText = "";
            this.Password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Password.DisabledState.Parent = this.Password;
            this.Password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Password.FillColor = System.Drawing.SystemColors.Control;
            this.Password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Password.FocusedState.Parent = this.Password;
            this.Password.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.ForeColor = System.Drawing.Color.DimGray;
            this.Password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Password.HoverState.Parent = this.Password;
            this.Password.IconLeft = global::Login_User.Properties.Resources.Password_User;
            this.Password.Location = new System.Drawing.Point(315, 171);
            this.Password.Margin = new System.Windows.Forms.Padding(4);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '\0';
            this.Password.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.Password.PlaceholderText = "Password";
            this.Password.SelectedText = "";
            this.Password.ShadowDecoration.Parent = this.Password;
            this.Password.Size = new System.Drawing.Size(226, 32);
            this.Password.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.Password.TabIndex = 2;
            this.Password.UseSystemPasswordChar = true;
            this.Password.Leave += new System.EventHandler(this.Password_Leave);
            // 
            // UserName
            // 
            this.UserName.AcceptsTab = true;
            this.UserName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserName.BorderRadius = 5;
            this.UserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UserName.DefaultText = "";
            this.UserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UserName.DisabledState.Parent = this.UserName;
            this.UserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UserName.FillColor = System.Drawing.SystemColors.Control;
            this.UserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UserName.FocusedState.Parent = this.UserName;
            this.UserName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.ForeColor = System.Drawing.Color.DimGray;
            this.UserName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UserName.HoverState.Parent = this.UserName;
            this.UserName.IconLeft = global::Login_User.Properties.Resources.User;
            this.UserName.Location = new System.Drawing.Point(315, 109);
            this.UserName.Margin = new System.Windows.Forms.Padding(4);
            this.UserName.Name = "UserName";
            this.UserName.PasswordChar = '\0';
            this.UserName.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.UserName.PlaceholderText = "Phone or Registration Number";
            this.UserName.SelectedText = "";
            this.UserName.ShadowDecoration.Parent = this.UserName;
            this.UserName.Size = new System.Drawing.Size(226, 32);
            this.UserName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.UserName.TabIndex = 1;
            this.UserName.TextChanged += new System.EventHandler(this.UserName_TextChanged);
            this.UserName.Leave += new System.EventHandler(this.UserName_Leave);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BtnExit.BorderRadius = 5;
            this.BtnExit.CheckedState.Parent = this.BtnExit;
            this.BtnExit.CustomImages.Parent = this.BtnExit;
            this.BtnExit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(140)))), ((int)(((byte)(172)))));
            this.BtnExit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.ForeColor = System.Drawing.Color.White;
            this.BtnExit.HoverState.Parent = this.BtnExit;
            this.BtnExit.Image = global::Login_User.Properties.Resources.Exit1;
            this.BtnExit.Location = new System.Drawing.Point(548, 4);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.ShadowDecoration.Parent = this.BtnExit;
            this.BtnExit.Size = new System.Drawing.Size(27, 24);
            this.BtnExit.TabIndex = 7;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // ForgotPassword
            // 
            this.ForgotPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ForgotPassword.AutoSize = true;
            this.ForgotPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForgotPassword.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.ForgotPassword.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ForgotPassword.Location = new System.Drawing.Point(303, 276);
            this.ForgotPassword.Name = "ForgotPassword";
            this.ForgotPassword.Size = new System.Drawing.Size(95, 13);
            this.ForgotPassword.TabIndex = 13;
            this.ForgotPassword.TabStop = true;
            this.ForgotPassword.Text = "Forgot Password ?";
            this.ForgotPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ForgotPassword_LinkClicked);
            // 
            // Error
            // 
            this.Error.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Error.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Error.ForeColor = System.Drawing.Color.Brown;
            this.Error.Location = new System.Drawing.Point(270, 89);
            this.Error.Name = "Error";
            this.Error.Size = new System.Drawing.Size(305, 23);
            this.Error.TabIndex = 14;
            this.Error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 352);
            this.ControlBox = false;
            this.Controls.Add(this.Error);
            this.Controls.Add(this.ForgotPassword);
            this.Controls.Add(this.ShowPw);
            this.Controls.Add(this.HidePassword);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.TypeUser);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.ManageUser);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.BtnExit);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Login_Load);
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UserProfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button BtnExit;
        private Guna.UI2.WinForms.Guna2TextBox UserName;
        private Guna.UI2.WinForms.Guna2TextBox Password;
        private Guna.UI2.WinForms.Guna2Button BtnLogin;
        private System.Windows.Forms.LinkLabel ManageUser;
        private System.Windows.Forms.LinkLabel Register;
        private Guna.UI2.WinForms.Guna2HtmlLabel TypeUser;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2PictureBox UserProfil;
        private Guna.UI2.WinForms.Guna2Button HidePassword;
        private Guna.UI2.WinForms.Guna2Button ShowPw;
        private System.Windows.Forms.LinkLabel ForgotPassword;
        private System.Windows.Forms.Label NameLogin;
        private System.Windows.Forms.Label Error;
    }
}


namespace Login_User
{
    partial class Forgot_password
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.RegisterAccount = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnExit = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LastName = new Guna.UI2.WinForms.Guna2TextBox();
            this.FirstName = new Guna.UI2.WinForms.Guna2TextBox();
            this.Register = new Guna.UI2.WinForms.Guna2Button();
            this.ShowPassword = new Guna.UI2.WinForms.Guna2CheckBox();
            this.ConfirmPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.Password = new Guna.UI2.WinForms.Guna2TextBox();
            this.Address = new Guna.UI2.WinForms.Guna2TextBox();
            this.Contact = new Guna.UI2.WinForms.Guna2TextBox();
            this.GenderFemale = new Guna.UI2.WinForms.Guna2CheckBox();
            this.GenderMale = new Guna.UI2.WinForms.Guna2CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(140)))), ((int)(((byte)(172)))));
            this.panel1.Controls.Add(this.RegisterAccount);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 562);
            this.panel1.TabIndex = 0;
            // 
            // RegisterAccount
            // 
            this.RegisterAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RegisterAccount.AutoSize = true;
            this.RegisterAccount.Font = new System.Drawing.Font("Calisto MT", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterAccount.ForeColor = System.Drawing.Color.White;
            this.RegisterAccount.Location = new System.Drawing.Point(69, 343);
            this.RegisterAccount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RegisterAccount.Name = "RegisterAccount";
            this.RegisterAccount.Size = new System.Drawing.Size(166, 32);
            this.RegisterAccount.TabIndex = 13;
            this.RegisterAccount.Text = "User Profile";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Login_User.Properties.Resources.ForgotPassword1;
            this.pictureBox1.Location = new System.Drawing.Point(23, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(249, 248);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            this.BtnExit.Location = new System.Drawing.Point(835, 5);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.ShadowDecoration.Parent = this.BtnExit;
            this.BtnExit.Size = new System.Drawing.Size(27, 24);
            this.BtnExit.TabIndex = 8;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(389, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 41);
            this.label1.TabIndex = 14;
            this.label1.Text = "Forgot password setting";
            // 
            // LastName
            // 
            this.LastName.AcceptsTab = true;
            this.LastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LastName.DefaultText = "";
            this.LastName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.LastName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.LastName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LastName.DisabledState.Parent = this.LastName;
            this.LastName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LastName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LastName.FocusedState.Parent = this.LastName;
            this.LastName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LastName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LastName.HoverState.Parent = this.LastName;
            this.LastName.IconLeft = global::Login_User.Properties.Resources.New_User;
            this.LastName.Location = new System.Drawing.Point(601, 149);
            this.LastName.Margin = new System.Windows.Forms.Padding(4);
            this.LastName.Name = "LastName";
            this.LastName.PasswordChar = '\0';
            this.LastName.PlaceholderText = "Last Name";
            this.LastName.SelectedText = "";
            this.LastName.ShadowDecoration.Parent = this.LastName;
            this.LastName.Size = new System.Drawing.Size(240, 26);
            this.LastName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.LastName.TabIndex = 16;
            // 
            // FirstName
            // 
            this.FirstName.AcceptsTab = true;
            this.FirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FirstName.DefaultText = "";
            this.FirstName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.FirstName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.FirstName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FirstName.DisabledState.Parent = this.FirstName;
            this.FirstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FirstName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FirstName.FocusedState.Parent = this.FirstName;
            this.FirstName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FirstName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FirstName.HoverState.Parent = this.FirstName;
            this.FirstName.IconLeft = global::Login_User.Properties.Resources.New_User;
            this.FirstName.Location = new System.Drawing.Point(320, 149);
            this.FirstName.Margin = new System.Windows.Forms.Padding(4);
            this.FirstName.Name = "FirstName";
            this.FirstName.PasswordChar = '\0';
            this.FirstName.PlaceholderText = "First Name";
            this.FirstName.SelectedText = "";
            this.FirstName.ShadowDecoration.Parent = this.FirstName;
            this.FirstName.Size = new System.Drawing.Size(240, 26);
            this.FirstName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.FirstName.TabIndex = 15;
            // 
            // Register
            // 
            this.Register.BorderRadius = 10;
            this.Register.CheckedState.Parent = this.Register;
            this.Register.CustomImages.Parent = this.Register;
            this.Register.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(140)))), ((int)(((byte)(172)))));
            this.Register.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register.ForeColor = System.Drawing.Color.White;
            this.Register.HoverState.Parent = this.Register;
            this.Register.Image = global::Login_User.Properties.Resources.Register;
            this.Register.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Register.Location = new System.Drawing.Point(496, 373);
            this.Register.Margin = new System.Windows.Forms.Padding(2);
            this.Register.Name = "Register";
            this.Register.ShadowDecoration.Parent = this.Register;
            this.Register.Size = new System.Drawing.Size(138, 27);
            this.Register.TabIndex = 24;
            this.Register.Text = "Register";
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // ShowPassword
            // 
            this.ShowPassword.AutoSize = true;
            this.ShowPassword.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ShowPassword.CheckedState.BorderRadius = 2;
            this.ShowPassword.CheckedState.BorderThickness = 0;
            this.ShowPassword.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ShowPassword.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ShowPassword.Location = new System.Drawing.Point(720, 338);
            this.ShowPassword.Name = "ShowPassword";
            this.ShowPassword.Size = new System.Drawing.Size(102, 17);
            this.ShowPassword.TabIndex = 23;
            this.ShowPassword.Text = "Show Password";
            this.ShowPassword.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ShowPassword.UncheckedState.BorderRadius = 2;
            this.ShowPassword.UncheckedState.BorderThickness = 0;
            this.ShowPassword.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ShowPassword.UseVisualStyleBackColor = true;
            // 
            // ConfirmPassword
            // 
            this.ConfirmPassword.AcceptsTab = true;
            this.ConfirmPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ConfirmPassword.DefaultText = "";
            this.ConfirmPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ConfirmPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ConfirmPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ConfirmPassword.DisabledState.Parent = this.ConfirmPassword;
            this.ConfirmPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ConfirmPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ConfirmPassword.FocusedState.Parent = this.ConfirmPassword;
            this.ConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ConfirmPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ConfirmPassword.HoverState.Parent = this.ConfirmPassword;
            this.ConfirmPassword.IconLeft = global::Login_User.Properties.Resources.Password_User;
            this.ConfirmPassword.Location = new System.Drawing.Point(606, 294);
            this.ConfirmPassword.Margin = new System.Windows.Forms.Padding(4);
            this.ConfirmPassword.Name = "ConfirmPassword";
            this.ConfirmPassword.PasswordChar = '\0';
            this.ConfirmPassword.PlaceholderText = "Password Confirmation";
            this.ConfirmPassword.SelectedText = "";
            this.ConfirmPassword.ShadowDecoration.Parent = this.ConfirmPassword;
            this.ConfirmPassword.Size = new System.Drawing.Size(240, 26);
            this.ConfirmPassword.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.ConfirmPassword.TabIndex = 22;
            this.ConfirmPassword.UseSystemPasswordChar = true;
            // 
            // Password
            // 
            this.Password.AcceptsTab = true;
            this.Password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Password.DefaultText = "";
            this.Password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Password.DisabledState.Parent = this.Password;
            this.Password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Password.FocusedState.Parent = this.Password;
            this.Password.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Password.HoverState.Parent = this.Password;
            this.Password.IconLeft = global::Login_User.Properties.Resources.Password_User;
            this.Password.Location = new System.Drawing.Point(319, 294);
            this.Password.Margin = new System.Windows.Forms.Padding(4);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '\0';
            this.Password.PlaceholderText = "Password";
            this.Password.SelectedText = "";
            this.Password.ShadowDecoration.Parent = this.Password;
            this.Password.Size = new System.Drawing.Size(240, 26);
            this.Password.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.Password.TabIndex = 21;
            this.Password.UseSystemPasswordChar = true;
            // 
            // Address
            // 
            this.Address.AcceptsTab = true;
            this.Address.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Address.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Address.DefaultText = "";
            this.Address.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Address.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Address.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Address.DisabledState.Parent = this.Address;
            this.Address.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Address.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Address.FocusedState.Parent = this.Address;
            this.Address.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Address.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Address.HoverState.Parent = this.Address;
            this.Address.IconLeft = global::Login_User.Properties.Resources.Address_User;
            this.Address.Location = new System.Drawing.Point(604, 233);
            this.Address.Margin = new System.Windows.Forms.Padding(4);
            this.Address.Name = "Address";
            this.Address.PasswordChar = '\0';
            this.Address.PlaceholderText = "Address";
            this.Address.SelectedText = "";
            this.Address.ShadowDecoration.Parent = this.Address;
            this.Address.Size = new System.Drawing.Size(240, 26);
            this.Address.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.Address.TabIndex = 20;
            // 
            // Contact
            // 
            this.Contact.AcceptsTab = true;
            this.Contact.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Contact.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Contact.DefaultText = "";
            this.Contact.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Contact.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Contact.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Contact.DisabledState.Parent = this.Contact;
            this.Contact.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Contact.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Contact.FocusedState.Parent = this.Contact;
            this.Contact.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Contact.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Contact.HoverState.Parent = this.Contact;
            this.Contact.IconLeft = global::Login_User.Properties.Resources.Contact_User;
            this.Contact.Location = new System.Drawing.Point(318, 233);
            this.Contact.Margin = new System.Windows.Forms.Padding(4);
            this.Contact.Name = "Contact";
            this.Contact.PasswordChar = '\0';
            this.Contact.PlaceholderText = "Contact : 034 12 345 67";
            this.Contact.SelectedText = "";
            this.Contact.ShadowDecoration.Parent = this.Contact;
            this.Contact.Size = new System.Drawing.Size(240, 26);
            this.Contact.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.Contact.TabIndex = 19;
            // 
            // GenderFemale
            // 
            this.GenderFemale.AutoSize = true;
            this.GenderFemale.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.GenderFemale.CheckedState.BorderRadius = 2;
            this.GenderFemale.CheckedState.BorderThickness = 0;
            this.GenderFemale.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.GenderFemale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GenderFemale.Location = new System.Drawing.Point(380, 192);
            this.GenderFemale.Name = "GenderFemale";
            this.GenderFemale.Size = new System.Drawing.Size(60, 17);
            this.GenderFemale.TabIndex = 18;
            this.GenderFemale.Text = "Female";
            this.GenderFemale.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.GenderFemale.UncheckedState.BorderRadius = 2;
            this.GenderFemale.UncheckedState.BorderThickness = 0;
            this.GenderFemale.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.GenderFemale.UseVisualStyleBackColor = true;
            // 
            // GenderMale
            // 
            this.GenderMale.AutoSize = true;
            this.GenderMale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.GenderMale.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.GenderMale.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(140)))), ((int)(((byte)(179)))));
            this.GenderMale.CheckedState.BorderRadius = 0;
            this.GenderMale.CheckedState.BorderThickness = 0;
            this.GenderMale.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.GenderMale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GenderMale.Location = new System.Drawing.Point(325, 192);
            this.GenderMale.Name = "GenderMale";
            this.GenderMale.Size = new System.Drawing.Size(49, 17);
            this.GenderMale.TabIndex = 17;
            this.GenderMale.Text = "Male";
            this.GenderMale.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.GenderMale.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.GenderMale.UncheckedState.BorderRadius = 2;
            this.GenderMale.UncheckedState.BorderThickness = 0;
            this.GenderMale.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.GenderMale.UseVisualStyleBackColor = true;
            // 
            // Forgot_password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 560);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.ShowPassword);
            this.Controls.Add(this.ConfirmPassword);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.Contact);
            this.Controls.Add(this.GenderFemale);
            this.Controls.Add(this.GenderMale);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Forgot_password";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forgot_password";
            this.Load += new System.EventHandler(this.Forgot_password_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button BtnExit;
        private System.Windows.Forms.Label RegisterAccount;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox LastName;
        private Guna.UI2.WinForms.Guna2TextBox FirstName;
        private Guna.UI2.WinForms.Guna2Button Register;
        private Guna.UI2.WinForms.Guna2CheckBox ShowPassword;
        private Guna.UI2.WinForms.Guna2TextBox ConfirmPassword;
        private Guna.UI2.WinForms.Guna2TextBox Password;
        private Guna.UI2.WinForms.Guna2TextBox Address;
        private Guna.UI2.WinForms.Guna2TextBox Contact;
        private Guna.UI2.WinForms.Guna2CheckBox GenderFemale;
        private Guna.UI2.WinForms.Guna2CheckBox GenderMale;
    }
}
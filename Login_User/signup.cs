﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Login_User
{
    public partial class signup : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        public signup()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Contact_TextChanged(object sender, EventArgs e)
        {

        }

        private void ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPassword.Checked == true)
            {
                Password.UseSystemPasswordChar = false;
                ConfirmPassword.UseSystemPasswordChar = false;
            }
            else if (ShowPassword.Checked == false)
            {
                Password.UseSystemPasswordChar = true;
                ConfirmPassword.UseSystemPasswordChar = true;
            }
        }

        private void GenderMale_CheckedChanged(object sender, EventArgs e)
        {
            if (GenderMale.Checked == true)
            {
                GenderFemale.Enabled = false;
            }
            else if(GenderMale.Checked == false)
            {
                GenderFemale.Enabled = true;
            }
        }

        private void GenderFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (GenderFemale.Checked == true)
            {
                GenderMale.Enabled = false;
            }
            else if (GenderFemale.Checked == false)
            {  
                GenderMale.Enabled = true;
            }
        }

        private void signup_Load(object sender, EventArgs e)
        {
            //this.Register.Enabled = false;  
        }

        Image IMG;
        private void Register_Click(object sender, EventArgs e)
        {
            if(this.FirstName.Text == "")
            {
                MessageBox.Show("This field must not be empty","First Name", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                FirstName.TabIndex = 1;
                FirstName.Focus();
            }
            else if (this.LastName.Text == "")
            {
                MessageBox.Show("This field must not be empty", "Last Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LastName.TabIndex = 2;
                LastName.Focus();
            }
            else if (this.GenderMale.Checked == false && this.GenderFemale.Checked == false)
            {
                MessageBox.Show("This field must not be empty", "Gender", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                GenderMale.TabIndex = 3;
                GenderMale.Focus();
            }
            else if (this.Contact.Text == "")
            {
                MessageBox.Show("This field must not be empty", "Contact", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Contact.TabIndex = 4;
                Contact.Focus();
            }
            else if (this.Address.Text == "")
            {
                MessageBox.Show("This field must not be empty", "Address", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Address.TabIndex = 5;
                Address.Focus();
            }
            else if (this.Password.Text == "")
            {
                MessageBox.Show("This field must not be empty", "Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Password.TabIndex = 6;
                Password.Focus();
            }
            else if (this.ConfirmPassword.Text == "")
            {
                MessageBox.Show("This field must not be empty", "Password Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ConfirmPassword.TabIndex = 7;
                ConfirmPassword.Focus();
            }
            else if (this.Profil.Image == null)
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "AllImages|*.JPEG;*.BMP;*.GIF;*.PNG;*.TIFF;*.JPG";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    IMG = Image.FromFile(ofd.FileName);
                    Profil.Image = IMG;
                }
            }
            else
            {
                SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\Perso\\PROJET C#\\Login\\Login_User\\dbCSharp.mdf\";Integrated Security=True;Connect Timeout=30");
                SqlCommand cmd = new SqlCommand("insert into Users values (@FirstName,@LastName,@GenderMale,@GenderFemale,@Contact,@Address,@Password,@Profil,@User ,@Supervisor,@Admin)", conn);
                conn.Open();


                //Get types from PictureBox
                Image img = Profil.Image;
                MemoryStream ms = new MemoryStream();
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] bytes = ms.ToArray();

                cmd.Parameters.AddWithValue("@FirstName",FirstName.Text);
                cmd.Parameters.AddWithValue("@LastName",LastName.Text);
                cmd.Parameters.AddWithValue("@GenderMale", SqlDbType.Bit).Value = GenderMale.Checked;
                cmd.Parameters.AddWithValue("@GenderFemale", SqlDbType.Bit).Value = GenderFemale.Checked;
                cmd.Parameters.AddWithValue("@Contact",Contact.Text);
                cmd.Parameters.AddWithValue("@Address",Address.Text);
                cmd.Parameters.AddWithValue("@Password",Password.Text);
                cmd.Parameters.Add("@Profil", SqlDbType.Binary).Value = bytes;
                cmd.Parameters.AddWithValue("@User",SqlDbType.Bit).Value = false;
                cmd.Parameters.AddWithValue("@Supervisor",SqlDbType.Bit).Value =false;
                cmd.Parameters.AddWithValue("@Admin",SqlDbType.Bit).Value =false;
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Successfully saved");
            }

        }
    }
}
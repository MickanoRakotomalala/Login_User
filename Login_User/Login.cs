using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data.SqlClient;
using System.IO;
using Microsoft.VisualBasic.ApplicationServices;
using System.Security.AccessControl;

namespace Login_User
{
    public partial class Login : Form
    {
        SqlConnection conn = new SqlConnection("data source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\dbCSharp.mdf;Integrated Security=True;Connect Timeout=30");
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

        public Login()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0,0,Width,Height,30,30));
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.BtnLogin.Enabled = false;
            this.UserName.TabIndex = 1;
            this.Password.TabIndex = 2;
            this.BtnLogin.TabIndex = 3;
            this.Register.TabIndex = 4;
            this.ManageUser.TabIndex = 5;
            this.BtnExit.TabIndex = 6;
        }

        private void Register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            signup signup = new signup();
            signup.Show();

        }

        private void TypeUser_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand($"SELECT * FROM Users WHERE Contact = @Contact AND Password = @Password", conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("Contact", UserName.Text);
            cmd.Parameters.AddWithValue("Password", Password.Text);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                Globals.NameUser = reader["FirstName"].ToString();
                Globals.LastNameUser = reader["LastName"].ToString();
                HomePage homePage = new HomePage();
                homePage.Show();
            }
            else
            {
                Error.Text = "User or password not found ?";
                //MessageBox.Show("User or Password Not found", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.UserName.TabIndex = 1;
                this.UserName.Focus();
            }
            conn.Close();
        }

        private void UserName_Leave(object sender, EventArgs e)
        {

            if (UserName.Text == "")
            {
                this.BtnLogin.Enabled = false;
            }
            else if (Password.Text != "" && UserName.Text != "")
            {
                this.BtnLogin.Enabled = true;
            }

            //Profil User
            conn.Open();
            SqlCommand cmd = new SqlCommand($"SELECT * FROM Users WHERE Contact = @Contact", conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("Contact",UserName.Text);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                    NameLogin.Text = reader["LastName"].ToString();
                    this.UserName.BorderColor = Color.Green;
            }
            else
            {
                //MessageBox.Show("User Not found","UserName",MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.UserName.BorderColor = Color.Red;
                //this.UserName.TabIndex = 1;
                //this.UserName.Focus();
            }
            conn.Close();
        }

        private void Password_Leave(object sender, EventArgs e)
        {
            if (Password.Text == "")
            {
                this.BtnLogin.Enabled = false;
            }
            else if (Password.Text != "" && UserName.Text != "")
            {
                this.BtnLogin.Enabled = true;
            }

            //Password User
            conn.Open();
            SqlCommand cmd = new SqlCommand($"SELECT * FROM Users WHERE Password = @Password", conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("Password", Password.Text);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
               this.Password.BorderColor = Color.Green;
            }
            else
            {
                //MessageBox.Show("Password Not found", "Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Password.BorderColor = Color.Red;
                this.Password.TabIndex = 2;
                //this.Password.Focus();
            }
            conn.Close();
        }

        private void UserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowPw_Click(object sender, EventArgs e)
        {
            if (Password.UseSystemPasswordChar == true)
            {
                HidePassword.BringToFront();
                Password.UseSystemPasswordChar = false;
            }
        }

        private void HidePassword_Click(object sender, EventArgs e)
        {
            if (Password.UseSystemPasswordChar == false)
            {
                ShowPw.BringToFront();
                Password.UseSystemPasswordChar = true;
            }
        }

        private void ForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }


        private void ManageUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ManageUser manageUser = new ManageUser();
            manageUser.Show();

        }
    }
}

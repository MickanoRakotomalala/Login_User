using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_User
{
    public partial class Forgot_password : Form
    {

        public Login login;
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
        public Forgot_password(Login login)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
            this.login = login;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Forgot_password_Load(object sender, EventArgs e)
        {
            //Contact.Enabled = false;
        }

        private void Register_Click(object sender, EventArgs e)
        {
            if (this.FirstName.Text == "")
            {
                MessageBox.Show("This field must not be empty", "First Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                Contact.TabIndex = 5;
                Contact.Focus();
            }
            else if (this.Address.Text == "")
            {
                MessageBox.Show("This field must not be empty", "Address", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Address.TabIndex = 6;
                Address.Focus();
            }
            else if (this.Password.Text == "")
            {
                MessageBox.Show("This field must not be empty", "Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Password.TabIndex = 7;
                Password.Focus();
            }
            else if (this.ConfirmPassword.Text == "")
            {
                MessageBox.Show("This field must not be empty", "Password Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ConfirmPassword.TabIndex = 8;
                ConfirmPassword.Focus();
            }
            else if (this.Password.Text != this.ConfirmPassword.Text)
            {
                MessageBox.Show("incorrect Password", "Check Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ConfirmPassword.TabIndex = 7;
                ConfirmPassword.Focus();
            }
            else
            {
                SqlCommand commandContact = new SqlCommand("select * from Users Where  Id = @Id AND Contact = @contact AND FirstName = @FirstName AND Address = @Address AND LastName = @LastName AND GenderMale = @GenderMale AND GenderFemale = @GenderFemale ", conn);
                conn.Open();

                commandContact.CommandType = CommandType.Text;
                commandContact.Parameters.AddWithValue("@Id", ID.id);
                commandContact.Parameters.AddWithValue("@contact", Contact.Text);
                commandContact.Parameters.AddWithValue("@FirstName", FirstName.Text);
                commandContact.Parameters.AddWithValue("@LastName", LastName.Text);
                commandContact.Parameters.AddWithValue("@Address", Address.Text);
                commandContact.Parameters.AddWithValue("@GenderMale", SqlDbType.Bit).Value = GenderMale.Checked;
                commandContact.Parameters.AddWithValue("@GenderFemale", SqlDbType.Bit).Value = GenderFemale.Checked;
                SqlDataReader reader = commandContact.ExecuteReader();
                if (reader.Read() == true)
                {
                    UPDATE();
                }
                else
                {
                    MessageBox.Show("Error information !");
                }
                conn.Close();
            }
        }
        private void UPDATE()
        {
            SqlConnection conn = new SqlConnection("data source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\dbCSharp.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand cmd = new SqlCommand("UPDATE Users set FirstName = @FirstName, LastName = @LastName, GenderMale = @GenderMale, GenderFemale = @GenderFemale, Contact = @Contact, Address = @Address, Password = @Password Where id = @Id", conn);
            conn.Open();

            cmd.Parameters.AddWithValue("@Id", ID.id);
            cmd.Parameters.AddWithValue("@FirstName", FirstName.Text);
            cmd.Parameters.AddWithValue("@LastName", LastName.Text);
            cmd.Parameters.AddWithValue("@GenderMale", SqlDbType.Bit).Value = GenderMale.Checked;
            cmd.Parameters.AddWithValue("@GenderFemale", SqlDbType.Bit).Value = GenderFemale.Checked;
            cmd.Parameters.AddWithValue("@Contact", Contact.Text);
            cmd.Parameters.AddWithValue("@Address", Address.Text);
            cmd.Parameters.AddWithValue("@Password", Password.Text);
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Password Successfully Updated");
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
                Password.UseSystemPasswordChar = true ;
                ConfirmPassword.UseSystemPasswordChar = true ;
            }
        }

        private void GenderMale_CheckedChanged(object sender, EventArgs e)
        {
            if (GenderMale.Checked == true)
            {
                GenderFemale.Enabled = false;
            }
            else if (GenderMale.Checked == false)
            {
                GenderFemale.Enabled = true ;
            }
        }

        private void GenderFemale_CheckedChanged(object sender, EventArgs e)
        {
            if(GenderFemale.Checked == true)
            {
                GenderMale.Enabled = false;
            }
            else if (GenderFemale.Checked == false)
            {
                GenderMale.Enabled= true ;
            }
        }
    }
}

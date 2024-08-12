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
                SqlConnection conn = new SqlConnection("data source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\dbCSharp.mdf;Integrated Security=True;Connect Timeout=30");
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
                else if (reader.Read() == false)
                {
                    SqlConnection connFirstName = new SqlConnection("data source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\dbCSharp.mdf;Integrated Security=True;Connect Timeout=30");
                    SqlCommand commandFirstName = new SqlCommand("select * from Users Where  Id = @Id AND Contact = @contact AND FirstName != @FirstName AND Address = @Address AND LastName = @LastName AND GenderMale = @GenderMale AND GenderFemale = @GenderFemale ", connFirstName);
                    connFirstName.Open();

                    commandFirstName.CommandType = CommandType.Text;
                    commandFirstName.Parameters.AddWithValue("@Id", ID.id);
                    commandFirstName.Parameters.AddWithValue("@contact", Contact.Text);
                    commandFirstName.Parameters.AddWithValue("@FirstName", FirstName.Text);
                    commandFirstName.Parameters.AddWithValue("@LastName", LastName.Text);
                    commandFirstName.Parameters.AddWithValue("@Address", Address.Text);
                    commandFirstName.Parameters.AddWithValue("@GenderMale", SqlDbType.Bit).Value = GenderMale.Checked;
                    commandFirstName.Parameters.AddWithValue("@GenderFemale", SqlDbType.Bit).Value = GenderFemale.Checked;
                    SqlDataReader readerFirstName = commandFirstName.ExecuteReader();
                    if (readerFirstName.Read() == true)
                    {
                        MessageBox.Show("Incorrect FirstName","FirstName",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        FirstName.TabIndex = 1;
                        FirstName.Focus();
                    }
                    else if (readerFirstName.Read() == false)
                    {
                        SqlConnection connLastName = new SqlConnection("data source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\dbCSharp.mdf;Integrated Security=True;Connect Timeout=30");
                        SqlCommand commandLastName = new SqlCommand("select * from Users Where  Id = @Id AND Contact = @contact AND FirstName = @FirstName AND Address = @Address AND LastName != @LastName AND GenderMale = @GenderMale AND GenderFemale = @GenderFemale ", connLastName);
                        connLastName.Open();

                        commandLastName.CommandType = CommandType.Text;
                        commandLastName.Parameters.AddWithValue("@Id", ID.id);
                        commandLastName.Parameters.AddWithValue("@contact", Contact.Text);
                        commandLastName.Parameters.AddWithValue("@FirstName", FirstName.Text);
                        commandLastName.Parameters.AddWithValue("@LastName", LastName.Text);
                        commandLastName.Parameters.AddWithValue("@Address", Address.Text);
                        commandLastName.Parameters.AddWithValue("@GenderMale", SqlDbType.Bit).Value = GenderMale.Checked;
                        commandLastName.Parameters.AddWithValue("@GenderFemale", SqlDbType.Bit).Value = GenderFemale.Checked;
                        SqlDataReader readerLastName = commandLastName.ExecuteReader();
                        if (readerLastName.Read() == true)
                        {
                            MessageBox.Show("Incorrect LastName","LastName",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                            LastName.TabIndex = 2;
                            LastName.Focus();
                        }
                        else if (readerLastName.Read() == false)
                        {
                            SqlConnection connGender = new SqlConnection("data source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\dbCSharp.mdf;Integrated Security=True;Connect Timeout=30");
                            SqlCommand commandGender = new SqlCommand("select * from Users Where  Id = @Id AND Contact = @contact AND FirstName = @FirstName AND Address = @Address AND LastName = @LastName AND (GenderMale != @GenderMale OR GenderFemale != @GenderFemale) ", connGender);
                            connGender.Open();

                            commandGender.CommandType = CommandType.Text;
                            commandGender.Parameters.AddWithValue("@Id", ID.id);
                            commandGender.Parameters.AddWithValue("@contact", Contact.Text);
                            commandGender.Parameters.AddWithValue("@FirstName", FirstName.Text);
                            commandGender.Parameters.AddWithValue("@LastName", LastName.Text);
                            commandGender.Parameters.AddWithValue("@Address", Address.Text);
                            commandGender.Parameters.AddWithValue("@GenderMale", SqlDbType.Bit).Value = GenderMale.Checked;
                            commandGender.Parameters.AddWithValue("@GenderFemale", SqlDbType.Bit).Value = GenderFemale.Checked;
                            SqlDataReader readerGender = commandGender.ExecuteReader();
                            if (readerGender.Read() == true)
                            {
                                MessageBox.Show("Incorrect Gender Type","Gender",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                                GenderMale.TabIndex = 3;
                                GenderMale.Focus();
                            }
                            else if (readerGender.Read() == false)
                            {
                                SqlConnection connAddress = new SqlConnection("data source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\dbCSharp.mdf;Integrated Security=True;Connect Timeout=30");
                                SqlCommand commandAddress = new SqlCommand("select * from Users Where  Id = @Id AND Contact = @contact AND FirstName = @FirstName AND Address != @Address AND LastName = @LastName AND GenderMale = @GenderMale AND GenderFemale = @GenderFemale ", connAddress);
                                connAddress.Open();

                                commandAddress.CommandType = CommandType.Text;
                                commandAddress.Parameters.AddWithValue("@Id", ID.id);
                                commandAddress.Parameters.AddWithValue("@contact", Contact.Text);
                                commandAddress.Parameters.AddWithValue("@FirstName", FirstName.Text);
                                commandAddress.Parameters.AddWithValue("@LastName", LastName.Text);
                                commandAddress.Parameters.AddWithValue("@Address", Address.Text);
                                commandAddress.Parameters.AddWithValue("@GenderMale", SqlDbType.Bit).Value = GenderMale.Checked;
                                commandAddress.Parameters.AddWithValue("@GenderFemale", SqlDbType.Bit).Value = GenderFemale.Checked;
                                SqlDataReader readerAddress = commandAddress.ExecuteReader();
                                if (readerAddress.Read() == true)
                                {
                                    MessageBox.Show("Incorrect Address","Address",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                                    Address.TabIndex = 6;
                                    Address.Focus();
                                }
                                connAddress.Close();
                            }
                            connGender.Close();
                        }
                        connLastName.Close();
                    }
                    connFirstName.Close();
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

using System;
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
using System.Security.AccessControl;
using System.Data.SqlTypes;

namespace Login_User
{
    public partial class Update_users : Form
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

        public ManageUser manageUser;
        public HomePage homePage;
        public Login login;
        public Menu menu;
        public Update_users(ManageUser manageUser)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
            this.manageUser = manageUser;
        }        
        public Update_users(HomePage homePage)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
            this.homePage = homePage;
        }        
        public Update_users(Login login)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
            this.login = login;
        }        
        public Update_users(Menu menu)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
            this.menu = menu;
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
        private void UserAccount_CheckedChanged(object sender, EventArgs e)
        {
            if (UserAccount.Checked == true)
            {
                Supervisor.Enabled = false;
                Admin.Enabled = false;
            }
            else if (UserAccount.Checked == false)
            {
                Supervisor.Enabled= true;
                Admin.Enabled= true;
            }
        }
        private void Supervisor_CheckedChanged(object sender, EventArgs e)
        {
            if (Supervisor.Checked == true)
            {
                UserAccount.Enabled = false;
                Admin.Enabled = false ;
            }
            else if(Supervisor.Checked == false)
            {
                UserAccount.Enabled= true;
                Admin.Enabled= true;
            }
        }
        private void Admin_CheckedChanged(object sender, EventArgs e)
        {
            if (Admin.Checked == true)
            {
                UserAccount.Enabled = false;
                Supervisor.Enabled = false ;
            }
            else if (Admin.Checked == false)
            {
                UserAccount.Enabled = true;
                Supervisor.Enabled= true;
            }
        }

        private void Update_users_Load(object sender, EventArgs e)
        {
            if (this.manageUser != null)
            {
                UserAccount.Visible = true;
                Supervisor.Visible = true;
                Admin.Visible = true;
            }
            if(this.homePage != null)
            {
                UserAccount.Visible= false;
                Supervisor.Visible= false;
                Admin.Visible= false;
                this.TitleUpdateUser.Text = "Update Account";
                this.Register.Text = "Update";
                this.RegisterAccount.Text = Globals.NameUser + " " + Globals.LastNameUser;
            }
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
            else if (this.UserAccount.Checked == false && this.Supervisor.Checked == false && this.Admin.Checked == false)
            {
                MessageBox.Show("This field must not be empty", "Type User", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                UserAccount.TabIndex = 15;
                UserAccount.Focus();
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
                ConfirmPassword.TabIndex = 8;
                ConfirmPassword.Focus();
            }
            else if (this.Password.Text != this.ConfirmPassword.Text)
            {
                MessageBox.Show("incorrect Password", "Check Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ConfirmPassword.TabIndex = 7;
                ConfirmPassword.Focus();
            }
            else if (this.Profil.Image == null)
            {
                MessageBox.Show("This field must not be empty", "Profile Picture", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnAddPicture.TabIndex = 10;
                btnAddPicture.Focus();
                Profil.FillColor = Color.Teal;
            }
            else
            {
                SqlCommand commandContact = new SqlCommand("select Contact from Users Where  Contact = @contact AND Id = @Id" ,conn);
                conn.Open();

                commandContact.CommandType = CommandType.Text;
                commandContact.Parameters.AddWithValue("@contact", Contact.Text);
                commandContact.Parameters.AddWithValue("@Id",ID.id);
                SqlDataReader reader = commandContact.ExecuteReader();
                if (reader.Read() == true)
                {
                    UPDATE();
                    if (this.homePage != null)
                    {
                        DialogResult dialogResult = new DialogResult();
                        dialogResult = MessageBox.Show("You must close this session to apply the update","Update",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                        if (dialogResult == DialogResult.Yes)
                        {
                            this.Close();
                            this.homePage.Close();    
                        }
                    }
                }
                else
                {
                    SqlConnection conn = new SqlConnection("data source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\dbCSharp.mdf;Integrated Security=True;Connect Timeout=30");
                    SqlCommand command = new SqlCommand("select Contact from Users Where  Contact = @contact AND Id != @Id", conn);
                    conn.Open();

                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@contact", Contact.Text);
                    command.Parameters.AddWithValue("@Id", ID.id);
                    SqlDataReader rdr = command.ExecuteReader();
                    if (rdr.Read() == true)
                    {
                        MessageBox.Show("This Contact already exists", "Error Contact", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Contact.TabIndex = 4;
                        Contact.Focus();
                    }
                    else
                    {
                        UPDATE();
                    }
                    conn.Close();
                }
                conn.Close();

            }

        }

        private void btnAddPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "AllImages|*.JPEG;*.BMP;*.GIF;*.PNG;*.TIFF;*.JPG";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                IMG = Image.FromFile(ofd.FileName);
                Profil.Image = IMG;
            }
        }

        private void UPDATE()
        {
            SqlConnection conn = new SqlConnection("data source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\dbCSharp.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand cmd = new SqlCommand("UPDATE Users set FirstName = @FirstName, LastName = @LastName, GenderMale = @GenderMale, GenderFemale = @GenderFemale, Contact = @Contact, Address = @Address, Password = @Password, Profil = @Profil, UserAccount = @UserAccount, Supervisor = @Supervisor, Admin = @Admin Where id = @Id", conn);
            conn.Open();

            //Get types from PictureBox
            Image img = Profil.Image;
            MemoryStream ms = new MemoryStream();
            img.Save(ms, Profil.Image.RawFormat);
            byte[] bytes = ms.ToArray();

            cmd.Parameters.AddWithValue("@Id", ID.id);
            cmd.Parameters.AddWithValue("@FirstName", FirstName.Text);
            cmd.Parameters.AddWithValue("@LastName", LastName.Text);
            cmd.Parameters.AddWithValue("@GenderMale", SqlDbType.Bit).Value = GenderMale.Checked;
            cmd.Parameters.AddWithValue("@GenderFemale", SqlDbType.Bit).Value = GenderFemale.Checked;
            cmd.Parameters.AddWithValue("@Contact", Contact.Text);
            cmd.Parameters.AddWithValue("@Address", Address.Text);
            cmd.Parameters.AddWithValue("@Password", Password.Text);
            cmd.Parameters.AddWithValue("@Profil", bytes);
            cmd.Parameters.AddWithValue("@UserAccount", SqlDbType.Bit).Value = UserAccount.Checked;
            cmd.Parameters.AddWithValue("@Supervisor", SqlDbType.Bit).Value = Supervisor.Checked;
            cmd.Parameters.AddWithValue("@Admin", SqlDbType.Bit).Value = Admin.Checked;
            cmd.ExecuteNonQuery();
            conn.Close();



            //Refresh Datagridview in manageUser
            if (this.manageUser != null)
            {
                manageUser.RefreshData();

                //Select a line update
                string ValueToFind = ID.id;
                foreach (DataGridViewRow row in manageUser.ListUsers.Rows)
                {
                    if (row.Cells["Id"].Value != null && row.Cells["Id"].Value.ToString() == ValueToFind)
                    {
                        row.Selected = true;
                        break;
                    }
                }
            }
            if (this.homePage == null)
            {
                MessageBox.Show("Successfully Updated");
            }
        }
    }
}

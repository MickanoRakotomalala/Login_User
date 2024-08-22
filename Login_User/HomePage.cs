using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.AccessControl;
using static Guna.UI2.Native.WinApi;
using System.Runtime.InteropServices;
namespace Login_User
{
    public partial class HomePage : Form
    {
        private Login login;
        //Windows State Maximized with taskbar
        // Import user32.dll to get the taskbar size
        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll")]
        static extern bool GetWindowRect(IntPtr hWnd, out RECT lpRect);
        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;
        }

        private void MaximizeWithTaskbar()
        {
            // Get the taskbar size
            IntPtr taskbarHandle = FindWindow("Shell_TrayWnd", null);
            RECT taskbarRect;
            GetWindowRect(taskbarHandle, out taskbarRect);

            // Calculate working area excluding the taskbar
            var screen = Screen.PrimaryScreen.WorkingArea;

            // Set the window size and position
            this.Location = new System.Drawing.Point(screen.Left, screen.Top);
            this.Size = new System.Drawing.Size(screen.Width, screen.Height);
            this.WindowState = FormWindowState.Normal;
        }

        public HomePage(Login login)
        {
            InitializeComponent();
            this.Load += new EventHandler(HomePage_Load);
            this.login = login;
        }        
        public HomePage()
        {
            InitializeComponent();
            this.Load += new EventHandler(HomePage_Load);
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            Session_Name.Text = Globals.NameUser + " " + Globals.LastNameUser;
            Menu.Text = Globals.LastNameUser;
            Menu.Image = Globals.ProfilUser;
            MaximizeWithTaskbar();
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Your are sure to Logout this Session ?", "Logout", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Your are sure to Logout this Session ?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Session_Name_Click(object sender, EventArgs e)
        {
            Update_users UpU = new Update_users(this);
            UpU.FirstName.Text = Globals.NameUser;
            UpU.LastName.Text = Globals.LastNameUser;
            UpU.Contact.Text = Globals.ContactUser;
            UpU.Address.Text = Globals.AddressUser;
            UpU.GenderMale.Checked = Convert.ToBoolean(Globals.GenderMaleUser);
            UpU.GenderFemale.Checked = Convert.ToBoolean(Globals.GenderFemaleUser);
            UpU.Password.Text = Globals.PasswordUser;
            UpU.ConfirmPassword.Text = Globals.PasswordUser;
            UpU.UserAccount.Checked = Convert.ToBoolean(Globals.UserAccount);
            UpU.Supervisor.Checked = Convert.ToBoolean(Globals.Supervisor);
            UpU.Admin.Checked = Convert.ToBoolean(Globals.Admin);
            UpU.Profil.Image = Globals.ProfilUser;
            UpU.ShowDialog();
        }
        private void Menu_DropDownOpened(object sender, EventArgs e)
        {
            Menu.ForeColor = Color.Teal;
        }

        private void Menu_DropDownClosed(object sender, EventArgs e)
        {
            Menu.ForeColor = Color.White;
        }
    }
}

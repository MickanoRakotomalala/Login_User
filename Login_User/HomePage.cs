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

        public HomePage()
        {
            InitializeComponent();
            this.Load += new EventHandler(HomePage_Load);

        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            SessionName.Text =Globals.NameUser + " " + Globals.LastNameUser;
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
    }
}

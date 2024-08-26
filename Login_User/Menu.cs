using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_User
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            this.IsMdiContainer = true;

            InitializeSidebar();
            InitializeNavbar();

        }
        private void InitializeSidebar()
        {
            Panel sidebar = new Panel();
            sidebar.Dock = DockStyle.Left;
            sidebar.Width = 200;
            sidebar.BackColor = Color.Gray;

            Button dashboard = new Button();
            dashboard.Text = "Tableau de bord";
            dashboard.Dock = DockStyle.Top;

            Button reception = new Button();
            reception.Text = "Reception";
            reception.Dock = DockStyle.Top;

            // Ajouter les boutons à la sidebar
            sidebar.Controls.Add(dashboard);
            sidebar.Controls.Add(reception);

            // Ajouter la sidebar au formulaire principal
            this.Controls.Add(sidebar);
        }

        private void InitializeNavbar()
        {
            Panel navbar = new Panel();
            navbar.Dock = DockStyle.Top;
            navbar.Height = 50;
            navbar.BackColor = Color.DarkBlue;

            Label title = new Label();
            title.Text = "Fichier";
            title.ForeColor = Color.White;
            title.Dock = DockStyle.Left;
            title.TextAlign = ContentAlignment.MiddleCenter;

            Button logoutButton  = new Button();
            logoutButton.Text = "Déconnexion";
            logoutButton.Dock = DockStyle.Right;
            logoutButton.Click += (s, e) => { this.Close(); };

            navbar.Controls.Add(logoutButton);
            navbar.Controls.Add(title);

            this.Controls.Add(navbar);
        }
    }
}

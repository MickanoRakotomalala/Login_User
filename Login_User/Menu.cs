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
        private Login login;
        public Menu(Login login)
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            this.login = login;
        }        
        public Menu()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            OpenChildForm(dashboard);
        }

        private Form activeForm = null;

        private void OpenChildForm(Form childForm)
        {
            // Fermer le formulaire enfant actuel s'il existe
            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm;

            // Configurer le formulaire enfant pour l'imbriquer dans mainPanel
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            // Ajouter le formulaire enfant au panneau principal
            this.mdiPanelChild.Controls.Add(childForm);
            this.mdiPanelChild.Tag = childForm;

            // Afficher le formulaire enfant
            childForm.BringToFront();
            childForm.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            OpenChildForm(dashboard);

            Name_User.Text = Globals.LastNameUser;
            Name_User.Image = Globals.ProfilUser;

            Session_Name.Text = Globals.NameUser + " " + Globals.LastNameUser;
            Session_Name.Image = Globals.ProfilUser;
        }
    }
}

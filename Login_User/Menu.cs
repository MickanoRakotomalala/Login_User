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

        private void Logout_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Vous voulez vraiment quitter cette session ?", "Déconnexion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.AccessControl;
using System.Drawing.Imaging;
using System.IO;
using DGVPrinterHelper;

namespace Login_User
{
    public partial class ManageUser : Form
    {
        public ManageUser()
        {
            InitializeComponent();
            buttonCenter();
        }        
        private void buttonCenter()
        {
            // Obtient la taille du formulaire
            int formWidth = this.ClientSize.Width;
            int formHeight = this.ClientSize.Height;

            // Obtient la taille du bouton
            int buttonWidthbtnPanel = btnPanel.Width;
            int buttonHeightbtnPanel = btnPanel.Height;

            // Calcule les nouvelles positions pour centrer le bouton
            int newButtonX = (formWidth - buttonWidthbtnPanel) / 2;
            //int newButtonY = (formHeight - buttonWidthbtnPanel)/1;
            int newButtonY = 85;

            // Applique les nouvelles positions
            btnPanel.Location = new System.Drawing.Point(newButtonX, newButtonY);
        }
        // S'assure que le bouton reste centré si la taille du formulaire change
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            buttonCenter();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void RefreshData()
        {
            SqlConnection conn = new SqlConnection("data source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\dbCSharp.mdf;Integrated Security=True;Connect Timeout=30");
            string sql = "Select * from Users";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet set = new DataSet();
            adapter.Fill(set);
            ListUsers.DataSource = set.Tables[0];
            ListUsers.ClearSelection();
        }

        private void UserControl_Load(object sender, EventArgs e)
        {
            Profil.Visible = true;
            // TODO: cette ligne de code charge les données dans la table 'dbCSharpDataSet.Users'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.usersTableAdapter.Fill(this.dbCSharpDataSet.Users);
            RefreshData();
            ListUsers.RowTemplate.Height = 30;
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            signup snup = new signup(this);
            snup.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("You are sure to delete this line ?", "Delete Line selected", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                if (ListUsers.SelectedRows.Count > 0)
                {
                    int selectedRowIndex = ListUsers.SelectedRows[0].Index;
                    int id = Convert.ToInt32(ListUsers.SelectedRows[0].Cells["Id"].Value);

                    DeleteRowFromDatabase(id);
                    ListUsers.Rows.RemoveAt(selectedRowIndex);
                    MessageBox.Show("Deleting a line successfully");
                }
                else
                {
                    MessageBox.Show("No line selected");
                    btnDelete.Enabled = false;
                }
            }
        }

        private void DeleteRowFromDatabase(int id)
        {
            SqlConnection conn = new SqlConnection("data source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\dbCSharp.mdf;Integrated Security=True;Connect Timeout=30");
            try
                {
                    conn.Open();
                    string query = "DELETE FROM Users WHERE Id = @Id";
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@Id", id);
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while deleting : " + ex.Message);
                }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Update_users up = new Update_users(this);
            // Assurez-vous qu'au moins une ligne est sélectionnée
            if (ListUsers.SelectedRows.Count > 0)
            {
                // Récupérer l'index de la première ligne sélectionnée
                int rowIndex = ListUsers.SelectedRows[0].Index;

                // Récupérez la valeur de l'ID de la colonne "ID"
                ID.id = ListUsers.Rows[rowIndex].Cells["ID"].Value.ToString();
                var FirstName = ListUsers.Rows[rowIndex].Cells["FirstName"].Value;
                var LastName = ListUsers.Rows[rowIndex].Cells["LastName"].Value;
                var GenderMale = ListUsers.Rows[rowIndex].Cells["GenderMale"].Value;
                var GenderFemale = ListUsers.Rows[rowIndex].Cells["GenderFemale"].Value;
                var Contact = ListUsers.Rows[rowIndex].Cells["Contact"].Value;
                var Address = ListUsers.Rows[rowIndex].Cells["Address"].Value;
                var UserAccount = ListUsers.Rows[rowIndex].Cells["UserAccount"].Value;
                var Supervisor = ListUsers.Rows[rowIndex].Cells["Supervisor"].Value;
                var Admin = ListUsers.Rows[rowIndex].Cells["Admin"].Value;
                var Password = ListUsers.Rows[rowIndex ].Cells["Password"].Value;

                byte[] imageData = (byte[])ListUsers.Rows[rowIndex].Cells["Profil"].Value;
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    up.Profil.Image = Image.FromStream(ms);
                }

                    //Attribution des valeurs au champs de la fenêtre Update_users
                    up.FirstName.Text = FirstName.ToString();
                    up.LastName.Text = LastName.ToString();
                    up.GenderMale.Checked = Convert.ToBoolean(GenderMale.ToString());
                    up.GenderFemale.Checked = Convert.ToBoolean(GenderFemale.ToString());
                    up.Contact.Text = Contact.ToString();
                    up.Address.Text = Address.ToString();
                    up.Password.Text = Password.ToString();
                    up.ConfirmPassword.Text = Password.ToString();
                    up.UserAccount.Checked = Convert.ToBoolean(UserAccount.ToString());
                    up.Supervisor.Checked = Convert.ToBoolean(Supervisor.ToString());
                    up.Admin.Checked = Convert.ToBoolean(Admin.ToString());
                    up.ShowDialog();

            }
            else
            {
                // Aucun ligne n'est sélectionnée
                MessageBox.Show("No line selected");
            }
        }

        private void ListUsers_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Update_users up = new Update_users(this);
                DataGridViewRow row = this.ListUsers.Rows[e.RowIndex];
                ID.id = row.Cells["Id"].Value.ToString();
                up.FirstName.Text = row.Cells["FirstName"].Value.ToString();
                up.LastName.Text = row.Cells["LastName"].Value.ToString();

                string GenderM = row.Cells["GenderMale"].Value.ToString();
                up.GenderMale.Checked = Convert.ToBoolean(GenderM);

                string GenderF = row.Cells["GenderFemale"].Value.ToString();
                up.GenderFemale.Checked = Convert.ToBoolean(GenderF);

                up.Contact.Text = row.Cells["Contact"].Value.ToString();
                up.Address.Text = row.Cells["Address"].Value.ToString();
                up.Password.Text = row.Cells["Password"].Value.ToString();
                up.ConfirmPassword.Text = row.Cells["Password"].Value.ToString();

                string TypeUser = row.Cells["UserAccount"].Value.ToString();
                up.UserAccount.Checked = Convert.ToBoolean(TypeUser);

                string TypeSupervisor = row.Cells["Supervisor"].Value.ToString();
                up.Supervisor.Checked = Convert.ToBoolean(TypeSupervisor);

                string TypeAdmin = row.Cells["Admin"].Value.ToString();
                up.Admin.Checked = Convert.ToBoolean(TypeAdmin);

                byte[] imageData = (byte[])row.Cells["Profil"].Value;
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    up.Profil.Image = Image.FromStream(ms); 
                }
                //MessageBox.Show(up.GenderFemale.Checked.ToString());
                up.ShowDialog();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //ListUsers.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            DGVPrinter printer = new DGVPrinter();
            printer.RowHeight = (DGVPrinter.RowHeightSetting)30;
            printer.ColumnWidth = (DGVPrinter.ColumnWidthSetting)10;
            printer.Title = "MANAGE USERS";
            printer.TitleAlignment = StringAlignment.Center;
            printer.SubTitle = string.Format("List Users",printer.SubTitleColor = Color.Teal,printer);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit|StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = false;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "List users by Mickano";
            printer.FooterSpacing = 10;
            printer.PageSettings.Landscape = true;
            printer.PrintMargins = new System.Drawing.Printing.Margins(20,20,20,20);
            printer.PrintPreviewDataGridView(ListUsers);
        }
    }   
}

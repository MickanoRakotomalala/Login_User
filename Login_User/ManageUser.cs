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
        }

        private void UserControl_Load(object sender, EventArgs e)
        {
            profilDataGridViewImageColumn.Visible = false;
            // TODO: cette ligne de code charge les données dans la table 'dbCSharpDataSet.Users'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.usersTableAdapter.Fill(this.dbCSharpDataSet.Users);
            RefreshData();

        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            signup snup = new signup(this);
            snup.Show();
            //this.Close();
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

        public void AddDataToGrid(string FirstName, string LastName, bool GenderMale,bool GenderFemale,string Contact, string Address, string Password,Image Profil)
        {
            string[] row = { FirstName, LastName,GenderMale.ToString(),GenderFemale.ToString(),Contact,Address,Password,Profil.ToString()};
            ListUsers.Rows.Add(row);
        }

        private void ListUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

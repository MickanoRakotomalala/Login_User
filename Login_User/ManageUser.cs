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
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RefreshData()
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
            signup snup = new signup();
            snup.Show();
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            {
                if (ListUsers.SelectedRows.Count > 0)
                {
                    int selectedRowIndex = ListUsers.SelectedRows[0].Index;
                    int id = Convert.ToInt32(ListUsers.SelectedRows[0].Cells["Id"].Value);

                    DeleteRowFromDatabase(id);
                    ListUsers.Rows.RemoveAt(selectedRowIndex);
                    MessageBox.Show(id.ToString());
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
                        MessageBox.Show(id.ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Une erreur s'est produite lors de la suppression : " + ex.Message);
                }
        }

        private void ListUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

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

namespace Login_User
{
    public partial class ManageUser : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\Perso\\PROJET C#\\Login\\Login_User\\dbCSharp.mdf\";Integrated Security=True;Connect Timeout=30");
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
    }
}

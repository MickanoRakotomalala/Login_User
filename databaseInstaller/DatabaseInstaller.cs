using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration.Install;
using System.Collections;
using System.ComponentModel;

namespace databaseInstaller
{
        [RunInstaller(true)]
    public class DatabaseInstaller : Installer
    {
        public override void Install(IDictionary stateSaver)
        {
            base.Install(stateSaver);
            ExecuteSqlScript();
        }

        private void ExecuteSqlScript()
        {
            string scriptPath = Context.Parameters["scriptPath"];
            string connectionString = Context.Parameters["connectionString"];

            if (File.Exists(scriptPath))
            {
                string script = File.ReadAllText(scriptPath);

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(script, connection);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            else
            {
                throw new FileNotFoundException($"Script file not found: {scriptPath}");
            }
        }
    }
}
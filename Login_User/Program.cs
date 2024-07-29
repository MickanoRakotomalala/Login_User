using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.AccessControl;
using System.IO;

namespace Login_User
{
    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string folderPath = @"C:\Program Files (x86)\Login";
            string userOrGroupName = "Utilisateurs";  // or use a specific user, e.g., "DOMAIN\User"

            SetFullControlPermissions(folderPath, userOrGroupName);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }

        public static void SetFullControlPermissions(string folderPath, string userOrGroupName)
        {
            try
            {
                // Verify that the folder exists
                if (!Directory.Exists(folderPath))
                {
                    Console.WriteLine("Directory does not exist.");
                    return;
                }

                // Get the directory info
                DirectoryInfo directoryInfo = new DirectoryInfo(folderPath);

                // Get the existing access control
                DirectorySecurity directorySecurity = directoryInfo.GetAccessControl();

                // Define the rule for full control
                FileSystemAccessRule rule = new FileSystemAccessRule(
                    userOrGroupName,  // User or group name
                    FileSystemRights.FullControl,  // Permissions
                    InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit,  // Inheritance
                    PropagationFlags.None,  // Propagation
                    AccessControlType.Allow);  // Access control type

                // Remove any existing rules for the specified user or group
                directorySecurity.RemoveAccessRuleAll(rule);

                // Add the new rule to the access control list
                directorySecurity.AddAccessRule(rule);

                // Set the updated access control
                directoryInfo.SetAccessControl(directorySecurity);

                Console.WriteLine($"Full control permissions set for {userOrGroupName}.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
        public static class Globals
        {
            public static String NameUser
            {get; set; }
            public static String LastNameUser 
            { get; set; }
        }

}

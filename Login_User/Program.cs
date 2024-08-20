using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.AccessControl;
using System.IO;
using System.Drawing;

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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HomePage());
        }

    }
        public static class Globals
        {
            public static String NameUser
            {get; set; }
            public static String LastNameUser 
            { get; set; }
            public static String GenderMaleUser
            { get; set; }
            public static String GenderFemaleUser
            { get; set; }
            public static String ContactUser
            { get; set; }
            public static String AddressUser 
            { get; set; }
            public static String PasswordUser
            { get; set; }
            public static String UserAccount
            { get; set; }
            public static String Supervisor 
            { get; set; }
            public static String Admin
            { get; set; }
            public static Image ProfilUser
            { get; set; }
        }
    public static class ID
        {
         public static String id { get; set; }
        }
}

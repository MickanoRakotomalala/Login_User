using System.Diagnostics;
using System.IO;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            // Chemin vers le fichier batch
            string batchFilePath = @"C:\Program Files (x86)\Login\Setup\Fullcontrol.bat"; // Changez le chemin en fonction de votre configuration

            // Créer un processus pour exécuter le fichier batch avec des privilèges élevés
            ProcessStartInfo processInfo = new ProcessStartInfo("cmd.exe", $"/c \"{batchFilePath}\"")
            {
                Verb = "runas", // Demande l'élévation des privilèges
                UseShellExecute = true
            };

            //Process process = Process.Start(processInfo);
            //process.WaitForExit();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erreur : {ex.Message}");
        }
    }
}

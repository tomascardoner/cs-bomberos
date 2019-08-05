using System;
using System.IO;

namespace ConfigFileFix
{
    class Program
    {
        static void Main(string[] args)
        {
            const string applicationFileName = "CSBomberos.exe.config";
            string[] excludedePaths = { "C:\\$Recycle.Bin", "C:\\Boot", "C:\\Config.Msi", "C:\\Documents and Settings", "C:\\Program Files", "C:\\Program Files (x86)", "C:\\ProgramData", "C:\\Recovery", "C:\\System Volume Information", "C:\\Users", "C:\\Windows", "C:\\Windows.old" };

            string[] foldersFound;
            string[] filesFound;

            Console.WriteLine("Config file fixer v1.0");
            Console.WriteLine("======================");
            Console.WriteLine("");

            foldersFound = Directory.GetDirectories("C:\\", "*", SearchOption.TopDirectoryOnly);
            foreach (string folderItem in foldersFound)
            {
                if (Array.Find(excludedePaths, element => element == folderItem) == null)
                {
                    filesFound = BuscarArchivoEnCarpeta(folderItem, applicationFileName);
                    if (filesFound.GetUpperBound(0) > -1)
                    {
                        Console.WriteLine("Se han encontrado {0} archivos.", filesFound.GetUpperBound(0) + 1);
                        foreach (string fileFound in filesFound)
                        {
                            ModificarArchivo(fileFound);
                        }
                    }
                }
            }
        }

        static private string[] BuscarArchivoEnCarpeta(string carpeta, string nombreArchivo)
        {
            Console.WriteLine("Buscando en la carpeta: {0}...", carpeta);
            return Directory.GetFiles(carpeta, nombreArchivo, SearchOption.AllDirectories);
        }

        static private void ModificarArchivo(string fileNameAndPath)
        {
            Console.WriteLine("Corrigiendo el archivo: {0}...", fileNameAndPath);
            string text = File.ReadAllText(fileNameAndPath);
            text = text.Replace("CSBomberos.DesktopApplication", "CSBomberos");
            File.WriteAllText(fileNameAndPath, text);
        }
    }
}

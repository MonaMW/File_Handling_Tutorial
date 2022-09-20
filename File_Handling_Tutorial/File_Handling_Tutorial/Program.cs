using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace File_Handling_Tutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileInfo fi = new FileInfo("T:/WKH_EXC/Trash/cbec/BMI-data.csv");
            //fi.CopyTo("C:/010 Projects/016_File_Handling_Tutorial/meineDatei13.csv");

            //FileInfo fi_neu = new FileInfo("C:/010 Projects/016_File_Handling_Tutorial/meineDatei13.csv");
            //fi_neu.Delete();

            Console.WriteLine("Gebe mir den Pfad an, wohin die Datei geschrieben werden soll.");
            string path = Console.ReadLine();
            path.Replace("\\", "\\\\");
            DirectoryInfo di = new DirectoryInfo(path);
            while(di.Exists == false)
            {
                Console.WriteLine("Der Pfad existiert nicht, gib mir einen neuen.");
                path = Console.ReadLine();
                di = new DirectoryInfo(path);
            }
            Console.WriteLine("Wie soll die Datei heißen?");
            string filename = Console.ReadLine();

            fi.CopyTo(path + "\\" + filename);

            Console.ReadLine();
        }
    }
}

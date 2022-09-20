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
            //FileInfo fi = new FileInfo("T:/WKH_EXC/Trash/cbec/BMI-data.csv");
            //fi.CopyTo("C:/010 Projects/016_File_Handling_Tutorial/meineDatei13.csv");

            //FileInfo fi_neu = new FileInfo("C:/010 Projects/016_File_Handling_Tutorial/meineDatei13.csv");
            //fi_neu.Delete();

            //Console.WriteLine("Gebe mir den Pfad an, wohin die Datei geschrieben werden soll.");
            //string path = Console.ReadLine();
            //path.Replace("\\", "\\\\");
            //DirectoryInfo di = new DirectoryInfo(path);
            //while(di.Exists == false)
            //{
            //    Console.WriteLine("Der Pfad existiert nicht, gib mir einen neuen.");
            //    path = Console.ReadLine();
            //    di = new DirectoryInfo(path);
            //}
            //Console.WriteLine("Wie soll die Datei heißen?");
            //string filename = Console.ReadLine();

            //fi.CopyTo(path + "\\" + filename);

            //FileInfo fi = new FileInfo("T:/WKH_EXC/Trash/cbec/BMI-data.csv");

            //if (fi.Exists)
            //{
            //    //Execute only if file exists
            //    fi.CopyTo("T:/WKH_EXC/Trash/cbec/BMI-data.csv");
            //}

            //@ damit kein \\ nötig ist
            string path = @"C:/010 Projects/016_File_Handling_Tutorial/meineDatei13.csv";
            StreamReader sr = new StreamReader(path);
            List<string[]> eintraege = new List<string[]>();

            //sr.ReadToEnd() liest den Stream zuende und sr.EndOfStream = true

            sr.ReadLine();  //Header der Datei wird gelesen und anschließend ignoriert
            while (!sr.EndOfStream)
            {
                //Console.WriteLine(sr.ReadLine());
                eintraege.Add(sr.ReadLine().Split(';'));
            }

            for(int j = 18; j <= 100; j++)
            {
                using (StreamWriter writer = new StreamWriter($@"C:/010 Projects/016_File_Handling_Tutorial/Gewichte_{j}.csv", true))  //true am Ende = if(File.Exists())
                    for (int i = 0; i < eintraege.Count; i++)
                    {
                        if (Convert.ToInt32(eintraege[i][2]) == j)
                        {
                            writer.WriteLine(string.Join(";", eintraege[i]));
                            Console.WriteLine(string.Join("\t", eintraege[i]));
                        }
                    }
            }
            
            Console.ReadLine();
        }
    }
}

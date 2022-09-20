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
            FileStream fs = new FileStream("C:\\csharpfile.txt", FileMode.Create);
            fs.Close();
            Console.Write("File has been created and the Path is C:\\csharpfile.txt");
            Console.ReadKey();
        }
    }
}

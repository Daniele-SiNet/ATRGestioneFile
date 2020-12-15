using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ATRGestioneFile
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("************************************");
            Console.WriteLine("inserisci il percorso da cui leggere i files:");
            string path = Console.ReadLine();
            Console.WriteLine("************************************");
            string[] files = System.IO.Directory.GetFiles(path);

            foreach (string s in files)
            {
                Console.WriteLine(s);
            }



            Console.ReadKey();
        }
    }
}
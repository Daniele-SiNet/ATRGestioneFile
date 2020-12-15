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
            string[] files = Directory.GetFiles(path);

            FileInfo fi;

            foreach (string s in files)
            {
                fi = new FileInfo(s);
                Console.WriteLine(fi.Name);
                if (fi.Name.StartsWith("FUTURO")) 
                {
                    Console.WriteLine("il file è presente");
                    File.Copy(s, "C:\\Users\\DanielePedruzzi\\Desktop\\SQL\\FUTURO.xlsx");
                }
            }

            Console.WriteLine("************************************");
            Console.WriteLine("operazione completata");
            Console.WriteLine("************************************");
            Console.ReadKey();
         
        }
    }
}
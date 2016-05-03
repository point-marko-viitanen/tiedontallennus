using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohjelmoinnin_jatkokurssi_tehtävä_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kirjoita tähän:");
            string UusiTeksi = Console.ReadLine();
            string Viesti = UusiTeksi;
            // kirjoittaa
            File.WriteAllText(@"C:\Temp\Teksi.txt", Viesti);
            // lukee
            Viesti = File.ReadAllText(@"C:\Temp\Teksi.txt"); 

            Console.ReadLine();


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohjelmointitehtävä2
{
    class Program
    {
        static void Main(string[] args)
        {
            string tiedosto = @"C:\Temp\Teksti.txt";
            string yourText = "Hello World!";

            System.IO.File.WriteAllText("yourfile.ext", yourText); //writing

            yourText = System.IO.File.ReadAllText("yourfile.ext"); //reading
        }
    }
}

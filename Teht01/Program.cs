using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht01
{
    class Program
    {
        static void Main(string[] args)
        {
            Hissi hissi = new Hissi();
            int luku;
            hissi.Kerros = 1;
            do
            {

                Console.WriteLine("Anna kerros 1-5, avaa ovet painamalla 0 -> ");
                string line = Console.ReadLine();
                luku = int.Parse(line);
                hissi.Kerros = luku;

                Console.WriteLine("Hissi on kerroksessa " + hissi.Kerros);
                
            } while (luku != 0);
            Console.WriteLine("Astu ulos hissistä!");
        }
    }
}

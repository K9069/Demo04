using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht02
{
    class Program
    {
        static void Main(string[] args)
        {
            Amplifier amplifier = new Amplifier();
            int luku;
            int lopetus;
            luku = 1;
            
            do
            {

                Console.WriteLine("Give new volume between 0-100, sammuta laite painamalla -1 -> ");
                string line = Console.ReadLine();
                luku = int.Parse(line);
                lopetus = int.Parse(line);
                amplifier.Volume = luku;

                Console.WriteLine("Amplifiers volume is set to " + amplifier.Volume);

            } while (lopetus != -1);
            Console.WriteLine("Amplifier is turned off!");
        }
    }
}


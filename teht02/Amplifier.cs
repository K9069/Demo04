using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht02
{
    class Amplifier
    {
        private readonly int maxVolume = 100;
        private readonly int minVolume = 0;

        private int volume;
        public int Volume
        {
            get
            {
                return volume;
            }
            set
            {
                if (value >= maxVolume)
                {
                    Console.WriteLine("Volume is set to maxium!");
                    volume = maxVolume;
                }
                
                else if (value <= minVolume)
                {
                    Console.WriteLine("Volume is se to minium!");
                    volume = minVolume;
                }
                else
                {
                    volume = value;
                }

            }
        }
    }
}

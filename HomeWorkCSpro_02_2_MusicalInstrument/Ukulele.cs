using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkCSpro_02_2_MusicalInstrument
{
    internal class Ukulele : MusicalInstrument
    {
        public Ukulele() : base("Ukulele",
                        "A small, guitar-like string instrument from Hawaii",
                        "The ukulele was developed in the 19th century in Hawaii"){ }

        public override string Sound()
        {
            return $"{this.GetType().Name} sounds: plink-plink";
        }
    }
}

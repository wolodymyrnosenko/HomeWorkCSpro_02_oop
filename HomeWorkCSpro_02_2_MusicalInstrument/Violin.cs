using System;

namespace HomeWorkCSpro_02_2_MusicalInstrument
{
    internal class Violin : MusicalInstrument
    {
        public Violin() : base("Violin",
                                "A bowed string instrument with four strings",
                                "The violin originated in Italy in the 16th century") { }

        public override string Sound()
        {
            return $"{this.GetType().Name} sounds: vreee-vreee";
        }
    }
}

using System;

namespace HomeWorkCSpro_02_2_MusicalInstrument
{
    internal class Trombone : MusicalInstrument
    {
        public Trombone() : base("Trombone",
                        "A brass wind instrument with a telescopic slide",
                        "The trombone was developed in 15th century Europe") { }

        public override string Sound()
        {
            return $"{this.GetType().Name} sounds: waaah-waah";
        }
    }
}

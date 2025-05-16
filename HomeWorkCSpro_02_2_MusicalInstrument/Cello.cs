using System;

namespace HomeWorkCSpro_02_2_MusicalInstrument
{
    internal class Cello : MusicalInstrument//Віолончель
    {
        public Cello() : base("Cello",
                        "A large bowed string instrument played sitting down",
                        "The cello emerged in 16th century Italy"){ }

        public override string Sound()
        {
            return $"{this.GetType().Name} sounds: voooom-voooom";
        }
    }
}

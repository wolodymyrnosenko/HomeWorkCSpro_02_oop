using System;

namespace HomeWorkCSpro_02_2_MusicalInstrument
{
    internal abstract class MusicalInstrument
    {
        public string Name { get; protected set; }
        public string Description { get; protected set; }
        public string HistoryFact { get; protected set; }

        public abstract string Sound();

        public MusicalInstrument(string name, string description, string historyFact)
        {
            Name = name;
            Description = description;
            HistoryFact = historyFact; 
        }
        public void Show()
        {
            Console.WriteLine($"Name: {Name}");
        }

        public void Desc()
        {
            Console.WriteLine($"Description: {Description}");
        }

        public void History()
        {
            Console.WriteLine($"History: {HistoryFact}");
        }
    }
}

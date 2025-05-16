namespace HomeWorkCSpro_02_2_MusicalInstrument
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var instruments = new List<MusicalInstrument>
            {
                new Cello(),
                new Trombone(),
                new Ukulele(),
                new Violin()
            };
            foreach (var instrument in instruments)
            {
                instrument.Show();
                instrument.Desc();
                instrument.History();
                Console.WriteLine(instrument.Sound());
                Console.WriteLine("-------------");
            }
        }
    }
}
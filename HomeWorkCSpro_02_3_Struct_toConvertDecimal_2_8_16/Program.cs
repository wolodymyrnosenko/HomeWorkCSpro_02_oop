using System.Text;

namespace HomeWorkCSpro_02_3_Struct_toConvertDecimal_2_8_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            for (int i = 5; i < 30; i += 10)
            {
                new DecimalNumber(i).OutputConsole();
                Console.WriteLine("-----------------------------");
            }
        }
    }
}
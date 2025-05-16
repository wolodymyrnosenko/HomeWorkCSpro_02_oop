using System.Text;

namespace HomeWorkCSpro_02_1_MoneyAndProduct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            var curTest = Currency.UAH.Name;
            Console.WriteLine(curTest);
            var curTest2 = Currency.UAH.Symbol;
            Console.WriteLine(curTest2);

            var moneyTest = new Money(10, 30, Currency.EUR);
            moneyTest.OutputConsole();
            var moneyTest2 = new Money(2, 350, Currency.UAH);
            moneyTest2.OutputConsole("digits");
            moneyTest2.OutputConsole("str");

            moneyTest.IncreaseAmount(20, 85);
            moneyTest.OutputConsole();
            moneyTest.DecreaseAmount(10, 123);
            moneyTest.OutputConsole();
            try
            {
                moneyTest.DecreaseAmount(50, 123);
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            moneyTest.OutputConsole();
            Console.WriteLine("-----------------");
            //Product coffee = new Product("", 100, 00);//Test exception

            /*string str = null;
            Product coffee = new Product(str, 100, 00);*///Test exception

            Product coffee = new Product("coffee", 100, 50);
            coffee.OutputConsole();

            Product bread = new Product("bread", 30, 0, Currency.UAH);
            bread.OutputConsole();

            bread.DecreasePrice(15, 140);
            bread.OutputConsole();

            try
            {
                bread.DecreasePrice(15, 140);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            bread.OutputConsole();
        }
    }
}
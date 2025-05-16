namespace HomeWorkCSpro_02_1_MoneyAndProduct
{
    internal class Money
    {
        private int _wholePart;
        private int _fractionalPart;
        public CurrencyType CurrencyTypeMoney { get; init; } = Currency.USD;//Type Currency do not allow to use, cause static type (How to incapsulate CurrencyType?)
        public int WholePart
        {
            get
            {
                return _wholePart;
            }
            set
            {
                if (value >= 0)
                    _wholePart = value;
                else
                    throw new ArgumentException("від’ємне значення не передбачено для вказання ціни продукта");
            }
        }
        public int FractionalPart
        {
            get
            {
                return _fractionalPart;
            }
            set
            {
                if (value >= 0)
                {
                    _fractionalPart = value % 100;
                    _wholePart += value / 100;
                }
                else
                    throw new ArgumentException("від’ємне значення не передбачено для вказання ціни продукта");
            }
        }
        public Money(int whole, int fractional)
        {
            WholePart = whole;
            FractionalPart = fractional;
        }

        public Money(int whole, int fractional, CurrencyType currency) : this(whole, fractional)
        {
            CurrencyTypeMoney = currency;
        }

        public void SetAmount(int whole, int fractional)
        {
            WholePart = whole;
            FractionalPart = fractional;
        }

        public void IncreaseAmount(int whole, int fractional)
        {
            int totalFractionals = (_wholePart * 100 + _fractionalPart) + (whole * 100 + fractional);
            WholePart = totalFractionals / 100;
            FractionalPart = totalFractionals % 100;
        }

        public void DecreaseAmount(int whole, int fractional)
        {
            int totalFractionals = (_wholePart * 100 + _fractionalPart) - (whole * 100 + fractional);
            DecreaseAmount(totalFractionals);
        }
        public void DecreaseAmount(int totalFractionals)
        {
            WholePart = totalFractionals / 100;
            FractionalPart = totalFractionals % 100;
        }

        public virtual void OutputConsole(string digits = "sum")
        {
            if (digits == "sum")
            { 
                Console.WriteLine($"Сума у {CurrencyTypeMoney.Name}: {_wholePart}{CurrencyTypeMoney.Separator}{_fractionalPart}{CurrencyTypeMoney.Symbol}");
                Console.WriteLine($"Сума у {CurrencyTypeMoney.Name}: {_wholePart} {CurrencyTypeMoney.AbbreviationWhole} {_fractionalPart} {CurrencyTypeMoney.AbbreviationFractionals}");
            }
            else if (digits == "digits")
                Console.WriteLine($"{_wholePart}{CurrencyTypeMoney.Separator}{_fractionalPart.ToString().PadLeft(2, '0')}{CurrencyTypeMoney.Symbol}");
            else
                Console.WriteLine("Необхідно задати параметр виводу на екран: text || digits");
        }
    }
}

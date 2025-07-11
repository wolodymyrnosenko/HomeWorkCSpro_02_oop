﻿namespace HomeWorkCSpro_02_1_MoneyAndProduct
{
    internal class Product : Money
    {
        public static int TotalQuantityProducts = 0;
        private string _name;

        public string Name
        {
            get
            {  
                return _name;
            }
            init
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("відсутня назва продукту");
                else
                    _name = value; 
            }
        }

        public Product(string name, int priceWhole, int priceFractional, CurrencyType currency)
            : base(priceWhole, priceFractional, currency)
        {
            Name = name;
            TotalQuantityProducts++;
        }
        public Product(string name, int priceWhole, int priceFractional)
    : base(priceWhole, priceFractional)
        {
            Name = name;
            TotalQuantityProducts++;
        }

        public void DecreasePrice(int whole, int fractional)//Equals inherited method DecreaseAmount
        {
            DecreaseAmount(whole, fractional);
        }

        public void DecreasePrice(int totalFractionals)//Equals inherited method DecreaseAmount
        {
            DecreaseAmount(totalFractionals);
        }
        public override void OutputConsole(string digits = "digits")
        {
            Console.WriteLine($"Всього створено продуктів: {Product.TotalQuantityProducts}");
            Console.Write($"Товар: {Name}, Ціна: ");
            base.OutputConsole(digits);
        }
    }
}
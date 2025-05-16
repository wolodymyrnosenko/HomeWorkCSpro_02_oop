namespace HomeWorkCSpro_02_1_MoneyAndProduct
{
    public static class Currency
    {
        public static readonly CurrencyType UAH = new CurrencyType("UAH", '₴', ',');
        public static readonly CurrencyType USD = new CurrencyType("USD", '$');
        public static readonly CurrencyType EUR = new CurrencyType("EUR", '€', '?');
    }
}

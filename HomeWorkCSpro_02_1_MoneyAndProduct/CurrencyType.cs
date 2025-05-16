namespace HomeWorkCSpro_02_1_MoneyAndProduct
{
    public class CurrencyType
    {
        public string Name { get; }
        public string  AbbreviationWhole{ get; }
        public string AbbreviationFractionals { get; }
        public char Symbol { get; }
        public char separator;//Cause there isn't automat building this field (why?)
        public char Separator
        {
            get
            { return separator; }
            set 
            {
                if (value != ',' || value != '.')
                    separator = '.';
            }
        }
        public CurrencyType(string name, char symbol, string abbrWhole, string abbrFractionals, char separator = '.')
        {
            Name = name;
            Symbol = symbol;
            Separator = separator;
            AbbreviationWhole = abbrWhole;
            AbbreviationFractionals = abbrFractionals;
        }
    }
}
namespace HomeWorkCSpro_02_3_Struct_toConvertDecimal_2_8_16
{
    struct DecimalNumber
    {
        private int number;
        public DecimalNumber(int number)
        {
            this.number = number;
        }
        public string ToBinary()
        {
            return Convert.ToString(number, 2);
        }
        public string ToOctal()
        {
            return Convert.ToString(number, 8);
        }
        public string ToHexadecimal()
        {
            return Convert.ToString(number, 16).ToUpper();
        }

        public void OutputConsole()
        {
            Console.WriteLine($"Десяткове число: {number}");
            Console.WriteLine($"Двійкова система: {ToBinary()}");
            Console.WriteLine($"Вісімкова система: {ToOctal()}");
            Console.WriteLine($"Шістнадцяткова система: {ToHexadecimal()}");
        }
    }
}

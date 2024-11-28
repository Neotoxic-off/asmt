namespace ASMT
{
    public static class Bases
    {
        public static string Hexadecimal(string inputValue)
        {
            if (int.TryParse(inputValue, out int decimalValue))
            {
                return decimalValue.ToString("X");
            }
            else
            {
                return $"Error: Invalid input '{inputValue}' for hexadecimal conversion.";
            }
        }

        public static string Decimal(string inputValue)
        {
            if (int.TryParse(inputValue, out int decimalValue))
            {
                return decimalValue.ToString("D");
            }
            else
            {
                return $"Error: Invalid input '{inputValue}' for decimal conversion.";
            }
        }

        public static string Octal(string inputValue)
        {
            if (int.TryParse(inputValue, out int decimalValue))
            {
                return Convert.ToString(decimalValue, 8);
            }
            else
            {
                return $"Error: Invalid input '{inputValue}' for octal conversion.";
            }
        }

        public static string Binary(string inputValue)
        {
            if (int.TryParse(inputValue, out int decimalValue))
            {
                return Convert.ToString(decimalValue, 2);
            }
            else
            {
                return $"Error: Invalid input '{inputValue}' for binary conversion.";
            }
        }
    }
}

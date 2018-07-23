namespace RomanConverter
{
    public class RomanNumeralConverter : IRomanNumeralConverter
    {
        public string Convert(int number)
        {
            string roman = "";

            if (number == 10)
            {
                roman = "X";
                return roman;
            }
            if (number == 9)
            {
                roman = "IX";
                return roman;
            }
            if (number >= 5)
            {
                roman = "V" + Convert(number - 5);
                return roman;
            }
            if (number >= 4)
            {
                roman = "IV" + Convert(number -4);
                return roman;
            }
            if (number >= 1)
            {
                roman = "I" + Convert(number -1);
                return roman;
            }
            return roman;
        }
    }
}
namespace RomanConverter
{
    public class RomanNumeralConverter : IRomanNumeralConverter
    {
        public string Convert(int number)
        {
            if(number == 100)
            {
                return "C";
            }
            if(number >= 90)
            {
                return "XC" + Convert(number - 90);
            }
            if(number >= 50)
            {
                return "L" + Convert(number - 50);
            }
            if (number >= 40)
            {
                return "XL" + Convert(number - 40);
            }
            if (number >= 10)
            {
                return "X" + Convert(number - 10);
            }
            if (number >= 9)
            {
                return "IX" + Convert(number - 9);
            }
            if (number >= 5)
            {
                return "V" + Convert(number - 5);
            }
            if (number >= 4)
            {
                return "IV" + Convert(number -4);
            }
            if (number >= 1)
            {
                return "I" + Convert(number -1);
            }
            return "";
        }
    }
}
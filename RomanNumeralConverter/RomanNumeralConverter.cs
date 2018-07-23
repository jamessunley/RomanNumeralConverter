namespace RomanConverter
{
    public class RomanNumeralConverter : IRomanNumeralConverter
    {
        public string Convert(int number)
        {
            string roman = "";
            while (number > 0)
            {
                if (number >= 1000)
                {
                    number = number - 1000;
                    roman += "M";
                }
                if (number >= 900 && number < 1000)
                {
                    number = number - 900;
                    roman += "CM";
                }
                if (number >= 500 && number < 900)
                {
                    number = number - 500;
                    roman += "D";
                }
                if (number >= 400 && number < 500)
                {
                    number = number - 400;
                    roman += "CD";
                }
                if (number >= 100 && number < 400)
                {
                    number = number - 100;
                    roman += "C";
                }
                if (number >= 90 && number < 100)
                {
                    number = number - 90;
                    roman += "XC";
                }
                if (number >= 50 && number <90)
                {
                    number = number - 50;
                    roman += "L";
                }
                if (number >= 40 && number <50)
                {
                    number = number - 40;
                    roman += "XL";
                }
                if (number >= 10 && number < 40)
                {
                    number = number - 10;
                    roman += "X";
                }
                if (number >= 9 && number <10 )
                {
                    number = number - 9;
                    roman += "IX";
                }
                if (number >= 5 && number < 9)
                {
                    number = number - 5;
                    roman += "V";
                }
                if (number >= 4 && number < 5)
                {
                    number = number - 4;
                    roman += "IV";
                }
                if (number >= 1 && number < 4)
                {
                    number = number - 1;
                    roman += "I"; ;
                }
            }
            return roman;

            //if(number == 1000)
            //{
            //    return "M" + Convert(number - 1000);
            //}
            //if(number == 900)
            //{
            //    return "CM" + Convert(number - 900);
            //}
            //if(number == 500)
            //{
            //    return "D" + Convert(number - 500);
            //}
            //if(number == 400)
            //{
            //    return "CD" + Convert(number - 400);
            //}
            //if(number == 100)
            //{
            //    return "C" + Convert(number - 100);
            //}
            //if(number >= 90)
            //{
            //    return "XC" + Convert(number - 90);
            //}
            //if(number >= 50)
            //{
            //    return "L" + Convert(number - 50);
            //}
            //if (number >= 40)
            //{
            //    return "XL" + Convert(number - 40);
            //}
            //if (number >= 10)
            //{
            //    return "X" + Convert(number - 10);
            //}
            //if (number >= 9)
            //{
            //    return "IX" + Convert(number - 9);
            //}
            //if (number >= 5)
            //{
            //    return "V" + Convert(number - 5);
            //}
            //if (number >= 4)
            //{
            //    return "IV" + Convert(number -4);
            //}
            //if (number >= 1)
            //{
            //    return "I" + Convert(number -1);
            //}
            //return "";
        }
    }
}
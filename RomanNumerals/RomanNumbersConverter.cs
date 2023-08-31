namespace RomanNumerals;

public static class RomanNumbersConverter
{
    public static string ArabicToRomanNumeral(this int number)
    {
        var result = string.Empty;

        if (number >= 10)
        {
            number -= 10;
            result += "X";
        }

        return CalculateOnes(number, result);
    }

    private static string CalculateOnes(int number, string result)
    {
        if (number < 4)
        {
            for (var i = 1; i <= number; i++)
            {
                result += "I";
            }

            return result;
        }

        if (number == 4)
        {
            result += "IV";

            return result;
        }

        if (number == 9)
        {
            result += "IX";

            return result;
        }

        if (number == 5)
        {
            result += "V";

            return result;
        }

        if (number is >= 5 and < 9)
        {
            number -= 5;
            result += "V";

            for (var i = 1; i <= number; i++)
            {
                result += "I";
            }
        }

        return result;
    }

    public static string RomanNumeralToArabic(this string number)
    {
        throw new NotImplementedException();
    }
}
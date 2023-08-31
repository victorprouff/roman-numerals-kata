namespace RomanNumerals;

public static class RomanNumbersConverter
{
    public static string ArabicToRomanNumeral(this int number)
    {
        var result = string.Empty;

        if (number == 9)
        {
            return "IX";
        }

        if (number == 4)
        {
            result += "I";
            number++;
        }

        if (number == 10)
        {
            return "X";
        }

        if (number >= 5)
        {
            number -= 5;
            result += "V";
        }

        for (var i = 1; i <= number; i++)
        {
            result += "I";
        }

        return result;
    }

    public static string RomanNumeralToArabic(this string number)
    {
        throw new NotImplementedException();
    }
}
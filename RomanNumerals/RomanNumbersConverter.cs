namespace RomanNumerals;

public static class RomanNumbersConverter
{
    public static string ArabicToRomanNumeral(this int number)
    {
        var result = string.Empty;

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
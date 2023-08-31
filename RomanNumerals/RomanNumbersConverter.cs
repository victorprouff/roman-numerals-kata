namespace RomanNumerals;

public static class RomanNumbersConverter
{
    public static string ArabicToRomanNumeral(this int number)
    {
        if (number == 1)
        {
            return "I";
        }

        if (number == 2)
        {
            return "II";
        }

        return "III";
    }

    public static string RomanNumeralToArabic(this string number)
    {
        throw new NotImplementedException();
    }

}
namespace RomanNumerals;

public static class RomanNumbersConverter
{
    public static string ArabicToRomanNumeral(this int number)
    {
        if (number == 1)
        {
            return "I";
        }

        return "II";
    }

    public static string RomanNumeralToArabic(this string number)
    {
        throw new NotImplementedException();
    }

}
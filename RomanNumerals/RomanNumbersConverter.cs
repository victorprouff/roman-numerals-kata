namespace RomanNumerals;

public static class RomanNumbersConverter
{
    public static string ArabicToRomanNumeral(this int number)
    {
        var romanNumberBuilder = new BuilderRomanNumber(number);

        return romanNumberBuilder.GetRomanNumber();
    }

    public static string RomanNumeralToArabic(this string number)
    {
        throw new NotImplementedException();
    }
}
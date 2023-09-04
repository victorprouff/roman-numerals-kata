namespace RomanNumerals;

public static class RomanNumbersConverter
{
    public static string ArabicToRomanNumeral(this int number)
    {
        var result = string.Empty;

        var ones = new OnesNumber(number);
        var tens = new TensNumber(number);
        var hundreds = new HundredNumber(number);

        result += hundreds.CalculateFromArabicNumber();
        result += tens.CalculateFromArabicNumber();
        result += ones.CalculateFromArabicNumber();

        return result;
    }

    public static string RomanNumeralToArabic(this string number)
    {
        throw new NotImplementedException();
    }
}
namespace RomanNumerals;

public static class RomanNumbersConverter
{
    public static string ArabicToRomanNumeral(this int number)
    {
        var ones = new OnesNumber(number);
        var tens = new TensNumber(number);
        var hundreds = new HundredNumber(number);

        return hundreds.CalculateFromArabicNumber()
               + tens.CalculateFromArabicNumber()
               + ones.CalculateFromArabicNumber();
    }

    public static string RomanNumeralToArabic(this string number)
    {
        throw new NotImplementedException();
    }
}
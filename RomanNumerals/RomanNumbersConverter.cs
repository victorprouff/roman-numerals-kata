namespace RomanNumerals;

public static class RomanNumbersConverter
{
    public static string ArabicToRomanNumeral(this int number)
    {
        var result = string.Empty;

        var hundreds = new HundredNumber(CalculateHundredNumber(number));
        var tens = new TensNumber(CalculateTensNumber(number, hundreds.Number));
        var ones = new OnesNumber(CalculateOnesNumber(number, hundreds.Number, tens.Number));

        result += hundreds.CalculateFromArabicNumber();
        result += tens.CalculateFromArabicNumber();
        result += ones.CalculateFromArabicNumber();

        return result;
    }


    private static int CalculateHundredNumber(int number) => number / 100;
    private static int CalculateTensNumber(int number, int hundreds) => (number - hundreds * 100) / 10;
    private static int CalculateOnesNumber(int number, int hundreds, int tens) => number - hundreds * 100 - 10 * tens;

    public static string RomanNumeralToArabic(this string number)
    {
        throw new NotImplementedException();
    }
}

public abstract class RomanNumber
{
    public int Number { get; private set; }

    protected RomanNumber(int number, string unit, string middle, string superiorUnit)
    {
        Number = number;
        Unit = unit;
        Middle = middle;
        SuperiorUnit = superiorUnit;
    }

    private string Unit { get; }
    private string Middle { get; }
    private string SuperiorUnit { get; }

    public string CalculateFromArabicNumber()
    {
        var result = string.Empty;

        if (Number < 4)
        {
            for (var i = 1; i <= Number; i++)
            {
                result += Unit;
            }

            return result;
        }

        if (Number == 4)
        {
            result += $"{Unit}{Middle}";

            return result;
        }

        if (Number == 9)
        {
            result += $"{Unit}{SuperiorUnit}";

            return result;
        }

        if (Number == 5)
        {
            result += $"{Middle}";

            return result;
        }

        if (Number is >= 5 and < 9)
        {
            Number -= 5;
            result += $"{Middle}";

            for (var i = 1; i <= Number; i++)
            {
                result += $"{Unit}";
            }
        }

        return result;
    }
}

public class OnesNumber : RomanNumber
{
    public OnesNumber(int number)
        : base(number, "I", "V", "X")
    {
    }
}

public class TensNumber : RomanNumber
{
    public TensNumber(int number)
        : base(number, "X", "L", "C")
    {
    }
}

public class HundredNumber : RomanNumber
{
    public HundredNumber(int number)
        : base(number, "C", "D", "M")
    {
    }
}
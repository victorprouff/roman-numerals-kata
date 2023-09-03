namespace RomanNumerals;

public static class RomanNumbersConverter
{
    public static string ArabicToRomanNumeral(this int number)
    {
        var result = string.Empty;

        var hundreds = number / 100;
        var tens = (number - hundreds * 100) / 10;

        var ones = new OnesNumber(number - hundreds * 100 - 10 * tens);
        result += CalculateHundreds(hundreds);
        result += CalculateTens(tens);
        result += ones.CalculateFromArabicNumber();

        return result;
    }

    private static string CalculateHundreds(int hundreds)
    {
        var result = string.Empty;
        if (hundreds < 4)
        {
            for (var i = 1; i <= hundreds; i++)
            {
                result += "C";
            }
        }

        if (hundreds == 4)
        {
            result += "CD";

            return result;
        }

        if (hundreds == 5)
        {
            result += "D";

            return result;
        }

        if (hundreds == 9)
        {
            result += "CM";

            return result;
        }

        if (hundreds is >= 5 and < 9)
        {
            hundreds -= 5;
            result += "D";

            for (var i = 1; i <= hundreds; i++)
            {
                result += "C";
            }
        }

        return result;
    }

    private static string CalculateTens(int tens)
    {
        var result = string.Empty;

        if (tens < 4)
        {
            for (var i = 1; i <= tens; i++)
            {
                result += "X";
            }

            return result;
        }

        if (tens == 4)
        {
            result += "XL";

            return result;
        }

        if (tens == 5)
        {
            result += "L";

            return result;
        }

        if (tens == 9)
        {
            result += "XC";

            return result;
        }

        if (tens is >= 5 and < 9)
        {
            tens -= 5;
            result += "L";

            for (var i = 1; i <= tens; i++)
            {
                result += "X";
            }
        }

        return result;
    }

    public static string RomanNumeralToArabic(this string number)
    {
        throw new NotImplementedException();
    }
}

public abstract class RomanNumber
{
    private int Number { get; set; }

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
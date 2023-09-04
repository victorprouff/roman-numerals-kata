namespace RomanNumerals;

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

    protected static int CalculateHundredNumber(int number) => number / 100;

    protected static int CalculateTensNumber(int number, int hundreds) => (number - hundreds * 100) / 10;
    protected static int CalculateOnesNumber(int number, int hundreds, int tens) => number - hundreds * 100 - 10 * tens;

}
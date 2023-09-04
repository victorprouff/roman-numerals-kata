namespace RomanNumerals;

public abstract class RomanNumber
{
    private int Number { get; set; }

    protected RomanNumber(int number, RomanLetters romanLetters)
    {
        Number = number;
        RomanLetters = romanLetters;
    }

    private RomanLetters RomanLetters { get; set; }

    public string CalculateFromArabicNumber()
    {
        var result = string.Empty;

        if (Number < 4)
        {
            for (var i = 1; i <= Number; i++)
            {
                result += RomanLetters.Unit;
            }

            return result;
        }

        if (Number == 4)
        {
            result += $"{RomanLetters.Unit}{RomanLetters.Middle}";

            return result;
        }

        if (Number == 9)
        {
            result += $"{RomanLetters.Unit}{RomanLetters.SuperiorUnit}";

            return result;
        }

        if (Number == 5)
        {
            result += $"{RomanLetters.Middle}";

            return result;
        }

        if (Number is >= 5 and < 9)
        {
            Number -= 5;
            result += $"{RomanLetters.Middle}";

            for (var i = 1; i <= Number; i++)
            {
                result += $"{RomanLetters.Unit}";
            }
        }

        return result;
    }

    protected static int CalculateHundredNumber(int number) => number / 100;

    protected static int CalculateTensNumber(int number, int hundreds) => (number - hundreds * 100) / 10;
    protected static int CalculateOnesNumber(int number, int hundreds, int tens) => number - hundreds * 100 - 10 * tens;
}

public record RomanLetters(string Unit, string Middle, string SuperiorUnit);
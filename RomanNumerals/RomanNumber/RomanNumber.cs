namespace RomanNumerals.RomanNumber;

public abstract class RomanNumber
{
    protected RomanNumber(int number, RomanLetters romanLetters)
    {
        Number = number;
        RomanLetters = romanLetters;
    }

    public int Number { get; set; }
    private RomanLetters RomanLetters { get; }

    public string CalculateRomanNumber()
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
}

public record RomanLetters(string Unit, string Middle, string SuperiorUnit);
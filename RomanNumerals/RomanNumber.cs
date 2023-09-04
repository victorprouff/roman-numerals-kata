namespace RomanNumerals;

public abstract class RomanNumber
{
    protected RomanNumber(int number, RomanLetters romanLetters)
    {
        Number = number;
        RomanLetters = romanLetters;
    }

    public int Number { get; set; }
    private RomanLetters RomanLetters { get; }

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

public class BuilderRomanNumber
{
    private readonly OnesNumber _ones;
    private readonly TensNumber _tens;
    private readonly HundredNumber _hundreds;

    private int Number { get; }
    public BuilderRomanNumber(int number)
    {
        Number = number;

        _tens = new TensNumber(number);
        _hundreds = new HundredNumber(number);

        _ones = new OnesNumber(CalculateOnesNumber(_hundreds.Number, _tens.Number));
    }

    public string GetRomanNumber() =>
        _hundreds.CalculateFromArabicNumber()
        + _tens.CalculateFromArabicNumber()
        + _ones.CalculateFromArabicNumber();

    private int CalculateOnesNumber(int hundreds, int tens) => Number - hundreds * 100 - 10 * tens;

}
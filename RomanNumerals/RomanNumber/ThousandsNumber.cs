namespace RomanNumerals.RomanNumber;

public class ThousandsNumber : RomanNumber
{
    public ThousandsNumber(int number)
        : base(number, new RomanLetters("M", "", ""))
    {
    }

    public override string CalculateRomanNumber()
    {
        var result = string.Empty;

        for (var i = 1; i <= Number; i++)
        {
            result += RomanLetters.Unit;
        }

        return result;
    }
}
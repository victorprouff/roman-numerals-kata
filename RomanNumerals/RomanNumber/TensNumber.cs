namespace RomanNumerals.RomanNumber;

public class TensNumber : RomanNumber
{
    public TensNumber(int number)
        : base(number, new RomanLetters("X", "L", "C"))
    {
    }
}
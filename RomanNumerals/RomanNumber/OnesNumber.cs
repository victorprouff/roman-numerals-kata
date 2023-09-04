namespace RomanNumerals.RomanNumber;

public class OnesNumber : RomanNumber
{
    public OnesNumber(int number)
        : base(number, new RomanLetters("I", "V", "X"))
    {
    }
}
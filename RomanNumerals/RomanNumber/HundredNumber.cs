namespace RomanNumerals.RomanNumber;

public class HundredNumber : RomanNumber
{
    public HundredNumber(int number)
        : base(number, new RomanLetters("C", "D", "M"))
    {
    }
}
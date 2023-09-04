namespace RomanNumerals;

public class HundredNumber : RomanNumber
{
    public HundredNumber(int number)
        : base(CalculateHundredNumber(number), new RomanLetters("C", "D", "M"))
    {
    }
}
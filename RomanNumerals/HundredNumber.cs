namespace RomanNumerals;

public class HundredNumber : RomanNumber
{
    public HundredNumber(int number)
        : base(CalculateHundredNumber(number), "C", "D", "M")
    {
    }
}
namespace RomanNumerals;

public class TensNumber : RomanNumber
{
    public TensNumber(int number)
        : base(CalculateTensNumber(number, CalculateHundredNumber(number)), "X", "L", "C")
    {
    }
}
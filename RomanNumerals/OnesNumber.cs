namespace RomanNumerals;

public class OnesNumber : RomanNumber
{
    public OnesNumber(int number)
        : base(
            CalculateOnesNumber(number,
                CalculateHundredNumber(number),
                CalculateTensNumber(number,
                    CalculateHundredNumber(number))),
            new RomanLetters("I", "V", "X"))
    {
    }
}
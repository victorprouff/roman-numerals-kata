using RomanNumerals.RomanNumber;

namespace RomanNumerals;

public class BuilderRomanNumber
{
    private readonly OnesNumber _ones;
    private readonly TensNumber _tens;
    private readonly HundredNumber _hundreds;

    private int Number { get; }
    public BuilderRomanNumber(int number)
    {
        Number = number;

        _hundreds = new HundredNumber(CalculateHundredNumber());
        _tens = new TensNumber(CalculateTensNumber(_hundreds.Number));
        _ones = new OnesNumber(CalculateOnesNumber(_hundreds.Number, _tens.Number));
    }

    public string GetRomanNumber() =>
        _hundreds.CalculateRomanNumber()
        + _tens.CalculateRomanNumber()
        + _ones.CalculateRomanNumber();

    private int CalculateOnesNumber(int hundreds, int tens) => Number - hundreds * 100 - 10 * tens;
    private int CalculateTensNumber(int hundreds) => (Number - hundreds * 100) / 10;
    private int CalculateHundredNumber() => Number / 100;

}
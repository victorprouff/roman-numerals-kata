using RomanNumerals.RomanNumber;

namespace RomanNumerals;

public class BuilderRomanNumber
{
    private readonly OnesNumber _ones;
    private readonly TensNumber _tens;
    private readonly HundredNumber _hundreds;
    private readonly ThousandsNumber _thousands;

    private int Number { get; }

    public BuilderRomanNumber(int number)
    {
        Number = number;

        _thousands = new ThousandsNumber(CalculateThousandsNumber());
        _hundreds = new HundredNumber(CalculateHundredNumber(_thousands.Number));
        _tens = new TensNumber(CalculateTensNumber(_thousands.Number, _hundreds.Number));
        _ones = new OnesNumber(CalculateOnesNumber(_thousands.Number, _hundreds.Number, _tens.Number));
    }

    public string GetRomanNumber() =>
        _thousands.CalculateRomanNumber()
        + _hundreds.CalculateRomanNumber()
        + _tens.CalculateRomanNumber()
        + _ones.CalculateRomanNumber();

    private int CalculateOnesNumber(int thousand, int hundreds, int tens) =>
        Number - thousand * 1000 - hundreds * 100 - 10 * tens;

    private int CalculateTensNumber(int thousand, int hundreds) => (Number - thousand * 1000 - hundreds * 100) / 10;
    private int CalculateHundredNumber(int thousand) => (Number - thousand * 1000) / 100;
    private int CalculateThousandsNumber() => Number / 1000;
}
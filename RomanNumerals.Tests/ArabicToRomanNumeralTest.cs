using FluentAssertions;

namespace RomanNumerals.Tests;

public class ArabicToRomanNumeralTest
{
    [Theory]
    [InlineData(1, "I")]
    [InlineData(2, "II")]
    [InlineData(3, "III")]
    public void BasicConversion(int arabicNumber, string expectedRomanValue)
    {
        var result = arabicNumber.ArabicToRomanNumeral();

        result.Should().Be(expectedRomanValue);
    }
}
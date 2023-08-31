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

    [Fact]
    public void Convert5ToV()
    {
        const int arabicNumber = 5;
        var result = arabicNumber.ArabicToRomanNumeral();

        const string expectedRomanValue = "V";
        result.Should().Be(expectedRomanValue);
    }

    [Fact]
    public void Convert4ToIV()
    {
        const int arabicNumber = 4;
        var result = arabicNumber.ArabicToRomanNumeral();

        const string expectedRomanValue = "IV";
        result.Should().Be(expectedRomanValue);
    }
}
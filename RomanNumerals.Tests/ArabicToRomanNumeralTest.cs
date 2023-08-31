using FluentAssertions;

namespace RomanNumerals.Tests;

public class ArabicToRomanNumeralTest
{
    [Theory]
    [InlineData(1, "I")]
    [InlineData(2, "II")]
    [InlineData(3, "III")]
    public void ConversionFrom1To3(int arabicNumber, string expectedRomanValue)
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

    [Theory]
    [InlineData(6, "VI")]
    [InlineData(7, "VII")]
    [InlineData(8, "VIII")]
    public void ConversionFrom6To8(int arabicNumber, string expectedRomanValue)
    {
        var result = arabicNumber.ArabicToRomanNumeral();

        result.Should().Be(expectedRomanValue);
    }

    [Fact]
    public void Convert9ToIX()
    {
        const int arabicNumber = 9;
        var result = arabicNumber.ArabicToRomanNumeral();

        const string expectedRomanValue = "IX";
        result.Should().Be(expectedRomanValue);
    }

    [Fact]
    public void Convert10ToX()
    {
        const int arabicNumber = 10;
        var result = arabicNumber.ArabicToRomanNumeral();

        const string expectedRomanValue = "X";
        result.Should().Be(expectedRomanValue);
    }
}
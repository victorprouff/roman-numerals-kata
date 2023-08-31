using FluentAssertions;

namespace RomanNumerals.Tests;

public class ArabicToRomanNumeralTest
{
    [Fact]
    public void Convert1ToI()
    {
        const int inputValue = 1;
        var result = inputValue.ArabicToRomanNumeral();

        result.Should().Be("I");
    }

    [Fact]
    public void Convert2ToII()
    {
        const int inputValue = 2;
        var result = inputValue.ArabicToRomanNumeral();

        result.Should().Be("II");
    }

    [Fact]
    public void Convert3ToIII()
    {
        const int inputValue = 3;
        var result = inputValue.ArabicToRomanNumeral();

        result.Should().Be("III");
    }
}
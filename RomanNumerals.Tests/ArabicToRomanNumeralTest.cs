using FluentAssertions;

namespace RomanNumerals.Tests;

public class ArabicToRomanNumeralTest
{
    [Theory]
    [InlineData(1, "I")]
    [InlineData(2, "II")]
    [InlineData(3, "III")]
    [InlineData(4, "IV")]
    [InlineData(5, "V")]
    [InlineData(6, "VI")]
    [InlineData(7, "VII")]
    [InlineData(8, "VIII")]
    [InlineData(9, "IX")]
    [InlineData(10, "X")]
    [InlineData(11, "XI")]
    [InlineData(12, "XII")]
    [InlineData(13, "XIII")]
    [InlineData(14, "XIV")]
    [InlineData(15, "XV")]
    [InlineData(16, "XVI")]
    [InlineData(17, "XVII")]
    [InlineData(18, "XVIII")]
    [InlineData(19, "XIX")]
    public void ConversionOnes(int arabicNumber, string expectedRomanValue)
    {
        var result = arabicNumber.ArabicToRomanNumeral();

        result.Should().Be(expectedRomanValue);
    }

    [Theory]
    [InlineData(10, "X")]
    [InlineData(20, "XX")]
    [InlineData(22, "XXII")]
    [InlineData(30, "XXX")]
    [InlineData(33, "XXXIII")]
    [InlineData(34, "XXXIV")]
    [InlineData(40, "XL")]
    [InlineData(41, "XLI")]
    [InlineData(49, "XLIX")]
    [InlineData(50, "L")]
    [InlineData(52, "LII")]
    [InlineData(55, "LV")]
    [InlineData(58, "LVIII")]
    [InlineData(60, "LX")]
    [InlineData(70, "LXX")]
    [InlineData(80, "LXXX")]
    public void ConvertTens(int arabicNumber, string expectedRomanValue)
    {
        var result = arabicNumber.ArabicToRomanNumeral();

        result.Should().Be(expectedRomanValue);
    }
}
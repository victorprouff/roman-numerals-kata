namespace RomanNumerals;

public static class RomanNumbersConverter
{
    public static string ArabicToRomanNumeral(this int number)
    {
        var result = string.Empty;

        var hundreds = number / 100;
        var tens = (number - hundreds * 100) / 10;
        var ones = number - hundreds * 100 - 10 * tens;

        result += CalculateHundreds(hundreds);
        result += CalculateTens(tens);
        result += CalculateOnes(ones);

        return result;
    }

    private static string CalculateHundreds(int hundreds)
    {
        var result = string.Empty;
        for (var i = 1; i <= hundreds; i++)
        {
            result += "C";
        }

        return result;
    }

    private static string CalculateTens(int tens)
    {
        var result = string.Empty;

        if (tens < 4)
        {
            for (var i = 1; i <= tens; i++)
            {
                result += "X";
            }

            return result;
        }

        if (tens == 4)
        {
            result += "XL";

            return result;
        }

        if (tens == 5)
        {
            result += "L";

            return result;
        }

        if (tens == 9)
        {
            result += "XC";

            return result;
        }

        if (tens is >= 5 and < 9)
        {
            tens -= 5;
            result += "L";

            for (var i = 1; i <= tens; i++)
            {
                result += "X";
            }
        }

        return result;
    }

    private static string CalculateOnes(int number)
    {
        var result = string.Empty;

        if (number < 4)
        {
            for (var i = 1; i <= number; i++)
            {
                result += "I";
            }

            return result;
        }

        if (number == 4)
        {
            result += "IV";

            return result;
        }

        if (number == 9)
        {
            result += "IX";

            return result;
        }

        if (number == 5)
        {
            result += "V";

            return result;
        }

        if (number is >= 5 and < 9)
        {
            number -= 5;
            result += "V";

            for (var i = 1; i <= number; i++)
            {
                result += "I";
            }
        }

        return result;
    }

    public static string RomanNumeralToArabic(this string number)
    {
        throw new NotImplementedException();
    }
}
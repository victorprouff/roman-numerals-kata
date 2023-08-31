namespace RomanNumerals;

public static class RomanNumbersConverter
{
    public static string ArabicToRomanNumeral(this int number)
    {
        var result = string.Empty;

        var tens = number / 10;
        var ones = number - 10 * tens;

        result += CalculateTens(tens);
        result += CalculateOnes(ones);

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
        }

        if (tens == 4)
        {
            result += "XL";
        }

        if (tens == 5)
        {
            result += "L";
        }

        // if (tens is >= 5 and < 9)
        // {
        //     tens -= 5;
        //     result += "V";
        //
        //     for (var i = 1; i <= tens; i++)
        //     {
        //         result += "I";
        //     }
        // }

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
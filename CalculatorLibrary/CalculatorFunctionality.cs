using System.Text.RegularExpressions;

namespace CalculatorLibrary
{
    public static class CalculatorFunctionality
    {
        public static int AddTwoNumbers(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public static bool isValidIntegerOrNegativeSign(string value)
        {
            Regex regex = new Regex("^[0-9]+$|^-[0-9]+$|^-?$");
            return regex.IsMatch(value);
        }
    }
}
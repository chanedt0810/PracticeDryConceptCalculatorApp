using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    public static class CalculatorFunctionality
    {
        public static int AddTwoNumbers(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public static bool isValidInteger(string value)
        {
            Regex regex = new Regex("^[0-9]+$|^-[0-9]+$|^-?$");
            return !regex.IsMatch(value);
        }
    }
}
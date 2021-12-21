using CalculatorLibrary;
using Xunit;

namespace CalculatorLibraryTest
{
    public class CalculatorFunctionalityTest
    {
        [Theory]
        [InlineData(1, 8, 9)]
        [InlineData(-1, 5, 4)]
        [InlineData(0, 6, 6)]
        public void AddTwoNumbers_ShouldCalculate(int firstNumber, int secondNumber, int expectedResult)
        {
            //Arrange
            //Act
            var actualResult = CalculatorFunctionality.AddTwoNumbers(firstNumber, secondNumber);
            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Theory]
        [InlineData("-1", true)]
        [InlineData("0", true)]
        [InlineData("15", true)]
        [InlineData("a", false)]
        [InlineData("-", true)]
        public void IsValidInteger_ShouldCalculate(string number, bool expectedResult)
        {
            //Arrange
            //Act
            var actualResult = CalculatorFunctionality.isValidIntegerOrNegativeSign(number);
            //Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
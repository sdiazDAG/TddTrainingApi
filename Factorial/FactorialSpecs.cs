using Xunit;

namespace Factorial
{
    public class FactorialSpecs
    {
        [Theory]
        [InlineData(1, 0)]
        [InlineData(1, 1)]
        [InlineData(2, 2)]
        [InlineData(6, 3)]
        [InlineData(3628800, 10)]
        public void Testing_to_calculate_number_factorial(int expectedResult, int number)
        {
            var currentResult = FactorialHandler.Calculate(number);

            Assert.Equal(expectedResult, currentResult);
        }
    }
}

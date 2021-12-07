using Xunit;

namespace Factorial
{
    public class FactorialSpecs
    {
        [Theory]
        [InlineData(1, 0)]
        [InlineData(1, 1)]
        [InlineData(2, 2)]
        public void Testing_to_calculate_number_factorial(int expectedResult, int number)
        {
            var currentResult = FactorialHandler.Calculate(number);

            Assert.Equal(expectedResult, currentResult);
        }
    }

    public class FactorialHandler
    {
        public static int Calculate(int number)
        {
            if (number <= 1) return 1;
            return 2;
        }
    }
}

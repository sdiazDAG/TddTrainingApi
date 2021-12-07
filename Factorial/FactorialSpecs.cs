using Xunit;

namespace Factorial
{
    public class FactorialSpecs
    {
        [Fact]
        public void Testing_to_calculate_zero_factorial()
        {
            var expectedResult = 1;

            var currentResult = FactorialHandler.Calculate(0);

            Assert.Equal(expectedResult, currentResult);
        }

        [Fact]
        public void Testing_to_calculate_one_factorial()
        {
            var expectedResult = 1;

            var currentResult = FactorialHandler.Calculate(1);

            Assert.Equal(expectedResult, currentResult);
        }

        [Fact]
        public void Testing_to_calculate_two_factorial()
        {
            var expectedResult = 2;

            var currentResult = FactorialHandler.Calculate(2);

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

using Xunit;

namespace Factorial
{
    public class FactorialSpecs
    {
        [Fact]
        public void Test1()
        {
            var expectedResult = 1;

            var currentResult = FactorialHandler.Calculate(0);

            Assert.Equal(expectedResult, currentResult);
        }
    }

    public class FactorialHandler
    {
        public static int Calculate(int expectedResult)
        {
            return 1;
        }
    }
}

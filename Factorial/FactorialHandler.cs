namespace Factorial
{
    public static class FactorialHandler
    {
        public static int Calculate(int number)
        {
            return number <= 1 ? 1 : number * Calculate(number - 1);
        }
    }
}
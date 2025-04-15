
namespace Basic_12_1_fibonacci_recursion
{
    public static class NumberFibonacci
    {
        public static int NumberFibonacciMethod(int n)
        {
            if (n == 1)
            {
                return 0;
            } 
            else if (n == 2 || n == 3)
            {
                return 1;
            }
            else
            {
                return NumberFibonacciMethod(n - 1) + NumberFibonacciMethod(n - 2);
            }
        }
    }
}
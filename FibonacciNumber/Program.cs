Console.WriteLine(new Solution().Fib(2));
Console.WriteLine(new Solution().Fib(3));
Console.WriteLine(new Solution().Fib(4));
Console.WriteLine(new Solution().Fib(30));
Console.WriteLine(new Solution().Fib(0));

Console.ReadKey();

public class Solution
{
    public static int[] fib = { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584, 4181, 6765, 10946, 17711, 28657, 46368, 75025, 121393, 196418, 317811, 514229, 832040 };
    public int Fib(int n)
    {
        return fib[n];
    }
}
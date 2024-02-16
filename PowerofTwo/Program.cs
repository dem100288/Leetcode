Console.WriteLine(new Solution().IsPowerOfTwo(1));
Console.WriteLine(new Solution().IsPowerOfTwo(16));
Console.WriteLine(new Solution().IsPowerOfTwo(3));
Console.WriteLine(new Solution().IsPowerOfTwo(0));
Console.WriteLine(new Solution().IsPowerOfTwo(-2147483648));
Console.WriteLine(new Solution().IsPowerOfTwo(-16));

Console.ReadKey();

public class Solution
{
    public bool IsPowerOfTwo(int n)
    {
        return n <= 0 ? false : (n & n - 1) == 0;
    }
}
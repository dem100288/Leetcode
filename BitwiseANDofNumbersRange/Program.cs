Console.WriteLine(new Solution().RangeBitwiseAnd(6, 12)); // 0
Console.WriteLine(new Solution().RangeBitwiseAnd(5, 7)); // 4
Console.WriteLine(new Solution().RangeBitwiseAnd(0, 0)); // 0
Console.WriteLine(new Solution().RangeBitwiseAnd(1, 2147483647)); // 0
Console.WriteLine(new Solution().RangeBitwiseAnd(2, 2)); // 2
Console.WriteLine(new Solution().RangeBitwiseAnd(3, 6)); // 0
Console.WriteLine(new Solution().RangeBitwiseAnd(3, 3)); // 3
Console.WriteLine(new Solution().RangeBitwiseAnd(6, 7)); // 6

Console.ReadKey();

public class Solution
{
    public int RangeBitwiseAnd(int left, int right)
    {
        int result = left & right;
        if (result == 0 || left == right) return result;
        int dif = right - left;
        int pow = 1;
        while (dif > 1)
        {
            pow++;
            dif >>= 1;
        }
        result = result >> pow;
        return result << pow;
    }
}
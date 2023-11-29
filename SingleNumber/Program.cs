//Single Number
Console.WriteLine(new Solution().SingleNumber(new int[] { 2, 2, 1 }));
Console.WriteLine(new Solution().SingleNumber(new int[] { 4, 1, 2, 1, 2 }));
Console.WriteLine(new Solution().SingleNumber(new int[] { 1 }));

Console.ReadKey();

public class Solution
{
    public int SingleNumber(int[] nums)
    {
        int res = 0;
        foreach (int num in nums)
        {
            res ^= num;
        }
        return res;
    }
}
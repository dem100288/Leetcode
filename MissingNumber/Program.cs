Console.WriteLine(new Solution().MissingNumber(new int[] { 3, 0, 1 })); // 2
Console.WriteLine(new Solution().MissingNumber(new int[] { 0, 1 })); // 2
Console.WriteLine(new Solution().MissingNumber(new int[] { 9, 6, 4, 2, 3, 5, 7, 0, 1 })); // 8

Console.ReadKey();

public class Solution
{
    public int MissingNumber(int[] nums)
    {
        return ((nums.Length * (nums.Length + 1)) / 2) - nums.Sum();
    }
}
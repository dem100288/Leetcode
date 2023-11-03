Console.WriteLine(new Solution().RemoveElement(new int[] { 3, 2, 2, 3 }, 3));
Console.WriteLine(new Solution().RemoveElement(new int[] { 3, 3 }, 3));
Console.WriteLine(new Solution().RemoveElement(new int[] { 1 }, 1));
Console.WriteLine(new Solution().RemoveElement(new int[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2));
Console.WriteLine(new Solution().RemoveElement(new int[] { 4, 5 }, 4));
Console.ReadKey();

public class Solution
{
    public int RemoveElement(int[] nums, int val)
    {
        if (nums.Length == 0) return 0;
        int k = 0;
        int g = nums.Length - 1;
        for (; k < g; k++)
        {
            if (nums[k] == val)
            {
                while (nums[g] == val)
                {
                    g--;
                    if (g < k) return k;
                }
                nums[k] = nums[g];
                g--;
            }
        }
        return g < k ? k : (nums[k] == val ? k : k + 1);
    }
}
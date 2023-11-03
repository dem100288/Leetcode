Console.WriteLine(new Solution().SearchInsert(new int[] { 1, 3, 5 }, 1).ToString() + " 0");
Console.WriteLine(new Solution().SearchInsert(new int[] { 1, 3, 5, 6 }, 2).ToString() + " 1");
Console.WriteLine(new Solution().SearchInsert(new int[] { 1, 3 }, 2).ToString() + " 1");
Console.WriteLine(new Solution().SearchInsert(new int[] { 1, 3 }, 1).ToString() + " 0");
Console.WriteLine(new Solution().SearchInsert(new int[] { 1, 3, 5, 6 }, 5).ToString() + " 2");

Console.WriteLine(new Solution().SearchInsert(new int[] { 1, 3, 5, 6 }, 7).ToString() + " 4");
Console.WriteLine(new Solution().SearchInsert(new int[] { 1 }, 0).ToString() + " 0");
Console.WriteLine(new Solution().SearchInsert(new int[] { 1 }, 1).ToString() + " 0");
Console.WriteLine(new Solution().SearchInsert(new int[] { 1 }, 2).ToString() + " 1");

Console.WriteLine(new Solution().SearchInsert(new int[] { 1, 3 }, 0).ToString() + " 0");
Console.WriteLine(new Solution().SearchInsert(new int[] { 1, 3 }, 4).ToString() + " 2");
Console.ReadKey();

public class Solution
{
    public int SearchInsert(int[] nums, int target)
    {
        if (target < nums[0]) return 0;
        if (target > nums[nums.Length - 1]) return nums.Length;
        int ind = (int)((nums.Length - 0.5) / 2);
        int count = (int)Math.Round(nums.Length / 4d, MidpointRounding.ToPositiveInfinity);
        while (count >= 1)
        {
            if (nums[ind] == target)
            {
                return ind;
            }
            if (nums[ind] > target)
                ind -= count;
            else
                ind += count;
            if (count == 1) break;
            count = (int)Math.Round(count / 2d, MidpointRounding.ToPositiveInfinity);
        }
        return nums[ind] < target ? ind + 1 : ind;
    }
}
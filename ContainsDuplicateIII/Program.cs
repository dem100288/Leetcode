//Console.WriteLine(new Solution().ContainsNearbyAlmostDuplicate(new int[] { 1, 2, 3, 1 }, 3, 0));
//Console.WriteLine(new Solution().ContainsNearbyAlmostDuplicate(new int[] { 1, 5, 9, 1, 5, 9 }, 2, 3));
Console.WriteLine(new Solution().ContainsNearbyAlmostDuplicate(new int[] { 1, 2, 1, 1 }, 1, 0));


Console.ReadKey();

public class Solution
{
    public bool ContainsNearbyAlmostDuplicate(int[] nums, int indexDiff, int valueDiff)
    {
        if (valueDiff == 0 && new HashSet<int>(nums).Count == nums.Length) return false; 
        for (int i = 0; i <= nums.Length - 2; ++i)
        {
            int max_j = i + indexDiff > nums.Length - 1 ? nums.Length - 1 : i + indexDiff;
            for (int j = i + 1; j <= max_j; ++j)
            {
                if (Math.Abs(nums[i] - nums[j]) <= valueDiff) return true;
            }
        }
        return false;
    }
}

Console.WriteLine(new Solution().ContainsNearbyDuplicate(new int[] { 1, 2, 3, 1 }, 3));
Console.WriteLine(new Solution().ContainsNearbyDuplicate(new int[] { 1, 0, 1, 1 }, 1));
Console.WriteLine(new Solution().ContainsNearbyDuplicate(new int[] { 1, 2, 3, 1, 2, 3 }, 2));


Console.ReadKey();

public class Solution
{
    public bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; ++i)
        {
            if (dict.TryGetValue(nums[i], out int t) && i - t <= k) return true;
            dict[nums[i]] = i;
        }
        return false;
    }
}

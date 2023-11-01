Console.WriteLine(string.Join(" ", new Solution().TwoSum(new int[] { 1, 2, 3 }, 6)));
Console.WriteLine(string.Join(" ", new Solution().TwoSum(new int[] { 3, 3 }, 6)));
Console.WriteLine(string.Join(" ", new Solution().TwoSum(new int[] { 1, 4, 6 }, 10)));
Console.ReadKey();

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> dic = new Dictionary<int, int>();
        int len = nums.Length;
        int[] result = new int[2];
        for (int i = 0; i < len; i++)
        {
            int to_find = target - nums[i];
            if (dic.ContainsKey(to_find))
            {
                result[0] = dic[to_find];
                result[1] = i;
                break;
            }
            else if (!dic.ContainsKey(nums[i]))
            {
                dic.Add(nums[i], i);
            }
        }
        return result;
    }
}
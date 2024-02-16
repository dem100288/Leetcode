Console.WriteLine(new Solution().SummaryRanges(new int[] { 0, 1, 2, 4, 5, 7 }));
Console.WriteLine(new Solution().SummaryRanges(new int[] { 0, 2, 3, 4, 6, 8, 9 }));
Console.WriteLine(new Solution().SummaryRanges(new int[] { -2147483648, -2147483647, 2147483647 }));

Console.ReadKey();

public class Solution
{
    public IList<string> SummaryRanges(int[] nums)
    {
        if (nums.Length == 0) return new List<string>();
        List<string> result = new List<string>();
        int first = nums[0];
        int last = nums[0];
        foreach (int num in nums.Skip(1))
        {
            var t = num - last;
            if (t > 1 || t < 1)
            {
                if (first == last) result.Add(first.ToString());
                else result.Add($"{first}->{last}");
                first = num;
            }
            last = num;
        }
        if (first == last) result.Add(first.ToString());
        else result.Add($"{first}->{last}");
        return result;
    }
}
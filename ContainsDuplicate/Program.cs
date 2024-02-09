Console.WriteLine(new Solution().ContainsDuplicate(new int[] { 1, 2, 3, 1 }));
Console.WriteLine(new Solution().ContainsDuplicate(new int[] { 1, 2, 3, 4 }));
Console.WriteLine(new Solution().ContainsDuplicate(new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 }));


Console.ReadKey();

public class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {
        return new HashSet<int>(nums).Count < nums.Length;
    }
}

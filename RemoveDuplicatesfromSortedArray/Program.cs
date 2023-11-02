Console.WriteLine(new Solution().RemoveDuplicates(new int[] { 1, 1, 2 }));
Console.WriteLine(new Solution().RemoveDuplicates(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }));
Console.ReadKey();

public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        int ind_repl = 1;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i - 1] != nums[i])
            {
                nums[ind_repl] = nums[i];
                ind_repl++;
            }
        }
        return ind_repl;
    }
}
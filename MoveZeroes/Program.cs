var nums = new int[] { 0, 1, 0, 3, 12 };
new Solution().MoveZeroes(nums); // 1,3,12,0,0
nums = new int[] { 0 };
new Solution().MoveZeroes(nums); // 0
Console.WriteLine(nums);

Console.ReadKey();


public class Solution
{
    public void MoveZeroes(int[] nums)
    {
        int last_num = 0;
        for (int i = 0; i < nums.Length; ++i)
        {
            if (nums[i] != 0)
            {
                if (last_num != i)
                {
                    nums[last_num] = nums[i];
                    nums[i] = 0;
                }
                last_num++;
            }
        }
    }
}
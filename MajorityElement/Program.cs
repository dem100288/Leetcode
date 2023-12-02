//Majority Element
Console.WriteLine((int)'A');
Console.WriteLine(new Solution().MajorityElement(new int[] { 3, 2, 3, 4 }));
Console.WriteLine(new Solution().MajorityElement(new int[] { 3, 2, 3 }));
Console.WriteLine(new Solution().MajorityElement(new int[] { 2, 2, 1, 1, 1, 2, 2 }));
Console.WriteLine(new Solution().MajorityElement(new int[] { 3, 3, 4 }));

Console.ReadKey();

public class Solution
{
    public int MajorityElement(int[] nums)
    {
        int maj = 0;
        int n = 0;
        for (int i = 0; i < nums.Length; ++i)
        {
            if (n == 0) maj = nums[i];
            n += maj == nums[i] ? 1 : -1;
        }
        return maj;
    }
}

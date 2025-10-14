
Console.WriteLine(new Solution().SpecialArray([3, 5])); // 2
Console.WriteLine(new Solution().SpecialArray([0, 0])); // -1
Console.WriteLine(new Solution().SpecialArray([0, 4, 3, 0, 4])); // 3
Console.ReadKey();

public class Solution {
    public int SpecialArray(int[] nums)
    {
        int min = nums[0];
        int num = 0;
        bool flag = false;
        for (int i = 0; i < nums.Length;)
        {
            if (nums[i] >= num)
            {
                num++;
                if (nums[i] < min)
                {
                    min = nums[i];
                }

                flag = num <= min;
            }
            if (num > min)
            {
                min = num;
                i = 0;
                num = 0;
                flag = false;
            }
            else
            {
                i++;
            }
        }

        return num <= min && flag ? num : -1;
    }
}
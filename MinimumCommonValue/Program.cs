Console.WriteLine(new Solution().GetCommon(new int[] { 1, 2, 3 }, new int[] { 2, 4 }));
Console.WriteLine(new Solution().GetCommon(new int[] { 1, 2, 3, 6 }, new int[] { 2, 3, 4, 5 }));

Console.ReadKey();


public class Solution
{
    public int GetCommon(int[] nums1, int[] nums2)
    {
        int i = 0;
        int j = 0;
        while (i < nums1.Length && j < nums2.Length)
        {
            if (nums1[i] == nums2[j]) return nums1[i];
            if (nums1[i] > nums2[j]) j++; else i++; 
        }
        return -1;
    }
}
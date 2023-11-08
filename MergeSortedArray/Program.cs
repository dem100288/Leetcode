var m = new int[] { 1, 2, 3, 0, 0, 0 };
new Solution().Merge(m, 3, new int[] { 2, 5, 6 }, 3);
m = new int[] { 1 };
new Solution().Merge(m, 1, new int[] { }, 0);


Console.ReadKey();

public class Solution
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        var mi = m - 1;
        var ni = n - 1;
        for (int i = m + n - 1; i >= 0; --i)
        {
            if (mi >= 0 && ni >= 0)
            {
                if (nums1[mi] < nums2[ni])
                {
                    nums1[i] = nums2[ni];
                    ni--;
                }
                else
                {
                    nums1[i] = nums1[mi];
                    mi--;
                }
            }
            else
            {
                if (mi >= 0)
                {
                    nums1[i] = nums1[mi];
                    mi--;
                }
                else
                {
                    nums1[i] = nums2[ni];
                    ni--;
                }
            }
        }
    }
}
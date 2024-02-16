//Console.WriteLine(new Solution().MedianSlidingWindow(new int[] { 1, 3, -1, -3, 5, 3, 6, 7 }, 3));
//Console.WriteLine(new Solution().MedianSlidingWindow(new int[] { 1, 3, -1, -3, 5, 3, 6, 7 }, 4));
//Console.WriteLine(new Solution().MedianSlidingWindow(new int[] { 1, 2, 3, 4, 2, 3, 1, 4, 2 }, 3));
//Console.WriteLine(new Solution().MedianSlidingWindow(new int[] { 1, 2, 3, 4, 2, 3, 1, 4, 2 }, 4));
Console.WriteLine(new Solution().MedianSlidingWindow(new int[] { 2147483647, 2147483647 }, 2));

Console.ReadKey();

public class Solution
{
    public double[] MedianSlidingWindow(int[] nums, int k)
    {
        List<double> result = new List<double>();
        List<int> window = nums.Take(k).ToList();
        window.Sort();
        var half = k / 2;
        var iter = nums.Length - k + 1;
        for (int i = 0; i < iter; ++i)
        {
            result.Add(k % 2 == 0 
                ? ((long)window[half] + (long)window[half - 1]) / 2d
                : window[half]);

            window.Remove(nums[i]);
            if (k + i < nums.Length)
            {
                var next = nums[i + k];
                for (var w_i = 0; w_i < window.Count; ++w_i)
                {
                    if (window[w_i] >= next)
                    {
                        window.Insert(w_i, next);
                        break;
                    }
                }
                if (window.Count < k) window.Add(next);
            }
        }
        return result.ToArray();
    }
}
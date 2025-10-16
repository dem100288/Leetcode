namespace AdjacentIncreasingSubarraysDetectionII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MaxIncreasingSubarrays([2, 5, 7, 8, 9, 2, 3, 4, 3, 1])); // 3
            Console.WriteLine(MaxIncreasingSubarrays([1, 2, 3, 4, 4, 4, 4, 5, 6, 7])); // 2
            Console.WriteLine(MaxIncreasingSubarrays([5, 8, -2, -1])); // 2
            Console.WriteLine(MaxIncreasingSubarrays([8, 9, 13, -10, -9, -3])); // 3
        }

        public static int MaxIncreasingSubarrays(IList<int> nums)
        {
            for (int k = nums.Count / 2; k > 1; k--)
            {
                for (int i = 0; i <= nums.Count - (2 * k); i++)
                {
                    if (nums[i] > nums[i + k - 1] - k + 1 && nums[i + k] > nums[i + (2 * k) - 1] - k + 1)
                    {
                        break;
                    }

                    bool isFound = true;

                    for (int j = 1; j < k; j++)
                    {
                        if (nums[i + j - 1] >= nums[i + j] || nums[i + j + k - 1] >= nums[i + j + k])
                        {
                            isFound = false;
                            break;
                        }
                    }

                    if (isFound)
                    {
                        return k;
                    }
                }
            }

            return 1;
        }
    }
}

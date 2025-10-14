namespace AdjacentIncreasingSubarraysDetectionI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(HasIncreasingSubarrays([2, 5, 7, 8, 9, 2, 3, 4, 3, 1], 3));
            Console.WriteLine(HasIncreasingSubarrays([1, 2, 3, 4, 4, 4, 4, 5, 6, 7], 5));
            Console.WriteLine(HasIncreasingSubarrays([5, 8, -2, -1], 2));
            Console.WriteLine(HasIncreasingSubarrays([8, 9, 13, -10, -9, -3], 3));
        }

        public static bool HasIncreasingSubarrays(IList<int> nums, int k)
        {
            if (k == 1)
            {
                return true;
            }

            var iMax = nums.Count - k;

            int lastA = int.MaxValue;
            int lastB = int.MaxValue;
            int countA = 0;
            int countB = 0;
            for (int i = 0; i < iMax; i++)
            {
                if (lastA >= nums[i] || lastB >= nums[i + k])
                {
                    countA = 0;
                    countB = 0;
                }

                lastA = nums[i];
                lastB = nums[i + k];
                countA++;
                countB++;

                if (countA == k && countB == k)
                {
                    return true;
                }
            }

            return false;
        }
    }
}

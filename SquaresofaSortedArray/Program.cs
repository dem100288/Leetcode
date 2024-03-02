Console.WriteLine(new Solution().SortedSquares(new int[] { -4, -1, 0, 3, 10 })); // [0,1,9,16,100]
Console.WriteLine(new Solution().SortedSquares(new int[] { -7, -3, 2, 3, 11 })); // [4,9,9,49,121]
Console.WriteLine(new Solution().SortedSquares(new int[] { 2, 3, 11 })); // [4,9,121]
Console.WriteLine(new Solution().SortedSquares(new int[] { -7, -3 })); // [9,49]
Console.WriteLine(new Solution().SortedSquares(new int[] { -7 })); // [49]
Console.WriteLine(new Solution().SortedSquares(new int[] { 7 })); // [49]
Console.WriteLine(new Solution().SortedSquares(new int[] { 0 })); // [0]

Console.ReadKey();

public class Solution
{
    public int[] SortedSquares(int[] nums)
    {
        Stack<int> stack = new Stack<int>();
        List<int> list = new List<int>();
        int i = 0;
        while (i < nums.Length && nums[i] < 0)
        {
            stack.Push(nums[i] * nums[i]);
            i++;
        }
        while (i < nums.Length || stack.Count > 0)
        {
            int square = i < nums.Length ? nums[i] * nums[i] : int.MaxValue;
            if (stack.TryPeek(out var sq))
            {
                if (sq < square)
                {
                    list.Add(stack.Pop());
                    continue;
                }
            }
            list.Add(square);
            i++;
        }
        return list.ToArray();
    }
}
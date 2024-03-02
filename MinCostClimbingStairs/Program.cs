Console.WriteLine(new Solution().MinCostClimbingStairs(new int[] { 10, 15, 20 })); // 15
Console.WriteLine(new Solution().MinCostClimbingStairs(new int[] { 1, 100, 1, 1, 1, 100, 1, 1, 100, 1 })); // 6
Console.WriteLine(new Solution().MinCostClimbingStairs(new int[] { 0, 1, 1, 1 })); // 1
Console.WriteLine(new Solution().MinCostClimbingStairs(new int[] { 0, 1, 2, 2 })); // 2
Console.WriteLine(new Solution().MinCostClimbingStairs(new int[] { 1, 2, 2, 0 })); // 2
Console.WriteLine(new Solution().MinCostClimbingStairs(new int[] { 0, 2, 2, 1 })); // 2
Console.WriteLine(new Solution().MinCostClimbingStairs(new int[] { 0, 2, 3, 2 } )); // 3
Console.WriteLine(new Solution().MinCostClimbingStairs(new int[] { 0, 0, 1, 2 } )); // 1
Console.WriteLine(new Solution().MinCostClimbingStairs(new int[] { 1, 0, 0, 2 } )); // 0

Console.ReadKey();

public class Solution
{
    public int MinCostClimbingStairs(int[] cost)
    {
        int ilr = -1;
        int cur = 0;
        int result = 0;
        while (ilr < cost.Length - 2)
        {
            ilr += (cost[ilr + 1] + (ilr + 3 < cost.Length ? cost[ilr + 3] : 0)) < (cost[ilr + 2] + (ilr + 4 < cost.Length ? cost[ilr + 4] : 0)) ? 1 : 2;
            cur = cost[ilr];
            result += cur;
        }
        return result;
    }
}
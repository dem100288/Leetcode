Console.WriteLine(new Solution().MaxProfit(new int[] { 7, 1, 5, 3, 6, 4 }));
Console.WriteLine(new Solution().MaxProfit(new int[] { 7, 6, 4, 3, 1 }));
Console.WriteLine(new Solution().MaxProfit(new int[] { 2 }));
Console.WriteLine(new Solution().MaxProfit(new int[] { 6, 5, 2, 3 }));


Console.ReadKey();

public class Solution
{
    public int MaxProfit(int[] prices)
    {
        int profit = 0;
        int min_buy = prices[0] + 1;
        for (int i = 0; i < prices.Length - 1; ++i)
        {
            if (prices[i] < min_buy)
            {
                for (int j = i + 1; j < prices.Length; ++j)
                {
                    int prof = prices[j] - prices[i];
                    if (prof > profit) profit = prof;
                }
                min_buy = prices[i];
            }
        }
        return profit;
    }
}
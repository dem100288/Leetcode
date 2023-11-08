Console.WriteLine(new Solution().ClimbStairs(1)); 
Console.WriteLine(new Solution().ClimbStairs(2));
Console.WriteLine(new Solution().ClimbStairs(3));
Console.WriteLine(new Solution().ClimbStairs(4));
Console.WriteLine(new Solution().ClimbStairs(5));
Console.WriteLine(new Solution().ClimbStairs(6));
Console.WriteLine(new Solution().ClimbStairs(7));
Console.WriteLine(new Solution().ClimbStairs(8));
Console.WriteLine(new Solution().ClimbStairs(45));

Console.ReadKey();

public class Solution
{

    public int ClimbStairs(int n)
    {
        if (n == 1) return 1;
        int f1 = 1;
        int f2 = 1;
        for (int i = 1; i < n; i++)
        {
            int t = f1;
            f1 = f2;
            f2 = t + f2;
        }
        return f2;
    }
}
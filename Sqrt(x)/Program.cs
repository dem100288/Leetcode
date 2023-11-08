Console.WriteLine(new Solution().MySqrt(4));
Console.WriteLine(new Solution().MySqrt(8));
Console.WriteLine(new Solution().MySqrt(2147395600));

Console.ReadKey();

public class Solution
{
    public int MySqrt(int x)
    {
        if (x <= 1) return x;
        double xk = 2;
        double xk1 = 0.5 * (xk + x / xk);
        while (Math.Abs(xk1 - xk) >= 1)
        {
            xk = xk1;
            xk1 = 0.5 * (xk + x / xk);
        }
        return (int)xk1;
    }
}
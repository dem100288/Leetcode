Console.WriteLine(new Solution().AddDigits(38)); // 2
Console.WriteLine(new Solution().AddDigits(0)); // 0
Console.WriteLine(new Solution().AddDigits(4)); // 4
Console.WriteLine(new Solution().AddDigits(10)); // 1

Console.ReadKey();

public class Solution
{
    public int AddDigits(int num)
    {
        string n = num.ToString();
        while (n.Length > 1) n = n.Sum(x => Convert.ToInt32(x.ToString())).ToString();
        return Convert.ToInt32(n);
    }

    public int AddDigits2(int n)
    {
        if (n == 0) return 0;
        return (n % 9 == 0) ? 9 : n % 9;
    }
}
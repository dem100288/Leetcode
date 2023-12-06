//Happy Number

Console.WriteLine(new Solution().IsHappy(19)); // true
Console.WriteLine(new Solution().IsHappy(2)); // false
Console.WriteLine(new Solution().IsHappy(1)); // true

Console.ReadKey();

public class Solution
{
    public bool IsHappy(int n)
    {
        List<int> list_nums = new List<int>();
        while (!list_nums.Contains(n) && n != 1)
        {
            list_nums.Add(n);
            n = n.ToString().Select(x => (int)Math.Pow(Convert.ToUInt32(x.ToString()), 2)).Sum();
        }
        return n == 1;
    }
}
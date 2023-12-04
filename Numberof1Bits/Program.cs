//Number of 1 Bits

Console.WriteLine(new Solution().HammingWeight(0b00000000000000000000000000001011)); // 3
Console.WriteLine(new Solution().HammingWeight(0b00000000000000000000000010000000)); // 1
Console.WriteLine(new Solution().HammingWeight(0b11111111111111111111111111111101)); // 31
Console.WriteLine(new Solution().HammingWeight(0b00000000000000000000000000000000)); // 0

Console.ReadKey();

public class Solution
{
    public int HammingWeight(uint n)
    {
        return Convert.ToString(n, toBase: 2).Count(x => x == '1');
    }
}
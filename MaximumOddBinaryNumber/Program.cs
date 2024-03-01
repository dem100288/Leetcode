using System.Text;

Console.WriteLine(new Solution().MaximumOddBinaryNumber("010")); // "001"
Console.WriteLine(new Solution().MaximumOddBinaryNumber("0101")); // "1001"
Console.WriteLine(new Solution().MaximumOddBinaryNumber("1")); // "1"

Console.ReadKey();

public class Solution
{
    public string MaximumOddBinaryNumber(string s)
    {
        var count_1 = s.Count(x => x == '1');
        return new StringBuilder().Append('1', count_1 - 1).Append('0', s.Length - count_1).Append("1").ToString();
    }
}
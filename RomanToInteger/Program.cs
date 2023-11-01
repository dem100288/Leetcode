Console.WriteLine(new Solution().RomanToInt("III"));
Console.WriteLine(new Solution().RomanToInt("LVIII"));
Console.WriteLine(new Solution().RomanToInt("MCMXCIV"));
Console.ReadKey();

public class Solution
{
    static Solution()
    {
        literals.Add('I', 1);
        literals.Add('V', 5);
        literals.Add('X', 10);
        literals.Add('L', 50);
        literals.Add('C', 100);
        literals.Add('D', 500);
        literals.Add('M', 1000);
    }

    public static Dictionary<char, int> literals = new Dictionary<char, int>();

    public int RomanToInt(string s)
    {
        int sum = 0;
        var ind_iter = s.Length - 1;
        for (int i = 0; i < ind_iter; i++)
        {
            var cur = literals[s[i]];
            if (cur < literals[s[i + 1]]){
                sum -= cur;
            }
            else
            {
                sum += cur;
            }
        }
        sum += literals[s[ind_iter]];
        return sum;
    }
}

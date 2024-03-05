Console.WriteLine(new Solution().MinimumLength("ca")); // 2
Console.WriteLine(new Solution().MinimumLength("cabaabac")); // 0
Console.WriteLine(new Solution().MinimumLength("aabccabba")); // 3
Console.WriteLine(new Solution().MinimumLength("aaaabccccaaabbbba")); // 7
Console.WriteLine(new Solution().MinimumLength("aabccabba")); // 3
Console.WriteLine(new Solution().MinimumLength("bbbbbbbbbbbbbbbbbbbbbbbbbbbabbbbbbbbbbbbbbbccbcbcbccbbabbb")); // 1
Console.WriteLine(new Solution().MinimumLength("bbbbbbbbbbbbbbbbbbb")); // 0

Console.ReadKey();


public class Solution
{
    public int MinimumLength(string s)
    {
        if (s.Length == 1) return 1;
        int i = 0;
        int j = s.Length - 1;
        while (i < s.Length && s[i] == s[j] && i < j)
        {
            char letter = s[i];
            for (; i <= j && s[i] == letter; ++i) ;
            for (; i <= j && s[j] == letter; --j) ;
        }
        return j - i + 1;
    }
}
Console.WriteLine(new Solution().StrStr("sadbutsad", "sad"));
Console.WriteLine(new Solution().StrStr("leetcode", "leeto"));
Console.ReadKey();

public class Solution
{
    public int StrStr(string haystack, string needle)
    {
        return haystack.IndexOf(needle);
    }
}
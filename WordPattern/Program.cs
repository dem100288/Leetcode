Console.WriteLine(new Solution().WordPattern("abba", "dog cat cat dog")); // true
Console.WriteLine(new Solution().WordPattern("abba", "dog cat cat fish")); // false
Console.WriteLine(new Solution().WordPattern("aaaa", "dog cat cat dog")); // false
Console.WriteLine(new Solution().WordPattern("abba", "dog dog dog dog")); // false

Console.ReadKey();

public class Solution
{
    public bool WordPattern(string pattern, string s)
    {
        Dictionary<char, string> dic = new Dictionary<char, string>();
        var words = s.Split(' ');
        if (pattern.Length != words.Length) return false;
        for (int i = 0; i < words.Length; ++i)
        {
            if (dic.TryGetValue(pattern[i], out string? word))
            {
                if (words[i] != word) return false;
            }
            else
            {
                if (dic.Values.Contains(words[i])) return false;
                dic.Add(pattern[i], words[i]);
            }
        }
        return true;
    }
}
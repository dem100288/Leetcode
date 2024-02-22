Console.WriteLine(new Solution().IsAnagram("anagram", "nagaram")); // true
Console.WriteLine(new Solution().IsAnagram("rat", "car")); // false
Console.WriteLine(new Solution().IsAnagram("abb", "aab")); // false


Console.ReadKey();

public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        return s.Length == t.Length ? (new HashSet<char>(s).All(x => s.Count(y => y == x) == t.Count(y => y == x))) : false;
    }
}
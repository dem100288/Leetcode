//Valid Palindrome
Console.WriteLine(new Solution().IsPalindrome("A man, a plan, a canal: Panama"));
Console.WriteLine(new Solution().IsPalindrome(" "));
Console.WriteLine(new Solution().IsPalindrome("aa"));

Console.WriteLine(new Solution().IsPalindrome("race a car"));

Console.ReadKey();

public class Solution
{
    public bool IsPalindrome(string s)
    {
        var str = s.ToLower().Where(x => char.IsDigit(x) || char.IsLetter(x));
        var count = str.Count();
        var middle = count % 2 == 0 ? count / 2 : (count / 2) + 1;
        var first = string.Join("", str.Take(count / 2));
        var second = string.Join("", str.Skip(middle).Reverse());
        return first == second;
    }
}
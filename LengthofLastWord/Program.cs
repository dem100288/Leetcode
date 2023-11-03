Console.WriteLine(new Solution().LengthOfLastWord("Hello World"));
Console.WriteLine(new Solution().LengthOfLastWord("   fly me   to   the moon  "));
Console.WriteLine(new Solution().LengthOfLastWord("luffy is still joyboy"));

Console.ReadKey();

public class Solution
{
    public int LengthOfLastWord(string s)
    {
        int count = 0;
        for (int i = s.Length - 1; i >= 0; i--)
        {
            if (s[i] != ' ') count++;
            if (s[i] == ' ' && count > 0) break;
        }
        return count;
    }
}
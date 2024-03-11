using System.Text;

Console.WriteLine(new Solution().CustomSortString("cba", "abcd")); // cbad
Console.WriteLine(new Solution().CustomSortString("bcafg", "abcd")); // bcad

Console.ReadKey();

public class Solution
{
    public string CustomSortString(string order, string s)
    {
        Dictionary<char, int> letters = new Dictionary<char, int>(order.Select(x => new KeyValuePair<char, int>(x, 0)));
        List<char> tail = new List<char>();
        foreach (var letter in s)
        {
            if (letters.ContainsKey(letter))
            {
                letters[letter] += 1;
            }
            else
            {
                tail.Add(letter);
            }
        }
        StringBuilder sb = new StringBuilder();
        foreach (var letter in letters)
        {
            sb.Append(letter.Key, letter.Value);
        }
        sb.AppendJoin("", tail);
        return sb.ToString();
    }
}
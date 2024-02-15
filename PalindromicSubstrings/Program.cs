Console.WriteLine(new Solution().CountSubstrings("abc"));
Console.WriteLine(new Solution().CountSubstrings("aaa"));

Console.ReadKey();

public class Solution
{
    public int CountSubstrings(string s)
    {
        int result = s.Length;
        List<string> subs = new List<string>();
        Dictionary<char, List<int>> chars = 
            new Dictionary<char, List<int>>(
                s.Select((x, ind) => new KeyValuePair<char, int>(x, ind))
                .GroupBy(x => x.Key)
                .Select(x => new KeyValuePair<char, List<int>>(x.Key, x.Select(y => y.Value).ToList()))
                );
        foreach (var pair in chars)
        {
            int i = 0;
            foreach (var ind_s in pair.Value.Take(pair.Value.Count - 1))
            {
                i++;
                foreach (var ind_e in pair.Value.Skip(i))
                {
                    var sub = s.Substring(ind_s, ind_e - ind_s + 1);
                    if (sub == string.Join("", sub.Reverse()))
                    {
                        result++;
                    }
                }
            }
        }
        return result;
    }
}
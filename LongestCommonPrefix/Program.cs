Console.WriteLine(new Solution().LongestCommonPrefix(new string[] { "flower", "flow", "flight" }));
Console.WriteLine(new Solution().LongestCommonPrefix(new string[] { "dog", "racecar", "car" }));
Console.ReadKey();

public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        var strs_len = strs.Length;
        string pref = strs[0];
        for (int i = 1; i < strs_len; i++)
        {
            if (strs[i] == "" || pref == "") return "";
            string new_pref = "";
            var pref_len = pref.Length;
            var strsi_len = strs[i].Length;
            if (strsi_len < pref_len)
            {
                pref = pref.Substring(0, strsi_len);
                pref_len = pref.Length;
            }
            for (int c = 0; c < pref_len; c++)
            {
                if (pref[c] != strs[i][c])
                {
                    break;
                }
                new_pref += pref[c];
            }
            pref = new_pref;
        }
        return pref;
    }

    public string LongestCommonPrefix2(string[] strs)
    {
        if (strs.Any(x => x == "")) return "";
        string pref = "";
        foreach (var ch in strs[0])
        {
            pref += ch;
            if (!strs.All(x => x.StartsWith(pref))) {
                pref = pref.Substring(0, pref.Length - 1);
                break;
            }
        }
        return pref;
    }
}

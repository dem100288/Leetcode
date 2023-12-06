//Isomorphic Strings

Console.WriteLine(new Solution().IsIsomorphic("badc", "baba"));
Console.WriteLine(new Solution().IsIsomorphic("egg", "add"));
Console.WriteLine(new Solution().IsIsomorphic("foo", "bar"));
Console.WriteLine(new Solution().IsIsomorphic("paper", "title"));


Console.ReadKey();


public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class Solution
{
    public bool IsIsomorphic(string s, string t)
    {
        if (s.Length != t.Length) return false;
        Dictionary<char, int> dic_s = new Dictionary<char, int>(new HashSet<char>(s).Select(x => new KeyValuePair<char, int>(x, int.MinValue)));
        Dictionary<char, int> dic_t = new Dictionary<char, int>(new HashSet<char>(t).Select(x => new KeyValuePair<char, int>(x, int.MinValue)));
        for (int i = 0; i < s.Length; ++i)
        {
            var dif_s_t = s[i] - t[i];
            var dif_t_s = t[i] - s[i];
            if ((dic_s[s[i]] != int.MinValue && dic_s[s[i]] != dif_s_t) || (dic_t[t[i]] != int.MinValue && dic_t[t[i]] != dif_t_s)) return false;
            dic_s[s[i]] = dif_s_t;
            dic_t[t[i]] = dif_t_s;
        }
        return true;
    }
}

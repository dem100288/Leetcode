Console.WriteLine(new Solution().AddBinary("111", "11"));
Console.WriteLine(new Solution().AddBinary("1010", "1011"));
Console.WriteLine(new Solution().AddBinary("11", "1"));

Console.ReadKey();

public class Solution
{
    public string AddBinary(string a, string b)
    {
        string res = "";
        if (a.Length != b.Length)
        {
            if (a.Length > b.Length)
            {
                b = b.PadLeft(a.Length, '0');
            }
            else
            {
                a = a.PadLeft(b.Length, '0');
            }
        }
        char ost = '0';
        for (int i = a.Length - 1; i >= 0; --i)
        {
            char cur = a[i] == b[i] ? '0' : '1';
            var t = ost;
            ost = a[i] == '1' && b[i] == '1' ? '1' : '0';
            var tcur = cur == t ? '0' : '1';
            ost = (cur == '1' && t == '1') || ost == '1' ? '1' : '0';
            res = tcur + res;
            
        }
        if (ost != '0') res = "1" + res;
        return res;
    }
}
Console.WriteLine(new Solution(new List<bool> { false, false, false, true, true}).FirstBadVersion(5)); // 4
Console.WriteLine(new Solution(new List<bool> { true }).FirstBadVersion(1)); // 1

Console.ReadKey();

public class VersionControl
{
    private List<bool> vesions;
    public VersionControl(List<bool> vesions)
    {
        this.vesions = vesions;
    }
    public bool IsBadVersion(int version)
    {
        return vesions[version - 1];
    }
}

public class Solution : VersionControl
{
    public Solution(List<bool> vesions) : base(vesions) { }

    public int FirstBadVersion(int n)
    {
        Dictionary<int, bool> dic = new Dictionary<int, bool>();
        if (IsBadVersion(1)) return 1;
        if (n == 2) return 2;
        dic.Add(1, false);
        int start = 2;
        int end = n;
        int cur = start + ((end - start) / 2);
        while (true)
        {
            bool cur_bad = IsBadVersion(cur);
            dic.TryAdd(cur, cur_bad);
            if (cur_bad && dic.TryGetValue(cur - 1, out var prev_cur) && !prev_cur) return cur;
            if (cur_bad)
            {
                end = cur - 1;
            }
            else
            {
                start = cur + 1;
            }
            cur = start + ((end - start) / 2);
        }
    }
}
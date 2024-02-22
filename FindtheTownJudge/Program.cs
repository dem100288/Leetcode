Console.WriteLine(new Solution().FindJudge(2, new int[][] { new int[] { 1, 2 } })); // 2
Console.WriteLine(new Solution().FindJudge(3, new int[][] { new int[] { 1, 3 }, new int[] { 2, 3 } })); // 3
Console.WriteLine(new Solution().FindJudge(3, new int[][] { new int[] { 1, 3 }, new int[] { 2, 3 }, new int[] { 3, 1 } })); // -1
Console.WriteLine(new Solution().FindJudge(3, new int[][] { new int[] { 1, 2 }, new int[] { 2, 3 } })); // -1
Console.WriteLine(new Solution().FindJudge(4, new int[][] { new int[] { 1, 3 }, new int[] { 1, 4 }, new int[] { 2, 3 }, new int[] { 2, 4 }, new int[] { 4, 3 } })); // 3
Console.WriteLine(new Solution().FindJudge(1, new int[][] { })); // 1

Console.ReadKey();

public class Solution
{
    public int FindJudge(int n, int[][] trust)
    {

        if (n == 1 && trust.Length == 0) return 1;
        if (n > 1 && trust.Length == 0) return -1;
        Dictionary<int, HashSet<int>> people = new Dictionary<int, HashSet<int>>();
        foreach (var t in trust)
        {
            if (people.TryGetValue(t[0], out var trusts))
            {
                trusts.Add(t[1]);
            }
            else
            {
                people.Add(t[0], new HashSet<int>() { t[1] });
            }
        }
        HashSet<int> res = people.Values.First();
        foreach (var t in people.Values.Skip(1))
        {
            res.IntersectWith(t);
        }
        return (n - people.Count) == 1 && res.Count == 1 ? res.First() : -1;
    }
}
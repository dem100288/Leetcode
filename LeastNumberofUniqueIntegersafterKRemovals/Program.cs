Console.WriteLine(new Solution().FindLeastNumOfUniqueInts(new int[] { 5, 5, 4 }, 1));
Console.WriteLine(new Solution().FindLeastNumOfUniqueInts(new int[] { 4, 3, 1, 1, 3, 3, 2 }, 3));
//Console.WriteLine(new Solution().FindLeastNumOfUniqueInts(new int[] { 5, 5, 50 }));
//Console.WriteLine(new Solution().FindLeastNumOfUniqueInts(new int[] { 1, 33, 25, 42, 12, 2, 20, 14, 4, 22 }));

Console.ReadKey();

public class Solution
{
    public int FindLeastNumOfUniqueInts(int[] arr, int k)
    {
        if (k == 0) return new HashSet<int>(arr).Count;
        Dictionary<int, int> dic = new Dictionary<int, int>();
        foreach (var num in arr)
        {
            if (dic.TryGetValue(num, out var count))
            {
                dic[num] = count + 1;
            }
            else
            {
                dic.Add(num, 1);
            }
        }
        var counts = dic.Values.ToList();
        counts.Sort();
        int result = counts.Count;
        foreach (var count in counts)
        {
            if (count <= k)
            {
                result -= 1;
                k -= count;
            }
            else break;
        }
        return result;
    }
}
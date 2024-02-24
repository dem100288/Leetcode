Console.WriteLine(new Solution().FindAllPeople(6, new int[][] { new int[] { 1, 2, 5}, new int[] { 2, 3, 8 }, new int[] { 1, 5, 10 } }, 1)); // [0,1,2,3,5]
Console.WriteLine(new Solution().FindAllPeople(4, new int[][] { new int[] { 3, 1, 3}, new int[] { 1, 2, 2 }, new int[] { 0, 3, 3 } }, 3)); // [0,1,3]
Console.WriteLine(new Solution().FindAllPeople(5, new int[][] { new int[] { 3, 4, 2}, new int[] { 1, 2, 1 }, new int[] { 2, 3, 1 } }, 1)); // [0,1,2,3,4]
Console.WriteLine(new Solution().FindAllPeople(11, new int[][] { new int[] { 5, 1, 4}, new int[] { 0, 4, 18 }, new int[] { 2, 3, 1 } }, 1)); // [0,1,4,5]

Console.ReadKey();

public class Solution
{
    public IList<int> FindAllPeople(int n, int[][] meetings, int firstPerson)
    {
        var dic_meetings = new SortedDictionary<int, List<KeyValuePair<int, int>>>();
        dic_meetings.Add(0, new List<KeyValuePair<int, int>>() { new KeyValuePair<int, int>(0, firstPerson) });
        HashSet<int> result = new HashSet<int>() { 0 };

        foreach (var meeting in meetings) 
        {
            if (dic_meetings.TryGetValue(meeting[2], out var time_mettings))
            {
                time_mettings.Add(new KeyValuePair<int, int>(meeting[0], meeting[1]));
            }
            else
            {
                dic_meetings.Add(meeting[2], new List<KeyValuePair<int, int>>() { new KeyValuePair<int, int>(meeting[0], meeting[1]) });
            }
        }

        foreach (var time_mettings in dic_meetings)
        {
            var flag = true;
            while (flag)
            {
                flag = false;
                foreach (var meeting in time_mettings.Value)
                {
                    if (result.Contains(meeting.Key) && !result.Contains(meeting.Value))
                    {
                        result.Add(meeting.Value);
                        flag = true;
                    }
                    else if (result.Contains(meeting.Value) && !result.Contains(meeting.Key))
                    {
                        result.Add(meeting.Key);
                        flag = true;
                    }
                }
            }
            if (result.Count == n) break;
        }

        return result.ToArray();
    }
}
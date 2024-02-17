Console.WriteLine(new Solution().FurthestBuilding(new int[] { 4, 2 }, 0, 0)); // 1
Console.WriteLine(new Solution().FurthestBuilding(new int[] { 4, 5 }, 0, 1)); // 1
Console.WriteLine(new Solution().FurthestBuilding(new int[] { 4, 5 }, 0, 0)); // 0
Console.WriteLine(new Solution().FurthestBuilding(new int[] { 4, 2, 7, 6, 9, 14, 12 }, 5, 1)); // 4
Console.WriteLine(new Solution().FurthestBuilding(new int[] { 4, 12, 2, 7, 3, 18, 20, 3, 19 }, 10, 2)); // 7
Console.WriteLine(new Solution().FurthestBuilding(new int[] { 14, 3, 19, 3 }, 17, 0)); // 3

Console.ReadKey();

public class Solution
{
    public int FurthestBuilding(int[] heights, int bricks, int ladders)
    {
        PriorityQueue<int, int> b = new PriorityQueue<int, int>();
        int building = 0;
        for (; building < heights.Length - 1; ++building)
        {
            var dif = heights[building + 1] - heights[building];
            if (dif <= 0) continue;
            if (dif <= bricks)
            {
                bricks -= dif;
                b.Enqueue(dif, -dif);
            }
            else if (ladders > 0)
            {
                if (b.Count > 0)
                {
                    if (dif < b.Peek())
                    {
                        bricks += b.Dequeue();
                        building--;
                    }
                }
                ladders--;
            }
            else
            {
                break;
            }
        }
        return building;
    }
}
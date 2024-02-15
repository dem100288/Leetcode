Console.WriteLine(new Solution().LargestPerimeter(new int[] { 5, 5, 5 }));
Console.WriteLine(new Solution().LargestPerimeter(new int[] { 1, 12, 1, 2, 5, 50, 3 }));
Console.WriteLine(new Solution().LargestPerimeter(new int[] { 5, 5, 50 }));
Console.WriteLine(new Solution().LargestPerimeter(new int[] { 1, 33, 25, 42, 12, 2, 20, 14, 4, 22 }));

Console.ReadKey();

public class Solution
{
    public long LargestPerimeter(int[] nums)
    {
        
        var list = new List<int>(nums);
        list.Sort((x,y) => x.CompareTo(y) * -1);
        int count = list.Count;
        long perimeter = 0;
        foreach (var item in list)
        {
            perimeter += item;
        }
        foreach (int num in list)
        {
            if (num >= perimeter - num)
            {
                perimeter -= num;
                count--;
            }
            else {
                return perimeter;
            }
        }
        return -1;
    }
}
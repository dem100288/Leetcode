Console.WriteLine(new Solution().GetRow(0));
Console.WriteLine(new Solution().GetRow(1));
Console.WriteLine(new Solution().GetRow(2));
Console.WriteLine(new Solution().GetRow(3));
Console.WriteLine(new Solution().GetRow(4));
Console.WriteLine(new Solution().GetRow(5));


Console.ReadKey();

public class Solution
{
    public IList<int> GetRow(int rowIndex)
    {
        if (rowIndex == 0)
        {
            return new List<int>(1) { 1 };
        }
        if (rowIndex == 1)
        {
            return new List<int>(2) { 1, 1 };
        }
        var prevLine = new List<int>(2) { 1, 1 };
        for (int i = 2; i <= rowIndex; ++i)
        {
            var newLine = new List<int>() { 1 };
            for (int z = 1; z < i; ++z)
            {
                newLine.Add(prevLine[z - 1] + prevLine[z]);
            }
            newLine.Add(1);
            prevLine = newLine;
        }

        return prevLine;
    }
}
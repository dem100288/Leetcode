Console.WriteLine(new Solution().Generate(1));
Console.WriteLine(new Solution().Generate(2));
Console.WriteLine(new Solution().Generate(3));
Console.WriteLine(new Solution().Generate(4));
Console.WriteLine(new Solution().Generate(5));

Console.ReadKey();

public class Solution
{
    public IList<IList<int>> Generate(int numRows)
    {
        IList<IList<int>> pascal = new List<IList<int>>(numRows) { new List<int>(1) { 1 } };
        if (numRows >= 2)
        {
            pascal.Add(new List<int>(2) { 1, 1 });
        }
        for (int i = 2; i < numRows; ++i)
        {
            var prevLine = pascal[i - 1];
            var newLine = new List<int>(prevLine);
            pascal.Add(newLine);
            newLine.Insert((i + 1) / 2, 0);
            for (int z = 1; z <= i / 2; ++z)
            {
                var val = prevLine[z - 1] + prevLine[z];
                newLine[z] = val;
                newLine[i - z] = val;
            }
        }

        return pascal;
    }
}
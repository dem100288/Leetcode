//Excel Sheet Column Number
Console.WriteLine(new Solution().TitleToNumber("A")); // 1
Console.WriteLine(new Solution().TitleToNumber("AB")); // 28
Console.WriteLine(new Solution().TitleToNumber("ZY")); // 701
Console.WriteLine(new Solution().TitleToNumber("Z")); // 26
Console.WriteLine(new Solution().TitleToNumber("AZ")); // 52
Console.WriteLine(new Solution().TitleToNumber("AA")); //27

Console.ReadKey();

public class Solution
{
    public int TitleToNumber(string columnTitle)
    {
        int num = 0;
        for (int i = 0; i < columnTitle.Length; ++i)
        {
            num += (columnTitle[columnTitle.Length - i - 1] - ('A' - 1)) * (int)Math.Pow(26, i);
        }
        return num;
    }
}
//Excel Sheet Column Title
Console.WriteLine((int)'A');
Console.WriteLine(new Solution().ConvertToTitle(52));
Console.WriteLine(new Solution().ConvertToTitle(26));
for (int i = 1; i <= 1000; ++i)
{
    Console.WriteLine(new Solution().ConvertToTitle(i));
}


Console.ReadKey();

public class Solution
{
    public string ConvertToTitle(int columnNumber)
    {
        string result = "";
        while (columnNumber > 0)
        {
            var ost = (columnNumber % 26);
            columnNumber /= 26;
            if (ost == 0)
            {
                ost = 26;
                columnNumber--;
            }
            result = (char)(ost + 64) + result;
        }
        return result;
    }
}

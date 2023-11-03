Console.WriteLine(new Solution().PlusOne(new int[] { 1, 2, 3 }));
Console.WriteLine(new Solution().PlusOne(new int[] { 4, 3, 2, 1 }));
Console.WriteLine(new Solution().PlusOne(new int[] { 9 }));

Console.ReadKey();

public class Solution
{
    public int[] PlusOne(int[] digits)
    {
        if (digits[digits.Length - 1] < 9)
        {
            digits[digits.Length - 1] += 1;
            return digits;
        }
        else
        {
            for (int i = digits.Length - 1; i >= 0; --i)
            {
                if (digits[i] < 9)
                {
                    digits[i] += 1;
                    return digits;
                }
                else
                {
                    digits[i] = 0;
                }
            }
            var res = new int[digits.Length + 1];
            res[0] = 1;
            digits.CopyTo(res, 1);
            return res;
        }
    }
}
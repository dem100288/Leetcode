NumArray nums = new NumArray(new int[] { -2, 0, 3, -5, 2, -1 });
Console.WriteLine(nums.SumRange(0, 2)); // 1
Console.WriteLine(nums.SumRange(2, 5)); // -1
Console.WriteLine(nums.SumRange(0, 5)); // -3

Console.ReadKey();

public class NumArray
{
    private Dictionary< int , List<(int right, int sum)?>> sums = new Dictionary<int, List<(int right, int sum)?>>();
    private int[] nums;
    public NumArray(int[] nums)
    {
        this.nums = nums;
    }

    public int SumRange(int left, int right)
    {
        int sum = 0;
        int cur_left = left;
        for (; cur_left <= right; ++cur_left)
        {
            if (sums.TryGetValue(cur_left, out var list_sums))
            {
                var list_item = list_sums.FirstOrDefault(x => x.Value.right <= right);
                if (list_item is not null)
                {
                    sum += list_item.Value.sum;
                    cur_left = list_item.Value.right;
                    continue;
                }
            }
            sum += nums[cur_left];
        }
        if (sums.TryGetValue(left, out var l_sums))
        {
            l_sums.Add((right, sum));
        }
        else
        {
            sums.Add(left, new List<(int right, int sum)?>() { (right, sum) });
        }
        return sum;
    }
}
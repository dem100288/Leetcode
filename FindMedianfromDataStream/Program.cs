MedianFinder f = new MedianFinder();
f.AddNum(1);
f.AddNum(2);
Console.WriteLine(f.FindMedian());
f.AddNum(3);
Console.WriteLine(f.FindMedian());

Console.ReadKey();

public class MedianFinder
{
    private List<int> _list = new List<int>();

    public MedianFinder()
    {
        
    }

    public void AddNum(int num)
    {
        if (_list.Count == 0) { _list.Add(num); return; }
        for (int i = 0; i < _list.Count; ++i)
        {
            if (num < _list[i]) { _list.Insert(i, num); return; }
        }
        _list.Add(num);
    }

    public double FindMedian()
    {
        return _list.Count % 2 == 0 
            ? (_list[_list.Count / 2] + _list[_list.Count / 2 - 1]) / 2d 
            : _list[_list.Count / 2];
    }
}
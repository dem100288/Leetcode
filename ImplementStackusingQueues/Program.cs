MyStack obj = new MyStack();
obj.Push(1);
obj.Push(2);
obj.Push(3);
obj.Push(4);
obj.Push(5);
Console.WriteLine(obj.Top());
Console.WriteLine(obj.Top());
Console.WriteLine(obj.Pop());
Console.WriteLine(obj.Pop());
Console.WriteLine(obj.Top());
Console.WriteLine(obj.Empty());
Console.WriteLine(obj.Pop());
Console.WriteLine(obj.Pop());
Console.WriteLine(obj.Top());
Console.WriteLine(obj.Pop());
Console.WriteLine(obj.Empty());


Console.ReadKey();

public class MyStack
{
    Queue<int> _qnums = new Queue<int>();

    public void Push(int x)
    {
        _qnums.Enqueue(x);
        for (int i = 1; i < _qnums.Count; ++i)
        {
            _qnums.Enqueue(_qnums.Dequeue());
        }
    }

    public int Pop() => _qnums.Dequeue();

    public int Top() => _qnums.Peek();

    public bool Empty() => _qnums.Count == 0;
}
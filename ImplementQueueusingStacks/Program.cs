
MyQueue stack = new MyQueue();
stack.Push(1);
stack.Push(2);
stack.Push(3);
Console.WriteLine(stack.Peek());
Console.WriteLine(stack.Pop());
Console.WriteLine(stack.Peek());
Console.WriteLine(stack.Empty());
Console.WriteLine(stack.Pop());


Console.ReadKey();

public class MyQueue
{
    private Stack<int> _stack = new Stack<int>();
    private Stack<int> _stackTemp = new Stack<int>();

    public MyQueue()
    {

    }

    public void Push(int x)
    {
        while (_stack.Count > 0)
        {
            _stackTemp.Push(_stack.Pop());
        }
        _stackTemp.Push(x);
        while (_stackTemp.Count > 0)
        {
            _stack.Push(_stackTemp.Pop());
        }
    }

    public int Pop()
    {
        return _stack.Pop();
    }

    public int Peek()
    {
        return _stack.Peek();
    }

    public bool Empty()
    {
        return _stack.Count == 0;
    }
}
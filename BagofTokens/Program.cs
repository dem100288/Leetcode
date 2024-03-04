Console.WriteLine(new Solution().BagOfTokensScore(new int[] { 100 }, 50)); // 0
Console.WriteLine(new Solution().BagOfTokensScore(new int[] { 200, 100 }, 150)); // 1
Console.WriteLine(new Solution().BagOfTokensScore(new int[] { 100, 200, 300, 400 }, 200)); // 2
Console.WriteLine(new Solution().BagOfTokensScore(new int[] { 90, 69, 47 }, 10)); // 0
Console.WriteLine(new Solution().BagOfTokensScore(new int[] { 48, 87, 26 }, 81)); // 2

Console.ReadKey();

public class Solution
{
    private PriorityQueue<int, int> _faceUp = new PriorityQueue<int, int>();
    private PriorityQueue<int, int> _faceDown = new PriorityQueue<int, int>();

    public int BagOfTokensScore(int[] tokens, int power)
    {
        foreach (var token in tokens)
        {
            _faceDown.Enqueue(token, token);
            _faceUp.Enqueue(token, -token);
        }

        var score = 0;
        while (_faceDown.Count > 0 && _faceUp.Count > 0)
        {
            if (power >= _faceDown.Peek())
            {
                score++;
                power -= _faceDown.Dequeue();
            } else if (score > 0 && power + _faceUp.Peek() > _faceDown.Peek())
            {
                score--;
                power += _faceUp.Dequeue();
            }
            else break;
        }

        return score;
    }
}
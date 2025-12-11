using System.Timers;

namespace SmallestMissingNon_negativeIntegerAfterOperations
{
    internal class Program
    {
        private readonly System.Timers.Timer _timer = new() { AutoReset = false, Interval = 1000 };

        static void Main(string[] args)
        {
            var prog = new Program();
        }

        private Program()
        {
            _timer.Elapsed += _timer_Elapsed;
            Console.WriteLine("Start timer");
            _timer.Start();

            Console.ReadKey();

            _timer.Elapsed -= _timer_Elapsed;
            _timer.Stop();
            _timer.Dispose();
        }

        private void _timer_Elapsed(object? sender, ElapsedEventArgs e)
        {
            Console.WriteLine("Timer elapsed");
        }
    }
}

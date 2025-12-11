using System.Collections;
using System.Linq;

namespace CountCoveredBuildings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountCoveredBuildings(3, [[1, 2], [2, 2], [3, 2], [2, 1], [2, 3]]));
            Console.WriteLine(CountCoveredBuildings(3, [[1, 1], [1, 2], [2, 1], [2, 2]]));
            Console.WriteLine(CountCoveredBuildings(5, [[1, 3], [3, 2], [3, 3], [3, 5], [5, 3]]));
        }

        public static int CountCoveredBuildings(int n, int[][] buildings)
        {
            Dictionary<int, Row> xRows = new(Enumerable.Range(1, n).Select(x => new KeyValuePair<int, Row>(x, new())));
            Dictionary<int, Row> yRows = new(Enumerable.Range(1, n).Select(x => new KeyValuePair<int, Row>(x, new())));
            int covered = 0;

            for (int i = 0; i < buildings.Length; ++i)
            {
                var building = buildings[i];
                var xRow = xRows[buildings[i][0]];
                var yRow = yRows[buildings[i][1]];

                xRow.Count++;
                if (building[1] > xRow.Min && building[1] < xRow.Max)
                {
                    xRow.Middle.Add(building[1]);
                }

                if (xRow.Min > building[1])
                {
                    if (xRow.Count > 2)
                    {
                        xRow.Middle.Add(xRow.Min);
                    }
                    xRow.Min = building[1];
                }
                if (xRow.Max < building[1])
                {
                    if (xRow.Count > 2)
                    {
                        xRow.Middle.Add(xRow.Max);
                    }
                    xRow.Max = building[1];
                }

                yRow.Count++;
                if (building[0] > yRow.Min && building[0] < yRow.Max)
                {
                    yRow.Middle.Add(building[0]);
                }

                if (yRow.Min > building[0])
                {
                    if (yRow.Count > 2)
                    {
                        yRow.Middle.Add(yRow.Min);
                    }
                    yRow.Min = building[0];
                }
                if (yRow.Max < building[0])
                {
                    if (yRow.Count > 2)
                    {
                        yRow.Middle.Add(yRow.Max);
                    }
                    yRow.Max = building[0];
                }
            }

            foreach (var xRow in xRows)
            {
                foreach (var yByilbing in xRow.Value.Middle)
                {
                    var yRow = yRows[yByilbing];
                    if (yRow.Middle.Contains(xRow.Key))
                    {
                        covered++;
                    }
                }
            }

            return covered;
        }

        private class Row
        {
            public int Min = int.MaxValue;
            public int Max = int.MinValue;
            public int Count;
            public HashSet<int> Middle = new();
        }
    }
}

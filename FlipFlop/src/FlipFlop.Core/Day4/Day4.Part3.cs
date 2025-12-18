using System.Text;

namespace FlipFlop.Core.Day4;

internal static partial class Day4 {

    internal static class Part3 {

        private static int ManhattanDistance(int[] position) => position[0] + position[1];

        internal static long Solve(string rawText) {

            List<int[]> trashPositions = [.. rawText.Split(Environment.NewLine).Select(line => line.Split(',').Select(int.Parse).ToArray())];
            trashPositions.Sort((a, b) =>  ManhattanDistance(a).CompareTo(ManhattanDistance(b)));
            string sortedRawText =string.Join(Environment.NewLine, trashPositions.Select(p => p[0]+","+p[1]));
            return Part2.Solve(sortedRawText);

        }

    }
}


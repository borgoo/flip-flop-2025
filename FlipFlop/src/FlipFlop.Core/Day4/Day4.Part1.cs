namespace FlipFlop.Core.Day4;

internal static partial class Day4 {

    internal static class Part1 {

        internal static long Solve(string rawText) {

            int[] prev = [0,0];
            int steps = 0;

            foreach(string line in rawText.Split(Environment.NewLine)) {

                int[] curr = [.. line.Split(',').Select(int.Parse)];

                steps += Math.Abs(curr[0] - prev[0]) + Math.Abs(curr[1] - prev[1]);
                prev = curr;
            }
            return steps;
        }

    }
}


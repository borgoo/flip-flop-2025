namespace FlipFlop.Core.Day4;

internal static partial class Day4 {

    internal static class Part2 {

        internal static long Solve(string rawText) {

            int[] prev = [0,0];
            int steps = 0;

            foreach(string line in rawText.Split(Environment.NewLine)) {

                int[] curr = [.. line.Split(',').Select(int.Parse)];
                int deltaX = Math.Abs(curr[0] - prev[0]);
                int deltaY = Math.Abs(curr[1] - prev[1]);
                steps += Math.Max(deltaX, deltaY);
                prev = curr;
            }
            return steps;
        }

    }
}


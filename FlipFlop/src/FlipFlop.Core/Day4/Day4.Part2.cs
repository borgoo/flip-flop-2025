namespace FlipFlop.Core.Day4;

internal static partial class Day4 {

    /// <summary>
    /// This could have be done with Chebyshev distance instead of Euclidean distance.
    /// </summary>
    internal static class Part2 {

        internal static long Solve(string rawText) {

            int[] prev = [0,0];
            int steps = 0;

            double sqrt2 = Math.Sqrt(2);

            foreach(string line in rawText.Split(Environment.NewLine)) {

                int[] curr = [.. line.Split(',').Select(int.Parse)];
                int deltaX = Math.Abs(curr[0] - prev[0]);
                int deltaY = Math.Abs(curr[1] - prev[1]);
                double hypotenuse = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
                int max = Math.Max(deltaX, deltaY);
                if(hypotenuse >= max) {
                    steps +=  max;
                    prev = curr;
                    continue;
                }
                int approxHypotenuse = (int)Math.Ceiling(hypotenuse / sqrt2);
                steps += approxHypotenuse;
                
                prev = curr;
            }
            return steps;
        }

    }
}


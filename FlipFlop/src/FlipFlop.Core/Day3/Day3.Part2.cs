namespace FlipFlop.Core.Day3;

internal static partial class Day3 {

    internal static class Part2 {

        internal static long Solve(string rawText) {

            const int redIdx = 0;
            const int greenIdx = 1;
            const int blueIdx = 2;

            var bushes = rawText.Split(Environment.NewLine).Select(line => line.Split(',').Select(int.Parse).ToArray());

            int result = 0;
            foreach(int[] bush in bushes) {
                if(bush.ToHashSet().Count < bush.Length) continue;
                if(bush[greenIdx] > bush[redIdx] && bush[greenIdx] > bush[blueIdx]) result++;
            }

            return result;
        }

    }
}


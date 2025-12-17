namespace FlipFlop.Core.Day6;

internal static partial class Day6 {

    internal static class Part3 {

        private const int secondsBetweenPictures = 31556926;
        internal static long Solve(string rawText) {

            return Part2.Solve(rawText, secondsBetweenPictures);
            
        }

    }
}


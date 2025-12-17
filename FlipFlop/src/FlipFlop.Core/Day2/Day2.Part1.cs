namespace FlipFlop.Core.Day2;

internal static partial class Day2 {
    private const char _up = '^';
    private const char _down = 'v';

    private static readonly Dictionary<char, int> _incMap = new Dictionary<char, int> {
        { _up, 1 },
        { _down, -1 }
    };

    internal static class Part1 {


        internal static long Solve(string rawText) {

            int curr = 0;
            int max = int.MinValue;

            foreach(char c in rawText) {

                curr += _incMap[c];
                if(c == _up) max = Math.Max(max, curr);
            }

            return max;
        }

    }
}


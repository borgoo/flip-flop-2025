namespace FlipFlop.Core.Day7;

internal static partial class Day7 {

    internal static class Part2 {

        internal static long Solve(string rawText) {

            long result = 0;
            (int n, int m, int w)[] sizes = [.. rawText.Split(Environment.NewLine).Select(line => line.Split(' ')).Select(sizes => (int.Parse(sizes[0]), int.Parse(sizes[1]), int.Parse(sizes[0])))];
            foreach( (int n, int m, int w) in sizes) {

                int yMovements = m-1;
                int xMovements = n-1;
                int zMovements = w-1;
                int totMovements = xMovements + yMovements + zMovements;
                CheckFactorial(totMovements);
                result += _factorial[totMovements] / (_factorial[xMovements] * _factorial[yMovements] * _factorial[zMovements]);
             
            }

            return result;
        }

    }
}


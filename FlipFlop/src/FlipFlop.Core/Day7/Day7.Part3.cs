namespace FlipFlop.Core.Day7;

internal static partial class Day7 {

    internal static class Part3 {

        internal static long Solve(string rawText) {

            long result = 0;
            (int numOfDimensions, int dimensionLength)[] sizes = [.. rawText.Split(Environment.NewLine).Select(line => line.Split(' ')).Select(sizes => (int.Parse(sizes[0]), int.Parse(sizes[1])))];
            foreach( (int numOfDimensions, int dimensionLength) in sizes) {

                int movementsInSpace = dimensionLength-1;
                int totMovements = movementsInSpace * numOfDimensions;
                CheckFactorial(totMovements);
                long denominator = (long)Math.Pow(_factorial[movementsInSpace], numOfDimensions);
                result += _factorial[totMovements] / denominator;
             
            }

            return result;
        }

    }
}


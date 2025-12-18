namespace FlipFlop.Core.Day7;

internal static partial class Day7 {

    const int _maxFactorial = 20;
    private static readonly long[] _factorial = InitFactorial();
    private static long[] InitFactorial() {
        long[] factorial = new long[_maxFactorial +1];
        factorial[0] = 1;
        for(int i = 1; i < factorial.Length; i++) {
            factorial[i] = factorial[i-1] * i;
        }
        return factorial;
    }

    private static void CheckFactorial(int factorial) {
        if(factorial > _maxFactorial) throw new Exception($"Bigger factorial needed (> {_maxFactorial} - {factorial} needed)");
    }

    internal static class Part1 {    
        internal static long Solve(string rawText) {

            long result = 0;
            (int n, int m)[] sizes = [.. rawText.Split(Environment.NewLine).Select(line => line.Split(' ')).Select(sizes => (int.Parse(sizes[0]), int.Parse(sizes[1])))];
            foreach( (int n, int m) in sizes) {

                int rightMovements = m-1;
                int leftMovements = n-1;
                int totMovements = leftMovements + rightMovements;
                CheckFactorial(totMovements);
                result += _factorial[totMovements] / (_factorial[leftMovements] * _factorial[rightMovements]);
             
            }

            return result;
        }

    }
}


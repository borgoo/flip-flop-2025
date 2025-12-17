namespace FlipFlop.Core.Day2;

internal static partial class Day2 {

    internal static class Part3 {

        private const int _maxFib = 100; 
        private static readonly long[] _fib = Init();

        private static long[] Init(){
            long[] fib = new long[_maxFib+1];
            fib[0] = 0;
            fib[1] = 1;
            for(int i = 2; i < fib.Length; i++) {
                fib[i] = fib[i-1] + fib[i-2];
            }
            return fib;
        }

        internal static long Solve(string rawText) {

            long curr = 0;
            long max = long.MinValue;

            for(int i = 0; i < rawText.Length; i++) {

                char c = rawText[i];

                int j = i;
                while( j + 1 < rawText.Length && rawText[j + 1] == c) j++;

                int delta = j - i + 1;

                long calcInc = _fib[delta];

                curr += (calcInc * _incMap[c]);

                if(c == _up) max = Math.Max(max, curr);
                i = j;              
               
            }

           
            return max;
        }

    }
}


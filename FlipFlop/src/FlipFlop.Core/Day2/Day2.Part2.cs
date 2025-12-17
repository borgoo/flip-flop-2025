namespace FlipFlop.Core.Day2;

internal static partial class Day2 {

    internal static class Part2 {

        internal static long Solve(string rawText) {

            int curr = 0;
            int max = int.MinValue;

            for(int i = 0; i < rawText.Length; i++) {

                char c = rawText[i];

                int j = i;
                while( j + 1 < rawText.Length && rawText[j + 1] == c) j++;

                int delta = j - i + 1;

                int calcInc = ( delta * (delta+1) )/ 2 ;

                curr += (calcInc * _incMap[c]);

                if(c == _up) max = Math.Max(max, curr);
                i = j;              
               
            }

           
            return max;
        }

    }
}


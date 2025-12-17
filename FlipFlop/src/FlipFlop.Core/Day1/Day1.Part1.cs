namespace FlipFlop.Core.Day1;

internal static partial class Day1 {

    internal static class Part1 {

        internal static long Solve(string rawText) {

            long result = 0;
            foreach(string line in rawText.Split(Environment.NewLine)) {
                for(int i = 0; i < line.Length -1; i++) {
                    
                    if(line[i] == 'b' && line[i+1] == 'a') {
                        result++;
                        i++;
                        continue;
                    }

                    if(line[i] == 'n' && (line[i+1] == 'a' || line[i+1] == 'e')) {
                        result++;
                        i++;
                        continue;
                    }
                }
            }
            return result;
        }

    }
}



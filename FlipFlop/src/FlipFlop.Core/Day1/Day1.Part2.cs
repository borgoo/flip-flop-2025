namespace FlipFlop.Core.Day1;

internal static partial class Day1 {

    internal static class Part2 {

          internal static long Solve(string rawText) {

            long result = 0;
            foreach(string line in rawText.Split(Environment.NewLine)) {
                int partial = 0;
                for(int i = 0; i < line.Length -1; i++) {
                    
                    if(line[i] == 'b' && line[i+1] == 'a') {
                        partial++;
                        i++;
                        continue;
                    }

                    if(line[i] == 'n' && (line[i+1] == 'a' || line[i+1] == 'e')) {
                        partial++;
                        i++;
                        continue;
                    }
                }
                
                if(partial % 2 == 0) result += partial;
            }
            return result;
        }

    }
}
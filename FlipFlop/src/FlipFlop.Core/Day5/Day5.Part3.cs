namespace FlipFlop.Core.Day5;

internal static partial class Day5 {

    internal static class Part3 {

        internal static long Solve(string rawText) {

            const int empty = -1;
            int end = rawText.Length -1;
            Dictionary<char, int[]> graph = [];
            for(int i = 0; i <= end; i++) {

                char c = rawText[i];
                if(!graph.ContainsKey(c)) graph[c] = [i, empty];
                else graph[c][1] = i;
                
            }

            int result = 0;
            int from = 0;
            while(true) {
                char c = rawText[from];
                bool isPoweredTunnel = c >= 'A' && c <= 'Z';
                int[] pair = graph[c];

                int to = pair[0] == from ? pair[1] : pair[0];
                int mul = isPoweredTunnel ? -1 : 1;
                result += mul * Math.Abs(to - from);
                if(to == end) break;

                from = to +1;            
            }

            return result;

        }

    }
}


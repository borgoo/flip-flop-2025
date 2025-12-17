namespace FlipFlop.Core.Day3;

internal static partial class Day3 {

    internal static class Part1 {

        internal static string Solve(string rawText) {


            string max = string.Empty;
            Dictionary<string, int> count = new(){
                {max, -1}
            };

            foreach(string bush in rawText.Split(Environment.NewLine)) {

                if(!count.ContainsKey(bush)) count[bush] = 0;
                count[bush]++;

                if(count[bush] > count[max]) max = bush;

            }

            return max;
        }

    }
}


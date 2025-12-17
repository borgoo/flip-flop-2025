namespace FlipFlop.Core.Day3;

internal static partial class Day3 {

    internal static class Part3 {

        private enum Colors {
            Red = 0,
            Green = 1,
            Blue = 2,
            Special = 3
        }

        private static readonly int[] _colorsCount = [4];
        private static readonly int[] _colorsPrices = [5,2,4,10];



        internal static long Solve(string rawText) {


            var bushes = rawText.Split(Environment.NewLine).Select(line => line.Split(',').Select(int.Parse).ToArray());

            int result = 0;
            foreach(int[] bush in bushes) {
                
                if(bush.ToHashSet().Count < bush.Length) {
                    result += _colorsPrices[(int)Colors.Special];
                    continue;
                }

                if(bush[(int)Colors.Green] > bush[(int)Colors.Red] && bush[(int)Colors.Green] > bush[(int)Colors.Blue]){
                    result += _colorsPrices[(int)Colors.Green];
                    continue;
                }
                if(bush[(int)Colors.Red] > bush[(int)Colors.Green] && bush[(int)Colors.Red] > bush[(int)Colors.Blue]){
                    result += _colorsPrices[(int)Colors.Red];
                    continue;
                }

                result += _colorsPrices[(int)Colors.Blue];
            }

            return result;
        }

    }
}


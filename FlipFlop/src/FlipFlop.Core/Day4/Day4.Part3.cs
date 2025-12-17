using System.Text;

namespace FlipFlop.Core.Day4;

internal static partial class Day4 {

    internal static class Part3 {

        private static int ManhattanDistance(int[] position) {
            return position[0] + position[1];
        }

        internal static long Solve(string rawText) {

            List<int[]> trashPositions = [.. rawText.Split(Environment.NewLine).Select(line => line.Split(',').Select(int.Parse).ToArray())];
            trashPositions.Sort((a, b) =>  ManhattanDistance(a).CompareTo(ManhattanDistance(b)));
            
            int[] prev = [0,0];
            int steps = 0;
             foreach(int[] curr in trashPositions) {

                int deltaX = Math.Abs(curr[0] - prev[0]);
                int deltaY = Math.Abs(curr[1] - prev[1]);
                int chebyshevDistance = (deltaX + deltaY + Math.Abs(deltaX - deltaY)) / 2;
                steps += chebyshevDistance;
                
                prev = curr;
            }
            return steps;


        }

    }
}


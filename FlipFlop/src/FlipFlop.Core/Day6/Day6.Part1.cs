namespace FlipFlop.Core.Day6;

internal static partial class Day6 {

    private const int _defaultSkySize = 1000;
    private const int _defaultFrameSize = 500;
    internal static class Part1 {

        private const int _defaultSecondsBeforeShoot = 100;

        internal static long Solve(string rawText, int skySize = _defaultSkySize, int frameSize = _defaultFrameSize, int secondsBeforeShoot = _defaultSecondsBeforeShoot) {

            int[][] velocities = [.. rawText.Split(Environment.NewLine).Select(line => line.Split(',').Select(int.Parse).ToArray())];

            int frameXFrom = (skySize - frameSize) / 2;
            int frameXTo = frameXFrom + frameSize - 1;
            int frameYFrom = (skySize - frameSize) / 2;
            int frameYTo = frameYFrom + frameSize - 1;

            int count = 0;
            for(int i = 0; i < velocities.Length; i++) {
                int[] velocity = velocities[i];
                int deltaX = Math.Abs(velocity[0] * secondsBeforeShoot) % skySize;
                int deltaY = Math.Abs(velocity[1] * secondsBeforeShoot) % skySize;
                int x = velocity[0] < 0 ? skySize - deltaX : deltaX;
                int y = velocity[1] < 0 ? skySize - deltaY : deltaY;

                if(x >= frameXFrom && x <= frameXTo && y >= frameYFrom && y <= frameYTo) count++;
            }

            return count;



            
        }

    }
}


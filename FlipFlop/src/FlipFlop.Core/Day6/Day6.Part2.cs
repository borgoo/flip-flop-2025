namespace FlipFlop.Core.Day6;

internal static partial class Day6 {

    internal static class Part2 {

        const int _defaultSecondsBetweenPictures = 3600;

        internal static long Solve(string rawText, int secondsBetweenPictures = _defaultSecondsBetweenPictures) {


            const int numOfPicturesToTake = 1000;

            int[][] velocities = [.. rawText.Split(Environment.NewLine).Select(line => line.Split(',').Select(int.Parse).ToArray())];

            int frameXFrom = (_defaultSkySize - _defaultFrameSize) / 2;
            int frameXTo = frameXFrom + _defaultFrameSize - 1;
            int frameYFrom = (_defaultSkySize - _defaultFrameSize) / 2;
            int frameYTo = frameYFrom + _defaultFrameSize - 1;

            int count = 0;
            for(int i = 0; i < velocities.Length; i++) {
                
                int[] velocity = velocities[i];
                long currTime = secondsBetweenPictures;
                for(int picturesTaken = 0; picturesTaken < numOfPicturesToTake; picturesTaken++) {

                    int mul = (int)(currTime % _defaultSkySize);
                    int deltaX = Math.Abs(velocity[0] % _defaultSkySize * mul) % _defaultSkySize;
                    int deltaY = Math.Abs(velocity[1] % _defaultSkySize * mul) % _defaultSkySize;
                    int x = velocity[0] < 0 ? _defaultSkySize - deltaX : deltaX;
                    int y = velocity[1] < 0 ? _defaultSkySize - deltaY : deltaY;

                    if(x >= frameXFrom && x <= frameXTo && y >= frameYFrom && y <= frameYTo) count++;
                    
                    currTime += secondsBetweenPictures;
                }
                
            }

            return count;



            
        }

    }
}


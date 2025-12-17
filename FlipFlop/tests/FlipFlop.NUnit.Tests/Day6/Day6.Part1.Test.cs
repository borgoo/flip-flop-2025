using static FlipFlop.Core.Day6.Day6;

namespace FlipFlop.NUnit.Tests.Day6;

public class Day6Part1Test
{
    [Test]
    public void Day6Part1_Solve_WhenVelocityIsNegative_ThenReturnsExpectedValue()
    {
        string rawText = "-1,1";
        const int skySize = 8;
        const int frameSize = 6;
        const int secondsBeforeShoot = 3;
        const long expected = 1;

        var result = Part1.Solve(rawText, skySize, frameSize, secondsBeforeShoot);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Day6Part1_Solve_WithSampleInput_ReturnsExpectedValue()
    {
        string rawText = TestDataHelper.LoadSampleInput(day: 6, part: 1);
        const int skySize = 8;
        const int frameSize = 4;
        const int secondsBeforeShoot = 8;
        const long expected = 0;

        var result = Part1.Solve(rawText, skySize, frameSize, secondsBeforeShoot);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Day6Part1_Solve_WithPuzzleInput_ReturnsExpectedValue()
    {
        string rawText = TestDataHelper.LoadPuzzleInput(day: 6);
        const long tooLow = 68;
        const long expected = 243;

        var result = Part1.Solve(rawText);

        Assert.That(result, Is.Not.LessThanOrEqualTo(tooLow));
        Assert.That(result, Is.EqualTo(expected));
    }
}


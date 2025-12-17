using static FlipFlop.Core.Day1.Day1;

namespace FlipFlop.NUnit.Tests.Day1;

public class Day1Part2Test
{
    [Test]
    public void Day1Part2_Solve_WithSampleInput_ReturnsExpectedValue()
    {
        string rawText = TestDataHelper.LoadSampleInput(day: 1, part: 1);
        const long expected = 16;

        var result = Part2.Solve(rawText);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Day1Part2_Solve_WithPuzzleInput_ReturnsExpectedValue()
    {
        string rawText = TestDataHelper.LoadPuzzleInput(day: 1);
        const long expected = 5332;

        var result = Part2.Solve(rawText);

        Assert.That(result, Is.EqualTo(expected));
    }
}



using static FlipFlop.Core.Day2.Day2;

namespace FlipFlop.NUnit.Tests.Day2;

public class Day2Part2Test
{
    [Test]
    public void Day2Part2_Solve_WithSampleInput_ReturnsExpectedValue()
    {
        string rawText = TestDataHelper.LoadSampleInput(day: 2, part: 1);
        const long expected = 15;

        var result = Part2.Solve(rawText);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Day2Part2_Solve_WithPuzzleInput_ReturnsExpectedValue()
    {
        string rawText = TestDataHelper.LoadPuzzleInput(day: 2);
        const long expected = 1280;

        var result = Part2.Solve(rawText);

        Assert.That(result, Is.EqualTo(expected));
    }
}


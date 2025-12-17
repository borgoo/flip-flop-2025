using static FlipFlop.Core.Day3.Day3;

namespace FlipFlop.NUnit.Tests.Day3;

public class Day3Part2Test
{
    [Test]
    public void Day3Part2_Solve_WithSampleInput_ReturnsExpectedValue()
    {
        string rawText = TestDataHelper.LoadSampleInput(day: 3, part: 1);
        const long expected = 0;

        var result = Part2.Solve(rawText);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Day3Part2_Solve_WithPuzzleInput_ReturnsExpectedValue()
    {
        string rawText = TestDataHelper.LoadPuzzleInput(day: 3);
        const long expected = 774;

        var result = Part2.Solve(rawText);

        Assert.That(result, Is.EqualTo(expected));
    }
}


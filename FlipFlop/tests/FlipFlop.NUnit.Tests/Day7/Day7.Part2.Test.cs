using static FlipFlop.Core.Day7.Day7;

namespace FlipFlop.NUnit.Tests.Day7;

public class Day7Part2Test
{
    [Test]
    public void Day7Part2_Solve_WithSampleInput_ReturnsExpectedValue()
    {
        string rawText = TestDataHelper.LoadSampleInput(day: 7, part: 1);
        const long expected = 108;

        var result = Part2.Solve(rawText);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Day7Part2_Solve_WithPuzzleInput_ReturnsExpectedValue()
    {
        string rawText = TestDataHelper.LoadPuzzleInput(day: 7);
        const long expected = 216678;

        var result = Part2.Solve(rawText);

        Assert.That(result, Is.EqualTo(expected));
    }
}


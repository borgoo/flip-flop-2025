using static FlipFlop.Core.Day4.Day4;

namespace FlipFlop.NUnit.Tests.Day4;

public class Day4Part1Test
{
    [Test]
    public void Day4Part1_Solve_WithSampleInput_ReturnsExpectedValue()
    {
        string rawText = TestDataHelper.LoadSampleInput(day: 4, part: 1);
        const long expected = 24;

        var result = Part1.Solve(rawText);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Day4Part1_Solve_WithPuzzleInput_ReturnsExpectedValue()
    {
        string rawText = TestDataHelper.LoadPuzzleInput(day: 4);
        const long expected = 6580;

        var result = Part1.Solve(rawText);

        Assert.That(result, Is.EqualTo(expected));
    }
}


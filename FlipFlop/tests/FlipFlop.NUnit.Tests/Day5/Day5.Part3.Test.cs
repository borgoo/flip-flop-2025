using static FlipFlop.Core.Day5.Day5;

namespace FlipFlop.NUnit.Tests.Day5;

public class Day5Part3Test
{
    [Test]
    public void Day5Part3_Solve_WithSampleInput_ReturnsExpectedValue()
    {
        string rawText = TestDataHelper.LoadSampleInput(day: 5, part: 1);
        const long expected = -6;

        var result = Part3.Solve(rawText);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Day5Part3_Solve_WithPuzzleInput_ReturnsExpectedValue()
    {
        string rawText = TestDataHelper.LoadPuzzleInput(day: 5);
        const long expected = 440;

        var result = Part3.Solve(rawText);

        Assert.That(result, Is.EqualTo(expected));
    }
}


using static FlipFlop.Core.Day2.Day2;

namespace FlipFlop.NUnit.Tests.Day2;

public class Day2Part3Test
{
    [Test]
    public void Day2Part3_Solve_WithSampleInput_ReturnsExpectedValue()
    {
        string rawText = TestDataHelper.LoadSampleInput(day: 2, part: 1);
        const long expected = 4;

        var result = Part3.Solve(rawText);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Day2Part3_Solve_WithPuzzleInput_ReturnsExpectedValue()
    {
        string rawText = TestDataHelper.LoadPuzzleInput(day: 2);
        const long expected = 30617;

        var result = Part3.Solve(rawText);

        Assert.That(result, Is.EqualTo(expected));
    }
}


using static FlipFlop.Core.Day3.Day3;

namespace FlipFlop.NUnit.Tests.Day3;

public class Day3Part3Test
{
    [Test]
    public void Day3Part3_Solve_WithSampleInput_ReturnsExpectedValue()
    {
        string rawText = TestDataHelper.LoadSampleInput(day: 3, part: 1);
        const long expected = 37;

        var result = Part3.Solve(rawText);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Day3Part3_Solve_WithPuzzleInput_ReturnsExpectedValue()
    {
        string rawText = TestDataHelper.LoadPuzzleInput(day: 3);
        const long expected = 9662;

        var result = Part3.Solve(rawText);

        Assert.That(result, Is.EqualTo(expected));
    }
}


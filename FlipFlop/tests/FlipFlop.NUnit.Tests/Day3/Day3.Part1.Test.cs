using static FlipFlop.Core.Day3.Day3;

namespace FlipFlop.NUnit.Tests.Day3;

public class Day3Part1Test
{
    [Test]
    public void Day3Part1_Solve_WithSampleInput_ReturnsExpectedValue()
    {
        string rawText = TestDataHelper.LoadSampleInput(day: 3, part: 1);
        const string expected = "10,20,30";

        var result = Part1.Solve(rawText);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Day3Part1_Solve_WithPuzzleInput_ReturnsExpectedValue()
    {
        string rawText = TestDataHelper.LoadPuzzleInput(day: 3);
        const string expected = "96,81,67";

        var result = Part1.Solve(rawText);

        Assert.That(result, Is.EqualTo(expected));
    }
}


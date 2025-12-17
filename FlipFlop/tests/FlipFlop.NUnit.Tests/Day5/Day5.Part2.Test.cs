using static FlipFlop.Core.Day5.Day5;

namespace FlipFlop.NUnit.Tests.Day5;

public class Day5Part2Test
{
    [Test]
    public void Day5Part2_Solve_WithSampleInput_ReturnsExpectedValue()
    {
        string rawText = TestDataHelper.LoadSampleInput(day: 5, part: 1);
        const string expected = "Bc";

        var result = Part2.Solve(rawText);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Day5Part2_Solve_WithPuzzleInput_ReturnsExpectedValue()
    {
        string rawText = TestDataHelper.LoadPuzzleInput(day: 5);
        const string expected = "JcNHhCpO";

        var result = Part2.Solve(rawText);

        Assert.That(result, Is.EqualTo(expected));
    }
}


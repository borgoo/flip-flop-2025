using static FlipFlop.Core.Day7.Day7;

namespace FlipFlop.NUnit.Tests.Day7;

public class Day7Part3Test
{
    [Test]
    public void Day7Part3_Solve_WithSampleInput_ReturnsExpectedValue()
    {
        string rawText = "4 3";
        const long expected = 2520;

        var result = Part3.Solve(rawText);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Day7Part3_Solve_WithPuzzleInput_ReturnsExpectedValue()
    {
        string rawText = TestDataHelper.LoadPuzzleInput(day: 7);
        const long expected = 455186632824;

        var result = Part3.Solve(rawText);

        Assert.That(result, Is.EqualTo(expected));
    }
}


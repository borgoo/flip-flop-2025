using static FlipFlop.Core.Day4.Day4;

namespace FlipFlop.NUnit.Tests.Day4;

public class Day4Part3Test
{

    [Test]
    public void Day4Part3_Solve_WithSampleInput_ReturnsExpectedValue()
    {
        string rawText = TestDataHelper.LoadSampleInput(day: 4, part: 1);
        const long expected = 9;

        var result = Part3.Solve(rawText);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Day4Part3_Solve_WithPuzzleInput_ReturnsExpectedValue()
    {
        string rawText = TestDataHelper.LoadPuzzleInput(day: 4);
        const long expected = 2075;

        var result = Part3.Solve(rawText);

        Assert.That(result, Is.EqualTo(expected));
    }
}


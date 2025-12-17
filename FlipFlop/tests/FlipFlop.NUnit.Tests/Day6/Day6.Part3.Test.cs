using static FlipFlop.Core.Day6.Day6;

namespace FlipFlop.NUnit.Tests.Day6;

public class Day6Part3Test
{
    [Test]
    public void Day6Part3_Solve_WithPuzzleInput_ReturnsExpectedValue()
    {
        string rawText = TestDataHelper.LoadPuzzleInput(day: 6);
        const long expected = 247460;

        var result = Part3.Solve(rawText);

        Assert.That(result, Is.EqualTo(expected));
    }
}


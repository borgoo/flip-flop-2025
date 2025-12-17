using static FlipFlop.Core.Day6.Day6;

namespace FlipFlop.NUnit.Tests.Day6;

public class Day6Part2Test
{
    
    [Test]
    public void Day6Part2_Solve_WithPuzzleInput_ReturnsExpectedValue()
    {
        string rawText = TestDataHelper.LoadPuzzleInput(day: 6);
        const long expected = 130800;

        var result = Part2.Solve(rawText);

        Assert.That(result, Is.EqualTo(expected));
    }
}


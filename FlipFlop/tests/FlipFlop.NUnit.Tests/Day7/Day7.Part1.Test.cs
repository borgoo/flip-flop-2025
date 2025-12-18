using static FlipFlop.Core.Day7.Day7;

namespace FlipFlop.NUnit.Tests.Day7;

public class Day7Part1Test
{
    [TestCase("2 2", 2)]
    [TestCase("3 3", 6)]
    [TestCase("2 3", 3)]
    public void Day7Part1_Solve_WhenSingleMatrixAsInput_ReturnsExpectedValue(string rawText, long expected)
    {
        var result = Part1.Solve(rawText);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Day7Part1_Solve_WithPuzzleInput_ReturnsExpectedValue()
    {
        string rawText = TestDataHelper.LoadPuzzleInput(day: 7);
        const long expected = 231;

        var result = Part1.Solve(rawText);

        Assert.That(result, Is.EqualTo(expected));
    }
}


using static FlipFlop.Core.Day4.Day4;

namespace FlipFlop.NUnit.Tests.Day4;

public class Day4Part2Test
{
    [TestCase("0,5", 5, TestName = "No delta X")]
    [TestCase("5,0", 5, TestName = "No delta Y")]
    public void Day4Part2_Solve_WhenNoHeightOrWidth_ReturnsExpectedValue( string rawText, long expected )
    {

        var result = Part2.Solve(rawText);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Day4Part2_Solve_WithSampleInput_ReturnsExpectedValue()
    {
        string rawText = TestDataHelper.LoadSampleInput(day: 4, part: 1);
        const long expected = 12;

        var result = Part2.Solve(rawText);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Day4Part2_Solve_WithPuzzleInput_ReturnsExpectedValue()
    {
        string rawText = TestDataHelper.LoadPuzzleInput(day: 4);
        const long tooLow = 3678;
        const long tooLow2 = 3724;
        const long tooLow3 = 3749;
        const long tooHigh = 7404;
        const long expected = 4667;

        var result = Part2.Solve(rawText);

        Assert.That(result, Is.Not.LessThanOrEqualTo(tooLow));
        Assert.That(result, Is.Not.LessThanOrEqualTo(tooLow2));
        Assert.That(result, Is.Not.LessThanOrEqualTo(tooLow3));
        Assert.That(result, Is.Not.GreaterThanOrEqualTo(tooHigh));
        Assert.That(result, Is.EqualTo(expected));
    }
}


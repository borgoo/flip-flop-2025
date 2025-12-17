using static FlipFlop.Core.Day2.Day2;

namespace FlipFlop.NUnit.Tests.Day2;

public class Day2Part1Test
{
    [Test]
    public void Day2Part1_Solve_When1IsTheMax_ThenReturns1(){
        string rawText = "^v^v^v^v^v";
        const long expected = 1;

        var result = Part1.Solve(rawText);

        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Day2Part1_Solve_WithSampleInput_ReturnsExpectedValue()
    {
        string rawText = TestDataHelper.LoadSampleInput(day: 2, part: 1);
        const long expected = 6;

        var result = Part1.Solve(rawText);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Day2Part1_Solve_WithPuzzleInput_ReturnsExpectedValue()
    {
        string rawText = TestDataHelper.LoadPuzzleInput(day: 2);
        const long expected = 115;
        const long tooHigh = 122;


        var result = Part1.Solve(rawText);

        Assert.That(result, Is.LessThan(tooHigh));
        Assert.That(result, Is.EqualTo(expected));
    }
}


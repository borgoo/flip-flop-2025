### Goal
Create (or remove) the FlipFlop “Day N” scaffold via a Cursor command.

### Command
- Name: `template`
- Usage:
  - Create: `/template <DAY>`
  - Remove: `/template <DAY> -rf`

This command is the single source of truth for scaffolding a Day.

### Inputs
- **DAY**: a positive integer day number (e.g., `5`, `19`).
- **ACTION (optional)**: `-rf` to remove Day folders instead of creating them.

### Project-relative paths (must match exactly)
Assume this file lives at repo root under `.cursor/commands/`.

- **SOLUTION_ROOT**: `FlipFlop`
- **DOCS_DIR**: `FlipFlop/docs`
- **CORE_DIR**: `FlipFlop/src/FlipFlop.Core`
- **TEST_DIR**: `FlipFlop/tests/FlipFlop.NUnit.Tests`

Day-specific folders:
- `DOCS_DIR/Day{DAY}`
- `CORE_DIR/Day{DAY}`
- `TEST_DIR/Day{DAY}`

### Behavior rules
- **Validate DAY**:
  - If DAY is missing: fail with an error message explaining usage.
  - If DAY is not a positive integer: fail.
- **Two modes**:
  - If ACTION is `-rf`: remove Day folders (see “Remove mode”).
  - Otherwise: create Day scaffold (see “Create mode”).

### Remove mode (`-rf`)
For each of the following directories, if it exists, delete it recursively; if it does not exist, do nothing (optionally warn):
- `FlipFlop/docs/Day{DAY}`
- `FlipFlop/src/FlipFlop.Core/Day{DAY}`
- `FlipFlop/tests/FlipFlop.NUnit.Tests/Day{DAY}`

After removal, do not create anything else.

### Create mode (default)
#### Preconditions
If **any** of these directories already exist, abort and do not create anything:
- `FlipFlop/docs/Day{DAY}`
- `FlipFlop/src/FlipFlop.Core/Day{DAY}`
- `FlipFlop/tests/FlipFlop.NUnit.Tests/Day{DAY}`

#### Create these directories (create parents as needed)
- `FlipFlop/docs/Day{DAY}/`
- `FlipFlop/src/FlipFlop.Core/Day{DAY}/`
- `FlipFlop/tests/FlipFlop.NUnit.Tests/Day{DAY}/`

#### Create these files (exact names and locations)
Docs:
- `FlipFlop/docs/Day{DAY}/Day{DAY}.md` (empty file)

Core source:
- `FlipFlop/src/FlipFlop.Core/Day{DAY}/Day{DAY}.Part1.cs`
- `FlipFlop/src/FlipFlop.Core/Day{DAY}/Day{DAY}.Part2.cs`

Tests:
- `FlipFlop/tests/FlipFlop.NUnit.Tests/Day{DAY}/Day{DAY}.Part1.Test.cs`
- `FlipFlop/tests/FlipFlop.NUnit.Tests/Day{DAY}/Day{DAY}.Part2.Test.cs`
- `FlipFlop/tests/FlipFlop.NUnit.Tests/Day{DAY}/Day{DAY}.Part1.SampleInput.txt` (empty file)
- `FlipFlop/tests/FlipFlop.NUnit.Tests/Day{DAY}/Day{DAY}.PuzzleInput.txt` (empty file)

### File content templates
When writing the following templates, substitute `{DAY}` with the day number (no padding).

#### `Day{DAY}.Part1.cs`
```csharp
namespace FlipFlop.Core.Day{DAY};

internal static partial class Day{DAY} {

    internal static class Part1 {

        internal static long Solve(string rawText) {

            throw new NotImplementedException();
        }

    }
}
```

#### `Day{DAY}.Part2.cs`
```csharp
namespace FlipFlop.Core.Day{DAY};

internal static partial class Day{DAY} {

    internal static class Part2 {

        internal static long Solve(string rawText) {

            throw new NotImplementedException();
        }

    }
}
```

#### `Day{DAY}.Part1.Test.cs`
```csharp
using static FlipFlop.Core.Day{DAY}.Day{DAY};

namespace FlipFlop.NUnit.Tests.Day{DAY};

public class Day{DAY}Part1Test
{
    [Test]
    public void Day{DAY}Part1_Solve_WithSampleInput_ReturnsExpectedValue()
    {
        string rawText = TestDataHelper.LoadSampleInput(day: {DAY}, part: 1);
        const long expected = -1;

        var result = Part1.Solve(rawText);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Day{DAY}Part1_Solve_WithPuzzleInput_ReturnsExpectedValue()
    {
        string rawText = TestDataHelper.LoadPuzzleInput(day: {DAY});
        const long expected = -1;

        var result = Part1.Solve(rawText);

        Assert.That(result, Is.EqualTo(expected));
    }
}
```

#### `Day{DAY}.Part2.Test.cs`
```csharp
using static FlipFlop.Core.Day{DAY}.Day{DAY};

namespace FlipFlop.NUnit.Tests.Day{DAY};

public class Day{DAY}Part2Test
{
    [Test]
    public void Day{DAY}Part2_Solve_WithSampleInput_ReturnsExpectedValue()
    {
        string rawText = TestDataHelper.LoadSampleInput(day: {DAY}, part: 1);
        const long expected = -1;

        var result = Part2.Solve(rawText);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Day{DAY}Part2_Solve_WithPuzzleInput_ReturnsExpectedValue()
    {
        string rawText = TestDataHelper.LoadPuzzleInput(day: {DAY});
        const long expected = -1;

        var result = Part2.Solve(rawText);

        Assert.That(result, Is.EqualTo(expected));
    }
}
```

### Output requirements for the generator (how the LLM should respond)
- If implementing via Cursor, prefer responding with **concrete file operations** (create directories/files; write exact contents), not prose.
- Never overwrite existing Day directories in create mode; abort instead.
- Keep created `.txt` and docs `.md` files empty (0 bytes is acceptable).

### Examples
- **Create Day 5 scaffold**: input DAY=`5` → create all folders/files above with `{DAY}=5`.
- **Remove Day 18**: input DAY=`18`, ACTION=`-rf` → delete the 3 Day18 directories if present.
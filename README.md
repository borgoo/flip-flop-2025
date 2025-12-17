# flip-flop-2025
A .NET10 TDD Template for FlipFlop challenges (Cursor-first).

## Remember

This repository is a fully scripted, test driven workflow for FlipFlop, designed to be used with **Cursor**.

- Use **Cursor** as your IDE.
- Use **Cursor Chat / Agent** to scaffold each day via the `template` command defined in `.cursor/commands/template.md`.
- The Cursor `template` command **replaces the old `template.bat`** (which has been removed).

## Getting Started

1. Clone the template  
   ```bash
   git clone https://github.com/borgoo/flip-flop-2025.git
   ```
2. Open the repo in Cursor  
   - `File > Open Folder…` and select the cloned `flip-flop-2025/` folder.
3. Restore dependencies  
   - From Cursor’s terminal, run: `dotnet restore`
4. Move to the repository root (if needed)  
   ```powershell
   cd ..
   # you should now be in C:\...\flip-flop-2025
   ```
5. Generate your first day  
   - Open **Cursor Chat** (or **Agent** mode).
   - Run:
     - `/template 1` (recommended), or
     - ask the agent: `template 1`

   This creates all Day 1 folders and files under `FlipFlop/docs`, `FlipFlop/src`, and `FlipFlop/tests`.

## Project Structure

```
flip-flop-2025/
├── FlipFlop/
│   ├── FlipFlop.slnx
│   ├── docs/                     # Holds DayN/DayN.md, reference only
│   ├── src/FlipFlop.Core/    # Production code
│   └── tests/FlipFlop.NUnit.Tests/   # NUnit tests & input data
└── .cursor/commands/template.md  # Cursor command for Day scaffolding
```

## Day Template Details

### Using the Cursor `template` command (replaces `template.bat`)

- **Create a day**: `/template <day>`
  - Example: `/template 5`
- **Remove a day**: `/template <day> -rf`
  - Example: `/template 5 -rf`

If you prefer, you can also ask the agent in plain text (e.g. `template 5`), but the canonical form is the slash command `/template ...`.

Running the command creates:

- `docs/Day<day>/Day<day>.md` – optional notes or puzzle breakdown.  
- `src/FlipFlop.Core/Day<day>/Day<day>.Part1.cs` and `Day<day>.Part2.cs` – the two solution entry points with `Solve(string rawText)` placeholders.  
- `tests/FlipFlop.NUnit.Tests/Day<day>/Day<day>.Part1.Test.cs` and `Day<day>.Part2.Test.cs` – NUnit fixtures already wired to load sample/puzzle inputs.  
- `tests/FlipFlop.NUnit.Tests/Day<day>/Day<day>.Part1.SampleInput.txt` / `Day<day>.PuzzleInput.txt` – start empty; paste puzzle data here.

## Working Through Each Day

After running the template for a new day, follow this loop:

1. **Populate inputs**  
   - Paste the FlipFlop sample example into `tests/FlipFlop.NUnit.Tests/Day<day>/Day<day>.Part1.SampleInput.txt` (and Part2 if provided).  
   - Paste the effective challenge (usually big) input into `tests/FlipFlop.NUnit.Tests/Day<day>/Day<day>.PuzzleInput.txt`.  
   - If you have extra scenarios, add them as additional `[Test]` methods inside `Day<day>.Part1.Test.cs` or `Day<day>.Part2.Test.cs`.
2. **Shape the API if needed**  
   Rename `Solve` or adjust method signatures to better suit the puzzle. Update the corresponding calls in the test files so they stay in sync.
3. **Work test-first**  
   - Run the tests from Cursor’s terminal:
     - `dotnet test .\FlipFlop\tests\FlipFlop.NUnit.Tests\FlipFlop.NUnit.Tests.csproj`
   - The Day <day> tests fail at first because `Solve` still throws.  
   - Implement the solution in `src/FlipFlop.Core/Day<day>/Day<day>.Part1.cs`, rerun the tests until the sample passes.
4. **Lock in the answer**  
   Once the puzzle input test passes, replace the placeholder expected value in the test with the real answer so regressions are caught later.
5. **Repeat for Part 2**  
   Use the same flow for `Day<day>.Part2.cs` and its test file.
6. **Commit your progress**  
   With all tests green, commit and push. Every commit captures both the implementation and the verified answers.

Rinse and repeat for each FlipFlop day. The files stay organised, inputs live under version control, and your answers are always backed by passing NUnit tests.

### Goal
Generate a **git commit message** following the **Conventional Commits** standard, based on the files changed in the current working tree (prefer staged changes if present).

### Command
- Name: `comment`
- Usage: `/comment`

### Inputs (implicit)
Use `git` to inspect changes:
- If there are **staged** changes: use `git diff --cached --name-status`
- Otherwise: use `git diff --name-status`
- Also read `git status --porcelain=v1` to include **added/removed/renamed** files and detect untracked directories.

### Output format (must match exactly)
Return **only** the commit message (no prose), with this structure:

1. A single header line:
   - `type(scope): subject`
2. A blank line
3. 2–6 bullet points starting with `- `

Example:
feat(dayN): add DayN part1 and part2 solution.

- add nunit tests for part1 and part2
- add docs for the problem

### Conventional Commit rules
- **type** must be one of: `feat`, `fix`, `refactor`, `docs`, `test`, `chore`, `build`, `ci`
- **scope** should be short and meaningful. Prefer:
  - `dayN` if changes are under `FlipFlop/**/DayN/` (e.g. `day5`)
  - otherwise: `core`, `tests`, `docs`, `template`, `repo`
- **subject**:
  - imperative mood (“add”, “fix”, “refactor”, “rename”)
  - <= ~72 chars
  - do **not** end with a period unless user explicitly provided one

### How to derive the message from changes
1. **Determine scope**
   - If exactly one Day folder is involved (e.g. `Day5`): scope = `day5`
   - If multiple days: scope = `days`
   - Otherwise pick based on dominant directory:
     - `FlipFlop/src/FlipFlop.Core/**` → `core`
     - `FlipFlop/tests/FlipFlop.NUnit.Tests/**` → `tests`
     - `FlipFlop/docs/**` → `docs`
     - `.cursor/commands/**` → `template`
     - repo-wide changes (rename/move) → `repo`
2. **Determine type**
   - If adds/updates solution code for a day: `feat`
   - If bug fix: `fix`
   - If mostly renames/moves/refactoring: `refactor`
   - If only documentation: `docs`
   - If only tests: `test`
   - If tooling/scripts/commands: `chore`
3. **Write subject**
   - Prefer patterns:
     - day work: `solve dayN part1 and part2`
     - scaffolding: `scaffold dayN`
     - command/tooling: `add cursor template command`
     - renames: `rename AdventOfCode to FlipFlop`
4. **Write bullets**
   - Summarize the most important concrete changes (2–6 bullets)
   - Prefer verbs: add/update/remove/rename/move/fix
   - Mention tests/docs when relevant

### Hard requirements
- Output must be copy-pastable as a commit message
- Do not mention file lists verbatim unless needed; summarize instead
- Do not include backticks or markdown formatting in the output message
- The command must be runnable as **`/comment` only**; do not require or request extra parameters.

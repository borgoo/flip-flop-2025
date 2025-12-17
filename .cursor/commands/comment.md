### Goal
Generate a **git commit message** following the **Conventional Commits** standard, based on the files changed in the current working tree (prefer staged changes if present).

### Command
- Name: `comment`
- Usage: `/comment`

### Inputs (implicit)
Use `git` to inspect changes (run these commands exactly; do not substitute others):
- `git diff --cached --name-status`
- `git diff --name-status`
- `git status --porcelain=v1 -uall`
- `git ls-files --others --exclude-standard`

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

### Determinism contract (non-negotiable)
- Always derive results from a single deterministic **change set** (defined below) so repeated runs yield the same message.
- Always use **stable ordering**:
  - Sort paths lexicographically (case-insensitive) before deriving scope/type/bullets.
  - Emit bullets in the fixed category order listed below.
- Never guess from file contents; infer only from paths + name-status.

### How to derive the message from changes
1. **Build the change set (deterministic)**
   - Let `staged = git diff --cached --name-status` (may be empty).
   - Let `unstaged = git diff --name-status` (may be empty).
   - Let `untracked = git ls-files --others --exclude-standard` (file paths only).
   - If `staged` is non-empty: **changeSet = staged** (ignore `unstaged` and `untracked`).
   - Else: **changeSet = unstaged + (A for each untracked file)**.
   - Use `git status --porcelain=v1 -uall` only to confirm untracked directories and detect renames/deletes; do not override `changeSet` computed above.
   - Sort `changeSet` paths lexicographically (case-insensitive) before analysis.
2. **Classify impacted areas**
   - A path is **docs** if it starts with `FlipFlop/docs/`.
   - A path is **core** if it starts with `FlipFlop/src/FlipFlop.Core/`.
   - A path is **tests** if it starts with `FlipFlop/tests/FlipFlop.NUnit.Tests/`.
   - A path is **template** if it starts with `.cursor/commands/`.
   - Anything else is **repo**.
3. **Determine Day scope (if any)**
   - Extract day numbers from any path segment exactly matching `Day{N}` where `N` is a positive integer.
   - If exactly one distinct `N` exists: scope = `dayN` (lowercase `day`, no zero padding).
   - If more than one distinct day: scope = `days`.
   - If no day: scope = the dominant impacted area using this precedence:
     - `core` > `tests` > `docs` > `template` > `repo`
     - (Dominant means “has the most files in changeSet”; ties break by the precedence order above.)
4. **Determine type (deterministic precedence)**
   - If changeSet contains any `.cursor/commands/` paths and no other areas: type = `chore`.
   - Else if only docs paths changed: type = `docs`.
   - Else if only tests paths changed: type = `test`.
   - Else if any rename (status `R`) or moves dominate (>50% of entries): type = `refactor`.
   - Else if scope is `dayN` or `days` and any of {core, tests, docs} changed: type = `feat`.
   - Else: type = `chore`.
5. **Write subject (use templates; pick the first matching)**
   - If scope is `dayN` or `days` and core+tests+docs all changed: `add dayN solutions, tests, and docs`
   - If scope is `dayN` or `days` and core+tests changed: `add dayN solutions and tests`
   - If scope is `dayN` or `days` and only docs changed: `add dayN docs`
   - If scope is `template`: `add cursor agent command`
   - If scope is `repo`: `update repo tooling`
   - Replace `dayN` with the actual scope (e.g. `day1`) in the subject when present.
6. **Write bullets (2–6, deterministic category order)**
   - Emit bullets in this order, only including categories that apply:
     1) core, 2) tests, 3) docs, 4) template, 5) repo
   - Use these fixed phrasings (choose the first that matches each category):
     - core: `add core implementations for dayN parts 1-3` (if 3 parts touched), else `update core implementation`
     - tests: `add NUnit tests and sample input for dayN`
     - docs: `add dayN puzzle write-up with answers`
     - template: `add /style cursor command to restyle FlipFlop day docs` (if `style.md` present), else `update cursor command templates`
     - repo: `update scaffolding/automation rules`
   - If fewer than 2 bullets would be produced, add a second bullet: `update project scaffolding`.

### Hard requirements
- Output must be copy-pastable as a commit message
- Do not mention file lists verbatim unless needed; summarize instead
- Do not include backticks or markdown formatting in the output message
- The command must be runnable as **`/comment` only**; do not require or request extra parameters.

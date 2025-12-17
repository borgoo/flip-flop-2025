### /style — Restyle FlipFlop puzzle docs

You are a Cursor coding agent. The user will run this command like:

`/style 1`

Treat the text after `/style` as a **single required parameter**: the day number \(N\).

### Goal

Apply the project’s docs markdown style to the file:

`FlipFlop/docs/DayN/DayN.md`

Example: `/style 1` targets `FlipFlop/docs/Day1/Day1.md`.

### Rules (must follow)

- **Do not change meaning**: preserve story text, examples, and all numeric answers exactly.
- **Do not change puzzle logic**: only restyle/format markdown.
- **Use consistent headings**:
  - Add a top title: `### Day N — <Puzzle Title>` (use the existing puzzle title already present in the doc; don’t invent a new one).
  - Use `###` headings for sections (Prologue, Puzzle, Part 2, Part 3, etc.).
- **Use proper code fences** for any multi-line banana/input examples.
- **Use blockquotes** for spoken dialogue.
- **Make key outputs stand out**:
  - Prefer: `**Your answer**: 12345` (keep the number unchanged).
- **Keep links** as inline code (backticks), e.g. `https://flipflop.slome.org/2025/N`.
- **No extra verbosity**: don’t add commentary; just format the existing content.

### Procedure

1. Parse day number \(N\) from the command argument.
   - If missing or not a positive integer, ask the user for a valid day number.
2. Open `FlipFlop/docs/DayN/DayN.md`.
   - If the file doesn’t exist, tell the user which path you tried and stop.
3. Rewrite the markdown to conform to the style rules above.
4. Ensure all code fences are balanced and the file renders cleanly.


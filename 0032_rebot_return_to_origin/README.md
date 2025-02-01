# Robot Return to Origin

## Problem Description
A robot starts at position `(0,0)`, the origin, on a 2D plane. Given a sequence of its moves, determine if the robot returns to the origin after completing all its moves.

You are given a string `moves` where `moves[i]` represents the robot's `i-th` move. The valid moves are:
- `'R'` (right)
- `'L'` (left)
- `'U'` (up)
- `'D'` (down)

Return `true` if the robot returns to the origin after all moves, otherwise return `false`.

### Notes:
- The robot's facing direction is irrelevant.
- Each move has the same magnitude.

---

## Examples

### Example 1:
**Input:**
```plaintext
moves = "UD"
```
**Output:**
```plaintext
true
```
**Explanation:**
The robot moves up once and then down once, returning to the origin.

### Example 2:
**Input:**
```plaintext
moves = "LL"
```
**Output:**
```plaintext
false
```
**Explanation:**
The robot moves left twice, ending up two moves to the left of the origin.

---

## Constraints
- `1 <= moves.length <= 2 * 10^4`
- `moves` only contains the characters `'U'`, `'D'`, `'L'`, and `'R'`.

---
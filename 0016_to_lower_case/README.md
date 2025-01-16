# 709. To Lower Case

## Problem Description

Given a string `s`, return the string after replacing every uppercase letter with the same lowercase letter.

---

## Examples

### Example 1:

**Input:**

```text
s = "Hello"
```

**Output:**

```text
"hello"
```

### Example 2:

**Input:**

```text
s = "here"
```

**Output:**

```text
"here"
```

### Example 3:

**Input:**

```text
s = "LOVELY"
```

**Output:**

```text
"lovely"
```

---

## Constraints

- `1 <= s.length <= 100`
- `s` consists of printable ASCII characters.

---

## Solution Approach

### Theory

The task is to convert every uppercase letter in the string to its corresponding lowercase letter. This can be achieved by using the ASCII values of characters or utilizing built-in string manipulation functions.

### Methods

1. **Using Built-in Functionality:**

   - In most programming languages, strings have a built-in method to convert to lowercase (e.g., `toLowerCase()` in JavaScript or `lower()` in Python).

2. **Using ASCII Manipulation:**
   - Each uppercase letter has a corresponding lowercase letter in the ASCII table. The difference between them is always 32. For example, 'A' (ASCII 65) and 'a' (ASCII 97) differ by 32.
   - Traverse the string and, for each character, check if it is an uppercase letter (ASCII 65 to 90). If true, add 32 to its ASCII value to convert it to lowercase.

### Complexity Analysis

- **Time Complexity:**
  - \(O(n)\), where \(n\) is the length of the string, as we traverse the string once.
- **Space Complexity:**
  - \(O(1)\) additional space, as the transformation can be done in-place (depending on language).

---

## Example Execution

### Input

```text
s = "Hello"
```

### Process

- Traverse each character:
  - 'H' -> 'h'
  - 'e' -> 'e'
  - 'l' -> 'l'
  - 'l' -> 'l'
  - 'o' -> 'o'
- Result: "hello"

### Output

```text
"hello"
```

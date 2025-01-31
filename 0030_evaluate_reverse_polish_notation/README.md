# Evaluate Reverse Polish Notation

## Problem Statement

You are given an array of strings `tokens` that represents an arithmetic expression in Reverse Polish Notation (RPN).

Evaluate the expression and return an integer that represents the value of the expression.

### Notes:

- The valid operators are `+`, `-`, `*`, and `/`.
- Each operand may be an integer or another expression.
- Division between two integers always truncates toward zero.
- There will be no division by zero.
- The input represents a valid arithmetic expression in RPN.
- The answer and all intermediate calculations fit within a 32-bit integer.

---

## Examples

### Example 1:

**Input:**

```plaintext
tokens = ["2", "1", "+", "3", "*"]
```

**Output:**

```plaintext
9
```

**Explanation:**

```plaintext
((2 + 1) * 3) = 9
```

### Example 2:

**Input:**

```plaintext
tokens = ["4", "13", "5", "/", "+"]
```

**Output:**

```plaintext
6
```

**Explanation:**

```plaintext
(4 + (13 / 5)) = 6
```

### Example 3:

**Input:**

```plaintext
tokens = ["10", "6", "9", "3", "+", "-11", "*", "/", "*", "17", "+", "5", "+"]
```

**Output:**

```plaintext
22
```

**Explanation:**

```plaintext
((10 * (6 / ((9 + 3) * -11))) + 17) + 5
= ((10 * (6 / (12 * -11))) + 17) + 5
= ((10 * (6 / -132)) + 17) + 5
= ((10 * 0) + 17) + 5
= (0 + 17) + 5
= 17 + 5
= 22
```

---

## Constraints

- `1 <= tokens.length <= 10^4`
- `tokens[i]` is either an operator: `+`, `-`, `*`, or `/`, or an integer in the range `[-200, 200]`.

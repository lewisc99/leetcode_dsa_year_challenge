# Split a String in Balanced Strings

Balanced strings are those that have an equal number of `'L'` and `'R'` characters.

## Problem Description

Given a balanced string `s`, split it into some number of substrings such that:

- Each substring is balanced (contains an equal number of `'L'` and `'R'`).

Return the **maximum number** of balanced strings you can obtain.

---

## Examples

### Example 1

**Input**:  
`s = "RLRRLLRLRL"`  
**Output**:  
`4`

**Explanation**:  
The string `s` can be split into the following balanced substrings:

- `"RL"`
- `"RRLL"`
- `"RL"`
- `"RL"`

Each substring contains the same number of `'L'` and `'R'`.

---

### Example 2

**Input**:  
`s = "RLRRRLLRLL"`  
**Output**:  
`2`

**Explanation**:  
The string `s` can be split into the following balanced substrings:

- `"RL"`
- `"RRRLLRLL"`

Note: The string cannot be split into substrings like `"RL"`, `"RR"`, `"RL"`, `"LR"`, `"LL"` because the 2nd and 5th substrings are not balanced.

---

### Example 3

**Input**:  
`s = "LLLLRRRR"`  
**Output**:  
`1`

**Explanation**:  
The string `s` can be split into a single balanced substring:

- `"LLLLRRRR"`

---

## Constraints

- The input string `s` is a balanced string.
- `1 <= s.length <= 1000`
- `s[i]` is either `'L'` or `'R'`.

## Approach

The problem can be solved by iterating through the string and keeping track of the count of `'L'` and `'R'`. Whenever the counts of `'L'` and `'R'` are equal, it indicates the end of a balanced substring, and the count of balanced substrings can be incremented.

---

Happy coding!

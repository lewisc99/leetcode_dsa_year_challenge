# 392. Is Subsequence

## Problem Statement

Given two strings `s` and `t`, return `true` if `s` is a subsequence of `t`, or `false` otherwise.

A **subsequence** of a string is a new string that is formed from the original string by deleting some (can be none) of the characters without disturbing the relative positions of the remaining characters.  
For example, `"ace"` is a subsequence of `"abcde"`, while `"aec"` is not.

---

## Examples

### Example 1
**Input:**  
`s = "abc"`, `t = "ahbgdc"`  
**Output:**  
`true`

### Example 2
**Input:**  
`s = "axc"`, `t = "ahbgdc"`  
**Output:**  
`false`

---

## Constraints

- `0 <= s.length <= 100`
- `0 <= t.length <= 10^4`
- `s` and `t` consist only of lowercase English letters.

---

## Follow-Up

Suppose there are lots of incoming `s`, say `s1, s2, ..., sk` where `k >= 10^9`, and you want to check one by one to see if `t` has its subsequence. In this scenario, you can optimize the solution by:
1. **Preprocessing `t`**: Create a mapping of each character in `t` to the list of indices where it occurs. This allows for faster lookup when checking if `s` is a subsequence.
2. **Binary Search**: Use binary search on the indices list to efficiently find the next character in `t` that matches the current character in `s`.

---

## Topics

- Strings
- Two Pointers
- Binary Search (Follow-Up)

---

## Companies

This problem has been reported in coding interviews at various companies. Solving it helps improve understanding of string manipulation and optimization techniques.

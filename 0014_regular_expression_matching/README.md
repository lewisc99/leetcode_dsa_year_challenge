# Regular Expression Matching

## Problem Description

Implement a function to perform regular expression matching with the following rules:
- `.` matches any single character.
- `*` matches zero or more occurrences of the preceding element.

The matching must cover the entire input string `s`, not just a part of it.

---

## Examples

### Example 1
**Input:**  
`s = "aa"`  
`p = "a"`  

**Output:**  
`false`  

**Explanation:**  
The pattern `"a"` does not match the entire string `"aa"`.

---

### Example 2
**Input:**  
`s = "aa"`  
`p = "a*"`  

**Output:**  
`true`  

**Explanation:**  
`'*'` means zero or more occurrences of the preceding element (`'a'`). Repeating `'a'` once matches the string `"aa"`.

---

### Example 3
**Input:**  
`s = "ab"`  
`p = ".*"`  

**Output:**  
`true`  

**Explanation:**  
`'.*'` means "zero or more occurrences of any character (`.`)". Thus, the pattern matches the string `"ab"`.

---

## Constraints
- `1 <= s.length <= 20`
- `1 <= p.length <= 20`
- `s` contains only lowercase English letters.
- `p` contains only lowercase English letters, `.` and `*`.
- It is guaranteed that for every `*` in `p`, there is a valid preceding character to match.

---

## Solution Approach

### Dynamic Programming
Use a 2D dynamic programming table `dp[i][j]` where:
- `dp[i][j]` represents whether the first `i` characters of `s` match the first `j` characters of `p`.

#### Transition Rules
1. If `p[j-1] == s[i-1]` or `p[j-1] == '.'`:
   - `dp[i][j] = dp[i-1][j-1]`.
2. If `p[j-1] == '*'`:
   - Treat `p[j-2]` and `*` as zero occurrences: `dp[i][j] = dp[i][j-2]`.
   - Treat `p[j-2]` and `*` as one or more occurrences if `s[i-1] == p[j-2]` or `p[j-2] == '.'`:  
     `dp[i][j] |= dp[i-1][j]`.

#### Initialization
- `dp[0][0] = true` (empty string matches empty pattern).
- For patterns like `a*`, `dp[0][j]` depends on the preceding character's ability to match zero occurrences.
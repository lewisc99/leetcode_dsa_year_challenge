# Clear Digits

## Problem Statement
You are given a string `s`.

Your task is to remove all digits by repeatedly performing the following operation:
- Delete the first digit and the closest non-digit character to its left.

Return the resulting string after removing all digits.

**Note:** The operation cannot be performed on a digit that does not have any non-digit character to its left.

## Examples

### Example 1:
**Input:**
```
s = "abc"
```
**Output:**
```
"abc"
```
**Explanation:**
There is no digit in the string.

---

### Example 2:
**Input:**
```
s = "cb34"
```
**Output:**
```
""
```
**Explanation:**
1. First, we apply the operation on `s[2]` (which is '3'), and `s` becomes `"c4"`.
2. Then we apply the operation on `s[1]` (which is '4'), and `s` becomes `""`.

## Constraints
- `1 <= s.length <= 100`
- `s` consists only of lowercase English letters and digits.
- The input is generated such that it is possible to delete all digits.

## Usage
To solve this problem, implement a function that processes the string according to the given operations until all digits are removed.


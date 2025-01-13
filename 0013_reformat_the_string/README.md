# 1417. Reformat The String

## Problem Statement

You are given an **alphanumeric string** `s`. An alphanumeric string consists of:

- Lowercase English letters (`a-z`), and
- Digits (`0-9`).

Your task is to find a permutation of the string such that:

1. No letter is followed by another letter.
2. No digit is followed by another digit.

If it is **impossible** to reformat the string to meet these conditions, return an empty string.

---

## Examples

### Example 1:

**Input:**  
`s = "a0b1c2"`

**Output:**  
`"0a1b2c"`

**Explanation:**  
Permutations such as `"a0b1c2"`, `"0a1b2c"`, or `"0c2a1b"` are all valid since no two adjacent characters are of the same type.

---

### Example 2:

**Input:**  
`s = "leetcode"`

**Output:**  
`""`

**Explanation:**  
The string `"leetcode"` contains only letters. It is impossible to separate them with digits.

---

### Example 3:

**Input:**  
`s = "1229857369"`

**Output:**  
`""`

**Explanation:**  
The string `"1229857369"` contains only digits. It is impossible to separate them with letters.

---

## Constraints

- `1 <= s.length <= 500`
- `s` consists of only lowercase English letters and/or digits.

---

## Approach

### 1. **Separate Characters by Type**:

- Extract all letters and digits from the string.
- Use two separate lists to store them.

### 2. **Check Feasibility**:

- If the absolute difference between the number of letters and digits exceeds 1, reformatting is impossible.

### 3. **Interleave Characters**:

- Alternate between letters and digits while constructing the result.
- Always start with the group (letters or digits) that has more characters.

### 4. **Edge Cases**:

- If `s` contains only letters or only digits, return an empty string.
- Single-character strings are always valid.

---

## Time Complexity

- **Character Classification:** `O(n)` where `n` is the length of the string.
- **Result Construction:** `O(n)`.

Overall: **O(n)**.

---

## Space Complexity

- Storing letters and digits separately: `O(n)`.

Total: **O(n)**.

---

## Example Walkthrough

### Input: `s = "a0b1c2"`

1. **Separate Characters**:

   - Letters: `["a", "b", "c"]`
   - Digits: `["0", "1", "2"]`

2. **Check Feasibility**:

   - Letters: `3`, Digits: `3` → Feasible (difference = 0).

3. **Construct Result**:

   - Alternate between digits and letters:
     - Add `"0"`, Result: `"0"`
     - Add `"a"`, Result: `"0a"`
     - Add `"1"`, Result: `"0a1"`
     - Add `"b"`, Result: `"0a1b"`
     - Add `"2"`, Result: `"0a1b2"`
     - Add `"c"`, Result: `"0a1b2c"`

4. **Output**: `"0a1b2c"`

---

### Input: `s = "leetcode"`

1. **Separate Characters**:

   - Letters: `["l", "e", "e", "t", "c", "o", "d", "e"]`
   - Digits: `[]`

2. **Check Feasibility**:

   - Letters: `8`, Digits: `0` → **Not Feasible** (difference > 1).

3. **Output**: `""`

---

### Input: `s = "1229857369"`

1. **Separate Characters**:

   - Letters: `[]`
   - Digits: `["1", "2", "2", "9", "8", "5", "7", "3", "6", "9"]`

2. **Check Feasibility**:

   - Letters: `0`, Digits: `10` → **Not Feasible** (difference > 1).

3. **Output**: `""`

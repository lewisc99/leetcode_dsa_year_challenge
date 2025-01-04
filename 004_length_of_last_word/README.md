# Length of Last Word

## Problem Description

Given a string `s` consisting of words and spaces, return the **length of the last word** in the string.

A word is defined as a maximal substring consisting of non-space characters only.

---

## Examples

### Example 1:

**Input:**  
`s = "Hello World"`

**Output:**  
`5`

**Explanation:**  
The last word is `"World"` with a length of `5`.

---

### Example 2:

**Input:**  
`s = "   fly me   to   the moon  "`

**Output:**  
`4`

**Explanation:**  
The last word is `"moon"` with a length of `4`.

---

### Example 3:

**Input:**  
`s = "luffy is still joyboy"`

**Output:**  
`6`

**Explanation:**  
The last word is `"joyboy"` with a length of `6`.

---

## Constraints

1. `1 <= s.length <= 10^4`
2. `s` consists of only English letters and spaces `' '`.
3. There will be at least one word in `s`.

---

## Approach

To solve this problem:

1. Strip any trailing spaces from the string.
2. Split the string into words using spaces as delimiters.
3. Return the length of the last word in the resulting list.

---

## Usage

Implement this function in your preferred programming language to determine the length of the last word in any valid input string `s`.

# Merge Strings Alternately

This is a simple string manipulation problem that involves merging two strings alternately. The task is to combine characters from two input strings in an alternating manner. If one string is longer than the other, the remaining characters from the longer string are appended to the result.

## Problem Description

Given two strings `word1` and `word2`, merge the strings by alternating their characters. Start with the first character of `word1`, then the first character of `word2`, and continue this process. If one string is longer, append the remaining characters to the merged string.

### Constraints
- `1 <= word1.length, word2.length <= 100`
- Both `word1` and `word2` consist of lowercase English letters.

## Examples

### Example 1
- **Input:** `word1 = "abc"`, `word2 = "pqr"`
- **Output:** `"apbqcr"`
- **Explanation:** Characters are alternated as follows:
- word1: a b c
- word2: p q r
- merged: a p b q c r


### Example 2
- **Input:** `word1 = "ab"`, `word2 = "pqrs"`
- **Output:** `"apbqrs"`
- **Explanation:** Since `word2` is longer, the remaining characters `r` and `s` are appended:
- word1: a b
- word2: p q r s
- merged: a p b q r s

### Example 3
- **Input:** `word1 = "abcd"`, `word2 = "pq"`
- **Output:** `"apbqcd"`
- **Explanation:** Since `word1` is longer, the remaining characters `c` and `d` are appended:
- word1: a b c d
- word2: p q
- merged: a p b q c d

## Usage

To solve this problem programmatically, you can:
1. Use a loop to iterate through the characters of both strings.
2. Append characters alternately to the result.
3. After the loop, append any remaining characters from the longer string.

This type of problem is useful for learning basic string manipulation and iteration techniques in programming.
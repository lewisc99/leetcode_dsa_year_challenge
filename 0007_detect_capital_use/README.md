# 520. Detect Capital

## Difficulty: Easy

## Problem Statement

We define the usage of capitals in a word to be correct when one of the following conditions holds:

1. All letters in the word are capitalized, like "USA".
2. All letters in the word are not capitalized, like "leetcode".
3. Only the first letter in the word is capitalized, like "Google".

Given a string `word`, return `true` if the usage of capitals in it is correct.

### Example

#### Example 1

**Input:**  
word = "USA"
Output:
true

Example 2
Input:
word = "FlaG"
Output:
false

Constraints
1 <= word.length <= 100
word consists of lowercase and uppercase English letters.
# Word Frequency (LeetCode Problem #192)

## Problem Description

Write a Bash script to calculate the frequency of each word in a text file `words.txt`.

### Assumptions

1. The file `words.txt` contains only lowercase characters and space `' '` characters.
2. Each word consists of lowercase characters only.
3. Words are separated by one or more whitespace characters.

## Example

Assume that `words.txt` contains the following content:

```
the day is sunny the the
the sunny is is
```

Your script should output the following, sorted by descending frequency:

```
the 4
is 3
sunny 2
day 1
```

### Note

- Don't worry about handling ties; it is guaranteed that each word's frequency count is unique.

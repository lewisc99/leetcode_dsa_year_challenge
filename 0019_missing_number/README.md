# Missing Number

## Problem Statement
Given an array `nums` containing `n` distinct numbers in the range `[0, n]`, return the only number in the range that is missing from the array.

---

## Examples

### Example 1
**Input:**
```plaintext
nums = [3,0,1]
```

**Output:**
```plaintext
2
```

**Explanation:**
- `n = 3` since there are 3 numbers.
- All numbers are in the range `[0,3]`.
- `2` is the missing number in the range since it does not appear in `nums`.

---

### Example 2
**Input:**
```plaintext
nums = [0,1]
```

**Output:**
```plaintext
2
```

**Explanation:**
- `n = 2` since there are 2 numbers.
- All numbers are in the range `[0,2]`.
- `2` is the missing number in the range since it does not appear in `nums`.

---

### Example 3
**Input:**
```plaintext
nums = [9,6,4,2,3,5,7,0,1]
```

**Output:**
```plaintext
8
```

**Explanation:**
- `n = 9` since there are 9 numbers.
- All numbers are in the range `[0,9]`.
- `8` is the missing number in the range since it does not appear in `nums`.

---

## Constraints
1. `n == nums.length`
2. `1 <= n <= 10^4`
3. `0 <= nums[i] <= n`
4. All the numbers of `nums` are unique.

---

## Follow-Up
Could you implement a solution using only **O(1)** extra space complexity and **O(n)** runtime complexity?
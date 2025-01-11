# 283. Move Zeroes

## Problem Description

Given an integer array `nums`, move all `0`s to the end of it while maintaining the relative order of the non-zero elements.

**Note:** You must perform this operation in-place without making a copy of the array.

---

## Examples

### Example 1

**Input:**

```plaintext
nums = [0,1,0,3,12]
```

**Output:**

```plaintext
[1,3,12,0,0]
```

### Example 2

**Input:**

```plaintext
nums = [0]
```

**Output:**

```plaintext
[0]
```

---

## Constraints

- \( 1 \leq \text{nums.length} \leq 10^4 \)
- \( -2^{31} \leq \text{nums}[i] \leq 2^{31} - 1 \)

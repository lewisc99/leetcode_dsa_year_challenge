# Swap Nodes in Pairs

## Problem Statement

Given a linked list, swap every two adjacent nodes and return its head. You must solve the problem without modifying the values in the list's nodes (i.e., only nodes themselves may be changed).

---

## Examples

### Example 1:

**Input:**

```plaintext
head = [1,2,3,4]
```

**Output:**

```plaintext
[2,1,4,3]
```

**Explanation:**
The nodes are swapped in pairs: 1↔2 and 3↔4.

### Example 2:

**Input:**

```plaintext
head = []
```

**Output:**

```plaintext
[]
```

### Example 3:

**Input:**

```plaintext
head = [1]
```

**Output:**

```plaintext
[1]
```

### Example 4:

**Input:**

```plaintext
head = [1,2,3]
```

**Output:**

```plaintext
[2,1,3]
```

---

## Constraints

- The number of nodes in the list is in the range `[0, 100]`.
- `0 <= Node.val <= 100`.

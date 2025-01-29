# Insertion Sort List

## Problem Statement

Given the head of a singly linked list, sort the list using insertion sort, and return the sorted list's head.

## Algorithm Explanation

The steps of the insertion sort algorithm are as follows:

1. **Iterate through the list:** Traverse the list, consuming one input element at each iteration.
2. **Sort incrementally:** Remove one element from the input list, find its correct location in the sorted list, and insert it there.
3. **Repeat until sorted:** Continue until all elements have been placed in their correct positions.

### Visual Representation

The partially sorted list (black) initially contains only the first element in the list. One element (red) is removed from the input data and inserted in-place into the sorted list with each iteration.

---

## Examples

### Example 1:

**Input:**

```plaintext
head = [4,2,1,3]
```

**Output:**

```plaintext
[1,2,3,4]
```

### Example 2:

**Input:**

```plaintext
head = [-1,5,3,4,0]
```

**Output:**

```plaintext
[-1,0,3,4,5]
```

---

## Constraints

- The number of nodes in the list is in the range `[1, 5000]`.
- Each node's value is between `-5000` and `5000`.

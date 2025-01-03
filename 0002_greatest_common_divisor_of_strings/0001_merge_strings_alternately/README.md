## 1071. Greatest Common Divisor of Strings  
**Difficulty**: Easy  
**Status**: Solved  

### Problem Description  
For two strings `s` and `t`, we say that "`t` divides `s`" if and only if `s` can be represented as `t` concatenated with itself one or more times (e.g., `s = t + t + ... + t`).  

Given two strings `str1` and `str2`, the task is to find the largest string `x` such that `x` divides both `str1` and `str2`.  

---

### Examples  

#### Example 1  
**Input**:  
`str1 = "ABCABC", str2 = "ABC"`  
**Output**:  
`"ABC"`  

#### Example 2  
**Input**:  
`str1 = "ABABAB", str2 = "ABAB"`  
**Output**:  
`"AB"`  

#### Example 3  
**Input**:  
`str1 = "LEET", str2 = "CODE"`  
**Output**:  
`""`  

---

### Constraints  
- `1 <= str1.length, str2.length <= 1000`  
- `str1` and `str2` consist of uppercase English letters only.  

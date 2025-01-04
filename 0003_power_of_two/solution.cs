public class Solution {
    public bool IsPowerOfTwo(int n) {
        if (n <= 0) 
            return false; // Negative numbers and zero are not powers of two.
        if (n == 1) 
            return true;  // 2^0 = 1

        int count = 1;

        while (count <= n) {
            if (count == n) 
                return true;
            if (count > n / 2) // Avoid overflow by checking if doubling will exceed `n`
                return false;

            count *= 2;
        }

        return false;
    }
}

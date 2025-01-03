public class Solution {
    public static string GcdOfStrings(string str1, string str2)
    {
        // Step 1: Check if one string can be formed by concatenating the other multiple times
        string concatenated1 = str1 + str2; // Concatenate str1 followed by str2
        string concatenated2 = str2 + str1; // Concatenate str2 followed by str1

        if (concatenated1 != concatenated2)
        {
            // If the concatenations don't match, there's no common divisor
            return "";
        }

        // Step 2: Calculate the greatest common divisor (GCD) of the lengths of the strings
        int length1 = str1.Length; // Length of str1
        int length2 = str2.Length; // Length of str2
        int gcdLength = FindGcd(length1, length2); // Find the GCD of the lengths

        // Step 3: Extract the substring of str1 with the length equal to the GCD
        string candidate = str1.Substring(0, gcdLength);

        return candidate; // Return the candidate as the result
    }

    // Helper method to calculate the GCD of two integers
    private static int FindGcd(int a, int b)
    {
        while (b != 0) // Continue until the remainder is 0
        {
            int remainder = a % b; // Calculate the remainder
            a = b; // Assign the divisor to 'a'
            b = remainder; // Assign the remainder to 'b'
        }
        return a; // The last non-zero divisor is the GCD
    }
}
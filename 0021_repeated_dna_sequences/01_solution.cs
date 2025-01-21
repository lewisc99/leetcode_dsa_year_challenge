using System;
using System.Collections.Generic;

public class Solution
{
    public IList<string> FindRepeatedDnaSequences(string s)
    {
        var result = new List<string>();

        var seen = new Dictionary<string, int>();

        for (int i = 0; i <= s.Length - 10; i++)
        {
            string sequence = s.Substring(i, 10);

            // If the sequence is already in the dictionary, increment its count.
            if (seen.ContainsKey(sequence))
            {
                seen[sequence]++;
            }
            else
            {
                // If the sequence is not in the dictionary, add it with a count of 1.
                seen[sequence] = 1;
            }
        }

        // Add sequences to the result if they occur more than once.
        foreach (var entry in seen)
        {
            if (entry.Value > 1)
            {
                result.Add(entry.Key);
            }
        }

        return result;
    }
}

// Execution Time: 56 ms (Faster than 71.05% of submissions)
// Memory Usage: 39.89 MB (Better than 45.32% of submissions)

public class Solution
{
    public string MergeAlternately(string word1, string word2)
    {
        StringBuilder newWord = new StringBuilder();

        int word1Length = word1.Length;
        int word2Length = word2.Length;

        for (int index = 0; index < word1Length; index++)
        {
            newWord.Append(word1[index]);

            if (word2Length - 1 >= index)
            {
                newWord.Append(word2[index]);
            }
        }

        if (word2Length > word1Length)
        {
            string restOfWord2Letters = word2.Substring(word1Length);
            newWord.Append(restOfWord2Letters);
        }

        return newWord.ToString();
    }
}
public class Solution
{
    public char FindTheDifference(string s, string t)
    {
        if (s.Length == 1)
        {
            if (s[0] == t[0])
                return t[1];

            return t[0];
        }

        if (s.Length == 0)
            return t[0];

        char word = t[0];
        var words = t.ToList();

        foreach (char c in s)
        {
            if (words.Contains(c))
            {
                int index = words.FindIndex(r => r.Equals(c));
                if (index >= 0)
                    words.RemoveAt(index);
            }
        }

        return words[0];
    }
}
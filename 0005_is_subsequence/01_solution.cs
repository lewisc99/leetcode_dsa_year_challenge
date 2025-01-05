public class Solution {
    public bool IsSubsequence(string s, string t)
    {
        StringBuilder stringBuilder = new StringBuilder(t.Length);
        int count = 0;

        for (int i = 0; i < t.Length; i++)
        {
            if (count < s.Length && s[count] == t[i])
            {
                count++;
                stringBuilder.Append(t[i]);
            }
        }

        if (stringBuilder.ToString() == s)
            return true;

        return false;
    }
}
public class Solution
{
    public bool IsAnagram(string s, string t)
    {

        if (s.Length < t.Length || s.Length > t.Length)
            return false;

        else if (s.Length == 1)
        {
            if (s[0] == t[0])
                return true;
        }

        else if (s.Length == 2)
        {
            if ((s[0] == t[0] && s[1] == t[1]) || (s[1] == t[0] && s[0] == t[1]))
            {
                return true;
            }
        }

        List<char> tList = t.ToList();

        for (int i = 0; i < s.Length; i++)
        {
            int index = tList.FindIndex(r => r.Equals(s[i]));

            if (index >= 0)
                tList.RemoveAt(index);
            else
                return false;
        }

        if (tList.Count == 0)
            return true;

        return false;
    }
}
public class Solution
{
    public bool ValidPalindrome(string s)
    {
        if (s.Length < 1)
            return true;

        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        string palindrome = new string(charArray);
        int countWordsNotInS = 0;

        StringBuilder stringBuilder = new StringBuilder();

        if (palindrome == s || (s.Length == 2 && palindrome == s))
            return true;

        for (int i = 0; i < s.Length; i++)
        {
            if (countWordsNotInS > 1)
            {
                return false;
            }

            if (s[i] == palindrome[i])
            {
                stringBuilder.Append(s[i]);
            }
            else
            {
                countWordsNotInS++;

                string modifiedS = s.Remove(i, 1);
                string modifiedPalindrome = palindrome.Remove(i, 1);

                if (modifiedS == new string(modifiedS.Reverse().ToArray()) ||
                    modifiedPalindrome == new string(modifiedPalindrome.Reverse().ToArray()))
                {
                    return true;
                }

                return false;
            }
        }

        return stringBuilder.ToString() == palindrome || s == palindrome;
    }
}
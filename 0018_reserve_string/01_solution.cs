public class Solution
{
    public void ReverseString(char[] s)
    {
        if (s.Length == 1)
            return;

        Int32 firstIndex = 0;
        Int32 lastIndex = s.Length - 1;

        while (firstIndex < lastIndex)
        {
            {
                char temp = s[firstIndex];
                s[firstIndex] = s[lastIndex];
                s[lastIndex] = temp;
                firstIndex++;
                lastIndex--;
            }
        }
    }
}
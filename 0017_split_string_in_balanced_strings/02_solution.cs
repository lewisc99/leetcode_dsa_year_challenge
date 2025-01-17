public class Solution
{
    public int BalancedStringSplit(string s)
    {
        if (s.Length == 2)
            return 1;

        char[] sArray = s.ToCharArray();

        Int16 count = 0;
        Int16 balance = 0;

        for (int i = 0; i < sArray.Length; i++)
        {
            if (sArray[i] == 'R')
                balance++;
            else
                balance--;

            if (balance == 0)
                count++;
        }
        return count;
    }
}
public class Solution
{
    public int BalancedStringSplit(string s)
    {
        if (s.Length == 2)
            return 1;

        char[] sArray = s.ToCharArray();

        int lCount = 0;
        int rCount = 0;
        int count = 0;

        for (int i = 0; i < sArray.Length; i++)
        {
            if (sArray[i] == 'R')
                rCount++;
            else
                lCount++;

            if (lCount == rCount)
            {
                lCount = 0;
                rCount = 0;
                count++;
            }
        }
        return count;
    }
}
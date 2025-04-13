public class Solution
{
    public string FreqAlphabets(string s)
    {
        StringBuilder result = new();

        string aToI = "abcdefghi";
        string jToZ = "jklmnopqrstuvwxyz";

        while (s.Length > 0)
        {
            string val = "";
            short val2 = 0;
            bool containsHashTag = false;

            if (s.Length > 2)
            {
                val = s.Substring(0, 3);

                if (val[^1] == '#')
                {
                    val2 = short.Parse(s.Substring(0, 2));

                    result.Append(jToZ[val2 - 10]);
                    s = s.Remove(0, 3);

                    containsHashTag = true;
                }
            }

            if (s.Length >= 1 && !containsHashTag)
            {
                val2 = short.Parse(s.Substring(0, 1));

                result.Append(aToI[val2 - 1]);
                s = s.Remove(0, 1);
            }
        }

        return result.ToString();
    }
}
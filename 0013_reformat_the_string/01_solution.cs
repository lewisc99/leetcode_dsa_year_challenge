public class Solution
{
    public string Reformat(string s)
    {
        if (s.Length == 1)
            return s;
        else if (s.Length == 2)
        {
            if ((char.IsDigit(s[0]) && char.IsLetter(s[1])) || (char.IsLetter(s[0]) && char.IsDigit(s[1])))
                return s;
            else
                return "";
        }

        char[] letterArray = s.Where(x => char.IsLetter(x)).ToArray();
        char[] digitArray = s.Where(x => char.IsDigit(x)).ToArray();
        Int16 letterLength = (Int16)(letterArray.Length - 1);
        Int16 digitLength = (Int16)(digitArray.Length - 1);
        Int16 greaterLength = (Int16)(letterLength > digitArray.Length ? letterArray.Length : digitArray.Length);

        Queue<char> queue = new Queue<char>();

        if (letterLength - 1 > digitLength || digitLength - 1 > letterLength)
            return "";

        for (Int16 i = 0; i <= greaterLength - 1; i++)
        {
            if (letterLength > digitLength)
            {
                queue.Enqueue(letterArray[i]);

                if (digitLength >= i)
                    queue.Enqueue(digitArray[i]);

                if (greaterLength - 1 == i && greaterLength == letterLength)
                {
                    queue.Enqueue(letterArray[i + 1]);
                }
            }
            else
            {
                queue.Enqueue(digitArray[i]);
                if (letterLength >= i)
                    queue.Enqueue(letterArray[i]);

                if (greaterLength - 1 == i && greaterLength == digitLength)
                {
                    queue.Enqueue(digitArray[i + 1]);
                }
            }
        }

        return new string(queue.ToArray());
    }
}
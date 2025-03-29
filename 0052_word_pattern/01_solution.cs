public class Solution {
   public  bool WordPattern(string pattern, string s)
{
    string[] wordsArray = s.Split(' ');

    if (pattern.Length != wordsArray.Length)
        return false;

    Dictionary<string, char> dic = new Dictionary<string, char>();
    short index = 0;

    while (index < wordsArray.Length)
    {
        if (index >= pattern.Length)
            return false;

        if (dic.ContainsValue(pattern[index]) && !dic.ContainsKey(wordsArray[index]))
            return false;
        else if (dic.ContainsKey(wordsArray[index]))
        {
            if (dic[wordsArray[index]] != pattern[index]) 
                return false;
        } 
        else
            dic.Add(wordsArray[index], pattern[index]);

        index++;
    }

    return true;
  }
}
public class Solution {
   public  IList<string> CommonChars(string[] words)
{
   var dic = new Dictionary<char, int>();

    foreach (char c in words[0])
    {
        if (dic.ContainsKey(c))
            dic[c]++;
        else
            dic[c] = 1;
    }

    for (int index = 1; index < words.Length; index++)
    {
        var tempDic = new Dictionary<char, int>();

        foreach (char c in words[index])
        {
            if (dic.ContainsKey(c))
            {
                if (tempDic.ContainsKey(c))
                    tempDic[c]++;
                else
                    tempDic[c] = 1;
            }
        }

        foreach (var key in dic.Keys.ToList())
        {
            if (tempDic.ContainsKey(key))
                dic[key] = Math.Min(dic[key], tempDic[key]);
            else
                dic.Remove(key);
        }
    }

    List<string> result = new List<string>();
    foreach (var kvp in dic)
    {
        for (int i = 0; i < kvp.Value; i++)
            result.Add(kvp.Key.ToString());
    }

    return result;
    }
}
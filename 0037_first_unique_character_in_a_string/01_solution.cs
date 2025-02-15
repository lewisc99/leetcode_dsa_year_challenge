public class Solution
{
  public int FirstUniqChar(string s)
  {
    char[] array = s.ToArray();
    Dictionary<char, Queue<int>> dic = new Dictionary<char, Queue<int>>();
    int index = 0;

    while (index < array.Length)
    {
      Queue<int> q = new Queue<int>();
      if (dic.ContainsKey(array[index]))
      {
        q = dic[array[index]];
        q.Enqueue(index);
        dic[array[index]] = q;
      }
      else
      {
        q.Enqueue(index);
        dic.Add(array[index], q);
      }

      index++;
    }

    var result = dic.Where(q => q.Value.Count == 1);

    if (result.Any())
      return result.Select(q => q.Value.Peek()).FirstOrDefault();

    return -1;

  }
}
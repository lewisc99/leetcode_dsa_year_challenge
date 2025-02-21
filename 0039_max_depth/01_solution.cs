public class Solution
{
  public int MaxDepth(string s)
  {
    sbyte count = 0;
    sbyte maxNum = 0;
    foreach (char c in s)
    {
      if (c == '(')
      {
        count++;
        if (maxNum < count)
          maxNum = count;
      }
      else if (c == ')')
      {
        count--;
      }
    }
    return maxNum;
  }
}
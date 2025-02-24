public class Solution
{
  public bool BackspaceCompare(string s, string t)
  {
    int i = s.Length - 1, j = t.Length - 1;
    char backspace = '#';

    while (i >= 0 || j >= 0)
    {
      int skipS = 0, skipT = 0;

      while (i >= 0)
      {
        if (s[i] == backspace) { skipS++; i--; }
        else if (skipS > 0) { skipS--; i--; }
        else break;
      }

      while (j >= 0)
      {
        if (t[j] == backspace) { skipT++; j--; }
        else if (skipT > 0) { skipT--; j--; }
        else break;
      }

      if (i >= 0 && j >= 0 && s[i] != t[j]) return false;

      if ((i >= 0) != (j >= 0)) return false;

      i--;
      j--;
    }

    return true;
  }
}
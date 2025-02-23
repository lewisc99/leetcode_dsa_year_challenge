public class Solution
{
  public bool BackspaceCompare(string s, string t)
  {
    Stack<char> sStack = new Stack<char>();
    Stack<char> tStack = new Stack<char>();

    void ProcessString(string str, Stack<char> stack)
    {
      foreach (char c in str)
      {
        if (c == '#')
        {
          if (stack.Count > 0) stack.Pop();
        }
        else
        {
          stack.Push(c);
        }
      }
    }

    ProcessString(s, sStack);
    ProcessString(t, tStack);

    return sStack.SequenceEqual(tStack);
  }

}
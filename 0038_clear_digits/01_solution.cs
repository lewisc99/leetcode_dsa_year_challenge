public class Solution
{
  public string ClearDigits(string s)
  {
    Queue<char> queue = new Queue<char>(s.ToCharArray());
    Stack<char> stack = new Stack<char>();
    sbyte index = 0;

    while (index < s.Length)
    {
      char c = queue.Dequeue();
      if (char.IsDigit(c))
        stack.Pop();
      else
        stack.Push(c);

      index++;
    }

    return new string(queue.ToArray()) + new string(stack.Reverse().ToArray());
  }
}
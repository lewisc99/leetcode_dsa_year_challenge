public class Solution
{
  public int EvalRPN(string[] tokens)
  {
    var stack = new Stack<int>();

    var operators = new Dictionary<string, Func<int, int, int>>
        {
            { "+", (x, y) => x + y },
            { "-", (x, y) => x - y },
            { "*", (x, y) => x * y },
            { "/", (x, y) => x / y }
        };

    foreach (var token in tokens)
    {
      if (int.TryParse(token, out var number))
      {
        stack.Push(number);
      }
      else if (operators.ContainsKey(token))
      {
        var operand2 = stack.Pop();
        var operand1 = stack.Pop();
        var result = operators[token](operand1, operand2);
        stack.Push(result);
      }
    }

    return stack.Pop();
  }
}
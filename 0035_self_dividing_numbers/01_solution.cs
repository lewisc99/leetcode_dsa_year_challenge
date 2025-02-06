public class Solution
{
  public IList<int> SelfDividingNumbers(int left, int right)
  {
    List<int> result = new List<int>();

    while (right >= left)
    {
      char[] leftCharArray = left.ToString().ToCharArray();
      sbyte leftCount = 0;
      bool isSelfDividedNumber = true;

      while (leftCount < leftCharArray.Length)
      {
        int number = int.Parse(leftCharArray[leftCount].ToString());

        if (number == 0)
        {
          isSelfDividedNumber = false;
          break;
        }

        if (left % number != 0)
          isSelfDividedNumber = false;

        leftCount++;
      }

      if (isSelfDividedNumber)
        result.Add(left);

      left++;
    }

    return result;
  }
}
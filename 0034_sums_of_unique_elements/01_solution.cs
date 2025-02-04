public class Solution
{
  public int SumOfUnique(int[] nums)
  {
    Dictionary<int, int> countMap = new Dictionary<int, int>();
    int sum = 0;

    foreach (var number in nums)
    {
      if (countMap.ContainsKey(number))
      {
        countMap[number]++;
        continue;
      }

      countMap[number] = 1;
    }

    foreach (var kvp in countMap)
    {
      if (kvp.Value == 1)
        sum += kvp.Key;
    }

    return sum;
  }
}
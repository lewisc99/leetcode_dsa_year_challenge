public class Solution
{
  public int NumIdenticalPairs(int[] nums)
  {
    var count = 0;
    Dictionary<int, int> map = new Dictionary<int, int>();

    for (var i = 0; i < nums.Length; i++)
    {
      if (map.ContainsKey(nums[i]))
      {
        count += map[nums[i]];
        map[nums[i]] += 1;
      }
      else
      {
        map.Add(nums[i], 1);
      }
    }

    return count;
  }
}
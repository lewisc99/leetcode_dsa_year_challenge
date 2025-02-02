public class Solution
{

  public IList<IList<int>> Subsets(int[] nums)
  {
    IList<IList<int>> list = new List<IList<int>>();
    list.Add(new List<int>());

    if (nums.Length == 1)
    {
      list.Add(new List<int> { nums[0] });
      return list;
    }

    foreach (int num in nums)
    {
      int size = list.Count;
      for (int i = 0; i < size; i++)
      {
        List<int> newSubset = new List<int>(list[i]) { num };
        list.Add(newSubset);
      }
    }

    return list;
  }
}
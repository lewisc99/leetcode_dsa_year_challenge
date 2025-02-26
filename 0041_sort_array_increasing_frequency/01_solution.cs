public class Solution
{
  public int[] FrequencySort(int[] nums)
  {
    var frequencyMap = new Dictionary<int, int>();
    foreach (int num in nums)
    {
      if (frequencyMap.ContainsKey(num))
        frequencyMap[num]++;
      else
        frequencyMap[num] = 1;
    }

    return nums.OrderBy(n => frequencyMap[n]).ThenByDescending(n => n).ToArray();
  }

  int[] Quicksort(int[] array)
  {
    if (array.Length < 2)
    {
      return array;
    }
    else
    {
      int pivot = array[0];
      int[] less = array.Skip(1).Where(i => i <= pivot).ToArray();
      int[] greater = array.Skip(1).Where(i => i > pivot).ToArray();

      return Quicksort(less).Concat(new List<int> { pivot }).Concat(Quicksort(greater)).ToArray();
    }
  }
}
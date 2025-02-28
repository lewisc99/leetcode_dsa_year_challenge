public class Solution
{
  public int[] SmallerNumbersThanCurrent(int[] nums)
  {
    int index = 0;
    int totalLength = 0;
    int[] array = new int[nums.Length];

    while (true)
    {
      if (totalLength > nums.Length - 1)
        break;

      if (index != totalLength && nums[index] < nums[totalLength])
        array[totalLength]++;

      if (index == nums.Length - 1)
      {
        index = 0;
        totalLength++;
      }
      else
      {
        index++;
      }
    }

    return array;
  }
}
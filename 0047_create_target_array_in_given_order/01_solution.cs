public class Solution
{
    public int[] CreateTargetArray(int[] nums, int[] index)
    {
        if (index.Length < 1)
            return nums;

        List<int> list = new List<int>();
        sbyte indexCount = 0;

        while (indexCount < nums.Length)
        {
            list.Insert(index[indexCount], nums[indexCount]);
            indexCount++;
        }

        return list.ToArray();
    }
}
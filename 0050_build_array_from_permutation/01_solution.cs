public class Solution
{
    public int[] BuildArray(int[] nums)
    {
        int[] ans = new int[nums.Length];
        short i = 0;

        while (i < nums.Length)
        {
            ans[i] = nums[nums[i]];
            i++;
        }

        return ans;
    }
}
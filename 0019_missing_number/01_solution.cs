public class Solution
{
    public int MissingNumber(int[] nums)
    {
        if (nums.Length == 1)
        {
            if (nums[0] == 0)
            {
                return 1;
            }
            else
            {
                return nums[0] - 1;
            }
        }

        Array.Sort(nums);

        if (nums[0] == 1)
            return 0;

        Int32 missingNumber = 0;
        Int32 index = 0;

        while (index < nums.Length)
        {
            if (nums[index] != index)
            {
                missingNumber = index;
                break;
            }

            index++;
        }

        return missingNumber != 0 ? missingNumber : nums[nums.Length - 1] + 1;
    }
}
public class Solution {
   public  int ThirdMax(int[] nums) {
        if (nums.Length == 1)
            return nums[0];

        int[] numsOrdered = nums.OrderBy(x => x).ToArray();

        int[] uniqueNums = numsOrdered.Distinct().ToArray();

        if (uniqueNums.Length < 3)
            return uniqueNums[uniqueNums.Length - 1];

        return uniqueNums[uniqueNums.Length - 3];
    }
}
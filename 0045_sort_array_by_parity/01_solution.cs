public class Solution
{
    public int[] SortArrayByParityII(int[] nums)
    {
        bool lastEven = false;
        int[] newArray = new int[nums.Length];
        int[] halfEven = nums.Where(x => x % 2 == 0).ToArray();
        int[] halfOdd = nums.Where(x => x % 2 != 0).ToArray();
        short indexEven = 0;
        short indexOdd = 0;
        short index = 0;


        while (index < newArray.Length)
        {
            if (!lastEven)
            {
                if (indexEven > halfEven.Length)
                    continue;

                newArray[index] = halfEven[indexEven];
                lastEven = true;
                indexEven++;
            }
            else
            {
                if (indexOdd > halfOdd.Length)
                    continue;

                newArray[index] = halfOdd[indexOdd];
                lastEven = false;
                indexOdd++;
            }

            index++;
        }

        return newArray;
    }
}
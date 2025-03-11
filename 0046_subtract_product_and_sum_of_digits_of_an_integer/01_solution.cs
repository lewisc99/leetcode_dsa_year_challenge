public class Solution
{
    public int SubtractProductAndSum(int n)
    {
        int[] array = n.ToString().Select(c => c - '0').ToArray();
        int index = 0;
        int productOfDigits = array[index];
        int sumOfDigits = 0;

        while (index < array.Length)
        {
            if (index != array.Length - 1)
                productOfDigits *= array[index + 1];

            sumOfDigits += array[index];
            index++;
        }
        return productOfDigits - sumOfDigits;
    }
}
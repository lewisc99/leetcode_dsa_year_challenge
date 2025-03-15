public class Solution {
    public IList<string> FizzBuzz(int n)
{
    String[] list = new String[n];
    short index = 1;
    short listIndex = 0;

    while (index <= n)
    {
        if (index % 3 == 0 && index % 5 == 0)
            list[listIndex] = "FizzBuzz";
        else if (index % 3 == 0)
            list[listIndex] = "Fizz";
        else if (index % 5 == 0)
            list[listIndex] = "Buzz";
        else
            list[listIndex] = index + "";
        index++;
        listIndex++;
    }

    return list;
    }
}
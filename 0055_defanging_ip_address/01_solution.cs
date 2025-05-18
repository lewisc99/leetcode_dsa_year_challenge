public class Solution
{
    public string DefangIPaddr(string address)
    {
        string result = "";
        sbyte index = 0;

        while (index < address.Length)
        {
            if (address[index] == '.')
                result += "[.]";
            else
                result += address[index];

            index++;
        }

        return result;
    }
}
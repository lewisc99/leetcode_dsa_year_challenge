public class Solution
{
    public string ReverseVowels(string s)
    {
        char[] toArray = s.ToCharArray();

        char[] vowelsArray = new char[] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

        char[] vowels = toArray.Where(x => vowelsArray.Contains(x)).Reverse().ToArray();

        int vowelIndex = 0;
        int index = 0;

        while (vowelIndex <= vowels.Length && index <= toArray.Length - 1)
        {
            if (vowels.Contains(toArray[index]))
            {
                toArray[index] = vowels[vowelIndex];
                vowelIndex++;
            }

            index++;
        }

        return new string(toArray);
    }
}
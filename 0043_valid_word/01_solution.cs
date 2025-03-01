public class Solution
{
  public bool IsValid(string word)
  {

    if (word.Length <= 2)
      return false;

    sbyte index = 0;
    bool isValidWord = true;
    bool containsConsoant = false;
    bool containsVowels = false;
    bool containsNumber = false;

    char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

    while (index < word.Length)
    {
      if (!char.IsLetterOrDigit((word[index])))
      {
        isValidWord = false;
        break;
      }
      else
      {
        if (vowels.Contains((word[index])))
          containsVowels = true;

        else if (!vowels.Contains((word[index])) && !char.IsDigit((word[index])))
          containsConsoant = true;
      }

      index++;
    }

    if (isValidWord && containsVowels && containsConsoant)
      return true;
    else return false;
  }
}
public class Solution
{
    public bool DetectCapitalUse(string word)
    {
        if (word.Length < 2)
        {
            return true;
        }

        string wordToUpperCase = word.ToUpper();
        string wordToLowerCase = word.ToLower();
        string firstLetterUpperCase = char.ToUpper(word[0]) + word.Substring(1).ToLower();

        if (word == wordToUpperCase || word == wordToLowerCase || firstLetterUpperCase == word)
            return true;
        else
            return false;
    }
}
public class Solution {
    public int LengthOfLastWord(string s) {
        string trimWordEnd = s.TrimEnd();
        string[] splitWords = trimWordEnd.Split(" ");
        int lengthOfLastWord = splitWords[splitWords.Length - 1].Length;

        return lengthOfLastWord;
    }
}
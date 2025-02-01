public class Solution
{
  public bool JudgeCircle(string moves)
  {
    int horizontal = 0;
    int vertical = 0;
    char[] movesArray = moves.ToCharArray();
    vertical += movesArray.Where(i => i == 'U').Count();
    vertical -= movesArray.Where(i => i == 'D').Count();
    horizontal += movesArray.Where(i => i == 'R').Count();
    horizontal -= movesArray.Where(i => i == 'L').Count();

    if (horizontal == 0 && vertical == 0)
      return true;
    else
      return false;
  }
}
public class Solution
{
  public bool JudgeCircle(string moves)
  {
    int horizontal = 0;
    int vertical = 0;

    for (int i = 0; i < moves.Length; i++)
    {
      switch (moves[i])
      {
        case 'U':
          vertical++;
          break;
        case 'D':
          vertical--;
          break;
        case 'R':
          horizontal++;
          break;
        case 'L':
          horizontal--;
          break;
      }
    }

    if (horizontal == 0 && vertical == 0)
      return true;
    else
      return false;
  }
}
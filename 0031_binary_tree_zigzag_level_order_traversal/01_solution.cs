/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution
{
  IList<IList<int>> answer = new List<IList<int>>();

  public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
  {
    if (root == null)
    {
      return answer;
    }

    Search(0, root);

    for (int i = 0; i < answer.Count(); i++)
    {
      if (i > 0 && i % 2 != 0)
      {
        List<int> temp = new List<int>(answer[i]);
        temp.Reverse();
        answer[i] = temp;
      }
    }
    return answer;
  }

  private void Search(int depth, TreeNode node)
  {
    if (node == null)
    {
      return;
    }
    if (depth >= answer.Count())
    {
      answer.Add(new List<int>());
    }

    answer[depth].Add(node.val);

    Search(depth + 1, node.left);
    Search(depth + 1, node.right);
  }
}
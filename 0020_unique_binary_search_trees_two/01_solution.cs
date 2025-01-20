using System.Collections.Generic;

public class Solution
{
    public IList<TreeNode> GenerateTrees(int n)
    {
        if (n == 0)
        {
            return new List<TreeNode>();
        }
        return GenerateSubtrees(1, n);
    }

    private IList<TreeNode> GenerateSubtrees(int start, int end)
    {
        var result = new List<TreeNode>();

        if (start > end)
        {
            result.Add(null);
            return result;
        }

        for (int i = start; i <= end; i++)
        {
            var leftSubtrees = GenerateSubtrees(start, i - 1);
            var rightSubtrees = GenerateSubtrees(i + 1, end);

            foreach (var left in leftSubtrees)
            {
                foreach (var right in rightSubtrees)
                {
                    var root = new TreeNode(i, left, right);
                    result.Add(root);
                }
            }
        }

        return result;
    }
}

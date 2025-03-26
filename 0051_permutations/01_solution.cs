public class Solution
{
    public IList<IList<int>> Permute(int[] nums)
    {
        List<IList<int>> result = new List<IList<int>>();
        GeneratePermutations(nums.ToList(), 0, result);
        return result;
    }

    public void GeneratePermutations(List<int> list, int index, List<IList<int>> result)
    {
        if (index == list.Count - 1)
        {
            result.Add(new List<int>(list));
            return;
        }

        for (int i = index; i < list.Count; i++)
        {
            Swap(list, index, i);
            GeneratePermutations(list, index + 1, result);
            Swap(list, index, i);
        }
    }

    public void Swap(List<int> list, int i, int j)
    {
        int temp = list[i];
        list[i] = list[j];
        list[j] = temp;
    }
}
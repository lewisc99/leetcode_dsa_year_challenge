public static bool UniqueOccurrences(int[] arr)
{
    short index = 0;
    Dictionary<int, short> dic = new Dictionary<int, short>();

    while (index < arr.Length)
    {
        if (dic.ContainsKey(arr[index]))
            dic[arr[index]] += 1;
        else
            dic.Add(arr[index], 1);

        index++;
    }

    index = 0;
    HashSet<int> freqSet = new HashSet<int>();

    foreach (KeyValuePair<int, short> entry in dic)
    {
        if (!freqSet.Add(entry.Value))
            return false;

        index++;
    }

    return true;
}
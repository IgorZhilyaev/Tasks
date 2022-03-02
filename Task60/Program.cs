// Составить частотный словарь элементов двумерного массива.

int[] array = new int[] { 9, 8, 4, 4, 5, 6, 1, 2, 47, 8, 5, 9, 6, 4 };

Dictionary<int, int> Execute()
{
    Dictionary<int, int> dic = new Dictionary<int, int>();
    for (int i = 0; i < array.Length; i++)
    {
        if (dic.ContainsKey(array[i]))
            dic[array[i]] = dic[array[i]] + 1;
        else
            dic.Add(array[i], 1);
    }
    return dic;
}

void PrintDic(Dictionary<int, int> dic)
{
    foreach (var item in dic)
    {
        Console.WriteLine($"{item.Key} встречается {item.Value} раз.");
    }
}

PrintDic(Execute());
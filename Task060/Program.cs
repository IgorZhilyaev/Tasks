// Составить частотный словарь элементов двумерного массива.

int[] array = new int[] { 9, 8, 4, 4, 5, 6, 1, 2, 47, 8, 5, 9, 6, 4 };

Dictionary<int, int> Execute()
{
    Dictionary<int, int> dic = new Dictionary<int, int>(); // Сщздаём словарь
    for (int i = 0; i < array.Length; i++)
    {
        if (dic.ContainsKey(array[i])) // проверяем есть ли такай ключ в словаре
            dic[array[i]] = dic[array[i]] + 1; // если есть то обращаемся к нему и прибавляем значение
        else
            dic.Add(array[i], 1);  // если нет то создаём ключ и присваиваем ему значение
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
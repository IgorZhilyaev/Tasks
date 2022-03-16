// Сформировать трехмерный массив не повторяющимися двузначными числами,
// показать его построчно на экран выводя индексы соответствующего элемента.

int[,,] array = new int[3, 4, 4];

Random rand = new Random();
void FillArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = rand.Next(10, 100);                                                      
            }
        } 
    }
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"({i}.{j}.{k}) {array[i, j, k]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

// Не получилось заполнить неповторяющимися

FillArray(array);
PrintArray(array);
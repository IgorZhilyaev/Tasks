// Написать программу, упорядочивания по убыванию элементы каждой строки двумерного массива.

int[,] array = new int[4, 4];

Random rand = new Random();
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
void SortArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - j - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int t = array[i, k];
                    array[i, k] = array[i, k + 1];
                    array[i, k + 1] = t;
                }
            }
        }
    }

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]} ");
            Console.WriteLine();
    }
}

FillArray(array);
Console.WriteLine("Исходный массив:");
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Полученный массив:");
SortArray(array);



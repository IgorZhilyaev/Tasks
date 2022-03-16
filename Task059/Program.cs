// В прямоугольной матрице найти строку с наименьшей суммой элементов.

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


void MinLineSum(int[,] array)
{
    int[] sum = new int[array.GetLength(0)];
    int lineSum = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            lineSum += array[i, j];
        }
        sum[i] = lineSum;
        lineSum = 0;
    }

    int minLineSum = sum.Min();
    int indexMin = Array.IndexOf(sum, minLineSum);

    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write($"{array[indexMin, i]} ");
    }
}

FillArray(array);
Console.WriteLine("Исходный массив:");
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Строка с наименьшей суммой элементов:");
MinLineSum(array);

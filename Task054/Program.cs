// В матрице чисел найти сумму элементов главной диагонали.

int[,] array = new int[5, 5];
Random rand = new Random();
void FillArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {

            array[i, j] = rand.Next(1, 10);
        }
    }
}

void PrintArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}   ");
        }
        Console.WriteLine();
    }
}

void SumDiagonal()
{
    int sumDiagonal = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            
            if (i == j)
            {
                sumDiagonal += array[i, j];              
            }          
        }
    }
Console.Write($"Сумма элементов главной диагонали = {sumDiagonal}");
}

FillArray();
PrintArray();
SumDiagonal();
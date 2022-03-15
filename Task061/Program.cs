// Найти произведение двух матриц.

int row = 3;
int[,] firstMatrix = new int[row, row];
int[,] secondMatrix = new int[row, row];

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

void MultipleMatrix(int[,] first, int[,] second)
{
    int[,] multipleMatrix = new int[row, row];

    for (int i = 0; i < multipleMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < multipleMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < multipleMatrix.GetLength(0); k++)
            {
                multipleMatrix[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
            }
            Console.Write($"{multipleMatrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

FillArray(firstMatrix);
FillArray(secondMatrix);
Console.WriteLine("Первая матрица:");
PrintArray(firstMatrix);
Console.WriteLine();
Console.WriteLine("Вторая матрица:");
PrintArray(secondMatrix);
Console.WriteLine();
Console.WriteLine("Произведение матриц:");
MultipleMatrix(firstMatrix, secondMatrix);


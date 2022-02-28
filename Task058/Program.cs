// Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, 
//что это невозможно (в случае, если матрица не квадратная).

int[,] array = new int[5, 5];
int[,] swapArray = new int[5, 5];

void FillArray()
{
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {

            array[i, j] = rand.Next(1, 10);
        }
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}   ");
        }
        Console.WriteLine();
    }
}

void SwapMatrix()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            swapArray[i, j] = array[j, i];
        }
    }
}

if (array.GetLength(0) != array.GetLength(1))
{
    Console.WriteLine("Матрица не квадратная.");
}
else
{
    FillArray();
    PrintArray(array);
    SwapMatrix();
    Console.WriteLine();
    PrintArray(swapArray);
}
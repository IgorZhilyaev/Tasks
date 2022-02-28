// Написать программу, которая обменивает элементы первой строки и последней строки.

int[,] array = new int[5, 5];

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

void SwapArray()
{
    int lastStr = array.GetLength(0) - 1;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        int saveNum = array[0,i];
        array[0,i] = array[lastStr,i];
        array[lastStr, i] = saveNum;
    }
}

FillArray();
PrintArray();
SwapArray();
Console.WriteLine();
PrintArray();
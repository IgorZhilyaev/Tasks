// В двумерном массиве n×k заменить четные элементы на противоположные.

int[,] array = new int[6, 5];
Random rand = new Random();
void FillArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {

            array[i, j] = rand.Next(1,10);
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

void ReplaceElements()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] % 2 == 0)
            {
                array[i, j] *= -1; 
            }
            Console.Write($"{array[i, j]}   ");
            
        }
        Console.WriteLine();
    }
}

FillArray();
PrintArray();
Console.WriteLine();
ReplaceElements();

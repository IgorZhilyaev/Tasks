// Задать двумерный массив следующим правилом: Aₘₙ = m+n.

Console.Clear();

int[,] array = new int[3, 3];
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

void PrintArray(int[,] array)
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

int[,] MethodSum() 
{
    int[,] arr = new int[array.GetLength(0),array.GetLength(1)];   
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {

           arr[i, j] = i + j;
        }
    }
    return arr;
}
FillArray();
PrintArray(array);
Console.WriteLine("----------------");
int[,] arr = MethodSum();
PrintArray(arr);

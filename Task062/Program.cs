// В двумерном массиве целых чисел. 
//Удалить строку и столбец, на пересечении которых расположен наименьший элемент.


int[,] array = new int[5, 5];
int[,] arrayResult = new int[4, 4];

void FillArray()
{
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {

            array[i, j] = rand.Next(-10, 10);
        }
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ○ ");
        }
        Console.WriteLine();
    }
}

(int, int) FindMin()      //кортеж
{
    int minStr = 0;
    int minColum = 0;
    int min = array[0, 0];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min)
            {
                min = array[i, j];
                minStr = i;
                minColum = j;
            }
        }
    }
    return (minStr, minColum);
}
void PrintResultArray(int str, int column)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (str != i && column != j)
                Console.Write($"{array[i, j]} ○ ");
        }
        Console.WriteLine();
    }
}

FillArray();
PrintArray(array);
(int minStr, int minColumn) = FindMin();
PrintResultArray(minStr, minColumn);

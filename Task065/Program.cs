// Спирально заполнить двумерный массив.

         
int[,] array = new int[3, 3];
 
void SpiralArray(int[,] array)
{   
    int row = 0, col = 0, dx = 0, dy = 1, dirChanges = 0, gran = array.GetLength(0);

    for (int i = 0; i < array.Length; i++)
    {
        array[col, row] = i + 1;
        if (--gran == 0)
        {
            gran = array.GetLength(0) * (dirChanges % 2) + array.GetLength(1) * ((dirChanges + 1) % 2) - (dirChanges / 2 - 1) - 2;
            int temp = dy;
            dy = -dx;
            dx = temp;
            dirChanges++;
            
        }
        col += dx;
        row += dy;
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

SpiralArray(array);
PrintArray(array);
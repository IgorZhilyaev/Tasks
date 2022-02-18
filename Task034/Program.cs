// Написать программу замену элементов массива на противоположные.

int[] arr = new int[10];

void FillArray()
{
    Random number = new Random();
    Console.WriteLine("Массив заполненный случайными числами: ");
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = number.Next(1, 10);
        Console.Write($"{arr[i]} ");
    }
    
}

void OppositeArray(int[] arr)
{
    Console.WriteLine("\nМассив с противоположными эллементами: ");
    for (int i = 0; i < arr.Length; i++)
    {
       arr[i] = arr[i] * -1;
       Console.Write($"{arr[i]} ");
    }
    
}

FillArray();
OppositeArray(arr);
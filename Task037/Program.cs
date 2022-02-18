// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99].

int[] arr = new int[123];

void FillArray()
{
    Random number = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = number.Next(0, 100);
        Console.Write($"{arr[i]} ");
    }
}

void Search()
{
    int count = 0;
    foreach (int item in arr)
    {
        if (item >= 10 && item <= 99)
            count++;
    }
    Console.WriteLine($"\nКоличество элементов из отрезка [10,99] = {count}");
}

FillArray();
Search();
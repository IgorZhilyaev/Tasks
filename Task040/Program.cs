// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом.

double[] arr = new double[] { 1.2, 3.5, 2.3, 2.8, -4.1, -1.6, 5.1 };

void ArrayPrint(double[] arr)
{
    Console.Write("Заданный массив: ");

    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

ArrayPrint(arr);

double max = arr[0];
double min = arr[0];

for (int i = 1; i < arr.Length; i++)
{
    if (max <= arr[i])
        max = arr[i];
    else if (min >= arr[i])
        min = arr[i];
}
Console.WriteLine($"\nМаксимальное значение равно {max}, минимальное {min}");
Console.WriteLine($"Разница между максимальным и минимальным элементами равна {max - min}");